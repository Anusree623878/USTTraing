create or alter  Procedure Perssonadress
@person_id int,@addres varchar(255) output
as
begin
select @addres= Address from Persons where PersonId=@person_id;
End;

