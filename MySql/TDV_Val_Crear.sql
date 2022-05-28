use TDV;

delimiter //
create procedure sp_Val_Crear(_Mail varchar(50))
begin
declare Cre int;
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;
select count(1) into Cre from tdv.usuarios where _Mail=usuarios.Mail;
select Cre;
commit;

end//

delimiter ;