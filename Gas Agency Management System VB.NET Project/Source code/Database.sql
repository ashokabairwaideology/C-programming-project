create database gas
use gas
create table consumer(con_no varchar(6) primary key, fname varchar (20), lname varchar(20),aline1 varchar(50), aline2 varchar(50), pin varchar(7), phone varchar(12), doc varchar(15), lastbook varchar(15), ctype varchar(10), stat varchar(10))
create table stock(commersial int, domesitc int)
create table booking(book_id int primary key, con_no varchar(6) foreign key references consumer, dob varchar(15), noc int, stat varchar(15))
create table rate(drate varchar(10), crate varchar(10))
create table delivery(del_id int primary key, book_id int foreign key references booking,dod varchar(15),con_no varchar(6) foreign key references consumer, noc int, price varchar(10))
create table password(pass varchar(10))

select * from consumer

select * from booking

select * from rate

select * from password

select * from delivery

select * from stock

truncate table booking

