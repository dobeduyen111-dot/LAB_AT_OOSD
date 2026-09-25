using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using QuanLyKhachSan.Forms;
using QuanLyKhachSan.Services;
using Xceed.Words.NET; // Thư viện thao tác với Word

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong() { InitializeComponent(); }

        private void Frm_Load(object a, EventArgs e)
        {
            cboDat.DataSource = s.LayPhieuDangO();
            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            cboNV2.DataSource = dm.LayNhanVien();
            cboNV2.DisplayMember = "HoTen";
            cboNV2.ValueMember = "MaNV";

            cboHT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" });
            cboHT.SelectedIndex = 0;

            dgvDBChon.DataSource = db;
            Tai();
        }

        string V(ComboBox c) { return c.SelectedValue == null ? "" : c.SelectedValue.ToString(); }

        void Tai()
        {
            if (cboDat.SelectedValue != null)
            {
                string so = V(cboDat);
                dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
            }
            dgvHD.DataSource = s.LayHoaDon();
        }

        private void dgvPhong_SelectionChanged(object a, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            dgvTN.DataSource = s.LayTienNghiPhong(txtPhong.Text);
        }

        private void btnThemDB_Click(object a, EventArgs e)
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
            string ten = Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value);
            foreach (var x in db)
                if (x.MaTienNghi == ma) { MessageBox.Show("Tiện nghi đã có trong phiếu đền bù."); return; }

            db.Add(new DenBuItem { MaTienNghi = ma, TenLoaiTN = ten, MucDoThietHai = txtMucDo.Text.Trim(), SoTien = numDenBu.Value });
        }

        private void btnLapDB_Click(object a, EventArgs e)
        {
            var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), txtPhong.Text.Trim(), DateTime.Now, V(cboNV), new List<DenBuItem>(db));
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) db.Clear();
        }

        // =========================================================================
        // SỰ KIỆN LẬP HÓA ĐƠN & TỰ ĐỘNG XUẤT FILE WORD
        // =========================================================================
        private void btnLapHD_Click(object a, EventArgs e)
        {
            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, V(cboNV2), (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao);

            if (k.ThanhCong)
            {
                XuatHoaDonWord();
            }

            Tai();
        }

        private void XuatHoaDonWord()
        {
            try
            {
                // 1. Kiểm tra file Word mẫu trong thư mục chạy (bin/Debug)
                string mauFilePath = Path.Combine(Application.StartupPath, "Hoa_don_thanh_toan_khach_san.docx");
                if (!File.Exists(mauFilePath))
                {
                    // Nếu không có trong bin/Debug, tìm ở thư mục dự án cha
                    mauFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Hoa_don_thanh_toan_khach_san.docx");
                }

                if (!File.Exists(mauFilePath))
                {
                    MessageBox.Show("Không tìm thấy file Word mẫu Hoa_don_thanh_toan_khach_san.docx!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Tạo thư mục chứa file xuất ra
                string folderXuat = Path.Combine(Application.StartupPath, "HoaDonDaXuat");
                if (!Directory.Exists(folderXuat)) Directory.CreateDirectory(folderXuat);

                string fileXuatPath = Path.Combine(folderXuat, $"HoaDon_{txtSoHD.Text.Trim()}_{DateTime.Now:yyyyMMdd_HHmmss}.docx");

                // 3. Mở file Word mẫu và thực hiện Replace các trường dữ liệu
                using (DocX doc = DocX.Load(mauFilePath))
                {
                    doc.ReplaceText("{SoHoaDon}", txtSoHD.Text.Trim());
                    doc.ReplaceText("{NgayLapHD}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    doc.ReplaceText("{MaPhieuDat}", V(cboDat));
                    doc.ReplaceText("{TenNhanVienHD}", cboNV2.Text);

                    doc.ReplaceText("{SoPhong}", txtPhong.Text.Trim());
                    doc.ReplaceText("{SoNgayO}", numSoNgay.Value.ToString());

                    doc.ReplaceText("{TienDenBu}", numDenBu.Value.ToString("N0") + " VNĐ");
                    doc.ReplaceText("{TienThanhToan}", numTienTT.Value.ToString("N0") + " VNĐ");
                    doc.ReplaceText("{HinhThucThanhToan}", cboHT.Text);
                    doc.ReplaceText("{MaTT}", txtMaTT.Text.Trim());

                    // Các trường thông tin bổ sung nếu có trên Form (để trống nếu không dùng)
                    doc.ReplaceText("{HoTenKhach}", "");
                    doc.ReplaceText("{SoCMND}", "");
                    doc.ReplaceText("{SoDienThoai}", "");
                    doc.ReplaceText("{DonGiaPhong}", "");
                    doc.ReplaceText("{TienPhong}", "");
                    doc.ReplaceText("{TienDichVu}", "");
                    doc.ReplaceText("{TongTien}", "");
                    doc.ReplaceText("{TienCoc}", "");
                    doc.ReplaceText("{TienBangChu}", "");
                    doc.ReplaceText("{BangChiTietDichVu}", "");
                    doc.ReplaceText("{BangChiTietDenBu}", "");

                    doc.SaveAs(fileXuatPath);
                }

                // 4. Tự động mở file Word ngay sau khi lập xong
                System.Diagnostics.Process.Start(fileXuatPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xuất file Word: " + ex.Message, "Lỗi xuất file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHD_SelectionChanged(object a, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
                txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
        }

        private void btnThanhToan_Click(object a, EventArgs e)
        {
            var k = s.ThanhToan(txtMaTT.Text.Trim(), txtHDChon.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao);
            Tai();
        }

        private void btnTraPhong_Click(object a, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao);
            Tai();
        }

        private void btnDong_Click(object a, EventArgs e) { Close(); }
    }
}