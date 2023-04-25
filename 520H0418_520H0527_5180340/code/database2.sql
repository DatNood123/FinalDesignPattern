create database user;
use user;

create table user(
    tennguoidung varchar(240) primary key,
    matkhau text
);
create table ykien(
	id int primary key auto_increment,
    opinion text
);
insert into user(tennguoidung,matkhau) values('user1','123456'),('user2','123456');
