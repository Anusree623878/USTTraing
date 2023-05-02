create table Persons(
PersonId int primary key not null,
FirstName varchar(255),
LastName varchar(255),
Address varchar(255),
City varchar(266)
);


select * from Persons;

insert into Persons values(
101,'Anusree','pulappadi','kolayad','kannur');

insert into Persons values(
101,'arya','km','kariyad','kannur');

select top(2) FirstName from Persons;

select FirstName from Persons where FirstName = 'Anusree' AND PersonId=101;

select FirstName from Persons where FirstName = 'Anusree' or PersonId=102;



