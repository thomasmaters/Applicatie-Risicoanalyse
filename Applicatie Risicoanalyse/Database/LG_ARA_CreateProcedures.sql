USE LG_Analysis_Database
GO
CREATE FUNCTION Get_Latest_Versions_Of_Risks()
RETURNS TABLE
AS
RETURN
(
	SELECT SubR.*
	FROM Tbl_Risk SubR
	INNER JOIN (SELECT RiskID, MAX(VersionID) AS MaxVersionID FROM Tbl_Risk GROUP BY RiskID) groupped
	ON SubR.RiskID = groupped.RiskID
	AND SubR.VersionID = groupped.MaxVersionID
);
GO
-----------------------------------
--Purpose: Get projects with project revision from tbl_Risk_Analysis
-----------------------------------
CREATE FUNCTION Get_Projects_With_Revision()
RETURNS TABLE
AS
RETURN(
	SELECT RA.ProjectID, RA.StateName, RA.Customer, RA.MachineType, RA.MachineNumber, P.LatestActivity, RA.OrderNumber,P.Revision, P.DateCreated
	FROM Tbl_Risk_Analysis RA LEFT JOIN Tbl_Project P ON RA.ProjectID = P.ProjectID
	);
GO
-----------------------------------
--Purpose:	Updates connection between a project and his its risks based on
--			the project state and the availabilty of a new version of a risk.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Update_Risks_In_Open_Risk_Projects
AS
BEGIN
	UPDATE Tbl_Risks_In_Project
	SET VersionID = (SELECT TOP 1 R.VersionID FROM Tbl_Risk R WHERE R.RiskID = Tbl_Risks_In_Project.RiskID ORDER BY R.VersionID DESC)
	,ReviewedByUser = NULL
	WHERE (SELECT TOP 1 RA.StateName FROM Tbl_Risk_Analysis RA WHERE RA.ProjectID = Tbl_Risks_In_Project.ProjectID) = 'DRAFT'
		AND (SELECT TOP 1 R.VersionID FROM Tbl_Risk R WHERE R.RiskID = Tbl_Risks_In_Project.RiskID ORDER BY R.VersionID DESC) != Tbl_Risks_In_Project.VersionID
		AND RiskDataID IS NULL
END
GO
-----------------------------------
--Purpose:	Get recent opend/edited risk projects.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Recent_Risk_Projects(@AmountOfResults AS INT)
AS
BEGIN
	SELECT TOP(20) *
	FROM Tbl_Project P
	LEFT JOIN Tbl_Risk_Analysis RA ON P.ProjectID = RA.ProjectID
	ORDER BY P.LatestActivity DESC
END
GO
-----------------------------------
--Purpose:	Creates a new project.
--ERROR CODES:
--1999 Succes!
-----------------------------------
CREATE PROCEDURE Create_RiskProject(@userID AS INT, @customer AS VARCHAR(64), @machineType AS VARCHAR(32),
@machineNumber AS CHAR(8),@orderNumber AS CHAR(8), @extraInfo AS VARCHAR(512))
AS
BEGIN
	IF(LEN(@extraInfo) = 0)
		SET @extraInfo = NULL

	--Create new project
	INSERT INTO Tbl_Project(Revision,LatestActivity, DateCreated,UserID,RevisionOfID)
	VALUES(1,GETDATE(), GETDATE(),@userID, NULL)

	DECLARE @newProjectID INT
	--Get projectID from new project.
	SET @newProjectID = (	SELECT MAX(P.ProjectID)
							FROM Tbl_Project P)

	--Link the project to a risk project.
	INSERT INTO Tbl_Risk_Analysis(ProjectID,StateName,Customer,MachineType,MachineNumber,OrderNumber,Info,DraftVersion)
	VALUES(@newProjectID,'DRAFT',@customer,@machineType,@machineNumber,@orderNumber,@extraInfo,1)
	
	RETURN 1999
END
GO
-----------------------------------
--Purpose:	Counts the amount of risks in a project with a specific group.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Risks_In_Project_Group(@projectID AS INT, @groupName AS VARCHAR(64))
AS
BEGIN
	SELECT COUNT(DISTINCT PR.RiskID) AS RisksInProjectGroup,(
		SELECT COUNT(DISTINCT RiskID) 
		FROM Get_Latest_Versions_Of_Risks() AS R
		WHERE R.GroupName = @groupName) AS RisksInGroup
	FROM Tbl_Risks_In_Project PR
	LEFT JOIN Get_Latest_Versions_Of_Risks() AS R ON PR.RiskID = R.RiskID
	WHERE PR.ProjectID = @projectID AND R.GroupName = @groupName
END
GO
-----------------------------------
--Purpose:	Counts the amount of risks in a project with a specific group and type.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Risks_In_Project_Type(@projectID AS INT, @groupName AS VARCHAR(64), @typeName AS VARCHAR(64))
AS
BEGIN
	SELECT COUNT(DISTINCT PR.RiskID) AS RisksInProjectGroup,(
		SELECT COUNT(DISTINCT RiskID) 
		FROM Get_Latest_Versions_Of_Risks() AS R
		WHERE R.GroupName = @groupName AND R.TypeName = @typeName) AS RisksInGroup
	FROM Tbl_Risks_In_Project PR
	LEFT JOIN Get_Latest_Versions_Of_Risks() AS R ON PR.RiskID = R.RiskID
	WHERE PR.ProjectID = @projectID AND R.GroupName = @groupName AND R.TypeName = @typeName
