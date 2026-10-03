using System;
using System.Drawing;
using System.Windows.Forms;

namespace eSHOPPING.Forms
{
    public class FrmMain : Form
    {
        private Label lblTitle;
        private Label lblMenu;
        private Button btnRegister;
        private Button btnProducts;
        private Button btnExit;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblMenu = new Label();
            this.btnRegister = new Button();
            this.btnProducts = new Button();
            this.btnExit = new Button();

            // Form
            this.Text = "e-SHOPPING";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(500, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Tiêu đề
            this.lblTitle.Text = "e-SHOPPING";
            this.lblTitle.Font = new Font(
                "Microsoft Sans Serif",
                24,
                FontStyle.Bold
            );
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(150, 40);

            // Dòng mô tả
            this.lblMenu.Text = "DANH MỤC CHỨC NĂNG";
            this.lblMenu.Font = new Font(
                "Microsoft Sans Serif",
                12,
                FontStyle.Bold
            );
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new Point(145, 100);

            // Nút Đăng ký
            this.btnRegister.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.btnRegister.Font = new Font(
                "Microsoft Sans Serif",
                11,
                FontStyle.Regular
            );
            this.btnRegister.Size = new Size(250, 50);
            this.btnRegister.Location = new Point(125, 140);
            this.btnRegister.Click += new EventHandler(
                this.btnRegister_Click
            );

            // Nút Xem sản phẩm
            this.btnProducts.Text = "XEM DANH SÁCH SẢN PHẨM";
            this.btnProducts.Font = new Font(
                "Microsoft Sans Serif",
                11,
                FontStyle.Regular
            );
            this.btnProducts.Size = new Size(250, 50);
            this.btnProducts.Location = new Point(125, 205);
            this.btnProducts.Click += new EventHandler(
                this.btnProducts_Click
            );

            // Nút thoát
            this.btnExit.Text = "THOÁT";
            this.btnExit.Font = new Font(
                "Microsoft Sans Serif",
                11,
                FontStyle.Regular
            );
            this.btnExit.Size = new Size(250, 50);
            this.btnExit.Location = new Point(125, 270);
            this.btnExit.Click += new EventHandler(
                this.btnExit_Click
            );

            // Thêm control vào Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnExit);
        }

        // Mở Form đăng ký
        private void btnRegister_Click(
            object sender,
            EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.ShowDialog();
        }

        // Mở Form sản phẩm
        private void btnProducts_Click(
            object sender,
            EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            frm.ShowDialog();
        }

        // Thoát chương trình
        private void btnExit_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}