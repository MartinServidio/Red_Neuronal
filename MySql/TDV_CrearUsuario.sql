use TDV;

delimiter //
create procedure sp_CrearUsuario(_Nombre varchar(30),_Apellido varchar(30),_Contraseña varchar(18),_Mail varchar(50))
begin
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;
insert into Usuarios(Nombre,Apellido,Contraseña,Mail)
values(
_Nombre,_Apellido,_Contraseña,_Mail
);
commit;
end//

delimiter ;


