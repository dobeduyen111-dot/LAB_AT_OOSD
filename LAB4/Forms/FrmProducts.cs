using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eSHOPPING.Models;

namespace eSHOPPING.Forms
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();

            this.Load += FrmProducts_Load;
            cboCategory.SelectedIndexChanged +=
                cboCategory_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;

            ConfigureDataGridView();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();

            cboCategory.Items.Add("Điện thoại");
            cboCategory.Items.Add("Laptop");
            cboCategory.Items.Add("Máy tính bảng");
            cboCategory.Items.Add("Phụ kiện");
        }

        private void cboCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cboCategory.SelectedItem == null)
                return;

            string category =
                cboCategory.SelectedItem.ToString();

            LoadProducts(category);
        }

        private void LoadProducts(string category)
        {
            try
            {
                List<Product> products =
                    GetMockProducts(category);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                SetColumnHeaders();

                if (dgvProducts.Columns["CurrentPrice"] != null)
                {
                    dgvProducts.Columns["CurrentPrice"]
                        .DefaultCellStyle.Format = "N0";
                }

                if (products.Count == 0)
                {
                    MessageBox.Show(
                        "Nhóm sản phẩm chưa có sản phẩm.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải danh sách sản phẩm.\n\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<Product> GetMockProducts(string category)
        {
            List<Product> products = new List<Product>();

            switch (category)
            {
                case "Điện thoại":

                    products.Add(new Product
                    {
                        ProductCode = "SP001",
                        ProductName = "Điện thoại ABC",
                        Manufacturer = "ABC",
                        CurrentPrice = 10000000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP002",
                        ProductName = "Điện thoại XYZ",
                        Manufacturer = "XYZ",
                        CurrentPrice = 12000000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP003",
                        ProductName = "Điện thoại Samsung",
                        Manufacturer = "Samsung",
                        CurrentPrice = 15000000,
                        StockStatus = "Còn hàng"
                    });

                    break;

                case "Laptop":

                    products.Add(new Product
                    {
                        ProductCode = "SP004",
                        ProductName = "Laptop ABC",
                        Manufacturer = "ABC",
                        CurrentPrice = 18000000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP005",
                        ProductName = "Laptop Dell",
                        Manufacturer = "Dell",
                        CurrentPrice = 22000000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP006",
                        ProductName = "Laptop HP",
                        Manufacturer = "HP",
                        CurrentPrice = 20000000,
                        StockStatus = "Hết hàng"
                    });

                    break;

                case "Máy tính bảng":

                    products.Add(new Product
                    {
                        ProductCode = "SP007",
                        ProductName = "Tablet ABC",
                        Manufacturer = "ABC",
                        CurrentPrice = 8000000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP008",
                        ProductName = "iPad",
                        Manufacturer = "Apple",
                        CurrentPrice = 15000000,
                        StockStatus = "Còn hàng"
                    });

                    break;

                case "Phụ kiện":

                    products.Add(new Product
                    {
                        ProductCode = "SP009",
                        ProductName = "Chuột không dây",
                        Manufacturer = "Logitech",
                        CurrentPrice = 500000,
                        StockStatus = "Còn hàng"
                    });

                    products.Add(new Product
                    {
                        ProductCode = "SP010",
                        ProductName = "Bàn phím cơ",
                        Manufacturer = "Rapoo",
                        CurrentPrice = 1200000,
                        StockStatus = "Còn hàng"
                    });

                    break;
            }

            return products;
        }

        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            if (cboCategory.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhóm sản phẩm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string category =
                cboCategory.SelectedItem.ToString();

            LoadProducts(category);
        }

        private void ConfigureDataGridView()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.RowHeadersVisible = false;
        }

        private void SetColumnHeaders()
        {
            if (dgvProducts.Columns["ProductCode"] != null)
                dgvProducts.Columns["ProductCode"].HeaderText = "Mã SP";

            if (dgvProducts.Columns["ProductName"] != null)
                dgvProducts.Columns["ProductName"].HeaderText =
                    "Tên sản phẩm";

            if (dgvProducts.Columns["Manufacturer"] != null)
                dgvProducts.Columns["Manufacturer"].HeaderText =
                    "Nhà sản xuất";

            if (dgvProducts.Columns["CurrentPrice"] != null)
                dgvProducts.Columns["CurrentPrice"].HeaderText =
                    "Giá bán";

            if (dgvProducts.Columns["StockStatus"] != null)
                dgvProducts.Columns["StockStatus"].HeaderText =
                    "Tình trạng";
        }
    }
}