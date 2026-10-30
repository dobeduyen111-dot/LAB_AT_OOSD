# Bài 4 – Quản lý cho thuê văn phòng cao ốc

**Một Solution – Một project C# WinForms (.NET Framework 4.7.2)**, cấu trúc thư mục theo ảnh bạn cung cấp.

```text
QuanLyVanPhong.sln
QuanLyVanPhong/
├── Properties/           (Visual Studio tạo mục References khi mở)
├── Data/
│   └── DbConnection.cs
├── Forms/
│   ├── FrmMain.cs (+ FrmMain.Designer.cs)
│   ├── FrmDanhMuc.cs (+ FrmDanhMuc.Designer.cs)
│   └── FrmHopDong.cs (+ FrmHopDong.Designer.cs)
├── Models/               (9 model nghiệp vụ + 1 DTO PhongThueChon)
│   ├── VanPhong.cs, KhachThue.cs, HopDongThue.cs, ChiTietThue.cs
│   ├── KhoanThanhToan.cs, DichVuSuDung.cs, PhieuGiaHan.cs
│   ├── NhanVienVanPhong.cs, KiemTraPhong.cs, PhongThueChon.cs
├── Repositories/
│   ├── VanPhongRepository.cs
│   ├── KhachThueRepository.cs
│   └── HopDongRepository.cs
├── Services/
│   ├── KetQuaXuLy.cs
│   ├── DanhMucService.cs
│   └── HopDongService.cs
├── App.config
├── Program.cs
└── QuanLyVanPhong.csproj

database/QuanLyVanPhongBai4_Gon.sql  (nằm ngoài project)
docs/Bai4_BaoCao_3Form.docx        (nằm ngoài project)
```

## Các Form hiện thực
- **FrmMain:** 8 nút kiểu mẫu Bài 6, nhưng chỉ Danh mục và Hợp đồng được kích hoạt. 6 nút còn lại bị vô hiệu hóa (không có Form tương ứng).
- **FrmDanhMuc:** Hai tab Văn phòng/Tầng và Khách thuê, đọc/ghi SQL Server.
- **FrmHopDong:** Chọn nhiều phòng, thời hạn >= 6 tháng, tính 6 tháng đầu, tạo hợp đồng bằng `sp_LapHopDong` và thu trước bằng `sp_ThuTruoc6Thang`.

## Chạy trên Windows
1. Mở **SSMS** → kết nối `(localdb)\MSSQLLocalDB` → chạy `database/QuanLyVanPhongBai4_Gon.sql` **một lần trên database mới**. Không chạy lại trên database đã có bảng.
2. Cài Visual Studio 2022 với workload **.NET desktop development** và **.NET Framework 4.7.2 Developer Pack**.
3. File → Open → Project/Solution → `QuanLyVanPhong.sln` (không mở thư mục bằng Folder View).
4. Build → Build Solution (Ctrl+Shift+B), F5 chạy.
5. Right click `Forms/FrmMain.cs` → View Designer để chỉnh Form; các file `.Designer.cs` tự lồng bên dưới.

## Kiến trúc
`Form → Service → Repository → DbConnection → SQL Server`, mọi SQL ở Repository; Service kiểm tra nghiệp vụ.

## Lưu ý
- `Models` có **9 mô hình nghiệp vụ**, thêm `PhongThueChon` là DTO riêng cho bảng lựa chọn trên Form, không phải lớp miền nghiệp vụ thứ 10.
- CSDL **10 bảng** (9 bảng nghiệp vụ + `LanThanhToan` để lưu lịch sử thu tiền).
- Chỉ có 3 Form được thiết kế trong báo cáo; các UC còn lại ở mức phân tích/chưa có Form.
- **Chưa xác minh Build hoặc chạy SQL trên Windows**. Hãy dùng bảng Error List nếu cần sửa lỗi máy cụ thể.
- Phần thư mục `database` và `docs` ở ngoài project để Solution Explorer có bố cục gần đúng với ảnh tham khảo.
