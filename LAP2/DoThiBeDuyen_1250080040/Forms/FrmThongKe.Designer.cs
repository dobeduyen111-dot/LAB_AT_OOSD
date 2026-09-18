using System;

namespace QuanLyThuVien.Forms
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;

        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;

        private System.Windows.Forms.Label lblMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblHuHong;
        private System.Windows.Forms.Label lblPhiPhat;

        private System.Windows.Forms.DataGridView dgvPhat;

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDong;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();

            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();

            this.lblMuon = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblHuHong = new System.Windows.Forms.Label();
            this.lblPhiPhat = new System.Windows.Forms.Label();

            this.dgvPhat = new System.Windows.Forms.DataGridView();

            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                16F,
                System.Drawing.FontStyle.Bold);

            this.lblTieuDe.Location = new System.Drawing.Point(300, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(200, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ THƯ VIỆN";

            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(30, 75);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(53, 13);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";

            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(90, 70);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 20);
            this.dtTu.TabIndex = 2;

            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(240, 75);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 13);
            this.lblDenNgay.TabIndex = 3;
            this.lblDenNgay.Text = "Đến ngày:";

            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(310, 70);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 20);
            this.dtDen.TabIndex = 4;

            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(460, 68);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 25);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // 
            // lblMuon
            // 
            this.lblMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuon.Location = new System.Drawing.Point(30, 115);
            this.lblMuon.Name = "lblMuon";
            this.lblMuon.Size = new System.Drawing.Size(180, 40);
            this.lblMuon.TabIndex = 6;
            this.lblMuon.Text = "Lượt sách mượn: 0";
            this.lblMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblQuaHan
            // 
            this.lblQuaHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuaHan.Location = new System.Drawing.Point(225, 115);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(180, 40);
            this.lblQuaHan.TabIndex = 7;
            this.lblQuaHan.Text = "Sách quá hạn: 0";
            this.lblQuaHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblMat
            // 
            this.lblMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMat.Location = new System.Drawing.Point(420, 115);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(150, 40);
            this.lblMat.TabIndex = 8;
            this.lblMat.Text = "Sách mất: 0";
            this.lblMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblHuHong
            // 
            this.lblHuHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHuHong.Location = new System.Drawing.Point(585, 115);
            this.lblHuHong.Name = "lblHuHong";
            this.lblHuHong.Size = new System.Drawing.Size(170, 40);
            this.lblHuHong.TabIndex = 9;
            this.lblHuHong.Text = "Sách hư hỏng: 0";
            this.lblHuHong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblPhiPhat
            // 
            this.lblPhiPhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhiPhat.Location = new System.Drawing.Point(30, 170);
            this.lblPhiPhat.Name = "lblPhiPhat";
            this.lblPhiPhat.Size = new System.Drawing.Size(725, 40);
            this.lblPhiPhat.TabIndex = 10;
            this.lblPhiPhat.Text = "Tổng phí phạt: 0";
            this.lblPhiPhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // dgvPhat
            // 
            this.dgvPhat.AllowUserToAddRows = false;
            this.dgvPhat.AllowUserToDeleteRows = false;
            this.dgvPhat.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhat.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhat.Location = new System.Drawing.Point(30, 230);
            this.dgvPhat.Name = "dgvPhat";
            this.dgvPhat.ReadOnly = true;
            this.dgvPhat.RowHeadersVisible = false;
            this.dgvPhat.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhat.Size = new System.Drawing.Size(725, 250);
            this.dgvPhat.TabIndex = 11;

            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(680, 495);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 30);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 550);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtDen);

            this.Controls.Add(this.btnThongKe);

            this.Controls.Add(this.lblMuon);
            this.Controls.Add(this.lblQuaHan);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblHuHong);
            this.Controls.Add(this.lblPhiPhat);

            this.Controls.Add(this.dgvPhat);
            this.Controls.Add(this.btnDong);

            this.Name = "FrmThongKe";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Thống kê thư viện";

            this.Load +=
                new System.EventHandler(this.FrmThongKe_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}