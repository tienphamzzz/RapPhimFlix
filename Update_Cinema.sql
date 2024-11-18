use [QLCinema]
go
-- tạo bảng khách
create table tblKhach(
	MaKhach nvarchar(255) primary key,
	TenKhach nvarchar(255) not null,
)
go
-- thêm khoá ngoại cho bảng hoá đơn
alter table tblHoaDon
add MaKhach nvarchar(255) not null
go
alter table tblHoaDon
add constraint FK_tblHoaDon_tblKhach foreign Key(MaKhach)
references tblKhach (MaKhach)
go

-- tạo bảng giảm giá
CREATE TABLE tblGiamGia (
    MaGiamGia INT PRIMARY KEY IDENTITY(1,1),
    TenGiamGia NVARCHAR(255) NOT NULL,
    PhanTramGiamGia inT NULL,
    SoTienGiamGia decimal(18, 2) NULL,
    NgayBatDau datetime NOT NULL,
    NgayKetThuc datetime NOT NULL,
    DieuKienApDung nvarchar(255) NULL,
    MaPhim nvarchar(255),

    -- Tạo khóa ngoại liên kết MaPhim với MaPhim trong bảng tblPhims
    constraint FK_tblGiamGia_tblPhims foreign Key (MaPhim)
    references tblPhims (MaPhim)
);