END
GO
-----------------------------------
--Purpose:	Gets the risks in a project with a specific group and type.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Risks_In_ProjectGroupType(@projectID AS INT, @groupName AS VARCHAR(64), @typeName AS VARCHAR(64))
AS
BEGIN
	SELECT DISTINCT(R.RiskID),R.VersionID,RD.HazardSituation,BS.FileObject, CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_Risks_In_Project
                                    WHERE RiskID = R.RiskID AND ProjectID = @projectID AND VersionID = R.VersionID)
                     THEN 1 ELSE 0
                   END AS InProject
	FROM Get_Latest_Versions_Of_Risks() AS R LEFT JOIN Tbl_Risk_Data RD ON RD.RiskDataID = R.RiskDataID LEFT JOIN Tbl_BLOB_Storage BS ON RD.FileID = BS.FileID
	WHERE R.GroupName = @groupName AND R.TypeName = @typeName
END
GO
-----------------------------------
--Purpose:	Inserts new risk with its latest version in project risks table. 
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Insert_In_ProjectRisks(@projectID AS INT, @riskID AS INT)
AS
BEGIN
	IF NOT EXISTS(SELECT *
	FROM Tbl_Risks_In_Project AS R
	WHERE R.RiskID = @riskID AND R.ProjectID = @projectID ) BEGIN

		INSERT INTO Tbl_Risks_In_Project
		SELECT @projectID, R.VersionID, @riskID,NULL,NULL ,NULL
		FROM Get_Latest_Versions_Of_Risks() AS R
		WHERE R.RiskID = @riskID
	END
END
GO
-----------------------------------
--Purpose:	Gets the newest add project in the database.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Newest_Added_Project
AS
BEGIN
	SELECT TOP 1 MAX(ProjectID) AS NewestProject
	FROM Tbl_Project
END
GO
-----------------------------------
--Purpose:	Deletes specific risk in project.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Delete_From_ProjectRisks(@projectID AS INT, @riskID AS INT)
AS
BEGIN
	DELETE FROM Tbl_Risks_In_Project
	WHERE ProjectID = @projectID AND RiskID = @riskID
END
GO
-----------------------------------
--Purpose:	Selects all risks sorted by there group and type name.
--ERROR CODES:
-----------------------------------
CREATE FUNCTION Select_Add_Risk_To_Project_Data()
RETURNS TABLE
AS
RETURN(
	SELECT CT.GroupName,CT.TypeName,R.RiskID,R.VersionID
	FROM Tbl_Component_Type CT LEFT JOIN Get_Latest_Versions_Of_Risks() AS R ON  CT.GroupName = R.GroupName AND CT.TypeName = R.TypeName
);
GO
-----------------------------------
--Purpose:	Adds or removes all risks from a specific type from a project.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Insert_Risks_From_Type_Into_Project(@projectID AS INT,@groupName AS VARCHAR(64), @typeName AS VARCHAR(64), @deleteOrInsert AS BIT)
AS
BEGIN
	DECLARE @riskID INT
	DECLARE cur CURSOR LOCAL FOR
		SELECT R.RiskID FROM Get_Latest_Versions_Of_Risks() AS R WHERE R.TypeName = @typeName AND R.GroupName = @groupName

	OPEN cur

	FETCH NEXT FROM cur INTO @riskID

	while @@FETCH_STATUS = 0 BEGIN
		IF @deleteOrInsert = 1 BEGIN
			EXEC Insert_In_ProjectRisks @projectID, @riskID
		END
		IF @deleteOrInsert = 0 BEGIN
			EXEC Delete_From_ProjectRisks @projectID, @riskID
		END

		FETCH NEXT FROM cur INTO @riskID
	END

	CLOSE cur
	DEALLOCATE cur
END
GO
-----------------------------------
--Purpose:	Check if risk is in a project.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Is_Risk_In_Project(@projectID AS INT, @riskID AS INT)
AS
BEGIN
	SELECT TOP 1 COUNT(PR.RiskID) AS InProject FROM Tbl_Risks_In_Project PR WHERE PR.ProjectID = @projectID AND PR.RiskID = @riskID
END
GO
-----------------------------------
--Purpose:	Executes a searchquery on risks that are in a specific project.
-----------------------------------
CREATE PROCEDURE Search_Risks_In_Project(@projectID AS INT, @searchString AS VARCHAR(64))
AS
BEGIN
	SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_Risks_In_Project PR
                                    WHERE PR.ProjectID = @projectID AND InnerTable.RiskID = PR.RiskID)
                     THEN 1 ELSE 0
                   END AS InProject
	FROM (
		SELECT R.RiskID,R.VersionID,R.TypeName,R.GroupName,R.RiskDataID AS DefaultRiskDataID,RP.RiskDataID AS ProjectRiskDataID,HazardSituation = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END
		FROM Get_Latest_Versions_Of_Risks() AS R LEFT JOIN Tbl_Risks_In_Project RP ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID AND RP.ProjectID = @projectID
	) AS InnerTable
	WHERE TypeName LIKE '%' + @searchString + '%' 
	OR GroupName LIKE '%' + @searchString + '%'
	OR HazardSituation LIKE '%' + @searchString + '%'
	OR RiskID LIKE @searchString
END
GO
-----------------------------------
--Purpose:	Gets component subgroup from group name.
-----------------------------------
CREATE PROCEDURE Get_TypeNames_In_Group(@groupName AS VARCHAR(64))
AS
BEGIN
	SELECT TypeName
	FROM Tbl_Component_Type CT
	WHERE CT.GroupName = @groupName
