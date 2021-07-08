CREATE TABLE [dbo].[Answer] (
    [paperForeignID]    INT             DEFAULT ((0)) NOT NULL,
    [questionForeignID] INT             DEFAULT ((0)) NOT NULL,
    [answerText]        NVARCHAR (4000) NULL,
    [answerComments]    NVARCHAR (4000) NULL,
    [timeTaken]         INT             DEFAULT ((0)) NOT NULL,
    [marksAchieved] TINYINT NOT NULL, 
    CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED ([questionForeignID] ASC, [paperForeignID] ASC),
    CONSTRAINT [FK_Answer_Paper] FOREIGN KEY ([paperForeignID]) REFERENCES [dbo].[Paper] ([paperID]),
    CONSTRAINT [FK_Answer_Question] FOREIGN KEY ([questionForeignID]) REFERENCES [dbo].[Question] ([questionID])
);

