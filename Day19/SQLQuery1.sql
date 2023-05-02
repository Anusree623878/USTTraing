create trigger empstring on Persons
after insert 
as
select 'person added';