END
GO
-----------------------------------
--Purpose:	Get risk estimation data attached to riskdata.
-----------------------------------
CREATE PROCEDURE Get_RiskEstimation_In_RiskData_After(@riskDataID AS INT)
AS
BEGIN
SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_RiskEstimation_In_Risk_After
                                    WHERE EstimationID = RE.EstimationID AND RiskDataID = @riskDataID)
                     THEN 1 ELSE 0
                   END AS InProject
FROM Tbl_RiskEstimation RE 
END
GO
-----------------------------------
--Purpose:  Get risk estimation data attached to riskdata.
-----------------------------------
CREATE PROCEDURE Get_RiskEstimation_In_RiskData_Before(@riskDataID AS INT)
AS
BEGIN
SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_RiskEstimation_In_Risk_Before
                                    WHERE EstimationID = RE.EstimationID AND RiskDataID = @riskDataID)
                     THEN 1 ELSE 0
                   END AS InProject
FROM Tbl_RiskEstimation RE 
END
GO
-----------------------------------
--Purpose:	Get risk reduction data attached to riskdata.
-----------------------------------
CREATE PROCEDURE Get_RiskReduction_In_RiskData(@riskDataID AS INT)
AS
BEGIN
SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_RiskReduction_In_Risk
                                    WHERE MeasureID = RM.MeasureID AND RiskDataID = @riskDataID)
                     THEN 1 ELSE 0
                   END AS InProject
FROM Tbl_RiskReductionMeasures RM 
END
GO
-----------------------------------
--Purpose:	Get minimaladdition data attached to riskdata.
-----------------------------------
CREATE PROCEDURE Get_MinimalAddition_In_RiskData(@riskDataID AS INT)
AS
BEGIN
SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_MinimalAddition_In_Risk
                                    WHERE MeasureID = RM.MeasureID AND RiskDataID = @riskDataID)
                     THEN 1 ELSE 0
                   END AS InProject
FROM Tbl_RiskReductionMeasures RM 
END
GO
-----------------------------------
--Purpose:	Get exposed persons attached to riskdata.
-----------------------------------
CREATE PROCEDURE Get_ExposedPersons_In_RiskData(@riskDataID AS INT)
AS
BEGIN
SELECT *,CASE WHEN EXISTS(SELECT 1
                                    FROM  Tbl_ExposedPersons_In_Risk
                                    WHERE ExposedPersonID = EP.ExposedPersonID AND RiskDataID = @riskDataID)
                     THEN 1 ELSE 0
                   END AS InProject
FROM Tbl_ExposedPersons EP 
END
GO
-----------------------------------
--Purpose:	Insert record in riskestimation.
-----------------------------------
CREATE PROCEDURE Insert_Into_RiskEstimation_Before(@riskDataID AS INT, @estimationID AS INT, @groupName AS VARCHAR(64))
AS
BEGIN
	IF NOT EXISTS(SELECT *
	FROM Tbl_RiskEstimation_In_Risk_Before RE
	WHERE RE.RiskDataID = @riskDataID AND RE.GroupName = @groupName) 
	AND EXISTS(SELECT *
	FROM Tbl_RiskEstimation RE
	WHERE RE.EstimationID = @estimationID AND RE.GroupName = @groupName)

		INSERT INTO Tbl_RiskEstimation_In_Risk_Before
		VALUES(@riskDataID,@estimationID,@groupName);
	ELSE
		IF EXISTS(SELECT *
		FROM Tbl_RiskEstimation RE
		WHERE RE.EstimationID = @estimationID AND RE.GroupName = @groupName)

			UPDATE Tbl_RiskEstimation_In_Risk_Before
			SET EstimationID = @estimationID
			WHERE RiskDataID = @riskDataID AND GroupName = @groupName;
END
GO
-----------------------------------
--Purpose:	Insert record in riskestimation.
-----------------------------------
CREATE PROCEDURE Insert_Into_RiskEstimation_After(@riskDataID AS INT, @estimationID AS INT, @groupName AS VARCHAR(64))
AS
BEGIN
	IF NOT EXISTS(SELECT *
	FROM Tbl_RiskEstimation_In_Risk_After RE
	WHERE RE.RiskDataID = @riskDataID AND RE.GroupName = @groupName) 
	AND EXISTS(SELECT *
	FROM Tbl_RiskEstimation RE
	WHERE RE.EstimationID = @estimationID AND RE.GroupName = @groupName)

		INSERT INTO Tbl_RiskEstimation_In_Risk_After
		VALUES(@riskDataID,@estimationID,@groupName);
	ELSE
		IF EXISTS(SELECT *
		FROM Tbl_RiskEstimation RE
		WHERE RE.EstimationID = @estimationID AND RE.GroupName = @groupName)

			UPDATE Tbl_RiskEstimation_In_Risk_After
			SET EstimationID = @estimationID
			WHERE RiskDataID = @riskDataID AND GroupName = @groupName;
END
GO
-----------------------------------
--Purpose:	Insert danger into risk.
-----------------------------------
CREATE PROCEDURE Insert_Danger_In_RiskData(@riskDataID AS INT, @dangerID AS INT, 
	@dangerSourceID AS INT, @hazardSituation AS VARCHAR(255), @hazardEvent AS VARCHAR(1024))
AS
BEGIN
		IF EXISTS(SELECT *
		FROM Tbl_Risk_Data RD
		WHERE RD.RiskDataID = @riskDataID) BEGIN

			UPDATE Tbl_Risk_Data
			SET HazardSituation = @hazardSituation
			,HazardEvent = @hazardEvent
			,DangerID = @dangerID
			,DangerSourceID = @dangerSourceID
			WHERE RiskDataID = @riskDataID
		END
