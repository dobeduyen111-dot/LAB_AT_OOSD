
# Quản lý hồ sơ bệnh án

Ứng dụng C# Windows Forms quản lý hồ sơ bệnh án, đăng ký bệnh nhân, khám bệnh, xét nghiệm và lập toa thuốc.

## Công nghệ

- C# Windows Forms
- .NET Framework 4.7.2
- SQL Server và ADO.NET
- Visual Studio 2022

## Chức năng

- FrmBenhNhan: đăng ký bệnh nhân, ảnh 3x4, phí quản lý, cấp hồ sơ và danh sách bệnh nhân.
- FrmKhamBenh: thông tin hồ sơ, bác sĩ, khoa, triệu chứng, chẩn đoán và chỉ định xét nghiệm.
- FrmLapToaThuoc: chọn thuốc, số lượng, liều dùng, lời dặn, thanh toán và hoàn tất hồ sơ.
- FrmDanhMuc: quản lý khoa điều trị, bác sĩ, thuốc và loại xét nghiệm bằng 4 TabPage.

## Build và chạy

Mở `WindowsFormsApp.sln` bằng Visual Studio, chọn `Debug` và nhấn `F5`.

Hoặc:

```powershell
msbuild WindowsFormsApp.sln /t:Rebuild /p:Configuration=Debug

## Trạng thái

Giao diện các Form đã được dựng bằng control Windows Forms thật và build thành công với .NET Framework 4.7.2. Các bảng hiện có dữ liệu mẫu để kiểm tra bố cục; Service có thể tiếp tục mở rộng CRUD theo schema database thực tế.

## GitHub

git add .
git commit -m "Add project README"
git push origin main

