using System;
using System.Windows.Forms;
using eSHOPPING.Models;
using eSHOPPING.Services;

namespace eSHOPPING.Forms
{
    public partial class FrmRegister : Form
    {
        private readonly CustomerService customerService;

        public FrmRegister()
        {
            InitializeComponent();

            customerService = new CustomerService();

            // Ẩn mật khẩu khi nhập
            txtPassword.UseSystemPasswordChar = true;

            // Thiết lập ngày sinh mặc định
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txtFullName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu cơ bản
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập họ và tên.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdPassport.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập CMND/CCCD/Hộ chiếu.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdPassport.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập địa chỉ.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAddress.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập số điện thoại.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPhone.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên đăng nhập.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập mật khẩu.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.Focus();
                    return;
                }

                // Tạo đối tượng Customer
                Customer customer = new Customer
                {
                    FullName = txtFullName.Text.Trim(),
                    DateOfBirth = dtpDateOfBirth.Value.Date,
                    IdPassport = txtIdPassport.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text)
                        ? null
                        : txtEmail.Text.Trim()
                };

                // Gọi Service để đăng ký
                bool result = customerService.Register(
                    customer,
                    txtPassword.Text
                );

                if (result)
                {
                    MessageBox.Show(
                        "Đăng ký tài khoản thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearForm();

                    txtFullName.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể tạo tài khoản.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtIdPassport.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();

            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
        }
    }
}