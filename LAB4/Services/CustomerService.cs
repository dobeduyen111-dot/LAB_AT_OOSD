using eSHOPPING.Models;
using eSHOPPING.Repositories;
using System;
using System.Text.RegularExpressions;
namespace eSHOPPING.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository repository;
        public CustomerService()
        {
            repository = new CustomerRepository();
        }
        public bool Register(Customer customer, string password)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new Exception("Vui lòng nhập họ và tên.");
            if (string.IsNullOrWhiteSpace(customer.IdPassport))
                throw new Exception("Vui lòng nhập CMND/CCCD/Hộ chiếu.");
            if (string.IsNullOrWhiteSpace(customer.Address))
                throw new Exception("Vui lòng nhập địa chỉ.");
            if (string.IsNullOrWhiteSpace(customer.Phone))
                throw new Exception("Vui lòng nhập số điện thoại.");
            if (string.IsNullOrWhiteSpace(customer.Username))
                throw new Exception("Vui lòng nhập tên đăng nhập.");
            if (string.IsNullOrWhiteSpace(password) ||
                password.Length < 6)
            {
                throw new Exception(
                    "Mật khẩu phải có ít nhất 6 ký tự.");
            }
            if (!Regex.IsMatch(customer.Phone, @"^[0-9]{9,11}$"))
                throw new Exception("Số điện thoại không hợp lệ.");
            if (!string.IsNullOrWhiteSpace(customer.Email) &&
                !Regex.IsMatch(
                    customer.Email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("Email không hợp lệ.");
            }
            if (repository.CheckUsername(customer.Username))
                throw new Exception(
                    "Tên đăng nhập đã tồn tại.");
            customer.PasswordHash = password;
            return repository.Create(customer);
        }
    }
}