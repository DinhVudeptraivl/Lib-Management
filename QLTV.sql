-- Note: you have to drop QLTV database (if you had) first before running entire script
--DROP DATABASE QLTV
CREATE DATABASE QLTV
go
USE QLTV

go
CREATE TABLE NHOMNGUOIDUNG
(
	id int IDENTITY(1,1) primary key,
	MaNhomNguoiDung AS CAST('NND' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	TenNhomNguoiDung nvarchar(max) NOT NULL
);

go
CREATE TABLE CHUCNANG
(
     id int  primary key IDENTITY(1,1),
	 MaChucNang AS CAST('CN' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
     TenChucNang NVARCHAR(MAX) NOT NULL,
     TenManHinh NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE PHANQUYEN
(
    idNhomNguoiDung INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG on delete cascade,
    idChucNang INT FOREIGN KEY REFERENCES CHUCNANG on delete cascade,
    PRIMARY KEY (idNhomNguoiDung, idChucNang)
)

go
CREATE TABLE NGUOIDUNG
(
	id INT IDENTITY PRIMARY KEY,
	MaNguoiDung  AS CAST('ND'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenNguoiDung NVARCHAR(MAX) NOT NULL,
    NgaySinh datetime,
    ChucVu NVARCHAR(MAX),
    TenDangNhap VARCHAR(256) UNIQUE NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
    idNhomNguoiDung INT REFERENCES NHOMNGUOIDUNG on delete cascade NOT NULL
)

go
CREATE TABLE THELOAI
(
	id int IDENTITY(1,1)  primary key,
	MaTheLoai As Cast('TL' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,  
	TenTheLoai NVARCHAR(MAX) NOT NULL
)


go

CREATE TABLE TUASACH
(
	id INT IDENTITY  PRIMARY KEY,
	MaTuaSach  AS cast('TS'+ right('0000' + CAST(ID AS VARCHAR(10)), 4) as char(6)) PERSISTED,
	TenTuaSach NVARCHAR(MAX) NOT NULL,
	idTheLoai int references THELOAI NOT NULL,
	DaAn int DEFAULT 0
)

go

CREATE TABLE TACGIA
(
	id INT IDENTITY PRIMARY KEY,
	MATACGIA  AS CAST('TG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenTacGia NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE CT_TACGIA
(
	idTacGia int references TACGIA  on delete cascade,
	idTuaSach int references TUASACH on delete cascade,
	primary key (idTacGia, idTuaSach)
)

go

CREATE TABLE LOAIDOCGIA
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaLoaiDocGia  AS CAST('LDG'+ RIGHT('000' + CAST(ID AS VARCHAR(10)), 3) AS CHAR(6))PERSISTED,
	TenLoaiDocGia NVARCHAR(MAX) NOT NULL
)

go
CREATE TABLE DOCGIA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaDocGia  AS CAST('DG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenDocGia NVARCHAR(MAX) NOT NULL,
	NgaySinh datetime NOT NULL, 
	DiaChi NVARCHAR(MAX),
	Email VARCHAR(MAX),
	NgayLapThe Datetime NOT NULL, 
	NgayHetHan Datetime NOT NULL, 
	idLoaiDocGia INT references LOAIDOCGIA NOT NULL, 
	TongNoHienTai int NOT NULL DEFAULT 0,
	idNguoiDung INT REFERENCES NGUOIDUNG UNIQUE NOT NULL
)


go
CREATE TABLE SACH
(
	id int IDENTITY(1,1) primary key,
	MaSach AS CAST('S'+ RIGHT('00000' + CAST(id AS VARCHAR(10)), 5) AS CHAR(6)) PERSISTED,
	idTuaSach int references TUASACH NOT NULL, 
	SoLuong int NOT NULL, 
	SoLuongConLai int NOT NULL, 
	DonGia int NOT NULL, 
	NamXB int NOT NULL, 
	NhaXB NVARCHAR(MAX) NOT NULL,
	DaAn int NOT NULL DEFAULT 0
)

go
CREATE TABLE PHIEUNHAPSACH
(
	SoPhieuNhap int IDENTITY(1,1) primary key,
	TongTien int NOT NULL DEFAULT 0, 
	NgayNhap Datetime NOT NULL
)
go
CREATE TABLE CT_PHIEUNHAP
(
	SoPhieuNhap int references PHIEUNHAPSACH(SoPhieuNhap),
	idSach int references SACH,
	DonGia int NOT NULL, 
	ThanhTien int NOT NULL, 
	SoLuongNhap int NOT NULL, 
	primary key (SoPhieuNhap, idSach)
)
go 
create table CUONSACH
(
	id int IDENTITY(1,1) primary key,
	MaCuonSach AS CAST('CS'+ RIGHT('0000' + CAST(id AS VARCHAR(10)), 4) AS CHAR(6)) PERSISTED,
	idSach int references SACH NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1,
	DaAn int NOT NULL DEFAULT 0
)
go
create table PHIEUMUONTRA
(
	SoPhieuMuonTra int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA NOT NULL,
	idCuonSach int references CUONSACH NOT NULL,
	NgayMuon Datetime NOT NULL, 
	NgayTra Datetime, 
	HanTra Datetime NOT NULL,
	SoTienPhat int DEFAULT 0
)
go
create table PHIEUTHU
(
	SoPhieuThu int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA NOT NULL,
	SoTienThu int NOT NULL DEFAULT 0,
	NgayLap datetime NOT NULL
)
go
create table BCLUOTMUONTHEOTHELOAI
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Thang int NOT NULL, 
	Nam int NOT NULL, 
	MaBaoCao AS CAST('BCLM' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
	TongSoLuotMuon int NOT NULL DEFAULT 0
)
go
create table CT_BCLUOTMUONTHEOTHELOAI
(
	idBaoCao INT references BCLUOTMUONTHEOTHELOAI,
	idTheLoai int references THELOAI,
	SoLuotMuon int NOT NULL DEFAULT 0, 
	TiLe numeric(4,2) DEFAULT 0,
	primary key (idBaoCao, idTheLoai)
)
go
create table BCSACHTRATRE
(
	Ngay datetime not null,
	idCuonSach int references CUONSACH on delete cascade,
	NgayMuon datetime NOT NULL,
	SoNgayTre int NOT NULL DEFAULT 0
	primary key(Ngay, idCuonSach)
)
go

create table THAMSO
(
	id int identity(1,1) primary key,
	TuoiToiThieu int NOT NULL, 
	TuoiToiDa int NOT NULL, 
	ThoiHanThe int NOT NULL, 
	KhoangCachXuatBan int NOT NULL , 
	SoSachMuonToiDa int NOT NULL, 
	SoNgayMuonToiDa int NOT NULL, 
	DonGiaPhat int NOT NULL,
	AD_QDKTTienThu int NOT NULL
)


-- INSERT DATA
go
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Quản Lý')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Thủ Thư')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Độc Giả')

go

insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLDG', N'Quản Lý Độc Giả')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLS', N'Quản Lý Sách')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPM', N'Quản Lý Phiếu Mượn Trả')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPT', N'Quản Lý Phiếu Thu')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('BCTK', N'Báo Cáo Thống Kê')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLND', N'Quản Lý Người Dùng')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('TDQD', N'Thay Đổi Quy Định')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('DG', N'Là Độc Giả')

go
INSERT INTO PHANQUYEN VALUES (1, 1)
INSERT INTO PHANQUYEN VALUES (1, 2)
INSERT INTO PHANQUYEN VALUES (1, 3)
INSERT INTO PHANQUYEN VALUES (1, 4)
INSERT INTO PHANQUYEN VALUES (1, 5)
INSERT INTO PHANQUYEN VALUES (1, 6)
INSERT INTO PHANQUYEN VALUES (1, 7)

INSERT INTO PHANQUYEN VALUES (2, 1)
INSERT INTO PHANQUYEN VALUES (2, 2)
INSERT INTO PHANQUYEN VALUES (2, 3)
INSERT INTO PHANQUYEN VALUES (2, 4)
INSERT INTO PHANQUYEN VALUES (2, 5)

INSERT INTO PHANQUYEN VALUES (3, 8)

go

set dateformat dmy
go
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Admin Hệ Thống', 'admin', '123', 1)
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Thủ Thư', 'lib', '123', 2)

INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Phan Cả Phát', '11/06/2004', 'docgia1', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trần Lê Anh Khoa', '08/01/2004', 'docgia2', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Phú Hào', '24/02/2004', 'docgia3', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Đào Đại Chí', '03/01/2004', 'docgia4', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Lê Thị Thương', '22/06/2004', 'docgia5', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trần Lê Yến Linh', '25/08/2004', 'docgia6', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Lê Nguyễn Thảo Vân', '11/04/2004', 'docgia7', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Phước Thắng', '02/11/2004', 'docgia8', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Hồ Vũ An', '03/07/2004', 'docgia9', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Dương Uy Quan', '25/09/2004', 'docgia10', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Thành Trung', '05/12/2004', 'docgia11', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Lê Thanh Phong', '09/04/2004', 'docgia12', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Đoàn Lê Giang Nam', '05/09/2004', 'docgia13', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trịnh Kiến Tường', '30/07/2004', 'docgia14', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Khánh Tường', '18/08/2004', 'docgia15', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Minh Tú', '23/10/2004', 'docgia16', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trịnh Tuấn Tú', '05/05/2004', 'docgia17', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trần Võ Lâm Trường', '24/11/2004', 'docgia18', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Thành Vinh', '19/05/2004', 'docgia19', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Ngô Thành Trung', '03/01/2004', 'docgia20', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Ngô Nguyễn Nam Trung', '01/07/2004', 'docgia21', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Vũ Anh Tuấn', '24/12/2004', 'docgia22', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Hoàng Khanh', '14/05/2004', 'docgia23', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Trần Khương An', '12/05/2004', 'docgia24', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Nguyễn Ấn', '23/01/2004', 'docgia25', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Đỗ Chí Hiếu', '01/01/2004', 'docgia26', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Trịnh Lê Thanh Bình', '28/10/2004', 'docgia27', '123', 3)
INSERT INTO NGUOIDUNG(TenNguoiDung, NgaySinh, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES (N'Lê Dương Minh Thiên', '21/05/2004', 'docgia28', '123', 3)

go
insert into THELOAI values(N'Truyện')
insert into THELOAI values(N'Tiểu thuyết')
insert into THELOAI values(N'Giáo trình')
insert into THELOAI values(N'Tài liệu tham khảo')
insert into THELOAI values(N'Văn học')
insert into THELOAI values(N'Khác')

go
insert into TUASACH values (N'Cửu Âm Chân Kinh', 5, 0)
insert into TUASACH values (N'Tam Quốc Diễn Nghĩa', 5, 0)
insert into TUASACH values (N'Cơ sở dữ liệu nâng cao', 4, 0)
insert into TUASACH values (N'Thực hành Hệ điều hành', 3, 0)
insert into TUASACH values (N'Các kỹ thuật trong xử lý ngôn ngữ tự nhiên', 3, 0)
insert into TUASACH values (N'Các hệ cơ sở tri thức', 3, 0)
insert into TUASACH values (N'Các hệ suy diễn mờ', 3, 0)
insert into TUASACH values (N'Khai phá dữ liệu (Data Mining)', 4, 0)
insert into TUASACH values (N'Phân tích mạng xã hội và ứng dụng', 4, 0)
insert into TUASACH values (N'Hướng dẫn giải bài tập xác suất và thống kê toán học', 4, 0)
insert into TUASACH values (N'Xử lý ngôn ngữ tự nhiên', 3, 0)
insert into TUASACH values (N'Phân tích thiết kế thuật toán', 5, 0)
insert into TUASACH values (N'Ô Long Truyện', 1, 0)
insert into TUASACH values (N'Kháng Long Ngũ Hối', 5, 0)
insert into TUASACH values (N'Kiếm Doran', 5, 0)
insert into TUASACH values (N'Vô Cực Kiếm Pháp', 5, 0)
insert into TUASACH values (N'Không Gia Đình', 5, 0)
insert into TUASACH values (N'Như Ý Tiền Truyện',2,0)
insert into TUASACH values (N'Giáng Long Thập Bát Chưởng', 5, 0)

go
INSERT INTO TACGIA VALUES (N'Nguyễn Xuân Danh')
INSERT INTO TACGIA VALUES (N'Trương Quốc Tuấn')
INSERT INTO TACGIA VALUES (N'Fujiko F. Fujio')
INSERT INTO TACGIA VALUES (N'Phan Đình Duy')
INSERT INTO TACGIA VALUES (N'Nguyễn Tuấn Đăng')
INSERT INTO TACGIA VALUES (N'Đỗ Văn Nhơn')
INSERT INTO TACGIA VALUES (N'Chu Du')
INSERT INTO TACGIA VALUES (N'Đỗ Phúc')
INSERT INTO TACGIA VALUES (N'Tư Mã Ý')
INSERT INTO TACGIA VALUES (N'Nguyễn Tuấn Đăng')
INSERT INTO TACGIA VALUES (N'Happer Lee')
INSERT INTO TACGIA VALUES (N'Jonas Jonasson')
INSERT INTO TACGIA VALUES (N'Shinkai Makoto')
INSERT INTO TACGIA VALUES (N'Ernest Hemingway')
INSERT INTO TACGIA VALUES (N'Namiya')
INSERT INTO TACGIA VALUES (N'Hector Malot')
INSERT INTO TACGIA VALUES (N'J. D. Salinger')

go
INSERT INTO CT_TACGIA VALUES (1, 1)
INSERT INTO CT_TACGIA VALUES (2, 2)
INSERT INTO CT_TACGIA VALUES (3, 3)
INSERT INTO CT_TACGIA VALUES (4, 4)
INSERT INTO CT_TACGIA VALUES (5, 5)
INSERT INTO CT_TACGIA VALUES (6, 6)
INSERT INTO CT_TACGIA VALUES (7, 7)
INSERT INTO CT_TACGIA VALUES (8, 8)
INSERT INTO CT_TACGIA VALUES (8, 9)
INSERT INTO CT_TACGIA VALUES (9, 10)
INSERT INTO CT_TACGIA VALUES (10, 11)
INSERT INTO CT_TACGIA VALUES (11, 12)
INSERT INTO CT_TACGIA VALUES (12, 13)
INSERT INTO CT_TACGIA VALUES (13, 14)
INSERT INTO CT_TACGIA VALUES (14, 15)
INSERT INTO CT_TACGIA VALUES (15, 16)
INSERT INTO CT_TACGIA VALUES (16, 17)
INSERT INTO CT_TACGIA VALUES (17, 18)

go
INSERT INTO LOAIDOCGIA VALUES(N'Giảng viên')
INSERT INTO LOAIDOCGIA VALUES(N'Sinh viên')
INSERT INTO LOAIDOCGIA VALUES(N'Khác')

go
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Phan Cả Phát', '11/06/2004', '26/09/2023', '26/03/2024', 2, 3)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trần Lê Anh Khoa', '08/01/2004', '26/09/2023', '26/03/2024', 2, 4)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Phú Hào', '24/02/2004', '26/08/2023', '26/02/2024', 2, 5)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Đào Đại Chí', '03/01/2004', '26/08/2023', '26/02/2024', 2, 6)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Lê Thị Thương', '22/06/2004', '19/05/2023', '19/11/2024', 2, 7)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trần Lê Yến Linh', '25/08/2004', '26/09/2023', '26/03/2024', 2, 8)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'NGuyễn Thảo Vân', '11/04/2004', '26/09/2023', '26/03/2024', 2, 9)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Phước Thắng', '02/11/2004', '26/09/2023', '26/03/2024', 2, 10)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Hồ Vũ An', '03/07/2004', '26/08/2023', '26/02/2024', 2, 11)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Dương Uy Quan', '25/09/2004', '26/09/2023', '26/03/2024', 2, 12)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Thành Trung', '05/12/2004', '26/09/2023', '26/03/2024', 2, 13)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Lê Thanh Phong', '09/04/2004', '26/09/2023', '26/03/2024', 2, 14)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Đoàn Lê Giang Nam', '05/09/2004', '26/09/2023', '26/03/2024', 2, 15)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trịnh Kiến Tường', '30/07/2004', '19/05/2024', '19/11/2024', 2, 16)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Khánh Tường', '18/08/2004', '26/09/2023', '26/03/2024', 2, 17)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Minh Tú', '23/10/2004', '19/05/2024', '19/11/2024', 2, 18)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trịnh Tuấn Tú', '05/05/2004', '19/05/2021', '19/11/2024', 2, 19)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trần Võ Lâm Trường', '24/11/2004', '26/09/2023', '26/03/2024', 2, 20)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Thành Vinh', '19/05/2004', '19/05/2021', '19/11/2024', 2, 21)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Ngô Thành Trung', '03/01/2004', '26/08/2023', '26/02/2024', 2, 22)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Ngô Nguyễn Nam Trung', '01/07/2004', '26/08/2023', '26/02/2024', 2, 23)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Vũ Anh Tuấn', '24/12/2004', '26/09/2023', '26/03/2024', 2, 24)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Hoàng Khanh', '14/05/2004', '26/09/2023', '26/03/2024', 2, 25)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Trần Khương An', '12/05/2004', '26/09/2023', '26/03/2024', 2, 26)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Nguyễn Ấn', '23/01/2004', '26/08/2023', '26/02/2024', 2, 27)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Đỗ Chí Hiếu', '01/01/2004', '19/05/2021', '19/11/2024', 2, 28)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trịnh Lê Thanh Bình', '28/10/2004', '26/08/2023', '26/02/2024', 2, 29)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Lê Dương Minh Thiên', '21/05/2004', '26/09/2023', '26/03/2024', 2, 30)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Trương Phi', '03/11/2004', '26/09/2023', '26/03/2024', 2, 31)
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung) VALUES (N'Hong Hae In', '04/05/2004', '26/08/2023', '26/02/2024', 2, 32)
go
INSERT INTO THAMSO VALUES(18, 55, 6, 8, 5, 4, 1000, 1)
