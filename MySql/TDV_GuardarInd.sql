use TDV;

delimiter //
create procedure sp_GuardarInd(Ind1 integer, Ind2 integer, 
Ind3 integer, Ind4 integer, Ind5 integer, Ind6 integer, 
Ind7 integer, Ind8 integer, Ind9 integer, Ind10 integer,
Ind11 integer, Ind12 integer, Ind13 integer, Ind14 integer,
Ind15 integer, Ind16 integer)
begin
declare exit handler for sqlexception
begin
rollback;
end;

start transaction;

insert into rel_usu_pred(
id_Prediccion
,id_Usuario
)
values(last_insert_id(),last_insert_id());


insert into rel_pred_cate(
id_Categoria
,id_Prediccion
)
values(last_insert_id(),last_insert_id());

insert into Rel_Usu_Pred (
id_prediccion
,id_Usuario
)
values(last_insert_id(),last_insert_id()
);

insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (1,last_insert_id(), Ind1);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (2,last_insert_id(), Ind2);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (3,last_insert_id(), Ind3);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (4,last_insert_id(), Ind4);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (5,last_insert_id(), Ind5);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (6,last_insert_id(), Ind6);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (7,last_insert_id(), Ind7);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (8,last_insert_id(), Ind8);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (9,last_insert_id(), Ind9);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (10,last_insert_id(), Ind10);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (11,last_insert_id(), Ind11);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (12,last_insert_id(), Ind12);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (13,last_insert_id(), Ind13);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (14,last_insert_id(), Ind14);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (15,last_insert_id(), Ind15);
insert into rel_ind_pred(id_indicador,id_prediccion,Valor) values (16,last_insert_id(), Ind16);
commit;
end//

delimiter ;

call sp_GuardarInd;