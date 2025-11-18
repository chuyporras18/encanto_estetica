create database if not exists encanto_estetica;

use encanto_estetica;

create table if not exists tipos_empleado(
	num_tipo_empleado int primary key auto_increment,
    nom_tipo_empleado char(50) not null,
    fecha_registro timestamp default current_timestamp
);

insert into tipos_empleado(nom_tipo_empleado)
values("Recepcionista");

insert into tipos_empleado(nom_tipo_empleado)
values("Estilista");

insert into tipos_empleado(nom_tipo_empleado)
values("Colorista");

insert into tipos_empleado(nom_tipo_empleado)
values("Manicurista");

insert into tipos_empleado(nom_tipo_empleado)
values("Maquillista");

insert into tipos_empleado(nom_tipo_empleado)
values("Especialista en cejas y pestañas");

insert into tipos_empleado(nom_tipo_empleado)
values("Cosmetóloga");

insert into tipos_empleado(nom_tipo_empleado)
values("Masajista");

insert into tipos_empleado(nom_tipo_empleado)
values("Encargada");

insert into tipos_empleado(nom_tipo_empleado)
values("Personal de limpieza");

create table if not exists empleados(
	num_empleado int primary key auto_increment,
    nombre char(50) not null,
    apellido_paterno char(50) not null,
    apellido_materno char(50) not null,
    contrasena char(50) not null,
    num_tipo_empleado int not null,
    fecha_registro timestamp default current_timestamp,
    constraint fk_tipos_empleado
		foreign key(num_tipo_empleado)
        references tipos_empleado(num_tipo_empleado)
);

insert into empleados( nombre, apellido_paterno, apellido_materno, contrasena, num_tipo_empleado)
values("Ali", "", "", "12345", 9);

create table if not exists tipo_servicios(
	num_tipo_servicio int primary key auto_increment,
    nom_servicio char(50) not null,
    costo_servicio float not null,
    fecha_registro timestamp default current_timestamp
);

insert into tipo_servicios(nom_servicio, costo_servicio)
values("Corte de Dama", 120);

insert into tipo_servicios(nom_servicio, costo_servicio)
values("Lifting de Pestañas", 140);

insert into tipo_servicios(nom_servicio, costo_servicio)
values("Manicure", 200);

create table if not exists citas(
	num_empleado int not null,
    num_cita int not null,
    num_tipo_servicio int not null,
    nombre char(50) not null,
    apellido_paterno char(50) not null,
    apellido_materno char(50) not null,
    fecha_servicio timestamp not null,
    fecha_registro timestamp default current_timestamp,
    primary key(num_empleado, num_cita),
    constraint fk_empleados
		foreign key (num_empleado)
        references empleados(num_empleado),
    constraint fk_tipo_servicios
		foreign key(num_tipo_servicio)
        references tipo_servicios(num_tipo_servicio)
);