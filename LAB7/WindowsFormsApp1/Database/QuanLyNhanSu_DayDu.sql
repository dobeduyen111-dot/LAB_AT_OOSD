-- Extracted from Bai_7_Quan_ly_nhan_su_1250080040.docx, Ch??ng 4.
/*
 BAI 7 - QUAN LY NHAN SU - SQL SERVER / LOCALDB
 15 bang nghiep vu theo bao cao + 3 bang ky thuat:
 CaLamViec, ChiTietPhanCong, ChiTietPhuTroi.
 Chay 01_TaoCSDL.sql TRUOC 02_DuLieuMau.sql.
 Co the chay lai: CREATE TABLE chi thuc hien khi bang chua ton tai.
*/
IF DB_ID(N'QuanLyNhanSu') IS NULL
    CREATE DATABASE QuanLyNhanSu;
GO
USE QuanLyNhanSu;
GO

-- A. NHAN SU, TUYEN DUNG, HOP DONG
IF OBJECT_ID(N'dbo.PhongBan',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PhongBan (
        MaPhongBan INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PhongBan PRIMARY KEY,
        TenPhongBan NVARCHAR(150) NOT NULL,
        LoaiDonVi NVARCHAR(80) NULL,
        CONSTRAINT UQ_PhongBan_Ten UNIQUE (TenPhongBan)
    );
END;
GO
IF OBJECT_ID(N'dbo.NhanVien',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.NhanVien (
        MaNV INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_NhanVien PRIMARY KEY,
        HoTen NVARCHAR(150) NOT NULL,
        NgaySinh DATE NULL,
        DiaChi NVARCHAR(250) NULL,
        MaPhongBan INT NOT NULL,
        TrangThai VARCHAR(15) NOT NULL CONSTRAINT DF_NhanVien_TrangThai DEFAULT 'ThuViec',
        CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES dbo.PhongBan(MaPhongBan),
        CONSTRAINT CK_NhanVien_TrangThai CHECK (TrangThai IN ('ThuViec','ChinhThuc','NghiViec'))
    );
END;
GO
IF OBJECT_ID(N'dbo.QuyetDinhTuyenDung',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuyetDinhTuyenDung (
        SoQDTD INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QDTD PRIMARY KEY,
        MaNV INT NOT NULL,
        MaPhongBan INT NOT NULL,
        NgayKy DATE NOT NULL,
        BatDauThuViec DATE NOT NULL,
        KetThucThuViec DATE NOT NULL,
        LuongThuViec DECIMAL(18,2) NOT NULL,
        DieuKhoan NVARCHAR(MAX) NOT NULL,
        CONSTRAINT UQ_QDTD_MaNV UNIQUE(MaNV),
        CONSTRAINT FK_QDTD_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT FK_QDTD_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES dbo.PhongBan(MaPhongBan),
        CONSTRAINT CK_QDTD_Ngay CHECK(KetThucThuViec >= BatDauThuViec),
        CONSTRAINT CK_QDTD_Luong CHECK(LuongThuViec >= 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.HopDongLaoDong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.HopDongLaoDong (
        SoHopDong INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_HopDong PRIMARY KEY,
        MaNV INT NOT NULL,
        LoaiHopDong VARCHAR(10) NOT NULL,
        NgayKy DATE NOT NULL,
        NgayBatDau DATE NOT NULL,
        NgayKetThuc DATE NULL,
        NoiDung NVARCHAR(MAX) NOT NULL,
        CONSTRAINT FK_HopDong_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT CK_HopDong_Loai CHECK(LoaiHopDong IN ('DaiHan','NganHan')),
        CONSTRAINT CK_HopDong_Ngay CHECK(NgayKetThuc IS NULL OR NgayKetThuc >= NgayBatDau)
    );
END;
GO
IF OBJECT_ID(N'dbo.QuyetDinhChucVu',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuyetDinhChucVu (
        SoQDChucVu INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QDChucVu PRIMARY KEY,
        MaNV INT NOT NULL,
        ChucVu NVARCHAR(100) NOT NULL,
        NgayKy DATE NOT NULL,
        NgayHieuLuc DATE NOT NULL,
        PhuCapChucVu DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDChucVu_PhuCap DEFAULT 0,
        CONSTRAINT FK_QDChucVu_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT CK_QDChucVu_PhuCap CHECK(PhuCapChucVu >= 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.QuyetDinhLuong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuyetDinhLuong (
        SoQDLuong INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QDLuong PRIMARY KEY,
        MaNV INT NOT NULL,
        NgayKy DATE NOT NULL,
        NgayHieuLuc DATE NOT NULL,
        LuongCoBan DECIMAL(18,2) NOT NULL,
        PhuCapLuong DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDLuong_PhuCap DEFAULT 0,
        PhuCapDocHai DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDLuong_DocHai DEFAULT 0,
        CONSTRAINT FK_QDLuong_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT CK_QDLuong_SoTien CHECK(LuongCoBan >= 0 AND PhuCapLuong >= 0 AND PhuCapDocHai >= 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.HoSoBaoHiem',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.HoSoBaoHiem (
        MaHoSoBH INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_HoSoBaoHiem PRIMARY KEY,
        MaNV INT NOT NULL,
        MaSoBHYT VARCHAR(30) NOT NULL,
        MaSoBHXH VARCHAR(30) NOT NULL,
        MucDongBHYT DECIMAL(18,2) NOT NULL,
        MucDongBHXH DECIMAL(18,2) NOT NULL,
        CONSTRAINT UQ_BaoHiem_NV UNIQUE(MaNV),
        CONSTRAINT UQ_BaoHiem_BHYT UNIQUE(MaSoBHYT),
        CONSTRAINT UQ_BaoHiem_BHXH UNIQUE(MaSoBHXH),
        CONSTRAINT FK_BaoHiem_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT CK_BaoHiem_SoTien CHECK(MucDongBHYT >= 0 AND MucDongBHXH >= 0)
    );
END;
GO

-- B. KE HOACH, CHAM CONG VA PHU TROI
-- CaLamViec: bang danh muc ky thuat cho UC08 (khong tinh la Class thu 16).
IF OBJECT_ID(N'dbo.CaLamViec',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CaLamViec (
        MaCa INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_CaLamViec PRIMARY KEY,
        TenCa NVARCHAR(80) NOT NULL CONSTRAINT UQ_CaLamViec_Ten UNIQUE,
        GioBatDau TIME(0) NOT NULL,
        GioKetThuc TIME(0) NOT NULL,
        CONSTRAINT CK_CaLamViec_Gio CHECK(GioKetThuc > GioBatDau)
    );
END;
GO
IF OBJECT_ID(N'dbo.KeHoachPhanCong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.KeHoachPhanCong (
        MaKeHoach INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_KeHoachPhanCong PRIMARY KEY,
        MaPhongBan INT NOT NULL,
        TuanBatDau DATE NOT NULL,
        NgayLap DATE NOT NULL,
        NoiDungPhanCong NVARCHAR(500) NULL,
        CONSTRAINT FK_KH_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES dbo.PhongBan(MaPhongBan),
        CONSTRAINT UQ_KH_PhongBan_Tuan UNIQUE(MaPhongBan,TuanBatDau)
    );
END;
GO
-- Bang lien ket ky thuat: KeHoachPhanCong x NhanVien x NgayLam x CaLamViec.
IF OBJECT_ID(N'dbo.ChiTietPhanCong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ChiTietPhanCong (
        MaKeHoach INT NOT NULL,
        MaNV INT NOT NULL,
        NgayLam DATE NOT NULL,
        MaCa INT NOT NULL,
        GhiChu NVARCHAR(200) NULL,
        CONSTRAINT PK_ChiTietPhanCong PRIMARY KEY(MaKeHoach,MaNV,NgayLam,MaCa),
        CONSTRAINT FK_CTPC_KeHoach FOREIGN KEY(MaKeHoach) REFERENCES dbo.KeHoachPhanCong(MaKeHoach),
        CONSTRAINT FK_CTPC_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT FK_CTPC_Ca FOREIGN KEY(MaCa) REFERENCES dbo.CaLamViec(MaCa)
    );
END;
GO
IF OBJECT_ID(N'dbo.BangChamCong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BangChamCong (
        MaBangCong INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_BangChamCong PRIMARY KEY,
        MaNV INT NOT NULL,
        Thang TINYINT NOT NULL,
        Nam SMALLINT NOT NULL,
        SoGioThucTe DECIMAL(8,2) NOT NULL,
        NgayTongHop DATE NOT NULL,
        CONSTRAINT FK_BCC_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT UQ_BCC_NV_ThangNam UNIQUE(MaNV,Thang,Nam),
        CONSTRAINT CK_BCC_Thang CHECK(Thang BETWEEN 1 AND 12),
        CONSTRAINT CK_BCC_Gio CHECK(SoGioThucTe >= 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.PhieuPhuTroi',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PhieuPhuTroi (
        SoPhieuPT INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PhieuPhuTroi PRIMARY KEY,
        NgayPhuTroi DATE NOT NULL,
        SoGioPhuTroi DECIMAL(6,2) NOT NULL,
        HinhThucPhuTroi VARCHAR(15) NOT NULL,
        HeSoPhuTroi DECIMAL(3,1) NOT NULL CONSTRAINT DF_PhieuPT_HeSo DEFAULT 1.5,
        CONSTRAINT CK_PhieuPT_Gio CHECK(SoGioPhuTroi > 0),
        CONSTRAINT CK_PhieuPT_HinhThuc CHECK(HinhThucPhuTroi IN ('TangCa','NgayLe','NgayNghi')),
        CONSTRAINT CK_PhieuPT_HeSo CHECK(HeSoPhuTroi = 1.5)
    );
END;
GO
IF OBJECT_ID(N'dbo.ChiTietPhuTroi',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ChiTietPhuTroi (
        SoPhieuPT INT NOT NULL,
        MaNV INT NOT NULL,
        SoGioThamGia DECIMAL(6,2) NOT NULL,
        CONSTRAINT PK_ChiTietPhuTroi PRIMARY KEY(SoPhieuPT,MaNV),
        CONSTRAINT FK_CTPT_Phieu FOREIGN KEY(SoPhieuPT) REFERENCES dbo.PhieuPhuTroi(SoPhieuPT),
        CONSTRAINT FK_CTPT_NV FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT CK_CTPT_Gio CHECK(SoGioThamGia > 0)
    );
END;
GO

-- C. KHEN THUONG, KY LUAT, THANH TOAN
IF OBJECT_ID(N'dbo.QuyetDinhKhenThuong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuyetDinhKhenThuong (
        SoQDKT INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QDKhenThuong PRIMARY KEY,
        MaNV INT NULL,
        MaPhongBan INT NULL,
        NgayKy DATE NULL,
        NoiDung NVARCHAR(500) NOT NULL,
        SoTienThuong DECIMAL(18,2) NOT NULL,
        TrangThaiKy VARCHAR(12) NOT NULL CONSTRAINT DF_QDKT_TrangThai DEFAULT 'ChoKy',
        CONSTRAINT FK_QDKT_NV FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT FK_QDKT_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES dbo.PhongBan(MaPhongBan),
        CONSTRAINT CK_QDKT_DoiTuong CHECK (
            (MaNV IS NOT NULL AND MaPhongBan IS NULL) OR
            (MaNV IS NULL AND MaPhongBan IS NOT NULL)
        ),
        CONSTRAINT CK_QDKT_Tien CHECK(SoTienThuong >= 0),
        CONSTRAINT CK_QDKT_TrangThai CHECK(TrangThaiKy IN ('ChoKy','DaKy')),
        CONSTRAINT CK_QDKT_NgayKy CHECK (
            (TrangThaiKy='ChoKy' AND NgayKy IS NULL) OR
            (TrangThaiKy='DaKy' AND NgayKy IS NOT NULL)
        )
    );
END;
GO
IF OBJECT_ID(N'dbo.PhieuChiKhenThuong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PhieuChiKhenThuong (
        SoPhieuChi INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PhieuChiKT PRIMARY KEY,
        SoQDKT INT NOT NULL,
        NgayChi DATE NOT NULL,
        SoTien DECIMAL(18,2) NOT NULL,
        CONSTRAINT UQ_PhieuChiKT_QD UNIQUE(SoQDKT),
        CONSTRAINT FK_PhieuChiKT_QD FOREIGN KEY(SoQDKT) REFERENCES dbo.QuyetDinhKhenThuong(SoQDKT),
        CONSTRAINT CK_PhieuChiKT_Tien CHECK(SoTien > 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.QuyetDinhKyLuat',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.QuyetDinhKyLuat (
        SoQDKL INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_QDKyLuat PRIMARY KEY,
        MaNV INT NULL,
        MaPhongBan INT NULL,
        NgayKy DATE NOT NULL,
        NoiDung NVARCHAR(500) NOT NULL,
        SoTienPhat DECIMAL(18,2) NOT NULL CONSTRAINT DF_QDKL_Tien DEFAULT 0,
        CONSTRAINT FK_QDKL_NV FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT FK_QDKL_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES dbo.PhongBan(MaPhongBan),
        CONSTRAINT CK_QDKL_DoiTuong CHECK (
            (MaNV IS NOT NULL AND MaPhongBan IS NULL) OR
            (MaNV IS NULL AND MaPhongBan IS NOT NULL)
        ),
        CONSTRAINT CK_QDKL_Tien CHECK(SoTienPhat >= 0)
    );
END;
GO
IF OBJECT_ID(N'dbo.PhieuThuNopPhat',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PhieuThuNopPhat (
        SoPhieuThu INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_PhieuThu PRIMARY KEY,
        SoQDKL INT NOT NULL,
        NgayThu DATE NOT NULL,
        SoTien DECIMAL(18,2) NOT NULL,
        HinhThucThu VARCHAR(20) NOT NULL,
        CONSTRAINT UQ_PhieuThu_QDKL UNIQUE(SoQDKL),
        CONSTRAINT FK_PhieuThu_QDKL FOREIGN KEY(SoQDKL) REFERENCES dbo.QuyetDinhKyLuat(SoQDKL),
        CONSTRAINT CK_PhieuThu_Tien CHECK(SoTien > 0),
        CONSTRAINT CK_PhieuThu_HinhThuc CHECK(HinhThucThu IN ('ThuTrucTiep','TruLuong'))
    );
END;
GO
IF OBJECT_ID(N'dbo.BangLuong',N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BangLuong (
        MaBangLuong INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_BangLuong PRIMARY KEY,
        MaNV INT NOT NULL,
        Thang TINYINT NOT NULL,
        Nam SMALLINT NOT NULL,
        LuongTheoCong DECIMAL(18,2) NOT NULL,
        PhuCap DECIMAL(18,2) NOT NULL CONSTRAINT DF_BangLuong_PhuCap DEFAULT 0,
        TienPhuTroi DECIMAL(18,2) NOT NULL CONSTRAINT DF_BangLuong_PhuTroi DEFAULT 0,
        TienThuong DECIMAL(18,2) NOT NULL CONSTRAINT DF_BangLuong_Thuong DEFAULT 0,
        TienPhat DECIMAL(18,2) NOT NULL CONSTRAINT DF_BangLuong_Phat DEFAULT 0,
        TruBaoHiem DECIMAL(18,2) NOT NULL CONSTRAINT DF_BangLuong_BaoHiem DEFAULT 0,
        ThucLinh AS CAST(LuongTheoCong + PhuCap + TienPhuTroi + TienThuong - TienPhat - TruBaoHiem AS DECIMAL(18,2)) PERSISTED,
        CONSTRAINT FK_BangLuong_NV FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
        CONSTRAINT UQ_BangLuong_NV_ThangNam UNIQUE(MaNV,Thang,Nam),
        CONSTRAINT CK_BangLuong_Thang CHECK(Thang BETWEEN 1 AND 12),
        CONSTRAINT CK_BangLuong_SoTien CHECK(
             LuongTheoCong >= 0 AND PhuCap >= 0 AND TienPhuTroi >= 0 AND
             TienThuong >= 0 AND TienPhat >= 0 AND TruBaoHiem >= 0)
    );
END;
GO

-- Chi cho phep lap phieu chi khi quyet dinh da ky va so tien khong vuot muc thuong.
CREATE OR ALTER TRIGGER dbo.TR_PhieuChiKT_KiemTra
ON dbo.PhieuChiKhenThuong AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 FROM inserted AS i
        JOIN dbo.QuyetDinhKhenThuong AS q ON q.SoQDKT=i.SoQDKT
        WHERE q.TrangThaiKy<>'DaKy' OR i.SoTien>q.SoTienThuong OR i.NgayChi<q.NgayKy
    )
        THROW 51001, N'Quyet dinh chua ky, ngay chi khong hop le hoac tien chi vuot quyet dinh.', 1;
END;
GO

-- Chi cho phep lap phieu thu voi tien <= muc phat tren QD.
CREATE OR ALTER TRIGGER dbo.TR_PhieuThu_KiemTra
ON dbo.PhieuThuNopPhat AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1 FROM inserted AS i
        JOIN dbo.QuyetDinhKyLuat AS q ON q.SoQDKL=i.SoQDKL
        WHERE i.SoTien>q.SoTienPhat OR i.NgayThu<q.NgayKy
    )
        THROW 51002, N'Ngay thu khong hop le hoac so tien vuot muc phat.', 1;
END;
GO

PRINT N'Da kiem tra va tao cac bang QuanLyNhanSu (neu chua ton tai).';
GO
/*
 BAI 7 - DU LIEU MINH HOA DE THU NGHIEM (KHONG PHAI DU LIEU THAT)
 Chay SAU 01_TaoCSDL.sql. Tat ca ma ID duoc gan ro rang de de doi chieu FK.
 Chi them du lieu neu database chua co PhongBan / NhanVien.
 Ngay, luong, BHYT/BHXH, muc thuong/phat la GIA DINH KIEM THU.
 Gio chuan tinh luong thang 09/2026 = 176 gio la GIA DINH DEMO.
 Khong coi cac muc bao hiem ben duoi la ty le/muc dong phap dinh.
*/
USE QuanLyNhanSu;
GO
SET NOCOUNT ON;
SET XACT_ABORT ON;

IF EXISTS (SELECT 1 FROM dbo.PhongBan) OR EXISTS (SELECT 1 FROM dbo.NhanVien)
BEGIN
    PRINT N'Da co du lieu nhan su. Bo qua INSERT mau de khong ghi de ho so hien co.';
END
ELSE
BEGIN
  BEGIN TRY
    BEGIN TRANSACTION;

    -- 01. PHONG BAN (3)
    SET IDENTITY_INSERT dbo.PhongBan ON;
    INSERT dbo.PhongBan(MaPhongBan,TenPhongBan,LoaiDonVi) VALUES
      (1,N'Phòng Hành chính - Nhân sự',N'Phòng ban'),
      (2,N'Phân xưởng Sản xuất',N'Phân xưởng'),
      (3,N'Phòng Kỹ thuật',N'Phòng ban');
    SET IDENTITY_INSERT dbo.PhongBan OFF;

    -- 02. NHAN VIEN (4 chinh thuc, 1 dang thu viec)
    SET IDENTITY_INSERT dbo.NhanVien ON;
    INSERT dbo.NhanVien(MaNV,HoTen,NgaySinh,DiaChi,MaPhongBan,TrangThai) VALUES
      (1,N'Nguyễn Minh An','1995-06-12',N'TP. Hồ Chí Minh',1,'ChinhThuc'),
      (2,N'Trần Thu Hà','1997-04-21',N'TP. Hồ Chí Minh',2,'ChinhThuc'),
      (3,N'Lê Quốc Bảo','1996-10-03',N'Đồng Nai',3,'ChinhThuc'),
      (4,N'Phạm Ngọc Lan','1998-08-15',N'TP. Hồ Chí Minh',1,'ChinhThuc'),
      (5,N'Võ Thanh Tùng','2001-11-09',N'Bình Dương',2,'ThuViec');
    SET IDENTITY_INSERT dbo.NhanVien OFF;

    -- 03. QUYET DINH TUYEN DUNG THU VIEC (5)
    SET IDENTITY_INSERT dbo.QuyetDinhTuyenDung ON;
    INSERT dbo.QuyetDinhTuyenDung(SoQDTD,MaNV,MaPhongBan,NgayKy,BatDauThuViec,KetThucThuViec,LuongThuViec,DieuKhoan) VALUES
      (1,1,1,'2025-11-28','2025-12-01','2026-01-31',8500000,N'Thử việc tại Phòng Hành chính - Nhân sự; thực hiện nhiệm vụ theo phân công.'),
      (2,2,2,'2026-01-28','2026-02-01','2026-03-31',7000000,N'Thử việc tại Phân xưởng Sản xuất; tuân thủ quy trình làm việc.'),
      (3,3,3,'2025-12-29','2026-01-01','2026-02-28',8000000,N'Thử việc tại Phòng Kỹ thuật; thực hiện nhiệm vụ theo phân công.'),
      (4,4,1,'2026-02-25','2026-03-01','2026-04-30',6500000,N'Thử việc tại Phòng Hành chính - Nhân sự.'),
      (5,5,2,'2026-09-27','2026-10-01','2026-11-30',6000000,N'Thử việc tại Phân xưởng Sản xuất.');
    SET IDENTITY_INSERT dbo.QuyetDinhTuyenDung OFF;

    -- 04. HOP DONG (3 dai han, 1 ngan han; NV5 chua co hop dong)
    SET IDENTITY_INSERT dbo.HopDongLaoDong ON;
    INSERT dbo.HopDongLaoDong(SoHopDong,MaNV,LoaiHopDong,NgayKy,NgayBatDau,NgayKetThuc,NoiDung) VALUES
      (1,1,'DaiHan','2026-01-31','2026-02-01',NULL,N'Hợp đồng dài hạn; công việc hành chính nhân sự.'),
      (2,2,'NganHan','2026-03-31','2026-04-01','2027-03-31',N'Hợp đồng ngắn hạn; công việc sản xuất.'),
      (3,3,'DaiHan','2026-02-28','2026-03-01',NULL,N'Hợp đồng dài hạn; công việc kỹ thuật.'),
      (4,4,'DaiHan','2026-04-30','2026-05-01',NULL,N'Hợp đồng dài hạn; công việc hành chính.');
    SET IDENTITY_INSERT dbo.HopDongLaoDong OFF;

    -- 05. QUYET DINH CHUC VU (4)
    SET IDENTITY_INSERT dbo.QuyetDinhChucVu ON;
    INSERT dbo.QuyetDinhChucVu(SoQDChucVu,MaNV,ChucVu,NgayKy,NgayHieuLuc,PhuCapChucVu) VALUES
      (1,1,N'Chuyên viên nhân sự','2026-01-31','2026-02-01',500000),
      (2,2,N'Nhân viên sản xuất','2026-03-31','2026-04-01',0),
      (3,3,N'Kỹ thuật viên','2026-02-28','2026-03-01',200000),
      (4,4,N'Nhân viên hành chính','2026-04-30','2026-05-01',0);
    SET IDENTITY_INSERT dbo.QuyetDinhChucVu OFF;

    -- 06. QUYET DINH LUONG (4)
    SET IDENTITY_INSERT dbo.QuyetDinhLuong ON;
    INSERT dbo.QuyetDinhLuong(SoQDLuong,MaNV,NgayKy,NgayHieuLuc,LuongCoBan,PhuCapLuong,PhuCapDocHai) VALUES
      (1,1,'2026-06-25','2026-07-01',12000000,300000,0),
      (2,2,'2026-06-25','2026-07-01',10000000,300000,0),
      (3,3,'2026-06-25','2026-07-01',11000000,200000,400000),
      (4,4,'2026-06-25','2026-07-01', 9000000,0,0);
    SET IDENTITY_INSERT dbo.QuyetDinhLuong OFF;

    -- 07. BAO HIEM (chi nhan vien hop dong DaiHan)
    SET IDENTITY_INSERT dbo.HoSoBaoHiem ON;
    INSERT dbo.HoSoBaoHiem(MaHoSoBH,MaNV,MaSoBHYT,MaSoBHXH,MucDongBHYT,MucDongBHXH) VALUES
      (1,1,'BHYT-DEMO-0001','BHXH-DEMO-0001',150000,500000),
      (2,3,'BHYT-DEMO-0003','BHXH-DEMO-0003',140000,480000),
      (3,4,'BHYT-DEMO-0004','BHXH-DEMO-0004',120000,430000);
    SET IDENTITY_INSERT dbo.HoSoBaoHiem OFF;

    -- 08. DANH MUC CA LAM VIEC
    SET IDENTITY_INSERT dbo.CaLamViec ON;
    INSERT dbo.CaLamViec(MaCa,TenCa,GioBatDau,GioKetThuc) VALUES
      (1,N'Ca sáng','08:00:00','12:00:00'),
      (2,N'Ca chiều','13:00:00','17:00:00'),
      (3,N'Ca hành chính','08:00:00','17:00:00');
    SET IDENTITY_INSERT dbo.CaLamViec OFF;

    -- 09. KE HOACH PHAN CONG TUAN (3 phong ban)
    SET IDENTITY_INSERT dbo.KeHoachPhanCong ON;
    INSERT dbo.KeHoachPhanCong(MaKeHoach,MaPhongBan,TuanBatDau,NgayLap,NoiDungPhanCong) VALUES
      (1,1,'2026-09-14','2026-09-10',N'Phân ca hành chính tuần 14/09/2026.'),
      (2,2,'2026-09-14','2026-09-10',N'Phân ca sản xuất tuần 14/09/2026.'),
      (3,3,'2026-09-14','2026-09-10',N'Phân ca kỹ thuật tuần 14/09/2026.');
    SET IDENTITY_INSERT dbo.KeHoachPhanCong OFF;

    -- 10. CHI TIET PHAN CONG: lien ket ke hoach - nhan vien - ngay - ca
    INSERT dbo.ChiTietPhanCong(MaKeHoach,MaNV,NgayLam,MaCa,GhiChu) VALUES
      (1,1,'2026-09-14',3,NULL),
      (1,4,'2026-09-14',3,NULL),
      (1,1,'2026-09-15',3,NULL),
      (1,4,'2026-09-15',3,NULL),
      (2,2,'2026-09-14',1,NULL),
      (2,2,'2026-09-14',2,NULL),
      (3,3,'2026-09-14',3,NULL);

    -- 11. BANG CHAM CONG THANG 09/2026 (4 nhan vien chinh thuc)
    SET IDENTITY_INSERT dbo.BangChamCong ON;
    INSERT dbo.BangChamCong(MaBangCong,MaNV,Thang,Nam,SoGioThucTe,NgayTongHop) VALUES
      (1,1,9,2026,176,'2026-09-30'),
      (2,2,9,2026,168,'2026-09-30'),
      (3,3,9,2026,176,'2026-09-30'),
      (4,4,9,2026,160,'2026-09-30');
    SET IDENTITY_INSERT dbo.BangChamCong OFF;

    -- 12. PHIEU PHU TROI (he so 1.5 theo de)
    SET IDENTITY_INSERT dbo.PhieuPhuTroi ON;
    INSERT dbo.PhieuPhuTroi(SoPhieuPT,NgayPhuTroi,SoGioPhuTroi,HinhThucPhuTroi,HeSoPhuTroi) VALUES
      (1,'2026-09-12',4,'TangCa',1.5),
      (2,'2026-09-20',3,'NgayNghi',1.5);
    SET IDENTITY_INSERT dbo.PhieuPhuTroi OFF;

    -- 13. NHAN VIEN THAM GIA PHU TROI
    INSERT dbo.ChiTietPhuTroi(SoPhieuPT,MaNV,SoGioThamGia) VALUES
      (1,1,4),
      (1,3,2),
      (2,3,3);

    -- 14. QUYET DINH KHEN THUONG: ca nhan / tap the / cho ky
    SET IDENTITY_INSERT dbo.QuyetDinhKhenThuong ON;
    INSERT dbo.QuyetDinhKhenThuong(SoQDKT,MaNV,MaPhongBan,NgayKy,NoiDung,SoTienThuong,TrangThaiKy) VALUES
      (1,1,NULL,'2026-09-25',N'Khen thưởng thành tích cá nhân tháng 9',300000,'DaKy'),
      (2,NULL,2,'2026-09-26',N'Khen thưởng tập thể phân xưởng sản xuất',2500000,'DaKy'),
      (3,4,NULL,NULL,N'Đề xuất khen thưởng chuyên cần',200000,'ChoKy');
    SET IDENTITY_INSERT dbo.QuyetDinhKhenThuong OFF;

    -- 15. PHIEU CHI THEO QUYET DINH DA KY (khong cong lai vao luong)
    SET IDENTITY_INSERT dbo.PhieuChiKhenThuong ON;
    INSERT dbo.PhieuChiKhenThuong(SoPhieuChi,SoQDKT,NgayChi,SoTien) VALUES
      (1,1,'2026-09-27',300000),
      (2,2,'2026-09-28',2500000);
    SET IDENTITY_INSERT dbo.PhieuChiKhenThuong OFF;

    -- 16. QUYET DINH KY LUAT: NV2 thu truc tiep; NV3 tru vao luong
    SET IDENTITY_INSERT dbo.QuyetDinhKyLuat ON;
    INSERT dbo.QuyetDinhKyLuat(SoQDKL,MaNV,MaPhongBan,NgayKy,NoiDung,SoTienPhat) VALUES
      (1,2,NULL,'2026-09-24',N'Vi phạm quy định làm việc - nộp phạt trực tiếp',150000),
      (2,3,NULL,'2026-09-24',N'Vi phạm nội quy - khấu trừ vào lương tháng 9',200000);
    SET IDENTITY_INSERT dbo.QuyetDinhKyLuat OFF;

    -- 17. PHIEU THU NOP PHAT (NV2 thu tien; NV3 KHONG thu lai)
    SET IDENTITY_INSERT dbo.PhieuThuNopPhat ON;
    INSERT dbo.PhieuThuNopPhat(SoPhieuThu,SoQDKL,NgayThu,SoTien,HinhThucThu) VALUES
      (1,1,'2026-09-26',150000,'ThuTrucTiep');
    SET IDENTITY_INSERT dbo.PhieuThuNopPhat OFF;

    -- 18. BANG LUONG THANG 09/2026 (4 nhan vien)
    -- Gia dinh demo: 176 gio chuan; don gia gio thuong = luong co ban / 176.
    -- Luong theo cong = luong co ban * gio thuc te / 176.
    -- Phu troi = tong(gio phu troi * 1.5) * don gia gio thuong.
    -- Tien thuong = 0 vi hai quyet dinh DaKy da duoc chi qua PhieuChiKhenThuong.
    -- Khoan phat cua NV2 da thu qua phieu: KHONG tru luong NV2 nua.
    -- Khoan phat cua NV3 chua thu: tru trong luong NV3.
    DECLARE @GioChuanThang DECIMAL(10,2) = 176.00;

    SET IDENTITY_INSERT dbo.BangLuong ON;
    ;WITH TinhLuong AS (
        SELECT cc.MaNV, cc.Thang, cc.Nam,
               CAST(ROUND(ql.LuongCoBan * cc.SoGioThucTe / @GioChuanThang, 2) AS DECIMAL(18,2)) AS LuongTheoCong,
               CAST(ql.PhuCapLuong + ql.PhuCapDocHai + ISNULL(cv.PhuCapChucVu,0) AS DECIMAL(18,2)) AS PhuCap,
               CAST(ROUND(ql.LuongCoBan * ISNULL(pt.GioQuyDoi,0) / @GioChuanThang,2) AS DECIMAL(18,2)) AS TienPhuTroi,
               CAST(0 AS DECIMAL(18,2)) AS TienThuong,
               CAST(ISNULL(kl.TienPhat,0) AS DECIMAL(18,2)) AS TienPhat,
               CAST(ISNULL(bh.MucDongBHYT,0) + ISNULL(bh.MucDongBHXH,0) AS DECIMAL(18,2)) AS TruBaoHiem
        FROM dbo.BangChamCong AS cc
        CROSS APPLY (
            SELECT TOP (1) d.LuongCoBan, d.PhuCapLuong, d.PhuCapDocHai
            FROM dbo.QuyetDinhLuong AS d
            WHERE d.MaNV=cc.MaNV AND d.NgayHieuLuc <= EOMONTH(DATEFROMPARTS(cc.Nam,cc.Thang,1))
            ORDER BY d.NgayHieuLuc DESC, d.SoQDLuong DESC
        ) AS ql
        OUTER APPLY (
            SELECT TOP (1) q.PhuCapChucVu
            FROM dbo.QuyetDinhChucVu AS q
            WHERE q.MaNV=cc.MaNV AND q.NgayHieuLuc <= EOMONTH(DATEFROMPARTS(cc.Nam,cc.Thang,1))
            ORDER BY q.NgayHieuLuc DESC, q.SoQDChucVu DESC
        ) AS cv
        LEFT JOIN dbo.HoSoBaoHiem AS bh ON bh.MaNV=cc.MaNV
        OUTER APPLY (
            SELECT SUM(ct.SoGioThamGia * p.HeSoPhuTroi) AS GioQuyDoi
            FROM dbo.ChiTietPhuTroi AS ct
            JOIN dbo.PhieuPhuTroi AS p ON p.SoPhieuPT=ct.SoPhieuPT
            WHERE ct.MaNV=cc.MaNV AND MONTH(p.NgayPhuTroi)=cc.Thang AND YEAR(p.NgayPhuTroi)=cc.Nam
        ) AS pt
        OUTER APPLY (
            SELECT SUM(q.SoTienPhat) AS TienPhat
            FROM dbo.QuyetDinhKyLuat AS q
            WHERE q.MaNV=cc.MaNV AND MONTH(q.NgayKy)=cc.Thang AND YEAR(q.NgayKy)=cc.Nam
              AND NOT EXISTS (SELECT 1 FROM dbo.PhieuThuNopPhat x WHERE x.SoQDKL=q.SoQDKL)
        ) AS kl
        WHERE cc.Thang=9 AND cc.Nam=2026
    )
    INSERT dbo.BangLuong(MaBangLuong,MaNV,Thang,Nam,LuongTheoCong,PhuCap,TienPhuTroi,TienThuong,TienPhat,TruBaoHiem)
    SELECT ROW_NUMBER() OVER(ORDER BY MaNV), MaNV, Thang, Nam,
           LuongTheoCong,PhuCap,TienPhuTroi,TienThuong,TienPhat,TruBaoHiem
    FROM TinhLuong;
    SET IDENTITY_INSERT dbo.BangLuong OFF;

    COMMIT TRANSACTION;
    PRINT N'Da them bo du lieu minh hoa quan ly nhan su thang 09/2026.';
  END TRY
  BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    THROW;
  END CATCH;
END;
GO

-- CAC TRUY VAN KIEM TRA NHANH SAU KHI CHAY
PRINT N'1. Danh sach nhan vien va phong ban';
SELECT nv.MaNV, nv.HoTen, pb.TenPhongBan, nv.TrangThai
FROM dbo.NhanVien nv JOIN dbo.PhongBan pb ON pb.MaPhongBan=nv.MaPhongBan
ORDER BY nv.MaNV;

PRINT N'2. Tinh trang hop dong';
SELECT nv.MaNV, nv.HoTen, hd.SoHopDong, hd.LoaiHopDong,
       hd.NgayBatDau, hd.NgayKetThuc
FROM dbo.NhanVien nv
LEFT JOIN dbo.HopDongLaoDong hd ON hd.MaNV=nv.MaNV
ORDER BY nv.MaNV;

PRINT N'3. Phieu phu troi va nhan vien tham gia';
SELECT p.SoPhieuPT, p.NgayPhuTroi, nv.HoTen,
       ct.SoGioThamGia, p.HeSoPhuTroi,
       ct.SoGioThamGia * p.HeSoPhuTroi AS GioQuyDoi
FROM dbo.PhieuPhuTroi p
JOIN dbo.ChiTietPhuTroi ct ON ct.SoPhieuPT=p.SoPhieuPT
JOIN dbo.NhanVien nv ON nv.MaNV=ct.MaNV
ORDER BY p.SoPhieuPT,nv.MaNV;

PRINT N'4. Bang luong thang 09/2026';
SELECT bl.Thang, bl.Nam, nv.MaNV, nv.HoTen,
       bl.LuongTheoCong, bl.PhuCap, bl.TienPhuTroi, bl.TienThuong,
       bl.TienPhat, bl.TruBaoHiem, bl.ThucLinh
FROM dbo.BangLuong bl
JOIN dbo.NhanVien nv ON nv.MaNV=bl.MaNV
WHERE bl.Thang=9 AND bl.Nam=2026
ORDER BY nv.MaNV;

PRINT N'5. Quyet dinh khen thuong: ca nhan / tap the / cho ky';
SELECT q.SoQDKT, q.NoiDung, nv.HoTen AS NhanVien, pb.TenPhongBan AS TapThe,
       q.SoTienThuong, q.TrangThaiKy, pc.SoPhieuChi
FROM dbo.QuyetDinhKhenThuong q
LEFT JOIN dbo.NhanVien nv ON nv.MaNV=q.MaNV
LEFT JOIN dbo.PhongBan pb ON pb.MaPhongBan=q.MaPhongBan
LEFT JOIN dbo.PhieuChiKhenThuong pc ON pc.SoQDKT=q.SoQDKT
ORDER BY q.SoQDKT;
GO
