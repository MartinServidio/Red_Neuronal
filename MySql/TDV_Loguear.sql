use TDV;

delimiter //
create procedure sp_Loguear(Nombre varchar(30),_Mail varchar(50),_Contraseña varchar(18))
begin
declare Log int;
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;
select count(1) into Log from Usuarios where Nombre=Usuarios.nombre and _Mail=Usuarios.Mail and _Contraseña=Usuarios.Contraseña;
select Log;
commit;

end//

delimiter ;