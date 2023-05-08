Create table Emp 
(EmpId int primary key not null,
EmpName varchar(30) not null,
DeptId int foreign key references Dept(DeptId));