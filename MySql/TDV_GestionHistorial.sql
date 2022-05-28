use TDV;

delimiter //
create procedure sp_Pedir_Historial()
begin
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;
select tdv.prediccion.resultado, tdv.prediccion.fecha_Pred from prediccion order by prediccion.id_prediccion limit 1;
commit;
end//

delimiter ;