END
GO
-----------------------------------
--Purpose:	Attach picture to riskdata.
-----------------------------------
CREATE PROCEDURE Insert_Picture_Into_Risk(@riskDataID AS INT, @objectData AS VARBINARY(MAX))
AS
BEGIN
		DECLARE @fileID INT
		SET @fileID = (SELECT TOP 1 MAX(FileID) FROM Tbl_BLOB_Storage)
		
		INSERT INTO Tbl_BLOB_Storage
		VALUES(@fileID + 1,@objectData)



		UPDATE Tbl_Risk_Data
		SET FileID = @fileID
		WHERE RiskDataID = @riskDataID
END
GO
-----------------------------------
--Purpose:	Search query for searching risks and also selecting looking if it is in a project.
-----------------------------------
CREATE PROCEDURE Search_ProjectRisks(@projectID AS INT, @searchString AS VARCHAR(255))
AS
BEGIN
	SELECT * 
	FROM (
		SELECT R.RiskID,R.VersionID,RP.ReviewedByUser, R.TypeName,R.GroupName,R.RiskDataID AS DefaultRiskDataID,RP.RiskDataID AS ProjectRiskDataID,HazardSituation = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END
		FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
		WHERE RP.ProjectID = @projectID
	) AS InnerTable
	WHERE TypeName LIKE '%' + @searchString + '%' 
	OR GroupName LIKE '%' + @searchString + '%'
	OR HazardSituation LIKE '%' + @searchString + '%'
	OR RiskID LIKE @searchString
END
GO
-----------------------------------
--Purpose:	Get riskdataid from a risk connected to a project.
-----------------------------------
CREATE PROCEDURE Get_RiskDataID_From_Risks_In_Project(@projectID AS INT, @riskID AS INT)
AS
BEGIN
	SELECT RiskDataID
	FROM Tbl_Risks_In_Project
	WHERE ProjectID = @projectID
	AND RiskID = @riskID
END
GO
-----------------------------------
--Purpose:	Copy riskdata and all of its components in other tables.
-----------------------------------
CREATE PROCEDURE Copy_RiskData_From_RiskDataID(@oldRiskDataID AS INT, @userID AS INT)
AS
BEGIN
	DECLARE @newRiskDataID INT

SET @newRiskDataID = (SELECT TOP 1 MAX(RiskDataID) FROM Tbl_Risk_Data)

	INSERT INTO Tbl_Risk_Data
	SELECT @newRiskDataID + 1,DangerID,DangerSourceID,HazardSituation,HazardEvent,@userID,RiskReductionInfo,MinimalAdditionInfo,FileID
	FROM Tbl_Risk_Data
	WHERE RiskDataID = @oldRiskDataID

	SET @newRiskDataID = (SELECT TOP 1 MAX(RiskDataID) FROM Tbl_Risk_Data)

	SELECT @newRiskDataID AS newRiskDataID

	INSERT INTO Tbl_ExposedPersons_In_Risk
	SELECT ExposedPersonID,@newRiskDataID
	FROM Tbl_ExposedPersons_In_Risk
	WHERE RiskDataID = @oldRiskDataID

	INSERT INTO Tbl_RiskEstimation_In_Risk_After
	SELECT @newRiskDataID,EstimationID,GroupName
	FROM Tbl_RiskEstimation_In_Risk_After
	WHERE RiskDataID = @oldRiskDataID

	INSERT INTO Tbl_RiskEstimation_In_Risk_Before
	SELECT @newRiskDataID,EstimationID,GroupName
	FROM Tbl_RiskEstimation_In_Risk_Before
	WHERE RiskDataID = @oldRiskDataID

	INSERT INTO Tbl_RiskReduction_In_Risk
	SELECT MeasureID,@newRiskDataID
	FROM Tbl_RiskReduction_In_Risk
	WHERE RiskDataID = @oldRiskDataID

	INSERT INTO Tbl_MinimalAddition_In_Risk
	SELECT MeasureID,@newRiskDataID
	FROM Tbl_MinimalAddition_In_Risk
	WHERE RiskDataID = @oldRiskDataID
END
GO
-----------------------------------
--Purpose:	Sets a risk project specific.
-----------------------------------
CREATE PROCEDURE Update_RiskDataID_In_RisksInProject(@projectID AS INT, @riskID AS INT, @userID AS INT)
AS
BEGIN
	DECLARE @riskDataID INT
	--Get riskdataid assosiated with the riskid.
	SET @riskDataID = (SELECT TOP 1 RiskDataID FROM Get_Latest_Versions_Of_Risks() WHERE RiskID = @riskID)
	--Copy that risk data.
	EXECUTE Copy_RiskData_From_RiskDataID @riskDataID,@userID

	UPDATE Tbl_Risks_In_Project
	SET RiskDataID = (SELECT TOP 1 MAX(RiskDataID) FROM Tbl_Risk_Data),
	ReviewedByUser = NULL
	WHERE ProjectID = @projectID
	AND RiskID = @riskID
