USE BANK
GO

CREATE TABLE dbo.Account  
   (AccountID INT IDENTITY (1, 1) NOT NULL,  
    Account# INT NOT NULL,  
	CustomerID INT NOT NULL,
    Pin# INT NOT NULL,
	AccountType nvarchar(25) NOT NULL,
	AccountBalance money NULL 
CONSTRAINT [PK_dbo.Account] PRIMARY KEY CLUSTERED ([AccountID] ASC),
CONSTRAINT [FK_dbo.Account_dbo.Customer_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]) ON DELETE CASCADE,
);

GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Account]([AccountID] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_CustomerID]
    ON [dbo].[Account]([CustomerID] ASC);

GO