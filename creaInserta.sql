use ProyectoDAI

create table tipo(
	cTipo int primary key,
	nomT varchar (100))

create table alimento(
	cAl int primary key,	
	nom varchar(100),
	kcal int,
	cTipo int references tipo)

create table dieta(
	cDieta int primary key,
	nombre varchar(100), 
	objetivo int)

create table usuario(
	CU int primary key,
	nombre varchar(100),
	dietista int,
	pwd varchar(30),
	correo varchar (50),
	edad int,
	altura int,
	peso int,
	sexo int,
	cDieta int references dieta)

create table dietaAlimento(
	cDieta int references dieta,
	CAl int references alimento,
	numPorciones int)

create table come(
	cAl int references alimento,
	CU int references usuario,
	fecha datetime)

--inserción de dietas
insert into dieta values(1000,'SobreHombre',2000)
insert into dieta values(1001,'SobreMujer',1500)
insert into dieta values(1002,'MedioHombre',2500)
insert into dieta values(1003,'MedioMujer',2000)
insert into dieta values(1004,'BajoHombre',3000)
insert into dieta values(1005,'BajoMujer',3500)

--usuario insert into usuario (CU, nombre, dietista 0 no y 1 si, pwd, correo, edad,altura,  peso, sexo 0 hombre)

insert into usuario values (101, 'Luis',0, 'luisito', 'luis99@gmail.com', 25,180, 80, 0,1000);
insert into usuario values( 102, 'Gerardo',0 , 'jerry', 'gjerry@gmail.com',19, 172 ,76,0,1002);
insert into usuario values(103, 'Pepe',1, 'ppe', 'pepon@gmail.com', 50, 175,95,0,1004);
insert into usuario values(104, 'Joss',1, 'joselo', 'joss101@gmail.com', 40, 190,102,0,1002);
insert into usuario values(105, 'Paty',0, 'patrishia', 'ppaty@gmail.com', 32,155,56,1,1005);
insert into usuario values (106, 'Brenda', 1, 'brendis', 'bren@gmail.com', 15, 155,50,1,1001);
insert into usuario values (107, 'Renata', 1, 'ttaa', 'remy@gmail.com', 22, 166,60,1,1003)
insert into usuario values (108, 'Alicia',0, 'lissa', 'lza99@gmail.com', 60, 150,50,1,1003);

--tipos

insert into tipo values(1,'Verdura')
insert into tipo values(2,'Fruta')
insert into tipo values(3,'Semillas')
insert into tipo values(4,'Cereales y Pasta')
insert into tipo values(5,'Legumbres')
insert into tipo values(6,'Lacteos')
insert into tipo values(7,'Carne')
insert into tipo values(8,'Pescados y Mariscos')
insert into tipo values(9,'Varios')

--Consulta para insertar alimentos:

--Sección Verduras (Nota las verduras llevan prefijo 10)
insert into alimento values(101,'Ajo',139,1)
insert into alimento values(102,'Berenjena',29,1)
insert into alimento values(103,'Calabaza',24,1)
insert into alimento values(104,'Cebolla',47,1)
insert into alimento values(105,'Col',28,1)
insert into alimento values(106,'Coliflor',30,1)
insert into alimento values(107,'Setas',28,1)
insert into alimento values(108,'Endibia',22,1)
insert into alimento values(109,'Esparragos',26,1)
insert into alimento values(110,'Espinacas',32,1)
insert into alimento values(111,'Guisantes',92,1)
insert into alimento values(112,'Lechuga',18,1)
insert into alimento values(113,'Papa Cocida',86,1)
insert into alimento values(114,'Pepino',12,1)
insert into alimento values(115,'Pimiento',22,1)
insert into alimento values(116,'Rabanos',20,1)
insert into alimento values(117,'Tomate',22,1)
insert into alimento values(118,'Zanahoria',42,1)


