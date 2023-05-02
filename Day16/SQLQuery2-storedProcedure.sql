CREATE OR ALTER PROCEDURE ShowName(@fname varchar(255))
as
begin
select * from Persons where FirstName=@fname
end

exec ShowName Anusree

