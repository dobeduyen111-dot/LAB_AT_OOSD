using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnChuyenLe;
        private System.Windows.Forms.Button btnDangKyLe;
        private System.Windows.Forms.Button btnDangKyDoan;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Location = new System.Drawing.Point(55, 30);
            this.lblHeader.Size = new System.Drawing.Size(810, 64);
            this.lblHeader.Text = "HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH";
            this.lblHeader.Font = new System.Drawing.Font(
                "Segoe UI", 19F,
                System.Drawing.FontStyle.Bold);
            this.lblHeader.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblHeader);

            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Location = new System.Drawing.Point(75, 130);
            this.btnDanhMuc.Size = new System.Drawing.Size(360, 36);
            this.btnDanhMuc.Text = "Quản lý danh mục";
            this.btnDanhMuc.Click +=
                new System.EventHandler(this.btnDanhMuc_Click);
            this.Controls.Add(this.btnDanhMuc);

            this.btnTour = new System.Windows.Forms.Button();
            this.btnTour.Name = "btnTour";
            this.btnTour.Location = new System.Drawing.Point(485, 130);
            this.btnTour.Size = new System.Drawing.Size(360, 36);
            this.btnTour.Text = "Tour - hành trình";
            this.btnTour.Click +=
                new System.EventHandler(this.btnTour_Click);
            this.Controls.Add(this.btnTour);

            this.btnChuyenLe = new System.Windows.Forms.Button();
            this.btnChuyenLe.Name = "btnChuyenLe";
            this.btnChuyenLe.Location = new System.Drawing.Point(75, 208);
            this.btnChuyenLe.Size = new System.Drawing.Size(360, 36);
            this.btnChuyenLe.Text = "Lịch chuyến khách lẻ";
            this.btnChuyenLe.Click +=
                new System.EventHandler(this.btnChuyenLe_Click);
            this.Controls.Add(this.btnChuyenLe);

            this.btnDangKyLe = new System.Windows.Forms.Button();
            this.btnDangKyLe.Name = "btnDangKyLe";
            this.btnDangKyLe.Location = new System.Drawing.Point(485, 208);
            this.btnDangKyLe.Size = new System.Drawing.Size(360, 36);
            this.btnDangKyLe.Text = "Đăng ký khách lẻ";
            this.btnDangKyLe.Click +=
                new System.EventHandler(this.btnDangKyLe_Click);
            this.Controls.Add(this.btnDangKyLe);

            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Location =
                new System.Drawing.Point(75, 286);
            this.btnDangKyDoan.Size =
                new System.Drawing.Size(360, 36);
            this.btnDangKyDoan.Text = "Đăng ký theo đoàn";
            this.btnDangKyDoan.Click +=
                new System.EventHandler(this.btnDangKyDoan_Click);
            this.Controls.Add(this.btnDangKyDoan);

            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Location =
                new System.Drawing.Point(485, 286);
            this.btnPhanCong.Size =
                new System.Drawing.Size(360, 36);
            this.btnPhanCong.Text = "Phân công hướng dẫn viên";
            this.btnPhanCong.Click +=
                new System.EventHandler(this.btnPhanCong_Click);
            this.Controls.Add(this.btnPhanCong);

            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Location =
                new System.Drawing.Point(75, 364);
            this.btnKetThuc.Size =
                new System.Drawing.Size(360, 36);
            this.btnKetThuc.Text = "Kết thúc tour - khảo sát";
            this.btnKetThuc.Click +=
                new System.EventHandler(this.btnKetThuc_Click);
            this.Controls.Add(this.btnKetThuc);

            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Location =
                new System.Drawing.Point(485, 364);
            this.btnThongKe.Size =
                new System.Drawing.Size(360, 36);
            this.btnThongKe.Text = "Lương - thống kê";
            this.btnThongKe.Click +=
                new System.EventHandler(this.btnThongKe_Click);
            this.Controls.Add(this.btnThongKe);

            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Location =
                new System.Drawing.Point(340, 458);
            this.btnThoat.Size =
                new System.Drawing.Size(240, 36);
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);
            this.Controls.Add(this.btnThoat);

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(920, 565);
            this.MinimumSize = new System.Drawing.Size(820, 550);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FrmMain";
            this.Text = "QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
        }
    }
}
