create database CarDP;
use CarDP;

create table Wheel(
    id int primary key  auto_increment ,
    nameWheel text not null ,
    size float not null,
    tireMaterial text,
    boneMaterial text
);

create table color(
    id int primary key auto_increment ,
    name text  not null ,
    hexCode varchar(20) not null
);

create table Engine(-- EEngine01,EEngine02- DEngine01 - DEngine02 - GEngine01 - GEngine02
    id int primary key auto_increment ,
    nameEngine text not null ,
    version varchar(20)
);


create table CarType( -- Gas, Diesel, Electric
     id int primary key auto_increment ,
     name text not null
);



create table Engine_car_type(
     id int primary key auto_increment ,
    Engine_ID int not null,
    CarType_ID int not null,
    CONSTRAINT fk_Engine_car_Engine foreign key (Engine_ID) references Engine(id),
    CONSTRAINT fk_Engine_car_CarType foreign key (CarType_ID) references CarType(id)
);


create table model_car(
  id int primary key auto_increment ,
 
  -- gas, diesel
  max_tank_volume float default null,
  fuel_tank_volume float default null,
  recommend_gas text default null,

    -- electric
  max_capacity text default null,
  battery_capacity text default null,

  Car_type_id int not null ,
  CONSTRAINT fk_model_car_CarType foreign key (Car_type_id) references CarType(id)
);

create table GearType(
    id int primary key auto_increment ,
    name text not null 
);

create table ModelCarType(
     id int primary key auto_increment ,
     name text not null 
);



create table Car(
    id int primary key auto_increment ,
    name_car text not null ,
    wheel_id int not null,
    engine_id int not null,
    color_id int not null,
    gear_type_id int not null,
    model_car_id int not null,
    CONSTRAINT fk_Car_Wheel foreign key (wheel_id) references Wheel(id),
    CONSTRAINT fk_Car_Engine foreign key (engine_id) references Engine(id),
    CONSTRAINT fk_Car_color foreign key (color_id) references color(id),
    CONSTRAINT fk_Car_GearType foreign key (gear_type_id) references GearType(id),
    CONSTRAINT fk_Car_ModelCarType foreign key (model_car_id) references ModelCarType(id)

);

insert into Engine(nameEngine,version) values ('EEngine01','1.0'),('EEngine02','1.1'),
												('DEngine01','1'),('DEngine02','1.1'),
												('GEngine01','1'),('GEngine02','1.1');

insert into Wheel(nameWheel,size,tireMaterial,boneMaterial) values ('DTDModel01_26',26,'Rubber','Alumium'),
																	('DTDModel01_27',27,'Rubber','Carbon'),
																	('DTDModel01_29',28,'Rubber','Alumium');


insert into color(name,hexCode) values ('Black','#000000'),('Blue','#0000FF'),
										('Green', '#00FF00'),('Red','#FF0000'),('White','#FFFFFF');

insert into CarType(name) values ('Gasoline'),('Diesel'),('Electric');

insert into model_car(max_tank_volume,fuel_tank_volume,recommend_gas,Car_type_id) values (70,0,'Gas',1),(90,0,'Diesel',2);
insert into model_car(max_capacity,battery_capacity,Car_type_id) values ('100 AH','0',3);



insert into Engine_car_type(Engine_ID,CarType_ID) values (1,2),(2,1),(3,3),
														(6,1),(5,2),(4,3);

insert into GearType(name) values ('Manual'),('Automatic');


insert into ModelCarType(name) values ('Sedan'),('SUV'),('Sport'),('Hatchback');


insert into Car(name_car,wheel_id,engine_id,color_id,gear_type_id,model_car_id) 
values ('Car 1', 1,1,2,1,2),('Car 2', 2,3,4,2,4),('Car 3', 3,4,4,2,4);





select * from Engine;
select * from Wheel;
select * from color;
select * from CarType;
select * from model_car;
select * from Engine_car_type;
select * from GearType;
select * from ModelCarType;
select * from Car;