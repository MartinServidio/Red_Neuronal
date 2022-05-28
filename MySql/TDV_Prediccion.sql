use TDV;

delimiter //
create procedure sp_Prediccion(vresultado double)
begin
declare vfecha date;
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;
select now() into vfecha;
insert into Prediccion(
Fecha_pred
,Resultado
)
values(vfecha,vresultado);


commit;
end//

delimiter ;
