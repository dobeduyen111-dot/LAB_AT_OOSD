# Hệ thống quản lý nhân sự

Ứng dụng desktop quản lý nhân sự được viết bằng C# Windows Forms.

## Công nghệ

- C#
- Windows Forms
- **.NET Framework 4.7.2**
- SQL Server / SQL Server LocalDB
- ADO.NET (`System.Data.SqlClient`)



## Chức năng

- Quản lý quyết định tuyển dụng và thử việc.
- Quản lý hợp đồng lao động.
- Quản lý thông tin bảo hiểm.
- Lập quyết định và phiếu chi khen thưởng.

## Yêu cầu

- Windows.
- Visual Studio với workload **.NET desktop development**.
- .NET Framework 4.7.2 Developer Pack.
- SQL Server LocalDB hoặc SQL Server.

## Cài đặt và chạy

1. Mở `WindowsFormsApp1.sln` bằng Visual Studio.
2. Kết nối SQL Server tới:

   ```text
   (localdb)\MSSQLLocalDB
   ```

3. Chạy file `WindowsFormsApp1/Database/QuanLyNhanSu_DayDu.sql` để tạo database và dữ liệu mẫu.
4. Kiểm tra chuỗi kết nối trong `WindowsFormsApp1/App.config`:

   ```text
   Data Source=(localdb)\MSSQLLocalDB;
   Initial Catalog=QuanLyNhanSu;
   Integrated Security=True;
   ```

5. Nhấn `F5` để biên dịch và chạy chương trình.