--Sección Frutas (Nota las Frutas llevan prefijo 20)
insert into alimento values(201,'Aguacate',167,2)
insert into alimento values(202,'Cerezas',77,2)
insert into alimento values(203,'Ciruelas',44,2)
insert into alimento values(204,'Coco',646,2)
insert into alimento values(205,'Frambuesa',40,2)
insert into alimento values(206,'Fresas',36,2)
insert into alimento values(207,'Granada',65,2)
insert into alimento values(208,'Kiwi',51,2)
insert into alimento values(209,'Limón',39,2)
insert into alimento values(210,'Mandarina',40,2)
insert into alimento values(211,'Mango',57,2)
insert into alimento values(212,'Manzana',52,2)
insert into alimento values(213,'Melón',31,2)
insert into alimento values(214,'Moras',37,2)
insert into alimento values(215,'Naranja',44,2)
insert into alimento values(216,'Papaya',45,2)
insert into alimento values(217,'Peras',61,2)
insert into alimento values(218,'Piña',51,2)
insert into alimento values(219,'Platano',90,2)
insert into alimento values(220,'Sandia',30,2)
insert into alimento values(221,'Uva',81,2)



--Sección Frutos Secos (Nota los Frutos Secos llevan prefijo 30)
insert into alimento values(301,'Almendras',620,3)
insert into alimento values(302,'Avellanas',675,3)
insert into alimento values(303,'Cacahuate',637,3)
insert into alimento values(304,'Nueces',660,3)
insert into alimento values(305,'Pistache',581,3)


--Sección Cereales y Pasta (Nota los Cereales y Pasta llevan prefijo 40)
insert into alimento values(401,'Arroz',354,4)
insert into alimento values(402,'Avena',367,4)
insert into alimento values(403,'Pan de Trigo',255,4)
insert into alimento values(404,'Pasta',368,4)


--Sección Legumbres (Nota las Legumbres llevan prefijo 50)
insert into alimento values(501,'Garbanzos',361,5)
insert into alimento values(502,'Habas',343,5)
insert into alimento values(503,'Lentejas',336,5)


--Sección Lacteos (Nota los Lacteos llevan prefijo 60)
insert into alimento values(601,'Leche',68,6)
insert into alimento values(602,'Queso Blanco',70,6)
insert into alimento values(603,'Queso Manchego',376,6)
insert into alimento values(604,'Yogur Natural',62,6)


--Sección Carne (Nota los  llevan prefijo 70)
insert into alimento values(701,'Chuleta',330,7)
insert into alimento values(702,'Lomo',208,7)
insert into alimento values(703,'Conejo',162,7)
insert into alimento values(704,'Cordero',215,7)
insert into alimento values(705,'Jamon',380,7)
insert into alimento values(706,'Pavo',223,7)
insert into alimento values(707,'Pollo',85,7)
insert into alimento values(708,'Ternera',181,7)



--Sección Pescados y Mariscos (Nota los Pescados y Mariscos llevan prefijo 80)
insert into alimento values(801,'Anchoas',175,8)
insert into alimento values(802,'Anguila',200,8)
insert into alimento values(803,'Atun',225,8)
insert into alimento values(804,'Bacalao',74,8)
insert into alimento values(805,'Calamar',82,8)
insert into alimento values(806,'Langosta',67,8)
insert into alimento values(807,'Lubina',118,8)
insert into alimento values(808,'Pulpos',57,8)
insert into alimento values(809,'Salmon',172,8)
insert into alimento values(810,'Sardinas',151,8)
insert into alimento values(811,'Trucha',94,8)



--Sección Varios (Nota los Varios llevan prefijo 90)
insert into alimento values(901,'Huevo',162,9)
insert into alimento values(902,'Azúcar',80,9)
insert into alimento values(903,'Miel',100,9)
insert into alimento values(904,'Aceitunas',149,9)
insert into alimento values(905,'Vino',80,9)
insert into alimento values(906,'Cafe',0,9)
insert into alimento values(907,'Chocolate',155,9)