END
GO
-----------------------------------
--Purpose:	Get risks that in a specific group and type and that are connected to the project.
--ERROR CODES:
-----------------------------------
CREATE PROCEDURE Get_Risks_With_Type_And_Group_In_Project(@projectID AS INT, @groupName AS VARCHAR(64), @typeName AS VARCHAR(64))
AS
BEGIN
	SELECT R.RiskID, R.VersionID, R.RiskDataID AS DefaultRiskDataID, RP.RiskDataID AS ProjectRiskDataID
	FROM Tbl_Risk AS R LEFT JOIN Tbl_Risks_In_Project RP ON R.VersionID = RP.VersionID AND R.RiskID = RP.RiskID
	WHERE RP.ProjectID = @projectID AND R.GroupName = @groupName AND R.TypeName = @typeName
END
GO
-----------------------------------
--Purpose:	Updates riskreductioninfo in riskdata record.
-----------------------------------
CREATE PROCEDURE Update_RiskReductionInfo_In_RiskData(@riskDataID AS INT, @riskReductionInfo AS VARCHAR(1024))
AS
BEGIN
	UPDATE Tbl_Risk_Data
	SET RiskReductionInfo = @riskReductionInfo
	WHERE RiskDataID = @riskDataID
END
GO
-----------------------------------
--Purpose:	Updates minimaladditioninfo in riskdata record.
-----------------------------------
CREATE PROCEDURE Update_MinimalAdditionInfo_In_RiskData(@riskDataID AS INT, @riskReductionInfo AS VARCHAR(1024))
AS
BEGIN
	UPDATE Tbl_Risk_Data
	SET MinimalAdditionInfo = @riskReductionInfo
	WHERE RiskDataID = @riskDataID
END
GO
-----------------------------------
--Purpose:	Searches the risk standard.
-----------------------------------
CREATE PROCEDURE Search_Risk_Standard(@searchString AS VARCHAR(64))
AS
BEGIN
	SELECT R.RiskID,R.VersionID,R.RiskDataID,R.GroupName,R.TypeName,RD.HazardSituation
	FROM Get_Latest_Versions_Of_Risks() AS R LEFT JOIN Tbl_Risk_Data RD ON R.RiskDataID = RD.RiskDataID
	WHERE TypeName LIKE '%' + @searchString + '%' 
	OR GroupName LIKE '%' + @searchString + '%'
	OR HazardSituation LIKE '%' + @searchString + '%'  
	OR RiskID LIKE @searchString
END
GO
-----------------------------------
--Purpose:	Creates a new version of a risk and copies its data, so the original stays untouched.
-----------------------------------
CREATE PROCEDURE Create_New_Risk_Version(@riskID AS INT,@versionID AS INT, @oldRiskDataID AS INT, @userID AS INT)
AS
BEGIN
	IF NOT EXISTS(SELECT TOP 1 R.RiskID FROM Tbl_Risk R WHERE R.RiskID = @riskID AND R.VersionID = @versionID + 1) BEGIN
	
		EXECUTE Copy_RiskData_From_RiskDataID @oldRiskDataID, @userID

		SET IDENTITY_INSERT Tbl_Risk ON

		INSERT INTO Tbl_Risk(RiskID,VersionID,DateCreated,TypeName,GroupName,RiskDataID)
		SELECT @riskID,@versionID + 1,GETDATE(),R.TypeName,R.GroupName,(SELECT MAX(RiskDataID) FROM Tbl_Risk_Data)
		FROM Tbl_Risk R
		WHERE R.RiskID = @riskID AND R.VersionID = @versionID

		SET IDENTITY_INSERT Tbl_Risk OFF
	END
END
GO
-----------------------------------
--Purpose:	Get risk with a specific group and type.
-----------------------------------
CREATE PROCEDURE Get_Risks_In_Group_And_Type(@groupName AS VARCHAR(64), @typeName AS VARCHAR(64))
AS
BEGIN
	SELECT *
	FROM Get_Latest_Versions_Of_Risks() AS R
	WHERE R.GroupName = @groupName AND R.TypeName = @typeName
END
GO
-----------------------------------
--Purpose:	Creates a new risk
-----------------------------------
CREATE PROCEDURE Create_New_Risk(@userID AS INT)
AS
BEGIN
	DECLARE @tempGroupName VARCHAR(128)
	DECLARE @tempTypeName VARCHAR(128)
	SET @tempGroupName = ( 
		SELECT TOP 1 GroupName FROM Tbl_Component_Group
		ORDER BY NEWID())
	SET @tempTypeName = ( 
		SELECT TOP 1 TypeName FROM Tbl_Component_Type
		WHERE GroupName = @tempGroupName
		ORDER BY NEWID())

	DECLARE @newRiskDataID INT
	SET @newRiskDataID = (SELECT TOP 1 MAX(RiskDataID) FROM Tbl_Risk_Data)

	INSERT INTO Tbl_Risk_Data
	VALUES(@newRiskDataID + 1,1,1,'','',@userID,'','',NULL)

	DECLARE @newRiskID INT
	SET @newRiskID = (SELECT TOP 1 MAX(RiskID) FROM Tbl_Risk)

	INSERT INTO Tbl_Risk
	VALUES(@newRiskID + 1,1,GETDATE(),@tempTypeName,@tempGroupName,(SELECT MAX(RiskDataID) FROM Tbl_Risk_Data))

	SELECT (SELECT MAX(RiskID) FROM Tbl_Risk) AS NewRiskID,(SELECT MAX(RiskDataID) FROM Tbl_Risk_Data) AS NewRiskDataID
END
GO
-----------------------------------
--Purpose:	Updates component group and type in riskdata record.
-----------------------------------
CREATE PROCEDURE Update_ComponentTypeAndGroup_In_Risk(@riskID AS INT, @versionID AS INT, @groupName AS VARCHAR(64), @typeName AS VARCHAR(64))
AS
BEGIN
	UPDATE Tbl_Risk
	SET GroupName = @groupName,TypeName = @typeName
	WHERE RiskID = @riskID AND VersionID = @versionID
