USE LG_Analysis_Database
GO
--Groups
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Bomb-bay');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Buffer');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carrousel');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Closing');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Discharge');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Erector');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Filling');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Folding');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Loading');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Carton Placement');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Chainpack Folding');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Coding');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Flex count');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('General');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Infeed');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Magazin Loading');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Product Placement');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Puck Distribution System');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Robot');
--SubGroups
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Bomb-bay','Pouches');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Bomb-bay','Regular');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Bomb-bay','Starwheel');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Bomb-bay','Stick');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Bomb-bay','Bora');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Buffer','Bucket buffer');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Buffer','Tray');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carrousel','General');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Closing','Glue Closing');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Closing','Tuck Closing');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Closing','Glue Closing (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Closing','Glue Unit (Higher level)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Discharge','No Reject');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Discharge','Reject Blow-off');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Discharge','Reject Pusher');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Erector','Pre-Break');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Erector','Rotary Feeder');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Erector','Rotary Feeder with adjustable magazine');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Erector','Pre-Break (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Erector','Rotary Feeder (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Filling','Automatic Filling');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Filling','Manual Filling');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Filling','Automatic Filling (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Folding','Folding Transport');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Folding','Folding transport (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Loading','Adjustable Magazin');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Loading','Extended Magazin');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Carton Loading','Template');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Chainpack Folding','Chainpack Folding Single- & Multi lane');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Coding','Emboss');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Coding','Laser');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Coding','Printer');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Flex count','Turn unit');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('General','Complete machine');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('General','Glass handling');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('General','Safe Speed');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Angled Conveyor');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Blister cassette unloading');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Leaflet feeder');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Overhead sweeper');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Reject Conveyor');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Spoonfeeder');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Stick drop table');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Tissue Overhead Turn Unit');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Tissue Turn Unit');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Tray Unload Module');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Incline bucket conveyor');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Stick drop table with safety guarding');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Leaflet folding feeder');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Tissue Overhead TU (Safe Speed)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Leaflet feeder (Safe remove)');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Infeed Screw');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Servotrain');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Lowerator');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed','Side Belts');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Magazin Loading','Complete magazin loading');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Magazin Loading','Tray Handling');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Magazin Loading','Tray Loading');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Product Placement','Manual');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Puck Distribution System','Puck Distribution General');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Puck Distribution System','Puck Loading');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Puck Distribution System','Puck Unloading');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Robot','Flex-picker');
GO
--User permissions
INSERT INTO Tbl_User_Permissions([PermissionName]) VALUES('ADMIN')
INSERT INTO Tbl_User_Permissions([PermissionName]) VALUES('LEAD')
INSERT INTO Tbl_User_Permissions([PermissionName]) VALUES('ENGINEER')
GO
--Users
INSERT INTO Tbl_User VALUES('Thomas', 0x42 ,1)
INSERT INTO Tbl_User VALUES('B.Huithink', 0x42 ,1)
INSERT INTO Tbl_User VALUES('BMathijssen', 0x42 ,1)
GO
--Project states
INSERT INTO Tbl_Risk_Project_State VALUES('DRAFT')
INSERT INTO Tbl_Risk_Project_State VALUES('FORREVIEW')
INSERT INTO Tbl_Risk_Project_State VALUES('FINALDRAFT')
INSERT INTO Tbl_Risk_Project_State VALUES('CLOSED')
--Risks
GO--ID,Group,item,weight
INSERT INTO Tbl_RiskEstimation VALUES(1, '(SE)Severity of harm','Death, loss of eye or arm',			4)
INSERT INTO Tbl_RiskEstimation VALUES(2, '(SE)Severity of harm','Permanent injury, loss of finger(s)',	3)
INSERT INTO Tbl_RiskEstimation VALUES(3, '(SE)Severity of harm','Reversible injury, medical attention',	2)
INSERT INTO Tbl_RiskEstimation VALUES(4, '(SE)Severity of harm','Reversible injury, first aid',			1)
INSERT INTO Tbl_RiskEstimation VALUES(6, '(FR)Frequency of exposure to the hazard','<1 Hour',			5)
INSERT INTO Tbl_RiskEstimation VALUES(7, '(FR)Frequency of exposure to the hazard','>1 Hour <24 Hour',	5)
INSERT INTO Tbl_RiskEstimation VALUES(8, '(FR)Frequency of exposure to the hazard','>24 Hour <2 Weeks',	4)
INSERT INTO Tbl_RiskEstimation VALUES(9, '(FR)Frequency of exposure to the hazard','>2 Weeks <1 Year',	3)
INSERT INTO Tbl_RiskEstimation VALUES(10,'(FR)Frequency of exposure to the hazard','>1 Year',			2)
INSERT INTO Tbl_RiskEstimation VALUES(11,'(PR)Probability of occurence','Very high',					5)
INSERT INTO Tbl_RiskEstimation VALUES(12,'(PR)Probability of occurence','Likely',						4)
INSERT INTO Tbl_RiskEstimation VALUES(13,'(PR)Probability of occurence','Possible',						3)
INSERT INTO Tbl_RiskEstimation VALUES(14,'(PR)Probability of occurence','Rarely',						2)
INSERT INTO Tbl_RiskEstimation VALUES(15,'(PR)Probability of occurence','Negligible',					1)
INSERT INTO Tbl_RiskEstimation VALUES(16,'(AV)Possibility of avoiding the hazard','Impossible',			5)
INSERT INTO Tbl_RiskEstimation VALUES(17,'(AV)Possibility of avoiding the hazard','Possible',			3)
INSERT INTO Tbl_RiskEstimation VALUES(18,'(AV)Possibility of avoiding the hazard','Likely',				1)
GO
INSERT INTO Tbl_Danger VALUES(1,'Mechanical hazards')
INSERT INTO Tbl_Danger VALUES(2,'Electrical hazards')
INSERT INTO Tbl_Danger VALUES(3,'Thermic hazards')
INSERT INTO Tbl_Danger VALUES(4,'Hazards by sound')
INSERT INTO Tbl_Danger VALUES(5,'Hazards by vibrations')
INSERT INTO Tbl_Danger VALUES(6,'Hazards by radiation')
INSERT INTO Tbl_Danger VALUES(7,'Hazards by materials/dust')
INSERT INTO Tbl_Danger VALUES(8,'Ergonomic hazards')
INSERT INTO Tbl_Danger VALUES(9,'Hazards by machine usage environment')
INSERT INTO Tbl_Danger VALUES(10,'Combination of hazards')
GO
INSERT INTO Tbl_Danger_Result VALUES(1,'Run over')
INSERT INTO Tbl_Danger_Result VALUES(2,'Knock down')
INSERT INTO Tbl_Danger_Result VALUES(3,'Shattering bones')
INSERT INTO Tbl_Danger_Result VALUES(4,'Cutting or cut off')
INSERT INTO Tbl_Danger_Result VALUES(5,'Draw in or jamming')
INSERT INTO Tbl_Danger_Result VALUES(6,'Sufficate')
INSERT INTO Tbl_Danger_Result VALUES(7,'Friction wound or graze')
INSERT INTO Tbl_Danger_Result VALUES(8,'Bump')
INSERT INTO Tbl_Danger_Result VALUES(9,'Injection')
INSERT INTO Tbl_Danger_Result VALUES(10,'Shear')
INSERT INTO Tbl_Danger_Result VALUES(11,'Slip, stumble and fall down')
INSERT INTO Tbl_Danger_Result VALUES(12,'Sting or sting through')
INSERT INTO Tbl_Danger_Result VALUES(13,'Suffication')
INSERT INTO Tbl_Danger_Result VALUES(14,'Burn wounds')
INSERT INTO Tbl_Danger_Result VALUES(15,'Chemical effects')
INSERT INTO Tbl_Danger_Result VALUES(16,'Effects on medical implants')
INSERT INTO Tbl_Danger_Result VALUES(17,'Electrocution')
INSERT INTO Tbl_Danger_Result VALUES(18,'Fall down, knock down')
INSERT INTO Tbl_Danger_Result VALUES(19,'Fire')
INSERT INTO Tbl_Danger_Result VALUES(20,'Shoot off of molten particals')
INSERT INTO Tbl_Danger_Result VALUES(21,'Shock')
INSERT INTO Tbl_Danger_Result VALUES(22,'Burn wounds')
INSERT INTO Tbl_Danger_Result VALUES(23,'Dehydration')
INSERT INTO Tbl_Danger_Result VALUES(24,'Inconvenience')
INSERT INTO Tbl_Danger_Result VALUES(25,'Freezing')
INSERT INTO Tbl_Danger_Result VALUES(26,'Injury by heat source radiation')
INSERT INTO Tbl_Danger_Result VALUES(27,'Burning')
INSERT INTO Tbl_Danger_Result VALUES(28,'Inconvenience')
INSERT INTO Tbl_Danger_Result VALUES(29,'Loss of attention')
INSERT INTO Tbl_Danger_Result VALUES(30,'Loss of balance')
INSERT INTO Tbl_Danger_Result VALUES(31,'Permanent loss of hearing')
INSERT INTO Tbl_Danger_Result VALUES(32,'Stress')
INSERT INTO Tbl_Danger_Result VALUES(33,'buzzing in one s ears (tinnitus)')
INSERT INTO Tbl_Danger_Result VALUES(34,'Fatigue')
INSERT INTO Tbl_Danger_Result VALUES(35,'Acoustic signals')
INSERT INTO Tbl_Danger_Result VALUES(36,'Inconvenience')
INSERT INTO Tbl_Danger_Result VALUES(37,'Low back troubles')
INSERT INTO Tbl_Danger_Result VALUES(38,'Neurologic disorders')
INSERT INTO Tbl_Danger_Result VALUES(39,'Joint disorders')
INSERT INTO Tbl_Danger_Result VALUES(40,'Back troubles')
INSERT INTO Tbl_Danger_Result VALUES(41,'Vascular disorder')
INSERT INTO Tbl_Danger_Result VALUES(42,'Burn wounds')
INSERT INTO Tbl_Danger_Result VALUES(43,'Eye or skin damage')
INSERT INTO Tbl_Danger_Result VALUES(44,'Effects to the reproduction organs')
INSERT INTO Tbl_Danger_Result VALUES(45,'Genetic mutations')
INSERT INTO Tbl_Danger_Result VALUES(46,'Head age, sleeplessness (insomnia)')
INSERT INTO Tbl_Danger_Result VALUES(47,'Breathing difficulties')
INSERT INTO Tbl_Danger_Result VALUES(48,'Suffication')
INSERT INTO Tbl_Danger_Result VALUES(49,'Cancer')
INSERT INTO Tbl_Danger_Result VALUES(50,'Corrosion')
INSERT INTO Tbl_Danger_Result VALUES(51,'Effects to the reproduction organs')
INSERT INTO Tbl_Danger_Result VALUES(52,'Explosion')
INSERT INTO Tbl_Danger_Result VALUES(53,'Fire')
INSERT INTO Tbl_Danger_Result VALUES(54,'Infection')
INSERT INTO Tbl_Danger_Result VALUES(55,'Mutation')
INSERT INTO Tbl_Danger_Result VALUES(56,'Poisoning')
INSERT INTO Tbl_Danger_Result VALUES(57,'Hypersensitiveness (idiosyncrasie)')
INSERT INTO Tbl_Danger_Result VALUES(58,'Inconvenience')
INSERT INTO Tbl_Danger_Result VALUES(59,'Fatigue')
INSERT INTO Tbl_Danger_Result VALUES(60,'Muscle disorder')
INSERT INTO Tbl_Danger_Result VALUES(61,'Stress')
INSERT INTO Tbl_Danger_Result VALUES(62,'Result by human error')
INSERT INTO Tbl_Danger_Result VALUES(63,'Burns')
INSERT INTO Tbl_Danger_Result VALUES(64,'Light disorders')
INSERT INTO Tbl_Danger_Result VALUES(65,'Slip, fall down')
INSERT INTO Tbl_Danger_Result VALUES(66,'Suffication')
GO --ID,Tbl_Danger,Danger source,Tbl_Danger_Result,Tbl_Danger_Result
INSERT INTO Tbl_Danger_Source VALUES(1,1,'Acceleration/deceleration (kinetic energy)'			,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(2,1,'Sharp cornered parts'									,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(3,1,'Approach of a moving element towards a fixed part'	,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(4,1,'Cutting elements'										,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(5,1,'Elastic elements'										,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(6,1,'Falling objects'										,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(7,1,'Gravitational force (stored energy)'					,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(8,1,'Height from ground'									,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(9,1,'High pressure'										,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(10,1,'Machine s mobility'									,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(11,1,'Moving elements'										,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(12,1,'Rotating elements'									,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(13,1,'Rough/slippery surfaces'								,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(14,1,'Sharp edges'											,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(15,1,'Stability'											,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(16,1,'Vacuum'												,1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(17,2,'Arc (e.g. welding)'									,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(18,2,'Electromagnetic phenomenon'							,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(19,2,'Electrostatic phenomenon'							,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(20,2,'Electronic parts'									,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(21,2,'Insufficient distance to high-voltage parts'			,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(22,2,'Overload'											,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(23,2,'Part becomes current-carrying part by malfunctions'	,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(24,2,'Short-circuit'										,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(25,2,'Thermic radiation'									,22,NULL)
INSERT INTO Tbl_Danger_Source VALUES(26,3,'Explosion'											,63,NULL)
INSERT INTO Tbl_Danger_Source VALUES(27,3,'Flame'												,63,NULL)
INSERT INTO Tbl_Danger_Source VALUES(28,3,'Objects or materials with high or low temperature'	,63,NULL)
INSERT INTO Tbl_Danger_Source VALUES(29,3,'Radiation from heat sources'							,63,NULL)
INSERT INTO Tbl_Danger_Source VALUES(33,4,'Fabrication proces'									,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(34,4,'Moving parts'										,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(35,4,'Scraping surfaces'									,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(36,4,'Unbalanced rotating parts'							,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(37,4,'Whistling sound from pneumatic parts'				,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(38,4,'Worn parts'											,31,NULL)
INSERT INTO Tbl_Danger_Source VALUES(42,5,'Scraping surfaces'									,24,NULL)
INSERT INTO Tbl_Danger_Source VALUES(43,5,'Unbalanced rotating parts'							,24,NULL)
INSERT INTO Tbl_Danger_Source VALUES(44,5,'Vibrating equipment'									,24,NULL)
INSERT INTO Tbl_Danger_Source VALUES(45,5,'Worn Parts'											,24,NULL)
INSERT INTO Tbl_Danger_Source VALUES(48,6,'Optic radiation (infra red, ultraviolet) incl. laser beam',55,NULL)
INSERT INTO Tbl_Danger_Source VALUES(50,7,'Aërosols'											,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(52,7,'Flammable'											,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(53,7,'Dust'												,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(54,7,'Explosive'											,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(55,7,'Fibers'												,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(56,7,'Inflammable'											,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(57,7,'Liquid'												,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(58,7,'Vapour/Fumes'										,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(59,7,'Gas'													,47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(62,8,'Access'												,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(63,8,'Design or location of indicators and displays'		,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(64,8,'Design, location or indentification of controllers'	,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(65,8,'High effort'											,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(66,8,'Flickering, blinding, shadow, stroboscopic effects'	,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(67,8,'Local illumination'									,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(68,8,'Mental overload/underload'							,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(69,8,'Posture'												,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(70,8,'Repetitive acivities'								,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(71,8,'Sight'												,60,NULL)
INSERT INTO Tbl_Danger_Source VALUES(73,9,'Electromagnetic disturbance'							,64,NULL)
INSERT INTO Tbl_Danger_Source VALUES(75,9,'Moisture'											,64,NULL)
INSERT INTO Tbl_Danger_Source VALUES(78,9,'Temperature'											,64,NULL)
INSERT INTO Tbl_Danger_Source VALUES(82,10,'Activity+high effort+environmental temperature'		,1,NULL)
GO
--DECLARE @AmountOfRisks INT
--SET @AmountOfRisks = 0
--WHILE @AmountOfRisks < 600  
--BEGIN 
--	DECLARE @tempGroupName VARCHAR(128)
--	DECLARE @tempTypeName VARCHAR(128)
--	SET @tempGroupName = ( 
--		SELECT TOP 1 GroupName FROM Tbl_Component_Group
--		ORDER BY NEWID())
--	SET @tempTypeName = ( 
--		SELECT TOP 1 TypeName FROM Tbl_Component_Type
--		WHERE GroupName = @tempGroupName
--		ORDER BY NEWID())
--
--	INSERT INTO Tbl_Risk_Data
--	VALUES(1,2,'Brief action description','Event description','RiskReductionInfo','MinimalAdditionInfo',NULL)
--	INSERT INTO Tbl_Risk
--	VALUES(@AmountOfRisks,1,GETDATE(),@tempTypeName,@tempGroupName,(SELECT TOP 1 MAX(RiskDataID) FROM Tbl_Risk_Data) - 1)
--
--	INSERT INTO Tbl_ExposedPersons_In_Risk
--	VALUES(	(SELECT TOP 1 EP.ExposedPersonID FROM Tbl_ExposedPersons EP
--			ORDER BY NEWID()),@AmountOfRisks)
--
--	SET @AmountOfRisks = @AmountOfRisks + 1
--END  
GO
INSERT INTO Tbl_RiskReductionMeasures VALUES(0,NULL,'Calculate PL',NULL) --Calculate pl ALWAYS has to be the first record in the table.
INSERT INTO Tbl_RiskReductionMeasures VALUES(1,'Stickers','"Electronic hazard" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(2,'Stickers','"Hot area" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(3,'Stickers','"Laser light" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(4,'Stickers','"Moving parts" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(5,'Stickers','"No go area" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(6,'Instructions','Additional instruction (Service sheet)',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(7,'Instructions','Instruction in manual',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(8,'People protection','Body protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(9,'People protection','Face protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(10,'People protection','Ear protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(11,'People protection','Safety boots',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(12,'People protection','Safety gloves',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(13,'People protection','Safety goggles',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(14,'Technical protection','Guarding to reduces noise level',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(15,'Technical protection','Removed sharp edges',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(16,'Technical protection','Protective cover',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(17,'Technical protection','Safety switch',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(18,'Other','Acoustic warning',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(19,'Other','Education of personal',NULL)
GO
INSERT INTO Tbl_ExposedPersons VALUES(1,'Operator')
INSERT INTO Tbl_ExposedPersons VALUES(2,'Cleaner')
INSERT INTO Tbl_ExposedPersons VALUES(3,'Technician')
INSERT INTO Tbl_ExposedPersons VALUES(4,'Visitor')
INSERT INTO Tbl_ExposedPersons VALUES(5,'Trainee')
GO

SELECT * FROM Tbl_Risk
SELECT * FROM Tbl_Risks_In_Project
SELECT * FROM Tbl_Risk_Data
SELECT * FROM Tbl_RiskReduction_In_Risk
SELECT * FROM Tbl_Risk_Analysis