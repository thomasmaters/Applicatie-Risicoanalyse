USE LG_Analysis_Database
GO
--Groups
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Overall system');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Infeed system');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Cartoner system');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Casepacker system');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Palletizer system');
INSERT INTO Tbl_Component_Group([GroupName]) VALUES('Other systems');
--SubGroups
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Overall system','Electronics');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Overall system','Pneumatics');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Overall system','Hydraulics');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Overall system','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Overall system','Other overall');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Conveying of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Equalizing of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Dropping of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Sweeping of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Picking and placing of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Pushing of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Transport of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Checking of products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Infeed system','Other infeed');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Storage of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Erection of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Transport of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Filling of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Closing of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Coding of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Checking of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Conveying of cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Cartoner system','Other cartoner');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Storage of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Erection of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Transport of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Filling of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Closing of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Coding of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Checking of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Conveying of cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Casepacker system','Other casepacker');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Storage of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Transport of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Loading of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Wrapping of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Coding of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Checking of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Conveying of pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Palletizer system','Other casepacker');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Buffering cartons');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Buffering products');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Buffering cases');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Buffering pallets');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Integration of OEM');
INSERT INTO Tbl_Component_Type([GroupName],[TypeName]) VALUES('Other systems','Other');
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
INSERT INTO Tbl_User VALUES('M.v.Loon', 0x42 ,1)
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
INSERT INTO Tbl_Danger VALUES(1,'Mechanical hazard')
INSERT INTO Tbl_Danger VALUES(2,'Electrical harzard')
INSERT INTO Tbl_Danger VALUES(3,'Thermal hazard')
INSERT INTO Tbl_Danger VALUES(4,'Noise hazard')
INSERT INTO Tbl_Danger VALUES(5,'Vibration hazard')
INSERT INTO Tbl_Danger VALUES(6,'Radiation hazards')
INSERT INTO Tbl_Danger VALUES(7,'Material/substance hazard')
INSERT INTO Tbl_Danger VALUES(8,'Ergonomic hazard')
INSERT INTO Tbl_Danger VALUES(9,'Environmental hazard')
INSERT INTO Tbl_Danger VALUES(10,'Combination hazard')
GO
INSERT INTO Tbl_Danger_Result VALUES(1,'Any other as a consequence of a human error')
INSERT INTO Tbl_Danger_Result VALUES(2,'Any other as a consequence of an interference with speech communication or with acoustic signals')
INSERT INTO Tbl_Danger_Result VALUES(3,'Any other as a consequence of the effect caused by the sources of the hazards on the machine or parts of the machine')
INSERT INTO Tbl_Danger_Result VALUES(4,'Being run over')
INSERT INTO Tbl_Danger_Result VALUES(5,'Being thrown')
INSERT INTO Tbl_Danger_Result VALUES(6,'Breathing difficulties, suffocation')
INSERT INTO Tbl_Danger_Result VALUES(7,'Burn')
INSERT INTO Tbl_Danger_Result VALUES(8,'Cancer')
INSERT INTO Tbl_Danger_Result VALUES(9,'Chemical effects')
INSERT INTO Tbl_Danger_Result VALUES(10,'Corrosion')
INSERT INTO Tbl_Danger_Result VALUES(11,'Crushing')
INSERT INTO Tbl_Danger_Result VALUES(12,'Cutting or severing')
INSERT INTO Tbl_Danger_Result VALUES(13,'Damage to eyes and skin')
INSERT INTO Tbl_Danger_Result VALUES(14,'Dehydration')
INSERT INTO Tbl_Danger_Result VALUES(15,'Dehydration, loss of awareness, heat stroke')
INSERT INTO Tbl_Danger_Result VALUES(16,'Discomfort')
INSERT INTO Tbl_Danger_Result VALUES(17,'Drawing-in or trapping')
INSERT INTO Tbl_Danger_Result VALUES(18,'Effects on medical implants')
INSERT INTO Tbl_Danger_Result VALUES(19,'Effects on reproductive capability')
INSERT INTO Tbl_Danger_Result VALUES(20,'Electrocution')
INSERT INTO Tbl_Danger_Result VALUES(21,'Entanglement')
INSERT INTO Tbl_Danger_Result VALUES(22,'Explosion')
INSERT INTO Tbl_Danger_Result VALUES(23,'Falling, being thrown')
INSERT INTO Tbl_Danger_Result VALUES(24,'Fatigue')
INSERT INTO Tbl_Danger_Result VALUES(25,'Fire')
INSERT INTO Tbl_Danger_Result VALUES(26,'Friction or abrasion')
INSERT INTO Tbl_Danger_Result VALUES(27,'Frostbite')
INSERT INTO Tbl_Danger_Result VALUES(28,'Headache, insomnia, etc')
INSERT INTO Tbl_Danger_Result VALUES(29,'Impact')
INSERT INTO Tbl_Danger_Result VALUES(30,'Infection')
INSERT INTO Tbl_Danger_Result VALUES(31,'Injection')
INSERT INTO Tbl_Danger_Result VALUES(32,'Injuries by the radiation of heat sources')
INSERT INTO Tbl_Danger_Result VALUES(33,'Loss of awareness')
INSERT INTO Tbl_Danger_Result VALUES(34,'Loss of balance')
INSERT INTO Tbl_Danger_Result VALUES(35,'Low-back morbidity')
INSERT INTO Tbl_Danger_Result VALUES(36,'Musculoskeletal disorder')
INSERT INTO Tbl_Danger_Result VALUES(37,'Mutation')
INSERT INTO Tbl_Danger_Result VALUES(38,'Neurological disorder')
INSERT INTO Tbl_Danger_Result VALUES(39,'Osteo-articular disorder')
INSERT INTO Tbl_Danger_Result VALUES(40,'Permanent hearing loss')
INSERT INTO Tbl_Danger_Result VALUES(41,'Poisoning')
INSERT INTO Tbl_Danger_Result VALUES(42,'Potential consequences')
INSERT INTO Tbl_Danger_Result VALUES(43,'Projection of molten particles')
INSERT INTO Tbl_Danger_Result VALUES(44,'Scald')
INSERT INTO Tbl_Danger_Result VALUES(45,'Sensitization')
INSERT INTO Tbl_Danger_Result VALUES(46,'Shearing')
INSERT INTO Tbl_Danger_Result VALUES(47,'Shock')
INSERT INTO Tbl_Danger_Result VALUES(48,'Slight disease')
INSERT INTO Tbl_Danger_Result VALUES(49,'Slipping, falling')
INSERT INTO Tbl_Danger_Result VALUES(50,'Slipping, tripping and falling')
INSERT INTO Tbl_Danger_Result VALUES(51,'Stabbing or puncture')
INSERT INTO Tbl_Danger_Result VALUES(52,'Stress')
INSERT INTO Tbl_Danger_Result VALUES(53,'Suffocation')
INSERT INTO Tbl_Danger_Result VALUES(54,'Tinnitus')
INSERT INTO Tbl_Danger_Result VALUES(55,'Tiredness')
INSERT INTO Tbl_Danger_Result VALUES(56,'Trauma of the spine')
INSERT INTO Tbl_Danger_Result VALUES(57,'Vascular disorder')
GO --ID,Tbl_Danger,Danger source,Tbl_Danger_Result,Tbl_Danger_Result
INSERT INTO Tbl_Danger_Source VALUES(1,1,'Acceleration, deceleration',5,50)
INSERT INTO Tbl_Danger_Source VALUES(2,8,'Access',16,36)
INSERT INTO Tbl_Danger_Source VALUES(3,7,'Aerosol',45,6)
INSERT INTO Tbl_Danger_Source VALUES(4,1,'Angular parts',51,NULL)
INSERT INTO Tbl_Danger_Source VALUES(5,1,'Approach of a moving element to a fixed part',17,29)
INSERT INTO Tbl_Danger_Source VALUES(6,2,'Arc',7,43)
INSERT INTO Tbl_Danger_Source VALUES(7,7,'Biological and microbiological (viral or bacterial) agent',30,37)
INSERT INTO Tbl_Danger_Source VALUES(8,4,'Cavitation phenomena',2,16)
INSERT INTO Tbl_Danger_Source VALUES(9,5,'Cavitation phenomena',2,57)
INSERT INTO Tbl_Danger_Source VALUES(10,7,'Combustible',25,22)
INSERT INTO Tbl_Danger_Source VALUES(11,1,'Cutting parts',12,46)
INSERT INTO Tbl_Danger_Source VALUES(12,8,'Design or location of indicators and visual displays units',16,1)
INSERT INTO Tbl_Danger_Source VALUES(13,8,'Design, location or identification of control devices',16,1)
INSERT INTO Tbl_Danger_Source VALUES(14,7,'Dust',6,22)
INSERT INTO Tbl_Danger_Source VALUES(15,9,'Dust and fog',3,NULL)
INSERT INTO Tbl_Danger_Source VALUES(16,8,'Effort',24,NULL)
INSERT INTO Tbl_Danger_Source VALUES(17,1,'Elastic elements',21,NULL)
INSERT INTO Tbl_Danger_Source VALUES(18,9,'Electromagnetic disturbance',3,NULL)
INSERT INTO Tbl_Danger_Source VALUES(19,2,'Electromagnetic phenomena',18,NULL)
INSERT INTO Tbl_Danger_Source VALUES(20,2,'Electrostatic phenomena',47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(21,4,'Exhausting system',16,52)
INSERT INTO Tbl_Danger_Source VALUES(22,3,'Explosion',7,NULL)
INSERT INTO Tbl_Danger_Source VALUES(23,7,'Explosive',25,22)
INSERT INTO Tbl_Danger_Source VALUES(24,1,'Falling objects',11,29)
INSERT INTO Tbl_Danger_Source VALUES(25,7,'Fibre',37,8)
INSERT INTO Tbl_Danger_Source VALUES(26,3,'Flame',7,44)
INSERT INTO Tbl_Danger_Source VALUES(27,7,'Flammable',25,22)
INSERT INTO Tbl_Danger_Source VALUES(28,8,'Flicker, dazzling, shadow, stroboscopic effect',16,1)
INSERT INTO Tbl_Danger_Source VALUES(29,7,'Fluid',45,41)
INSERT INTO Tbl_Danger_Source VALUES(30,10,'Repetitive activity + effort + high environmental temperature',15,NULL)
INSERT INTO Tbl_Danger_Source VALUES(31,7,'Fume',45,41)
INSERT INTO Tbl_Danger_Source VALUES(32,7,'Gas',6,41)
INSERT INTO Tbl_Danger_Source VALUES(33,4,'Gas leaking at high speed',40,54)
INSERT INTO Tbl_Danger_Source VALUES(34,1,'Gravity',11,29)
INSERT INTO Tbl_Danger_Source VALUES(35,1,'Height from the ground',50,NULL)
INSERT INTO Tbl_Danger_Source VALUES(36,1,'High pressure',11,31)
INSERT INTO Tbl_Danger_Source VALUES(37,1,'Instability',50,NULL)
INSERT INTO Tbl_Danger_Source VALUES(38,6,'Ionizing radiation source',19,37)
INSERT INTO Tbl_Danger_Source VALUES(39,1,'Kinetic energy',11,29)
INSERT INTO Tbl_Danger_Source VALUES(40,9,'Lack of oxygen',53,NULL)
INSERT INTO Tbl_Danger_Source VALUES(41,9,'Lightning',3,7)
INSERT INTO Tbl_Danger_Source VALUES(42,2,'Live parts',20,47)
INSERT INTO Tbl_Danger_Source VALUES(43,8,'Local lighting',1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(44,6,'Low frequency electromagnetic radiation',28,NULL)
INSERT INTO Tbl_Danger_Source VALUES(45,1,'Machinery mobility',4,17)
INSERT INTO Tbl_Danger_Source VALUES(46,4,'Manufacturing process (stamping, cutting, etc)',40,54)
INSERT INTO Tbl_Danger_Source VALUES(47,8,'Mental overload/underload',24,52)
INSERT INTO Tbl_Danger_Source VALUES(48,5,'Misalignment of moving parts',16,NULL)
INSERT INTO Tbl_Danger_Source VALUES(49,7,'Mist',6,NULL)
INSERT INTO Tbl_Danger_Source VALUES(50,5,'Mobile equipment',35,56)
INSERT INTO Tbl_Danger_Source VALUES(51,9,'Moisture',3,NULL)
INSERT INTO Tbl_Danger_Source VALUES(52,1,'Moving elements',11,26)
INSERT INTO Tbl_Danger_Source VALUES(53,4,'Moving parts',33,34)
INSERT INTO Tbl_Danger_Source VALUES(54,2,'Not enough distance to live parts under high voltage',47,NULL)
INSERT INTO Tbl_Danger_Source VALUES(55,3,'Objects or materials with a high or low temperature',27,44)
INSERT INTO Tbl_Danger_Source VALUES(56,6,'Optical radiation (infrared, visible and ultraviolet), including laser',7,13)
INSERT INTO Tbl_Danger_Source VALUES(57,2,'Overload',9,25)
INSERT INTO Tbl_Danger_Source VALUES(58,7,'Oxidizer',10,25)
INSERT INTO Tbl_Danger_Source VALUES(59,2,'Parts which have become live under fault conditions',20,47)
INSERT INTO Tbl_Danger_Source VALUES(60,9,'Pollution',48,NULL)
INSERT INTO Tbl_Danger_Source VALUES(61,8,'Posture',16,36)
INSERT INTO Tbl_Danger_Source VALUES(62,3,'Radiation from heat sources',16,32)
INSERT INTO Tbl_Danger_Source VALUES(63,6,'Radio frequency electromagnetic radiation',28,NULL)
INSERT INTO Tbl_Danger_Source VALUES(64,8,'Repetitive activity',24,52)
INSERT INTO Tbl_Danger_Source VALUES(65,1,'Rotating elements',17,26)
INSERT INTO Tbl_Danger_Source VALUES(66,1,'Rough, slippery surface',26,50)
INSERT INTO Tbl_Danger_Source VALUES(67,4,'Scraping surfaces',52,55)
INSERT INTO Tbl_Danger_Source VALUES(68,5,'Scraping surfaces',16,NULL)
INSERT INTO Tbl_Danger_Source VALUES(69,1,'Sharp edges',12,NULL)
INSERT INTO Tbl_Danger_Source VALUES(70,2,'Short-circuit',9,25)
INSERT INTO Tbl_Danger_Source VALUES(71,9,'Snow',49,NULL)
INSERT INTO Tbl_Danger_Source VALUES(72,1,'Stored energy',29,NULL)
INSERT INTO Tbl_Danger_Source VALUES(73,9,'Temperature',7,NULL)
INSERT INTO Tbl_Danger_Source VALUES(74,2,'Thermal radiation',7,25)
INSERT INTO Tbl_Danger_Source VALUES(75,4,'Unbalanced rotating parts',16,52)
INSERT INTO Tbl_Danger_Source VALUES(76,5,'Unbalanced rotating parts',16,38)
INSERT INTO Tbl_Danger_Source VALUES(77,1,'Vacuum',53,NULL)
INSERT INTO Tbl_Danger_Source VALUES(78,5,'Vibrating equipment',38,39)
INSERT INTO Tbl_Danger_Source VALUES(79,8,'Visibility',1,NULL)
INSERT INTO Tbl_Danger_Source VALUES(80,9,'Water',49,NULL)
INSERT INTO Tbl_Danger_Source VALUES(81,4,'Whistling pneumatics',2,16)
INSERT INTO Tbl_Danger_Source VALUES(82,9,'Wind',3,NULL)
INSERT INTO Tbl_Danger_Source VALUES(83,4,'Worn parts',52,55)
INSERT INTO Tbl_Danger_Source VALUES(84,5,'Worn parts',16,NULL)
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
INSERT INTO Tbl_RiskReductionMeasures VALUES(1,'Sticker','"Electronic hazard" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(2,'Sticker','"Hot area" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(3,'Sticker','"Laser light" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(4,'Sticker','"Moving parts" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(5,'Sticker','"No go area" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(6,'Sticker','"Lock out" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(7,'Sticker','"Slippery surface" sticker',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(8,'Personel protective equipment','Body protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(9,'Personel protective equipment','Face protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(10,'Personel protective equipment','Hearing protection',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(11,'Personel protective equipment','Safety boots',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(12,'Personel protective equipment','Safety gloves',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(13,'Personel protective equipment','Safety goggles',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(14,'Technical protection','Guarding to reduces noise level',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(15,'Technical protection','Removed sharp edges',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(16,'Technical protection','Protective cover',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(17,'Technical protection','Safety switch',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(18,'Warning','Acoustic signal',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(19,'Warning','Visual signal',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(20,'Warning','Operating screen',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(21,'Instruction','General safety instruction',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(22,'Instruction','Basic machine training',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(23,'Instruction','Intermediate machine training',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(24,'Instruction','Advanced machine training',NULL)
INSERT INTO Tbl_RiskReductionMeasures VALUES(25,'Instruction','Instruction in manual',NULL)
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