END
GO
-----------------------------------
--Purpose:	Deletes a risk and all of its connections in other tables.
-----------------------------------
CREATE PROCEDURE Delete_Risk(@riskID AS INT, @riskDataID AS INT)
AS
BEGIN
	DELETE FROM Tbl_RiskReduction_In_Risk
	WHERE RiskDataID = @riskDataID

	DELETE FROM Tbl_MinimalAddition_In_Risk
	WHERE RiskDataID = @riskDataID

	DELETE FROM Tbl_ExposedPersons_In_Risk
	WHERE RiskDataID = @riskDataID

	DELETE FROM Tbl_RiskEstimation_In_Risk_After
	WHERE RiskDataID = @riskDataID

	DELETE FROM Tbl_RiskEstimation_In_Risk_Before
	WHERE RiskDataID = @riskDataID

	DELETE FROM Tbl_Risk
	WHERE RiskID = @riskID

	DELETE FROM Tbl_Risk_Data
	WHERE RiskDataID = @riskDataID
END
GO
-----------------------------------
--Purpose:	Get some basic riskdata.
-----------------------------------
CREATE PROCEDURE Get_Risks_With_RiskData_In_Project(@projectID AS INT)
AS
BEGIN
		SELECT RP.ProjectID,R.RiskID,R.VersionID,R.TypeName,R.GroupName,RP.ReviewedByUser, R.RiskDataID AS DefaultRiskDataID,RP.RiskDataID AS ProjectRiskDataID,HazardSituation = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END
		FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
		WHERE RP.ProjectID = @projectID
END
GO
-----------------------------------
--Get all the remaining risks in a specific project.
-----------------------------------
CREATE PROCEDURE Get_RemainingRisks_In_Project(@projectID AS INT)
AS
BEGIN
		SELECT RD.HazardEvent, RD.HazardSituation, kaas.GroupName, kaas.TypeName, kaas.RiskDataID, kaas.RiskID 
		FROM Tbl_Risk_Data RD LEFT JOIN
			(SELECT R.RiskID, R.GroupName, R.TypeName, RiskDataID = CASE WHEN RP.RiskDataID IS NULL THEN R.RiskDataID ELSE RP.RiskDataID END
			FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
			WHERE RP.ProjectID = @projectID ) AS kaas ON kaas.riskDataID = RD.RiskDataID
		
		WHERE RD.RiskDataID IN
			(SELECT riskDataID = CASE WHEN RP.RiskDataID IS NULL THEN R.RiskDataID ELSE RP.RiskDataID END
			FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
			WHERE RP.ProjectID = @projectID ) 
		AND(DATALENGTH(RD.MinimalAdditionInfo) > 0 
		OR EXISTS(SELECT * FROM Tbl_MinimalAddition_In_Risk MA WHERE MA.RiskDataID = RD.RiskDataID))
END
GO
-----------------------------------
--Increase Draftversion number from a project.
-----------------------------------
CREATE PROCEDURE Increase_Project_DraftVersion(@projectID AS INT)
AS
BEGIN
	IF EXISTS(SELECT * 
	FROM Tbl_Risk_Analysis RA LEFT JOIN Tbl_Risk_Project_State RPS ON RA.StateName = RPS.StateName
	WHERE RA.ProjectID = @projectID AND RA.StateName = 'DRAFT') BEGIN
		DECLARE @DraftVersion TINYINT
		SET @DraftVersion = (SELECT TOP 1 DraftVersion FROM Tbl_Risk_Analysis WHERE ProjectID = @projectID)

		IF @DraftVersion IS NOT NULL
			UPDATE Tbl_Risk_Analysis
			SET DraftVersion = @DraftVersion + 1
			WHERE ProjectID = @projectID

		IF @DraftVersion IS NULL
			UPDATE Tbl_Risk_Analysis
			SET DraftVersion = 0
			WHERE ProjectID = @projectID
	END
END
GO
-----------------------------------
--Updates a project state. When its set to draft, the risks lose there reviewer.
-----------------------------------
CREATE PROCEDURE Update_Project_State(@projectID INT, @projectState VARCHAR(64))
AS
BEGIN
	IF ((SELECT COUNT(ProjectID) FROM Tbl_Risks_In_Project WHERE ProjectID = @projectID) > 0) BEGIN
		UPDATE Tbl_Risk_Analysis
		SET StateName = @projectState
		WHERE ProjectID = @projectID

		--When the project state changes to FORREVIEW set all risks as not reviewed.
		--TODO Is this necessary?
		IF @projectState = 'FORREVIEW'
			UPDATE Tbl_Risks_In_Project
			SET ReviewerComment = NULL
			WHERE ProjectID = @projectID
	END
END
GO
-----------------------------------
--Did the review accept the risks in the project?
-----------------------------------
CREATE PROCEDURE Is_ProjectReview_Accepted(@projectID INT)
AS
BEGIN
	IF EXISTS(SELECT *
	FROM Tbl_Risks_In_Project
	WHERE ProjectID = @projectID
	AND ReviewedByUser IS NULL)
		SELECT 0 AS IsProjectReviewAccepted
	ELSE
		SELECT 1 AS IsProjectReviewAccepted
