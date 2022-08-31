create database BookBiz;

use BookBiz;

create table auther (
auther_id int not null identity primary key,
firstname varchar(50) not null,
lastname varchar(50) not null,
email varchar(50)
);

create table publisher (
publisher_id int not null identity primary key,
name varchar(50) not null
);

create table book (
book_id int not null identity primary key,
isbn varchar(50) not null unique,
title varchar(100) not null,
unitprice decimal default 0,
yearpublished int,
qoh int default 0,
category varchar(50),
publisher_id int references publisher(publisher_id)
);

create table book_auther (
book_auther_id int not null identity primary key,
auther_id int references auther(auther_id),
book_id int references book(book_id)
);

create table client (
client_id int not null identity primary key,
name varchar(100) not null,
street varchar(100),
city varchar(50),
postalcode varchar(50),
phone varchar(25),
fax varchar(25),
creaditlimit int default 0
);

create table orders (
order_id int not null identity primary key,
totalprice decimal default 0,
date date,
client_id int references client(client_id)
);

create table book_orders (
book_order_id int not null identity primary key,
quantity int,
price decimal default 0, 
book_id int references book(book_id),
order_id int references orders(order_id)
);

create table employee (
employee_id int not null identity primary key,
firstname varchar(50) not null,
lastname varchar(50) not null,
email varchar(50),
department varchar(25)
);

create table users (
user_id int not null identity primary key,
username varchar(50) not null,
password varchar(50) not null,
privilege varchar(50) not null
);

insert into users (username,password,privilege) values('Henry','111','MIS');
insert into users (username,password,privilege) values('Thomas','111','Sales');
insert into users (username,password,privilege) values('Peter','111','Inventory');
insert into users (username,password,privilege) values('Mary','111','Order');
insert into users (username,password,privilege) values('Jennifer','111','Order');






