# Quản lý công ty du lịch

Ứng dụng desktop Windows Forms hỗ trợ quản lý hoạt động của một công ty du lịch. Giao diện và nghiệp vụ được viết bằng C#, dữ liệu được lưu trên SQL Server.

## Chức năng

- Quản lý danh mục phương tiện, điểm bán vé, hướng dẫn viên và điểm tham quan.
- Quản lý tour, các điểm dừng, phương tiện theo chặng và điểm tham quan trong hành trình.
- Lập lịch chuyến khách lẻ, mở hoặc đóng đăng ký.
- Đăng ký khách lẻ và đăng ký khách theo đoàn, bao gồm danh sách thành viên.
- Phân công hướng dẫn viên cho chuyến đi hoặc đoàn khách.
- Theo dõi thanh toán đoàn sau tour, gửi khảo sát và ghi nhận phản hồi.
- Xem thống kê đăng ký, thanh toán, khảo sát và tính lương hướng dẫn viên theo tháng.

## Công nghệ

- C# Windows Forms
- .NET Framework 4.7.2
- SQL Server LocalDB (`MSSQLLocalDB`)
- ADO.NET (`System.Data.SqlClient`)

## Yêu cầu

- Windows
- Visual Studio có workload **.NET desktop development** và hỗ trợ .NET Framework 4.7.2
- SQL Server Express LocalDB
- Database `QuanLyCongTyDuLich` với schema mà ứng dụng sử dụng

> Repository hiện không kèm script tạo database/schema hoặc dữ liệu mẫu. Cần tạo database và các bảng tương thích trước khi chạy ứng dụng; nếu chưa có database, ứng dụng sẽ không kết nối được.

## Cấu hình kết nối

Mặc định, `WindowsFormsApp1/App.config` kết nối tới LocalDB trên máy hiện tại bằng Windows Authentication:

```xml
<add name="QuanLyCongTyDuLichDB"
     connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

Nếu dùng SQL Server instance khác, sửa `Data Source` và thông tin xác thực trong connection string. Tên database phải khớp với database đã tạo.

## Chạy chương trình

1. Clone hoặc tải repository về máy.
2. Mở `WindowsFormsApp1.sln` bằng Visual Studio.
3. Tạo database `QuanLyCongTyDuLich` cùng schema cần thiết trên SQL Server/LocalDB.
4. Kiểm tra connection string trong `WindowsFormsApp1/App.config`.
5. Build solution, sau đó chạy project `WindowsFormsApp1` (F5).

## Cấu trúc thư mục

```text
WindowsFormsApp1/
├── Data/          # Tiện ích kết nối và truy vấn SQL
├── Forms/         # Các màn hình WinForms
├── Services/      # Truy vấn và xử lý nghiệp vụ
├── Properties/    # Tài nguyên và cấu hình project
├── App.config     # Cấu hình .NET và connection string
└── Program.cs     # Điểm vào ứng dụng
```

Các thao tác database được gọi qua `Data/Db.cs`; các form sử dụng những service tương ứng trong `Services/`.
