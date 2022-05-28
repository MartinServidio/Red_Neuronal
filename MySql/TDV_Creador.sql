create schema if not exists TDV;
use TDV;

create table if not exists TDV.Usuarios(
id_Usuario int auto_increment not null,
Nombre varchar(30) not null,
Apellido varchar(30) not null,
Contraseña varchar(18) not null,
Mail varchar(50) not null,
primary key(id_Usuario)
);

create table if not exists TDV.Prediccion(
id_prediccion int auto_increment not null,
Fecha_pred date not null,
Resultado double not null,
primary key(id_prediccion)
);

create table if not exists TDV.Indicadores(
id_indicador int auto_increment not null,
Descripcion varchar(30) not null,
Mapeo varchar(18) not null,
primary key(id_indicador)
);

create table if not exists TDV.Categorias(
id_categoria int auto_increment not null,
Descripcion varchar(60) not null,
primary key(id_categoria)
);

create table if not exists TDV.Rel_Usu_Pred(
id_Usu_Ind int auto_increment not null,
id_prediccion integer not null,
id_Usuario integer not null,
primary key(id_Usu_Ind),
foreign key(id_Usuario) references TDV.Usuarios(id_Usuario)
on delete no action
on update no action,
foreign key(id_prediccion) references TDV.Prediccion(id_prediccion)
on delete no action
on update no action
);

create table if not exists TDV.Rel_Ind_Pred(
id_relpredic int auto_increment not null,
id_indicador int not null,
id_prediccion int not null,
Valor int,
primary key(id_relpredic),
foreign key(id_indicador) references TDV.Indicadores(id_indicador)
on delete no action
on update no action,
foreign key(id_prediccion) references TDV.Prediccion(id_prediccion)
on delete no action
on update no action
);

create table if not exists TDV.Rel_Pred_Cate(
id_relpredcate int auto_increment not null,
id_categoria int not null,
id_prediccion int not null,
primary key(id_relpredcate),
foreign key(id_prediccion) references TDV.Prediccion(id_prediccion)
on delete no action
on update no action,
foreign key(id_categoria) references TDV.Categorias(id_categoria)
on delete no action
on update no action
);