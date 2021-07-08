CREATE TABLE [dbo].[Question] (
    [questionID]             INT            IDENTITY (1, 1) NOT NULL,
    [questionFilePath]       NVARCHAR (300) DEFAULT ((0)) NOT NULL,
    [isMultipleChoice]       BIT            DEFAULT ((0)) NOT NULL,
    [multipleChoiceAnswer]   NCHAR (1)      NULL,
    [topic]                  NVARCHAR (100) DEFAULT ((0)) NOT NULL,
    [subtopic]               NVARCHAR (100) DEFAULT ((0)) NOT NULL,
    [yearAppears]            SMALLINT       NULL DEFAULT ((0)),
    [marksWorth]             TINYINT        DEFAULT ((0)) NOT NULL,
    [markSchemeFilePath]     NVARCHAR (300) DEFAULT ((0)) NULL,
    [examinerReportFilePath] NVARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([questionID] ASC)
);

