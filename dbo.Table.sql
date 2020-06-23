CREATE TABLE [dbo].[BookDetails]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BookName] NVARCHAR(50) NULL, 
    [Price] NVARCHAR(50) NULL, 
    [Category] NVARCHAR(50) NULL, 
    [AuthorName] NVARCHAR(50) NULL, 
    [Edition] NVARCHAR(50) NULL, 
    [BookCondition] NVARCHAR(50) NULL, 
    [Available] NCHAR(10) NULL
)
