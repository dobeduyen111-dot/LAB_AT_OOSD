using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmChuyenLe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.DateTimePicker dtDi;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.TextBox txtDon;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDongDK;
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
                new System.Drawing.Point(18, 14);
            this.lblTitle1.Size =
                new System.Drawing.Size(680, 28);
            this.lblTitle1.Text = "LẬP LỊCH CHUYẾN KHÁCH LẺ";
            this.Controls.Add(this.lblTitle1);

            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Location =
                new System.Drawing.Point(20, 62);
            this.lblTitle2.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle2.Text = "Mã chuyến";
            this.Controls.Add(this.lblTitle2);

            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtMa.Name = "txtMa";
            this.txtMa.Location =
                new System.Drawing.Point(165, 63);
            this.txtMa.Size =
                new System.Drawing.Size(265, 29);
            this.Controls.Add(this.txtMa);

            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Location =
                new System.Drawing.Point(540, 62);
            this.lblTitle3.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle3.Text = "Tour";
            this.Controls.Add(this.lblTitle3);

            this.cboTour = new System.Windows.Forms.ComboBox();
            this.cboTour.Name = "cboTour";
            this.cboTour.Location =
                new System.Drawing.Point(685, 62);
            this.cboTour.Size =
                new System.Drawing.Size(362, 30);
            this.cboTour.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.SelectedIndexChanged +=
                new System.EventHandler(this.TinhNgayVe);
            this.Controls.Add(this.cboTour);

            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Location =
                new System.Drawing.Point(20, 112);
            this.lblTitle4.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle4.Text = "Ngày đi";
            this.Controls.Add(this.lblTitle4);

            this.dtDi =
                new System.Windows.Forms.DateTimePicker();
            this.dtDi.Name = "dtDi";
            this.dtDi.Location =
                new System.Drawing.Point(165, 112);
            this.dtDi.Size =
                new System.Drawing.Size(265, 30);
            this.dtDi.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDi.CustomFormat = "dd/MM/yyyy";
            this.dtDi.ValueChanged +=
                new System.EventHandler(this.TinhNgayVe);
            this.Controls.Add(this.dtDi);

            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Location =
                new System.Drawing.Point(540, 112);
            this.lblTitle5.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle5.Text = "Ngày về";
            this.Controls.Add(this.lblTitle5);

            this.lblNgayVe = new System.Windows.Forms.Label();
            this.lblNgayVe.Name = "lblNgayVe";
            this.lblNgayVe.Location =
                new System.Drawing.Point(685, 112);
            this.lblNgayVe.Size =
                new System.Drawing.Size(350, 30);
            this.lblNgayVe.Text = "-";
            this.lblNgayVe.Font = new System.Drawing.Font(
                "Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.lblNgayVe);

            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Location =
                new System.Drawing.Point(20, 161);
            this.lblTitle6.Size =
                new System.Drawing.Size(145, 28);
            this.lblTitle6.Text = "Địa điểm đón";
            this.Controls.Add(this.lblTitle6);

            this.txtDon = new System.Windows.Forms.TextBox();
            this.txtDon.Name = "txtDon";
            this.txtDon.Location =
                new System.Drawing.Point(165, 162);
            this.txtDon.Size =
                new System.Drawing.Size(785, 29);
            this.Controls.Add(this.txtDon);

            this.btnThem = new System.Windows.Forms.Button();
            this.btnThem.Name = "btnThem";
            this.btnThem.Location =
                new System.Drawing.Point(555, 212);
            this.btnThem.Size =
                new System.Drawing.Size(160, 36);
            this.btnThem.Text = "Tạo chuyến";
            this.btnThem.Click +=
                new System.EventHandler(this.btnThem_Click);
            this.Controls.Add(this.btnThem);

            this.btnDongDK = new System.Windows.Forms.Button();
            this.btnDongDK.Name = "btnDongDK";
            this.btnDongDK.Location =
                new System.Drawing.Point(728, 212);
            this.btnDongDK.Size =
                new System.Drawing.Size(160, 36);
            this.btnDongDK.Text = "Đóng đăng ký";
            this.btnDongDK.Click +=
                new System.EventHandler(this.btnDongDK_Click);
            this.Controls.Add(this.btnDongDK);

            this.btnDong = new System.Windows.Forms.Button();
            this.btnDong.Name = "btnDong";
            this.btnDong.Location =
                new System.Drawing.Point(899, 212);
            this.btnDong.Size =
                new System.Drawing.Size(160, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click +=
                new System.EventHandler(this.btnDong_Click);
            this.Controls.Add(this.btnDong);

            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv.Name = "dgv";
            this.dgv.Location =
                new System.Drawing.Point(20, 276);
            this.dgv.Size =
                new System.Drawing.Size(1035, 382);
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

            this.ClientSize = new System.Drawing.Size(1120, 710);
            this.MinimumSize = new System.Drawing.Size(820, 550);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FrmChuyenLe";
            this.Text = "QUẢN LÝ LỊCH CHUYẾN KHÁCH LẺ";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load +=
                new System.EventHandler(this.FrmChuyenLe_Load);

            this.ResumeLayout(false);
        }
    }
}
