USE LG_Analysis_Database
GO
SELECT * FROM T1 WHERE MainPart NOT IN (SELECT GroupName From Tbl_Component_Group)
SELECT * FROM T1 WHERE Part NOT IN (SELECT TypeName From Tbl_Component_Type)
GO
DELETE
FROM T1
WHERE T1.MainPart = '00 Project Dependent'
GO
DELETE
FROM T1
WHERE T1.IRErnst = 0
GO
DELETE
FROM T1
WHERE T1.Part NOT IN (SELECT TypeName From Tbl_Component_Type)
GO
DELETE
FROM T1 
WHERE T1.[Action] IS NULL
GO
DELETE
FROM T1
WHERE T1.IRSource IS NULL
GO 
INSERT INTO Tbl_Risk(VersionID,DateCreated,GroupName,TypeName)
SELECT 1,GETDATE(), T1.MainPart, T1.Part FROM T1 ORDER BY T1.Date  
GO
INSERT INTO Tbl_Risk_Data(DangerID,DangerSourceID,HazardSituation, HazardEvent, RiskReductionInfo, MinimalAdditionInfo, FileID, UserID)
SELECT T1.IRDanger,T1.IRSource,CONVERT(nvarchar(255),T1.[Action]), CONVERT(nvarchar(255),T1.Info) ,CONVERT(nvarchar(255),T1.Aanwezig) ,CONVERT(nvarchar(255),T1.Toevoegen),NULL,1 FROM T1 ORDER BY T1.Date  
GO
UPDATE Tbl_Risk
SET     RiskDataID = RiskID
GO
UPDATE Tbl_Danger_Source
SET		DangerResultID1 = (
	SELECT TOP 1 IRResult1 
	FROM T1 
	WHERE IRSource = DangerSourceID AND IRResult1 IS NOT NULL
	)
WHERE DangerSourceID IN (SELECT IRSource FROM T1)
GO
UPDATE Tbl_Danger_Source
SET		DangerResultID2 = (
	SELECT TOP 1 IRResult2 
	FROM T1 
	WHERE IRSource = DangerSourceID AND IRResult2 IS NOT NULL AND IRResult2 IN (SELECT DangerSourceID FROM Tbl_Danger_Result)
	)
WHERE DangerSourceID IN (SELECT IRSource FROM T1 WHERE IRResult2 IS NOT NULL)
GO
DECLARE @MyCursor CURSOR;
DECLARE @MyField Bit;
DECLARE @curRow INT;
SET @curRow = 1;
BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT Person_Operator FROM T1  
	ORDER BY T1.Date  

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		IF(@MyField = 1)
			INSERT INTO Tbl_ExposedPersons_In_Risk
			VALUES(1,@curRow)
		SET @curRow = @curRow + 1
      FETCH NEXT FROM @MyCursor 
      INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;
GO
DECLARE @MyCursor CURSOR;
DECLARE @MyField Bit;
DECLARE @curRow INT;
SET @curRow = 1;
BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT Person_Clean FROM T1 
	ORDER BY T1.Date   

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		IF(@MyField = 1)
			INSERT INTO Tbl_ExposedPersons_In_Risk
			VALUES(2,@curRow)
		SET @curRow = @curRow + 1
      FETCH NEXT FROM @MyCursor 
      INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;
GO
DECLARE @MyCursor CURSOR;
DECLARE @MyField Bit;
DECLARE @curRow INT;
SET @curRow = 1;
BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT Person_TD FROM T1 
	ORDER BY T1.Date   

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		IF(@MyField = 1)
			INSERT INTO Tbl_ExposedPersons_In_Risk
			VALUES(3,@curRow)
		SET @curRow = @curRow + 1
      FETCH NEXT FROM @MyCursor 
      INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;
