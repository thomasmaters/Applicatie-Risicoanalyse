
USE LG_Analysis_Database
GO
CREATE TABLE Tbl_User_Permissions(
	PermissionID		INT				IDENTITY(1,1)	NOT NULL,
	PermissionName		VARCHAR(64)		NOT NULL,
	
	PRIMARY KEY(PermissionID)
)
GO
CREATE TABLE Tbl_User(
	UserID				INT				IDENTITY(1,1)	NOT NULL,
	UserName			VARCHAR(64)		NOT NULL,
	PasswordHash		BINARY(64)		NOT NULL,
	PermissionID		INT				NOT NULL,
	
	PRIMARY KEY(UserID),
	
	CONSTRAINT FK_User_UserPermissions
	FOREIGN KEY(PermissionID)			REFERENCES Tbl_User_Permissions(PermissionID)	
)
GO
CREATE TABLE Tbl_Project(
	ProjectID			INT				IDENTITY(1,1)	NOT NULL,
	Revision			SMALLINT		NOT NULL,
	DateCreated			DATE			NOT NULL,
	LatestActivity		DATETIME		NOT NULL,
	UserID				INT				NOT NULL,
	RevisionOfID		INT				NULL,

	PRIMARY KEY(ProjectID),

	CONSTRAINT FK_Project_User
	FOREIGN KEY(UserID)					REFERENCES Tbl_User(UserID),
	CONSTRAINT FK_Project_Project
	FOREIGN KEY(RevisionOfID)		REFERENCES Tbl_Project(ProjectID)
)
GO
CREATE TABLE Tbl_Log(
	LogDate				DATETIME		NOT NULL,
	ActionDescription	VARCHAR(255)	NOT NULL,
	UserID				INT				NOT NULL,

	PRIMARY KEY(LogDate),

	CONSTRAINT FK_Log_User
	FOREIGN KEY(UserID)					REFERENCES Tbl_User(UserID)
)
GO
CREATE TABLE Tbl_Risk_Project_State(
	StateName			VARCHAR(64)		NOT NULL,
	StateID				INT				IDENTITY(1,1)	NOT NULL,

	PRIMARY KEY(StateName)
)
GO
CREATE TABLE Tbl_Risk_Analysis(
	ProjectID			INT				NOT NULL,
	StateName			VARCHAR(64)		NOT NULL,
	Customer			VARCHAR(64)		NOT NULL,
	MachineType			VARCHAR(32)		NOT NULL,
	MachineNumber		CHAR(8)			NOT NULL,
	OrderNumber			CHAR(8)			NOT NULL,
	Info				CHAR(512)		NULL,
	DraftVersion		TINYINT			NOT NULL,

	PRIMARY KEY(ProjectID),

	CONSTRAINT FK_RiskAnalysis_RiskProjectState
	FOREIGN KEY(StateName)				REFERENCES Tbl_Risk_Project_State(StateName),
	CONSTRAINT FK_RiskAnalysis_Project
	FOREIGN KEY(ProjectID)				REFERENCES Tbl_Project(ProjectID)
)
GO
CREATE TABLE Tbl_Component_Group(
	GroupName			VARCHAR(64)		NOT NULL,

	PRIMARY KEY(GroupName)
)
GO
CREATE TABLE Tbl_Component_Type(
	TypeName			VARCHAR(64)		NOT NULL,
	GroupName			VARCHAR(64)		NOT NULL,

	PRIMARY KEY(TypeName,GroupName),

	CONSTRAINT FK_ComponentType_ComponentGroup
	FOREIGN KEY(GroupName)				REFERENCES Tbl_Component_Group(GroupName)
)
GO
CREATE TABLE Tbl_BLOB_Storage(
	FileID				INT				IDENTITY(1,1)	NOT NULL,
	FileObject			VARBINARY(MAX)	NOT NULL,
	PRIMARY KEY(FileID)
)
GO
CREATE TABLE Tbl_Danger(
	DangerID			INT				NOT NULL,
	DangerGroupName		VARCHAR(128)	NOT NULL,

	PRIMARY KEY(DangerID)
)
GO
CREATE TABLE Tbl_Danger_Result(
	DangerResultID		INT				NOT NULL,
	DangerResultName	VARCHAR(128)	NOT NULL,

	PRIMARY KEY(DangerResultID),
)
GO
CREATE TABLE Tbl_Danger_Source(
	DangerSourceID		INT				NOT NULL,
	DangerID			INT				NOT NULL,
	DangerSourceName	VARCHAR(128)	NOT NULL,
	DangerResultID1		INT				NOT NULL,
	DangerResultID2		INT				NULL

	PRIMARY KEY(DangerSourceID),

	CONSTRAINT FK_DangerSource_Danger
	FOREIGN KEY(DangerID)				REFERENCES Tbl_Danger(DangerID),

	CONSTRAINT FK_DangerSource_DangerResult1
	FOREIGN KEY(DangerResultID1)				REFERENCES Tbl_Danger_Result(DangerResultID),

	CONSTRAINT FK_DangerSource_DangerResult2
	FOREIGN KEY(DangerResultID2)				REFERENCES Tbl_Danger_Result(DangerResultID)
)
GO
CREATE TABLE Tbl_Risk_Data(
	RiskDataID			INT				IDENTITY(1,1)			NOT NULL,
	DangerID			INT				NOT NULL,
	DangerSourceID		INT				NOT NULL,
	HazardSituation		VARCHAR(255)	NOT NULL,
	HazardEvent			VARCHAR(1024)	NOT NULL,
	UserID				INT				NOT NULL,
	RiskReductionInfo	VARCHAR(1024)	NULL,
	MinimalAdditionInfo	VARCHAR(1024)	NULL,
	FileID				INT				NULL,

	PRIMARY KEY(RiskDataID),

	CONSTRAINT FK_RiskData_Danger
	FOREIGN KEY(DangerID)			REFERENCES Tbl_Danger(DangerID),
	CONSTRAINT FK_RiskData_DangerSource
	FOREIGN KEY(DangerSourceID)		REFERENCES Tbl_Danger_Source(DangerSourceID),
	CONSTRAINT FK_RiskData_BLOBStorage
	FOREIGN KEY(FileID)				REFERENCES Tbl_BLOB_Storage(FileID),
	CONSTRAINT FK_RiskData_User
	FOREIGN KEY(UserID)				REFERENCES Tbl_User(UserID),
)
GO
CREATE TABLE Tbl_Risk(	
	RiskID				INT				identity(1,1) NOT NULL,
	VersionID			INT				NOT NULL,
	DateCreated			Date			NOT NULL,
	TypeName			VARCHAR(64)		NOT NULL,
	GroupName			VARCHAR(64)		NOT NULL,
	RiskDataID			INT				NULL,

	PRIMARY KEY(RiskID,VersionID),

	CONSTRAINT FK_Risk_ComponentType
	FOREIGN KEY(TypeName,GroupName)		REFERENCES Tbl_Component_Type(TypeName,GroupName),
	CONSTRAINT FK_Risk_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES TBL_Risk_Data(RiskDataID)
)
GO
CREATE TABLE Tbl_Risks_In_Project(
	ProjectID			INT				NOT NULL,
	VersionID			INT				NOT NULL,
	RiskID				INT				NOT NULL,
	RiskDataID			INT				NULL,
	ReviewedByUser		INT				NULL,
	ReviewerComment		VARCHAR(512)	NULL,

	PRIMARY KEY(ProjectID,VersionID,RiskID),

	CONSTRAINT FK_ProjectRisks_Risk 
	FOREIGN KEY(RiskID,VersionID)		REFERENCES Tbl_Risk(RiskID,VersionID),
	CONSTRAINT FK_ProjectRisks_Project
	FOREIGN KEY(ProjectID)				REFERENCES Tbl_Project(ProjectID),
	CONSTRAINT FK_RisksInProject_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID),
	CONSTRAINT FK_RisksInProject_User
	FOREIGN KEY(ReviewedByUser)			REFERENCES Tbl_User(UserID)
)
GO
CREATE TABLE Tbl_ExposedPersons(
	ExposedPersonID		INT				NOT NULL,
	PersonDescription	VARCHAR(255)	NOT NULL,

	PRIMARY KEY(ExposedPersonID)
)
GO
CREATE TABLE Tbl_RiskEstimation(
	EstimationID		INT				NOT NULL,
	GroupName			VARCHAR(64)		NOT NULL,
	ItemDescription		VARCHAR(64)		NOT NULL,
	ItemWeight			INT				NOT NULL,

	PRIMARY KEY(EstimationID,GroupName)
)
GO
CREATE TABLE Tbl_RiskReductionMeasures(
	MeasureID			INT				NOT NULL,
	MeasureGroup		VARCHAR(64)		NULL,
	MeasureSubGroup		VARCHAR(64)		NOT NULL,
	FileID				INT				NULL,

	PRIMARY KEY(MeasureID),

	CONSTRAINT FK_RiskReductionMeasures_BlobStorage
	FOREIGN KEY(FileID)					REFERENCES Tbl_BLOB_Storage(FileID)
)
GO
CREATE TABLE Tbl_ExposedPersons_In_Risk(
	ExposedPersonID		INT				NOT NULL,
	RiskDataID			INT				NOT NULL,

	PRIMARY KEY(ExposedPersonID,RiskDataID),

	CONSTRAINT FK_ExposedPersonsInRisk_ExposedPersons
	FOREIGN KEY(ExposedPersonID)		REFERENCES Tbl_ExposedPersons(ExposedPersonID),
	CONSTRAINT FK_ExposedPersonsInRisk_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID)
)
GO
CREATE TABLE Tbl_RiskEstimation_In_Risk_Before(
	RiskDataID			INT				NOT NULL,
	EstimationID		INT				NOT NULL,
	GroupName			VARCHAR(64)		NOT NULL,

	PRIMARY KEY(EstimationID,RiskDataID,GroupName),

	CONSTRAINT FK_RiskEstimationBefore_RiskEstimation
	FOREIGN KEY(EstimationID,GroupName)	REFERENCES Tbl_RiskEstimation(EstimationID,GroupName),
	CONSTRAINT FK_RiskEstimationBefore_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID)
)
GO
CREATE TABLE Tbl_RiskEstimation_In_Risk_After(
	RiskDataID			INT				NOT NULL,
	EstimationID		INT				NOT NULL,
	GroupName			VARCHAR(64)		NOT NULL,

	PRIMARY KEY(EstimationID,RiskDataID,GroupName),

	CONSTRAINT FK_RiskEstimationAfter_RiskEstimation
	FOREIGN KEY(EstimationID,GroupName)	REFERENCES Tbl_RiskEstimation(EstimationID,GroupName),
	CONSTRAINT FK_RiskEstimationAfter_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID)
)
GO
CREATE TABLE Tbl_RiskReduction_In_Risk(
	MeasureID			INT				NOT NULL,
	RiskDataID			INT				NOT NULL,

	PRIMARY KEY(MeasureID,RiskDataID),

	CONSTRAINT FK_RiskReductionInRisk_ExposedPersons
	FOREIGN KEY(MeasureID)				REFERENCES Tbl_RiskReductionMeasures(MeasureID),
	CONSTRAINT FK_RiskReductionInRisk_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID)
)
GO
CREATE TABLE Tbl_MinimalAddition_In_Risk(
	MeasureID			INT				NOT NULL,
	RiskDataID			INT				NOT NULL,

	PRIMARY KEY(MeasureID,RiskDataID),

	CONSTRAINT FK_MinimalAddition_ExposedPersons
	FOREIGN KEY(MeasureID)				REFERENCES Tbl_RiskReductionMeasures(MeasureID),
	CONSTRAINT FK_MinimalAddition_RiskData
	FOREIGN KEY(RiskDataID)				REFERENCES Tbl_Risk_Data(RiskDataID)
)