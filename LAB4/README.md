# e-SHOPPING

Ứng dụng desktop quản lý một số chức năng cơ bản của cửa hàng trực tuyến, được xây dựng bằng Windows Forms và C#.

## Chức năng

- Hiển thị màn hình chính của ứng dụng.
- Đăng ký tài khoản khách hàng.
- Kiểm tra dữ liệu đăng ký:
  - Họ tên, CMND/CCCD/Hộ chiếu, địa chỉ, số điện thoại và tên đăng nhập không được để trống.
  - Mật khẩu tối thiểu 6 ký tự.
  - Số điện thoại gồm 9–11 chữ số.
  - Email (nếu nhập) phải đúng định dạng cơ bản.
  - Không cho phép trùng tên đăng nhập.
- Xem danh sách sản phẩm theo nhóm:
  - Điện thoại
  - Laptop
  - Máy tính bảng
  - Phụ kiện
- Làm mới danh sách sản phẩm và thoát ứng dụng.

## Công nghệ sử dụng

- C# / Windows Forms
- .NET Framework 4.7.2
- SQL Server LocalDB (`MSSQLLocalDB`)
- ADO.NET (`System.Data.SqlClient`)
- Visual Studio 2017 trở lên (khuyến nghị)

## Cấu trúc thư mục

```text
WindowsFormsApp1/
├── Data/             # Kết nối cơ sở dữ liệu
├── Forms/            # Các giao diện WinForms
├── Models/           # Các lớp dữ liệu Customer, Product
├── Repositories/     # Thao tác dữ liệu khách hàng
├── Services/         # Kiểm tra nghiệp vụ đăng ký
├── App.config        # Cấu hình .NET và connection string
├── Program.cs        # Điểm khởi chạy ứng dụng
└── WindowsFormsApp1.csproj
```

## Yêu cầu môi trường

1. Windows.
2. Visual Studio có workload **.NET desktop development**.
3. .NET Framework 4.7.2 Developer Pack.
4. SQL Server Express LocalDB và công cụ `SqlLocalDB`.

## Cài đặt cơ sở dữ liệu

Ứng dụng sử dụng database `eSHOPPING` và bảng `Customer`. Có thể tạo database và bảng bằng script sau trong SQL Server Object Explorer hoặc SQL Server Management Studio:

```sql
IF DB_ID(N'eSHOPPING') IS NULL
    CREATE DATABASE eSHOPPING;
GO

USE eSHOPPING;
GO

IF OBJECT_ID(N'dbo.Customer', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Customer
    (
        CustomerId  INT IDENTITY(1,1) PRIMARY KEY,
        FullName    NVARCHAR(150) NOT NULL,
        DateOfBirth DATE NOT NULL,
        IdPassport  NVARCHAR(50) NOT NULL,
        Address     NVARCHAR(255) NOT NULL,
        Phone       VARCHAR(11) NOT NULL,
        Username    NVARCHAR(100) NOT NULL UNIQUE,
        PasswordHash NVARCHAR(255) NOT NULL,
        Email       NVARCHAR(255) NULL
    );
END;
GO
```

Mặc định connection string trong `WindowsFormsApp1/App.config` là:

```text
Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=eSHOPPING;
Integrated Security=True;
TrustServerCertificate=True;
MultipleActiveResultSets=True
```

Nếu dùng SQL Server instance khác, cập nhật connection string trong `App.config` và chuỗi kết nối trong `Data/DbConnection.cs` cho đồng nhất.

## Chạy chương trình

1. Mở file `WindowsFormsApp1.sln` bằng Visual Studio.
2. Tạo database và bảng `Customer` theo phần hướng dẫn trên.
3. Chọn configuration `Debug` hoặc `Release`.
4. Nhấn `F5` hoặc chọn **Build > Build Solution**, sau đó chạy project.

Ứng dụng sẽ mở màn hình chính `e-SHOPPING`.

## Lưu ý

- Danh sách sản phẩm hiện là dữ liệu mẫu được tạo trực tiếp trong `Forms/FrmProducts.cs`, chưa đọc từ database.
- Chức năng hiện có đăng ký tài khoản, chưa có màn hình đăng nhập hoặc quản lý đơn hàng.
- Trường có tên `PasswordHash` hiện đang nhận trực tiếp mật khẩu từ form; khi triển khai thực tế cần băm mật khẩu bằng thuật toán an toàn như Argon2, bcrypt hoặc PBKDF2 trước khi lưu.
- File `Form1.cs` là form mẫu mặc định của Visual Studio và hiện không được sử dụng làm màn hình khởi động.

## Giấy phép

Chưa khai báo giấy phép cho project.
