# Quản lý khách sạn

Ứng dụng desktop quản lý hoạt động khách sạn, được xây dựng bằng Windows Forms và C#. Phần mềm hỗ trợ quản lý phòng, đặt phòng, khách lưu trú, dịch vụ, tiện nghi, trả phòng, thanh toán và thống kê doanh thu.

## Chức năng chính

- Quản lý danh mục:
  - Khu vực/phân khu phòng.
  - Nhân viên.
  - Loại tiện nghi và quy định đền bù.
  - Dịch vụ của khách sạn.
- Quản lý phòng và tiện nghi:
  - Thêm phòng, thiết lập sức chứa, đơn giá và trạng thái phòng.
  - Thêm tiện nghi, cập nhật tình trạng và lập phiếu lắp đặt.
- Đặt phòng:
  - Thêm khách hàng và lập phiếu đặt phòng.
  - Chọn nhiều phòng, nhập tiền cọc và kênh đặt phòng.
  - Thêm người lưu trú, nhận phòng hoặc đánh dấu No-show.
- Dịch vụ:
  - Ghi nhận dịch vụ khách sử dụng theo phòng và phiếu đặt.
  - Theo dõi lịch sử sử dụng dịch vụ.
- Trả phòng và thanh toán:
  - Lập phiếu đền bù tiện nghi hư hỏng/mất mát.
  - Lập hóa đơn, ghi nhận thanh toán và trả phòng.
  - Xuất hóa đơn ra file Word từ mẫu `Hoa_don_thanh_toan_khach_san.docx`.
- Thống kê tổng hợp và thống kê dịch vụ theo khoảng thời gian.

## Công nghệ sử dụng

- C# / Windows Forms.
- .NET Framework 4.7.2.
- Microsoft SQL Server LocalDB (`MSSQLLocalDB`).
- ADO.NET (`System.Data.SqlClient`) để truy cập dữ liệu.
- DocX 5.2.0 để tạo hóa đơn Word.
- Visual Studio 2017 trở lên, khuyến nghị Visual Studio 2022.

## Yêu cầu môi trường

- Windows.
- Visual Studio có workload **.NET desktop development**.
- .NET Framework 4.7.2 Developer Pack.
- SQL Server LocalDB, thường được cài cùng Visual Studio hoặc SQL Server Express.
- SQL Server Management Studio (không bắt buộc, dùng để chạy script SQL thuận tiện hơn).

## Cài đặt và chạy

### 1. Tạo cơ sở dữ liệu

1. Mở SQL Server Management Studio hoặc công cụ chạy truy vấn SQL.
2. Kết nối tới:

   ```text
   (localdb)\\MSSQLLocalDB
   ```

3. Mở và chạy toàn bộ file [`SQLQuery1.sql`](SQLQuery1.sql).

   Script sẽ tạo database `QuanLyKhachSan`, các bảng, chỉ mục và dữ liệu mẫu.

> Lưu ý: script có các lệnh `DROP TABLE` để tạo lại cấu trúc dữ liệu. Không chạy trên database có dữ liệu cần giữ lại nếu chưa sao lưu.

### 2. Mở solution

Mở file [`QuanLyKhachSan.sln`](QuanLyKhachSan.sln) bằng Visual Studio, sau đó khôi phục package NuGet nếu Visual Studio chưa tự động thực hiện.

Package chính của project là `DocX` phiên bản `5.2.0`, được tham chiếu từ thư mục `packages`.

### 3. Kiểm tra cấu hình kết nối

Cấu hình mặc định trong [`QuanLyKhachSan/App.config`](QuanLyKhachSan/App.config) là:

```xml
<add name="QuanLyKhachSanDB"
     connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
     providerName="System.Data.SqlClient" />
```

Nếu sử dụng SQL Server instance khác, chỉnh `Data Source` và thông tin xác thực trong connection string trước khi chạy.

### 4. Build và chạy

1. Chọn cấu hình `Debug` hoặc `Release`.
2. Chọn project `QuanLyKhachSan` làm Startup Project.
3. Nhấn `F5` hoặc `Ctrl + F5` để chạy ứng dụng.

Ứng dụng khởi động tại màn hình chính `FrmMain`.

## Xuất hóa đơn Word

Khi lập hóa đơn, chương trình tìm file mẫu theo thứ tự:

1. Thư mục chạy ứng dụng, thường là `QuanLyKhachSan/bin/Debug`.
2. Thư mục gốc của project.

Để tính năng hoạt động ổn định sau khi build, đặt file `Hoa_don_thanh_toan_khach_san.docx` cạnh file `.exe` trong thư mục output. Hóa đơn tạo ra được lưu trong thư mục `HoaDonDaXuat`.

## Cấu trúc project

```text
QuanLyKhachSan/
├── Data/
│   └── Db.cs                  # Kết nối và thực thi truy vấn SQL
├── Forms/                     # Các giao diện Windows Forms
├── Services/                  # Nghiệp vụ đặt phòng, dịch vụ, trả phòng...
├── Properties/                # Settings và resources
├── App.config                 # Connection string và cấu hình runtime
├── QuanLyKhachSan.csproj      # Cấu hình project
└── Program.cs                 # Điểm khởi động ứng dụng
SQLQuery1.sql                  # Script tạo database và dữ liệu mẫu
QuanLyKhachSan.sln             # Solution Visual Studio
```

## Luồng sử dụng đề xuất

1. Khởi tạo danh mục khu vực, nhân viên, loại tiện nghi, dịch vụ và quy định đền bù.
2. Khai báo phòng và tiện nghi.
3. Thêm thông tin khách hàng, sau đó lập phiếu đặt phòng.
4. Nhận phòng và ghi nhận dịch vụ phát sinh.
5. Khi khách rời đi, lập phiếu đền bù nếu có, lập hóa đơn và ghi nhận thanh toán.
6. Sử dụng màn hình thống kê để xem số phiếu đặt, số khách đang ở, hóa đơn, doanh thu và doanh thu dịch vụ.

## Ghi chú

- Ứng dụng sử dụng xác thực Windows (`Integrated Security=True`) khi kết nối SQL Server.
- Database mặc định có dữ liệu mẫu để kiểm tra nhanh các chức năng.
- Mã nguồn hiện chưa kèm bộ kiểm thử tự động; nên kiểm tra kết nối database và dữ liệu mẫu trước khi sử dụng.