END
GO
-----------------------------------
--Marks the risk in a project as reviewed.
-----------------------------------
CREATE PROCEDURE Set_Risk_In_Project_Reviewed(@projectID INT, @riskID INT, @userID INT, @reviewerComment VARCHAR(512))
AS
BEGIN
	IF @userID = -1
		UPDATE Tbl_Risks_In_Project
		SET ReviewedByUser = NULL,
		ReviewerComment = @reviewerComment
		WHERE ProjectID = @projectID
		AND RiskID = @riskID
	ELSE
		UPDATE Tbl_Risks_In_Project
		SET ReviewedByUser = @userID,
		ReviewerComment = @reviewerComment
		WHERE ProjectID = @projectID
		AND RiskID = @riskID
END
GO
-----------------------------------
--Get all risks in a project.
-----------------------------------
CREATE PROCEDURE Get_Risks_In_Project(@projectID INT)
AS
BEGIN
	SELECT *,R.RiskDataID AS DefaultRiskDataID, RP.RiskDataID AS ProjectRiskDataID
	FROM Tbl_Risk AS R LEFT JOIN Tbl_Risks_In_Project RP ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
	WHERE RP.ProjectID = @projectID
END
GO
-----------------------------------
--Check if a risk with a specific version is old.
-----------------------------------
CREATE PROCEDURE Is_Risk_Old(@riskID INT, @versionID INT)
AS
BEGIN
	IF(EXISTS(SELECT * FROM Get_Latest_Versions_Of_Risks() WHERE RiskID = @riskID AND VersionID = @versionID)) 
		SELECT 0 AS IsRiskOld
	ELSE
		SELECT 1 AS IsRiskOld
END
GO
-----------------------------------
--Search projects on Customer, MachineType, MachineNumber & OrderNumber.
-----------------------------------
CREATE PROCEDURE Search_Projects(@searchString AS VARCHAR(255))
AS
BEGIN
	SELECT *
	FROM Get_Projects_With_Revision()
	WHERE Customer LIKE '%' + @searchString +'%' 
	OR MachineType LIKE '%' + @searchString +'%' 
	OR MachineNumber LIKE '%' + @searchString +'%'
	OR OrderNumber LIKE '%' + @searchString +'%'
END
GO
CREATE PROCEDURE Get_RiskAssessment_Index_Data(@projectID INT, @dangerID INT)
AS
BEGIN
		SELECT InnerTable.*, DS.DangerSourceName
		FROM (SELECT R.RiskID,R.VersionID,R.TypeName,R.GroupName,R.RiskDataID AS DefaultRiskDataID,RP.RiskDataID AS ProjectRiskDataID,DangerID = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.DangerID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.DangerID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END,DangerSourceID = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.DangerSourceID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.DangerSourceID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END,HasRemainingRisk = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 R.RiskID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID AND (DATALENGTH(RD.MinimalAdditionInfo) > 0  OR EXISTS(SELECT * FROM Tbl_MinimalAddition_In_Risk MA WHERE MA.RiskDataID = RD.RiskDataID))) ELSE 
						 (SELECT TOP 1 R.RiskID FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID AND (DATALENGTH(RD.MinimalAdditionInfo) > 0  OR EXISTS(SELECT * FROM Tbl_MinimalAddition_In_Risk MA WHERE MA.RiskDataID = RP.RiskDataID)))
					   END

			FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
			WHERE RP.ProjectID = @projectID) AS InnerTable LEFT JOIN Tbl_Danger D ON InnerTable.DangerID = D.DangerID RIGHT JOIN Tbl_Danger_Source DS ON D.DangerID = DS.DangerID AND InnerTable.DangerSourceID = DS.DangerSourceID
		WHERE DS.DangerID = @dangerID
END
GO

-----------------------------------
--Purpose:	Get some basic riskdata where the risks have pl reduction measure.
-----------------------------------
CREATE PROCEDURE Get_Risks_With_PL_In_Project(@projectID AS INT)
AS
BEGIN
		SELECT RP.ProjectID,R.RiskID,R.VersionID,R.TypeName,R.GroupName,R.RiskDataID AS DefaultRiskDataID,RP.RiskDataID AS ProjectRiskDataID,HazardSituation = CASE WHEN RP.RiskDataID IS NULL
						 THEN (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = R.RiskDataID) ELSE 
						 (SELECT TOP 1 RD.HazardSituation FROM Tbl_Risk_Data RD WHERE RD.RiskDataID = RP.RiskDataID) 
					   END
		FROM Tbl_Risks_In_Project RP LEFT JOIN Tbl_Risk R ON R.RiskID = RP.RiskID AND R.VersionID = RP.VersionID
		WHERE RP.ProjectID = @projectID AND
		EXISTS(SELECT * FROM Tbl_RiskReduction_In_Risk RR WHERE RR.MeasureID = 0 AND RR.RiskDataID = CASE WHEN RP.RiskDataID IS NOT NULL THEN RP.RiskDataID ELSE R.RiskDataID END)