--alimentos de prueba a dietas
select cAl,nom from alimento order by nom asc
--dieta hombres con sobre peso
insert into dietaAlimento values(1000,601,1)
insert into dietaAlimento values(1000,403,1)
insert into dietaAlimento values(1000,206,1)
insert into dietaAlimento values(1000,212,1)
insert into dietaAlimento values(1000,905,2)
insert into dietaAlimento values(1000,102,1)
insert into dietaAlimento values(1000,707,1)
insert into dietaAlimento values(1000,117,1)
insert into dietaAlimento values(1000,906,1)
insert into dietaAlimento values(1000,604,1)
insert into dietaAlimento values(1000,304,1)
insert into dietaAlimento values(1000,103,1)
insert into dietaAlimento values(1000,705,4)
insert into dietaAlimento values(1000,907,1)
--dieta mujeres con sobrepeso
insert into dietaAlimento values(1001,601,1)
insert into dietaAlimento values(1001,403,2)
insert into dietaAlimento values(1001,705,4)
insert into dietaAlimento values(1001,206,1)
insert into dietaAlimento values(1001,212,1)
insert into dietaAlimento values(1001,102,1)
insert into dietaAlimento values(1001,707,1)
insert into dietaAlimento values(1001,117,1)
insert into dietaAlimento values(1001,906,1)
insert into dietaAlimento values(1001,604,1)
insert into dietaAlimento values(1001,907,2)
insert into dietaAlimento values(1001,905,1)
insert into dietaAlimento values(1001,103,1)
--dieta hombres en peso ideal
insert into dietaAlimento values(1002,901,3)
insert into dietaAlimento values(1002,601,1)
insert into dietaAlimento values(1002,403,2)
insert into dietaAlimento values(1002,705,6)
insert into dietaAlimento values(1002,206,1)
insert into dietaAlimento values(1002,212,1)
insert into dietaAlimento values(1002,905,2)
insert into dietaAlimento values(1002,102,1)
insert into dietaAlimento values(1002,707,1)
insert into dietaAlimento values(1002,117,1)
insert into dietaAlimento values(1002,906,1)
insert into dietaAlimento values(1002,604,1)
insert into dietaAlimento values(1002,304,1)
insert into dietaAlimento values(1002,103,1)
insert into dietaAlimento values(1002,907,1)
--dieta mujeres en peso ideal
insert into dietaAlimento values(1003,901,3)
insert into dietaAlimento values(1003,601,1)
insert into dietaAlimento values(1003,403,2)
insert into dietaAlimento values(1003,705,6)
insert into dietaAlimento values(1003,206,1)
insert into dietaAlimento values(1003,212,1)
insert into dietaAlimento values(1003,905,2)
insert into dietaAlimento values(1003,102,1)
insert into dietaAlimento values(1003,707,1)
insert into dietaAlimento values(1003,117,1)
insert into dietaAlimento values(1003,906,1)
insert into dietaAlimento values(1003,604,1)
insert into dietaAlimento values(1003,304,1)
insert into dietaAlimento values(1003,103,1)
insert into dietaAlimento values(1003,907,1)
--dieta hombres bajos de peso
insert into dietaAlimento values(1004,601,2)
insert into dietaAlimento values(1004,402,1)
insert into dietaAlimento values(1004,403,5)
insert into dietaAlimento values(1004,602,1)
insert into dietaAlimento values(1004,201,1)
insert into dietaAlimento values(1004,210,2)
insert into dietaAlimento values(1004,705,2)
insert into dietaAlimento values(1004,304,1)
insert into dietaAlimento values(1004,219,1)
insert into dietaAlimento values(1004,404,1)
insert into dietaAlimento values(1004,708,1)
insert into dietaAlimento values(1004,102,1)
insert into dietaAlimento values(1004,604,2)
insert into dietaAlimento values(1004,215,1)
insert into dietaAlimento values(1004,803,1)
insert into dietaAlimento values(1004,809,1)
insert into dietaAlimento values(1004,901,1)
insert into dietaAlimento values(1004,503,1)
--dieta mujeres bajas de peso
insert into dietaAlimento values(1005,601,2)
insert into dietaAlimento values(1005,402,1)
insert into dietaAlimento values(1005,403,5)
insert into dietaAlimento values(1005,602,1)
insert into dietaAlimento values(1005,201,1)
insert into dietaAlimento values(1005,210,2)
insert into dietaAlimento values(1005,705,2)
insert into dietaAlimento values(1005,304,1)
insert into dietaAlimento values(1005,219,1)
insert into dietaAlimento values(1005,404,1)
insert into dietaAlimento values(1005,708,1)
insert into dietaAlimento values(1005,102,1)
insert into dietaAlimento values(1005,604,2)
insert into dietaAlimento values(1005,215,1)
insert into dietaAlimento values(1005,803,1)
insert into dietaAlimento values(1005,809,1)
insert into dietaAlimento values(1005,901,1)
insert into dietaAlimento values(1005,503,1)


