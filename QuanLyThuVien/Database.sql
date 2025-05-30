﻿Create database QLTV;

use qltv;

create table sach(
	ma_sach int identity(1,1) primary key,
	ten_sach nvarchar(50) not null,
	tac_gia nvarchar(50) not null,
	nxb nvarchar(50) not null,
	nam int check (nam > 1000 and nam < 2025),
	the_loai nvarchar(50) not null,
	so_luong_tong int not null,
	sl_con_lai int not null
);

Create table doc_gia(
	ma_doc_gia int identity(1,1) primary key,
	ho_ten nvarchar(50) not null,
	ngay_sinh date not null,
	so_dien_thoai char(10) check(so_dien_thoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	diachi nvarchar(50),
	email varchar(50),
);


Create table nhan_vien(
	ma_nhan_vien int identity(1,1) primary key,
	ho_ten nvarchar(50) not null,
	so_dien_thoai char(10) check(so_dien_thoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	email varchar(50) not null,
	mat_khau varchar(20) check (len(mat_khau)>=8),
	);

Create table muon(
	ma_muon int identity(1,1) primary key,
	ma_doc_gia int references doc_gia(ma_doc_gia) on update cascade on delete cascade,
	ma_sach int references sach(ma_sach) on update cascade on delete cascade,
	ngay_muon date not null default sysdatetime(),
	ngay_het_han date not null,
	ngay_tra date,
);

ALTER TABLE muon 
ADD ma_nhan_vien INT;

ALTER TABLE muon 
ADD CONSTRAINT fk_muon_nhan_vien FOREIGN KEY (ma_nhan_vien) REFERENCES nhan_vien(ma_nhan_vien);


insert into doc_gia values ( N'Lê Quốc Đạt', '2003-08-29', '0123456789', N'Ninh Kiều, Cần Thơ','lqdat@gmail.com');
insert into doc_gia values ( N'Nguyễn Văn A', '2003-01-01', '0987654321', N'Ninh Kiều, Cần Thơ','nva@gmail.com');
insert into doc_gia values ( N'Lê Thị B', '2005-12-23', '0582958271', N'Ninh Kiều, Cần Thơ','ltb@gmail.com');

insert into sach values(N'Sách 1', N'Tác giả 1', 'NXB ABC', 2024, N'Sách giáo khoa', 10, 9);

insert into nhan_vien values(N'Nhân viên 1', '0987987987', 'nv1@gmail.com', '12345678');
