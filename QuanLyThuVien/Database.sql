Create database QLTV;

use qltv;

create table sach(
	ma_sach int primary key,
	ten_sach nvarchar not null,
	tac_gia nvarchar not null,
	nxb nvarchar not null,
	nam int check (nam > 1000 and nam < 2025),
	the_loai nvarchar not null,
	so_luong_tong int not null,
	sl_con_lai int not null
);

Create table doc_gia(
	ma_doc_gia int primary key,
	ho_ten nvarchar not null,
	ngay_sinh date not null,
	so_dien_thoai char(10) check(so_dien_thoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	diachi nvarchar,
	email varchar,
);


Create table nhan_vien(
	ma_nhan_vien int primary key,
	ho_ten nvarchar not null,
	so_dien_thoai char(10) check(so_dien_thoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), 
	email varchar not null,
	mat_khau varchar check (len(mat_khau)>=8),
	);

Create table muon(
	ma_muon int primary key,
	ma_doc_gia int references doc_gia(ma_doc_gia) on update cascade on delete cascade,
	ma_sach int references sach(ma_sach) on update cascade on delete cascade,
	ngay_muon date not null default sysdatetime(),
	ngay_het_han date not null,
	ngay_tra date,
	trang_thai char check(trang_thai in ('Đang mượn', 'Đã trả' , 'Đã hết hạn')) --có thể không cần
);

Create table phat(
	ma_phat_tien int primary key,
	ma_muon int references muon(ma_muon) on update cascade on delete cascade,
	so_tien int not null,
	da_tra int default 0,
);