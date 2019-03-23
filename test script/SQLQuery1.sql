create database Customer
use Customer
create table Customer
(
FirstName varchar(50),
LastName varchar(50),
Age int
)

insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Ram','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Rash','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('hala','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Rose','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Osama','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Baba','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Mama','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('Kobe','ham',24,GETDATE());
insert into dbo.Customer (FirstName,LastName,Age,[Date]) values ('hasag','ham',24,GETDATE());

select *
from Customer

update Customer
set City='Rotterdam'
where FirstName like 'Ram' and LastName like 'ham'

delete Customer
where FirstName like 'Ram';

alter table Customer 
add City varchar (50) not null
alter table Customer
add Id int primary key identity (1,1)

alter table Customer drop col
update INFORMATION_SCHEMA.COLUMNS
set  ORDINAL_POSITION=1
where TABLE_NAME like 'Customer' and COLUMN_NAME like 'Id'

alter table Customer
add [Date] Date
