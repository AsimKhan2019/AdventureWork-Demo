set nocount on
set xact_abort on
/* TODO. Substitute Database Name */
USE [Science2019]
GO

/* Drop Element table in Schema Chemistry if present */
IF (SELECT OBJECT_ID('Chemistry.Element','U')) IS NOT NULL
BEGIN
	DROP TABLE [Chemistry].[Element]
END
GO

/* Drop and create new Schema */
IF EXISTS(select * from INFORMATION_SCHEMA.SCHEMATA where [SCHEMA_NAME] = 'Chemistry')
BEGIN
	DROP SCHEMA [Chemistry]
END
GO

CREATE SCHEMA [Chemistry]
GO	

BEGIN TRY

BEGIN TRAN

	/* Create new table */
	CREATE TABLE [Chemistry].[Element] (
	[Symbol] nvarchar(2) NOT NULL,
	[Number] tinyint NOT NULL,
	[Name] nvarchar(50) NOT NULL,
	[Mass] nvarchar(50) NOT NULL,
	constraint [PK_Element_Symbol] PRIMARY KEY CLUSTERED(Symbol ASC),
	constraint [UQ_Element_Number] UNIQUE NONCLUSTERED(Number ASC)
	)
	ON [PRIMARY]

	/* Populate new table */
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ac',89,'Actinium','[227]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ag',47,'Silver','107.8682(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Al',13,'Aluminum','26.9815386(8)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Am',95,'Americium','[243]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ar',18,'Argon','39.948(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('As',33,'Arsenic','74.92160(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('At',85,'Astatine','[210]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Au',79,'Gold','196.966569(4)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('B',5,'Boron','10.811(7)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ba',56,'Barium','137.327(7)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Be',4,'Beryllium','9.012182(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Bh',107,'Bohrium','[272]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Bi',83,'Bismuth','208.98040(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Bk',97,'Berkelium','[247]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Br',35,'Bromine','79.904(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('C',6,'Carbon','12.0107(8)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ca',20,'Calcium','40.078(4)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cd',48,'Cadmium','112.411(8)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ce',58,'Cerium','140.116(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cf',98,'Californium','[251]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cl',17,'Chlorine','35.453(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cm',96,'Curium','[247]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cn',112,'Copernicium','[285]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Co',27,'Cobalt','58.933195(5)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cr',24,'Chromium','51.9961(6)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cs',55,'Cesium','132.9054519(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Cu',29,'Copper','63.546(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Db',105,'Dubnium','[268]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ds',110,'Darmstadtium','[281]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Dy',66,'Dysprosium','162.500(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Er',68,'Erbium','167.259(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Es',99,'Einsteinium','[252]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Eu',63,'Europium','151.964(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('F',9,'Fluorine','18.9984032(5)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Fe',26,'Iron','55.845(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Fl',114,'Flerovium','[289]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Fm',100,'Fermium','[257]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Fr',87,'Francium','[223]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ga',31,'Gallium','69.723(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Gd',64,'Gadolinium','157.25(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ge',32,'Germanium','72.64(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('H',1,'Hydrogen','1.00794(4)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('He',2,'Helium','4.002602(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Hf',72,'Hafnium','178.49(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Hg',80,'Mercury','200.59(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ho',67,'Holmium','164.93032(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Hs',108,'Hassium','[270]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('I',53,'Iodine','126.90447(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('In',49,'Indium','114.818(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ir',77,'Iridium','192.217(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('K',19,'Potassium','39.0983(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Kr',36,'Krypton','83.798(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('La',57,'Lanthanum','138.90547(7)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Li',3,'Lithium','6.941(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Lr',103,'Lawrencium','[262]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Lu',71,'Lutetium','174.9668(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Lv',116,'Livermorium','[293]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Mc',115,'Moscovium','[288]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Md',101,'Mendelevium','[258]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Mg',12,'Magnesium','24.3050(6)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Mn',25,'Manganese','54.938045(5)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Mo',42,'Molybdenum','95.96(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Mt',109,'Meitnerium','[276]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('N',7,'Nitrogen','14.0067(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Na',11,'Sodium','22.98976928(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Nb',41,'Niobium','92.90638(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Nd',60,'Neodymium','144.242(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ne',10,'Neon','20.1797(6)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Nh',113,'Nihonium','[284]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ni',28,'Nickel','58.6934(4)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('No',102,'Nobelium','[259]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Np',93,'Neptunium','[237]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('O',8,'Oxygen','15.9994(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Og',118,'Oganesson','[294]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Os',76,'Osmium','190.23(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('P',15,'Phosphorus','30.973762(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pa',91,'Protactinium','231.03588(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pb',82,'Lead','207.2(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pd',46,'Palladium','106.42(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pm',61,'Promethium','[145]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Po',84,'Polonium','[209]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pr',59,'Praseodymium','140.90765(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pt',78,'Platinum','195.084(9)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Pu',94,'Plutonium','[244]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ra',88,'Radium','[226]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Rb',37,'Rubidium','85.4678(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Re',75,'Rhenium','186.207(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Rf',104,'Rutherfordium','[267]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Rg',111,'Roentgenium','[280]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Rh',45,'Rhodium','102.90550(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Rn',86,'Radon','[222]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ru',44,'Ruthenium','101.07(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('S',16,'Sulfur','32.065(5)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sb',51,'Antimony','121.760(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sc',21,'Scandium','44.955912(6)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Se',34,'Selenium','78.96(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sg',106,'Seaborgium','[271]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Si',14,'Silicon','28.0855(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sm',62,'Samarium','150.36(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sn',50,'Tin','118.710(7)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Sr',38,'Strontium','87.62(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ta',73,'Tantalum','180.94788(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Tb',65,'Terbium','158.92535(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Tc',43,'Technetium','[98]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Te',52,'Tellurium','127.60(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Th',90,'Thorium','232.03806(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ti',22,'Titanium','47.867(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Tl',81,'Thallium','204.3833(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Tm',69,'Thulium','168.93421(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Ts',117,'Tennessine','[294]')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('U',92,'Uranium','238.02891(3)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('V',23,'Vanadium','50.9415(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('W',74,'Tungsten','183.84(1)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Xe',54,'Xenon','131.293(6)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Y',39,'Yttrium','88.90585(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Yb',70,'Ytterbium','173.054(5)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Zn',30,'Zinc','65.38(2)')
	INSERT [Chemistry].[Element] ([Symbol],[Number],[Name],[Mass])VALUES('Zr',40,'Zirconium','91.224(2)')

	COMMIT TRAN
	print '[Chemistry].[Element] created successfully'
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	print 'Script executed with errors'
	print 'Error ' + cast(ERROR_NUMBER() as nvarchar(8)) + ': ' + ERROR_Message()
	print 'Rollback applied successfully' 
END CATCH