END
GO
-----------------------------------
--Purpose:	Copies a risk from a project into an other project.
-----------------------------------
CREATE PROCEDURE Copy_Risk_From_Project_Into_Project(@riskID AS INT, @fromProjectID AS INT, @toProjectID AS INT)
AS
BEGIN
	IF ((SELECT COUNT(*) FROM Tbl_Risks_In_Project P WHERE P.ProjectID = @toProjectID AND P.RiskID = @riskID) = 0) BEGIN
		DECLARE @versionID INT
		DECLARE @riskDataID INT
		SET @versionID = (SELECT TOP 1 RP.VersionID FROM Tbl_Risks_In_Project RP
			WHERE RP.ProjectID = @fromProjectID
			AND RP.RiskID = @riskID)
		SET @riskDataID = (SELECT TOP 1 RPP.RiskDataID FROM Tbl_Risks_In_Project RPP
			WHERE RPP.ProjectID = @fromProjectID
			AND RPP.RiskID = @riskID)

		IF(@riskDataID IS NULL)
			SET @versionID = (SELECT TOP 1 RP.VersionID FROM Get_Latest_Versions_Of_Risks() RP
			WHERE RP.RiskID = @riskID)

		INSERT INTO Tbl_Risks_In_Project(ProjectID,RiskID,VersionID,RiskDataID,ReviewedByUser,ReviewerComment)
		VALUES(@toProjectID, @riskID, @versionID, @riskDataID,NULL,NULL)
	END
END
GO
-----------------------------------
--Purpose: Make a revision of a risk project, including al its risks.
-----------------------------------
CREATE PROCEDURE Create_RiskProject_Revision(@OriginalProjectID AS INT,@CurrentUserID as INT) 
AS
BEGIN
	IF NOT EXISTS(SELECT P.ProjectID FROM Tbl_Project P WHERE P.RevisionOfID = @OriginalProjectID)
	BEGIN
		DECLARE @Revision INT
		SET @Revision = (SELECT P.Revision FROM Tbl_Project P WHERE P.ProjectID = @OriginalProjectID)

		--Declare local variables.
		DECLARE @NewProjectID INT
		--Create New Project.
		INSERT INTO Tbl_Project(Revision,LatestActivity, DateCreated,UserID,RevisionOfID)
		VALUES((SELECT P.Revision FROM Tbl_Project P WHERE P.ProjectID = @OriginalProjectID) + 1,GETDATE(),GETDATE(),@CurrentUserID,@OriginalProjectID)
		--Get projectID from new project.
		SET @NewProjectID = (	SELECT MAX(P.ProjectID)
								FROM Tbl_Project P)
		--Let the system know its a Risk Analysis project.
		INSERT INTO Tbl_Risk_Analysis(ProjectID,StateName,Customer,MachineType,MachineNumber,OrderNumber,Info,DraftVersion)
		SELECT @NewProjectID,'DRAFT',P.Customer,P.MachineType,P.MachineNumber,P.OrderNumber,P.Info,1 FROM Tbl_Risk_Analysis P WHERE P.ProjectID = @OriginalProjectID
		--Copy risk links.
		INSERT INTO Tbl_Risks_In_Project(ProjectID,VersionID,RiskID,RiskDataID,ReviewedByUser,ReviewerComment)
		SELECT @NewProjectID,R.VersionID,R.RiskID,NULL,NULL,NULL FROM Get_Latest_Versions_Of_Risks() R
		WHERE R.RiskID IN (SELECT p.RiskID FROM Tbl_Risks_In_Project P WHERE P.ProjectID = @OriginalProjectID) AND
			R.RiskID NOT IN (SELECT p.RiskID FROM Tbl_Risks_In_Project P WHERE P.ProjectID = @NewProjectID) 
	END
END
GO
-----------------------------------
--Purpose: Get projects where a user can create a project revision of.
-----------------------------------
CREATE PROCEDURE Get_Projects_For_ProjectRevision
AS
BEGIN
	SELECT P.ProjectID,RA.Customer, P.Revision,RA.MachineNumber, (SELECT RAA.MachineNumber FROM Tbl_Risk_Analysis RAA WHERE P.RevisionOfID = RAA.ProjectID) AS RevisionOf
	FROM Tbl_Project P RIGHT JOIN Tbl_Risk_Analysis RA ON P.ProjectID = RA.ProjectID
	WHERE NOT EXISTS(SELECT PR.ProjectID FROM Tbl_Project PR WHERE PR.RevisionOfID = P.ProjectID) AND RA.StateName = 'CLOSED'
END
GO
-----------------------------------
--Purpose: Get top 20 latest activity in the application order by the logdate.
-----------------------------------
CREATE PROCEDURE Get_Latest_Activity
AS
BEGIN
	SELECT top 20 *
	FROM Tbl_Log
	ORDER BY LogDate DESC
END
GO
-----------------------------------
--Purpose: Combines data from normal projects and risk projects.
-----------------------------------
CREATE PROCEDURE Get_All_RiskProject_Info(@projectID AS INT)
AS
BEGIN
	SELECT RA.*, P.UserID, P.DateCreated,P.LatestActivity, P.Revision, P.RevisionOfID
	FROM Tbl_Risk_Analysis RA LEFT JOIN Tbl_Project P ON RA.ProjectID = P.ProjectID
	WHERE RA.ProjectID = @projectID
END
GO
-----------------------------------
--Purpose: Profides an procedure for updating project details of a specific project.
-----------------------------------
CREATE PROCEDURE Update_ProjectDetails(@projectID AS INT, @customer AS VARCHAR(64), @machineType AS VARCHAR(32), 
	@machineNumber AS VARCHAR(8), @orderNumber AS VARCHAR(8), @info AS CHAR(512))
AS
BEGIN
	UPDATE Tbl_Risk_Analysis
	SET Customer = @customer,
		MachineType = @machineType,
		MachineNumber = @machineNumber,
		OrderNumber = @orderNumber,
		Info = @info
	WHERE ProjectID = @projectID
END
GO
CREATE PROCEDURE Update_Project_RecentActivity(@projectID AS INT)
AS
BEGIN
	UPDATE Tbl_Project
	SET LatestActivity = GETDATE()
	WHERE ProjectID = @projectID
END