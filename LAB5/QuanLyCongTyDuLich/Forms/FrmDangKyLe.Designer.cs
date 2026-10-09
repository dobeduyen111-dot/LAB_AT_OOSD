using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyLe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.ComboBox cboDiemBan;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblTitle7;
        private System.Windows.Forms.NumericUpDown numNguoi;
        private System.Windows.Forms.Label lblTitle8;
        private System.Windows.Forms.Label lblThanhTien;

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Location =
                new System.Drawing.Point(20, 14);
            this.lblTitle1.Size =
                new System.Drawing.Size(760, 28);
            this.lblTitle1.Text = "LẬP PHIẾU ĐĂNG KÝ KHÁCH LẺ";
            this.Controls.Add(this.lblTitle1);

            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Location =
                new System.Drawing.Point(20, 59);
            this.lblTitle2.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle2.Text = "Số đăng ký";
            this.Controls.Add(this.lblTitle2);

            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtSo.Name = "txtSo";
            this.txtSo.Location =
                new System.Drawing.Point(165, 60);
            this.txtSo.Size =
                new System.Drawing.Size(260, 29);
            this.Controls.Add(this.txtSo);

            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Location =
                new System.Drawing.Point(540, 59);
            this.lblTitle3.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle3.Text = "Chuyến";
            this.Controls.Add(this.lblTitle3);

            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.cboChuyen.Name = "cboChuyen";
            this.cboChuyen.Location =
                new System.Drawing.Point(685, 59);
            this.cboChuyen.Size =
                new System.Drawing.Size(350, 30);
            this.cboChuyen.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyen.SelectedIndexChanged +=
                new System.EventHandler(this.TinhTien);
            this.Controls.Add(this.cboChuyen);

            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Location =
                new System.Drawing.Point(20, 108);
            this.lblTitle4.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle4.Text = "Điểm bán vé";
            this.Controls.Add(this.lblTitle4);

            this.cboDiemBan = new System.Windows.Forms.ComboBox();
            this.cboDiemBan.Name = "cboDiemBan";
            this.cboDiemBan.Location =
                new System.Drawing.Point(165, 108);
            this.cboDiemBan.Size =
                new System.Drawing.Size(260, 30);
            this.cboDiemBan.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(this.cboDiemBan);

            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Location =
                new System.Drawing.Point(540, 108);
            this.lblTitle5.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle5.Text = "Người đăng ký";
            this.Controls.Add(this.lblTitle5);

            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTen.Name = "txtTen";
            this.txtTen.Location =
                new System.Drawing.Point(685, 109);
            this.txtTen.Size =
                new System.Drawing.Size(350, 29);
            this.Controls.Add(this.txtTen);

            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Location =
                new System.Drawing.Point(20, 157);
            this.lblTitle6.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle6.Text = "Điện thoại";
            this.Controls.Add(this.lblTitle6);

            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDT.Name = "txtDT";
            this.txtDT.Location =
                new System.Drawing.Point(165, 158);
            this.txtDT.Size =
                new System.Drawing.Size(260, 29);
            this.Controls.Add(this.txtDT);

            this.lblTitle7 = new System.Windows.Forms.Label();
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Location =
                new System.Drawing.Point(540, 157);
            this.lblTitle7.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle7.Text = "Số người (<12)";
            this.Controls.Add(this.lblTitle7);

            this.numNguoi =
                new System.Windows.Forms.NumericUpDown();
            this.numNguoi.Name = "numNguoi";
            this.numNguoi.Location =
                new System.Drawing.Point(685, 157);
            this.numNguoi.Size =
                new System.Drawing.Size(160, 30);
            this.numNguoi.Minimum = 1M;
            this.numNguoi.Maximum = 11M;
            this.numNguoi.Value = 1M;
            this.numNguoi.ValueChanged +=
                new System.EventHandler(this.TinhTien);
            this.Controls.Add(this.numNguoi);

            this.lblTitle8 = new System.Windows.Forms.Label();
            this.lblTitle8.Name = "lblTitle8";
            this.lblTitle8.Location =
                new System.Drawing.Point(20, 212);
            this.lblTitle8.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle8.Text = "Thành tiền";
            this.Controls.Add(this.lblTitle8);

            this.lblThanhTien =
                new System.Windows.Forms.Label();
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Location =
                new System.Drawing.Point(164, 209);
            this.lblThanhTien.Size =
                new System.Drawing.Size(360, 34);
            this.lblThanhTien.Text = "0 đ";
            this.lblThanhTien.Font =
                new System.Drawing.Font(
                    "Segoe UI", 12F,
                    System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.lblThanhTien);

            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Location =
                new System.Drawing.Point(570, 205);
            this.btnDangKy.Size =
                new System.Drawing.Size(310, 36);
            this.btnDangKy.Text = "Đăng ký và thanh toán vé";
            this.btnDangKy.Click +=
                new System.EventHandler(this.btnDangKy_Click);
            this.Controls.Add(this.btnDangKy);

            this.btnDong = new System.Windows.Forms.Button();
            this.btnDong.Name = "btnDong";
            this.btnDong.Location =
                new System.Drawing.Point(900, 205);
            this.btnDong.Size =
                new System.Drawing.Size(165, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click +=
                new System.EventHandler(this.btnDong_Click);
            this.Controls.Add(this.btnDong);

            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv.Name = "dgv";
            this.dgv.Location =
                new System.Drawing.Point(20, 269);
            this.dgv.Size =
                new System.Drawing.Size(1040, 409);
            this.dgv.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.MultiSelect = false;
            this.dgv.RowHeadersVisible = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ReadOnly = true;
            this.Controls.Add(this.dgv);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1120, 735);
            this.MinimumSize = new System.Drawing.Size(820, 550);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FrmDangKyLe";
            this.Text = "ĐĂNG KÝ KHÁCH LẺ - THANH TOÁN VÉ";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load +=
                new System.EventHandler(this.FrmDangKyLe_Load);

            this.ResumeLayout(false);
        }
    }
}