GO
DECLARE @MyCursor CURSOR;
DECLARE @MyField Bit;
DECLARE @curRow INT;
SET @curRow = 1;
BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT Person_Visit FROM T1
	ORDER BY T1.Date  

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		IF(@MyField = 1)
			INSERT INTO Tbl_ExposedPersons_In_Risk
			VALUES(4,@curRow)
		SET @curRow = @curRow + 1
      FETCH NEXT FROM @MyCursor 
      INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_Before(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(SE)Severity of harm', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(SE)Severity of harm' AND ItemWeight = T1.IRErnst) 
FROM T1
ORDER BY T1.Date
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_Before(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(FR)Frequenty of exposure to the hazard', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(FR)Frequenty of exposure to the hazard' AND (ItemWeight = T1.IRFrequentie OR (T1.IRFrequentie = 6 AND ItemWeight = 5))) 
FROM T1
ORDER BY T1.Date
GO
UPDATE Tbl_RiskEstimation_In_Risk_Before
SET EstimationID = 7
WHERE EstimationID = 6 AND 5 = (SELECT k.IRFrequentie FROM (SELECT ROW_NUMBER() OVER (ORDER BY T1.Date) AS row, IRFrequentie
		FROM T1) AS k
		WHERE k.row = RiskDataID)
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_Before(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(PR)Propability of occurence', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(PR)Propability of occurence' AND ItemWeight = T1.IRWaarschijnlijkheid) 
FROM T1
ORDER BY T1.Date
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_Before(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(AV)Possability of avoiding the hazard', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(AV)Possability of avoiding the hazard' AND ItemWeight = T1.IROntwijk) 
FROM T1
ORDER BY T1.Date

-----------------------------------------------------
GO
UPDATE T1
SET RRErnst = 1
WHERE RRErnst = 0
GO
UPDATE T1
SET RRFrequentie = 2
WHERE RRFrequentie = 0 OR RRFrequentie = 1
GO
UPDATE T1
SET RROntwijk = 1
WHERE RROntwijk = 0
GO
UPDATE T1
SET RRWaarschijnlijkheid = 1
WHERE RRWaarschijnlijkheid = 0
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_After(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(SE)Severity of harm', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(SE)Severity of harm' AND ItemWeight = T1.RRErnst) 
FROM T1
ORDER BY T1.Date
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_After(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(FR)Frequenty of exposure to the hazard', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(FR)Frequenty of exposure to the hazard' AND (ItemWeight = T1.RRFrequentie OR (T1.RRFrequentie = 6 AND ItemWeight = 5))) 
FROM T1
ORDER BY T1.Date
GO
UPDATE Tbl_RiskEstimation_In_Risk_After
SET EstimationID = 7
WHERE EstimationID = 6 AND 5 = (SELECT k.RRFrequentie FROM (SELECT ROW_NUMBER() OVER (ORDER BY T1.Date) AS row, RRFrequentie
		FROM T1) AS k
		WHERE k.row = RiskDataID)
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_After(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(PR)Propability of occurence', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(PR)Propability of occurence' AND ItemWeight = T1.RRWaarschijnlijkheid) 
FROM T1
ORDER BY T1.Date
GO
INSERT INTO Tbl_RiskEstimation_In_Risk_After(RiskDataID,GroupName,EstimationID)
SELECT ROW_NUMBER()
        OVER (ORDER BY T1.Date) AS Row, 
    '(AV)Possability of avoiding the hazard', (SELECT TOP 1 EstimationID FROM Tbl_RiskEstimation WHERE GroupName = '(AV)Possability of avoiding the hazard' AND ItemWeight = T1.RROntwijk) 
FROM T1
ORDER BY T1.Date
GO
DECLARE @MyCursor CURSOR;
DECLARE @MyField Bit;
DECLARE @curRow INT;
SET @curRow = 1;
BEGIN
    SET @MyCursor = CURSOR FOR
    SELECT Plr FROM T1
	ORDER BY T1.Date  

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @MyField

    WHILE @@FETCH_STATUS = 0
    BEGIN
		IF(@MyField = 1)
			INSERT INTO Tbl_RiskReduction_In_Risk
			VALUES(0,@curRow)
		SET @curRow = @curRow + 1
      FETCH NEXT FROM @MyCursor 
      INTO @MyField 
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;
GO