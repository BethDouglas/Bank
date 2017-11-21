USE BANK;    
GO    

CREATE TABLE dbo.Transactions (
    TransactionID INT IDENTITY (1, 1) NOT NULL,
    AccountID  INT NOT NULL,
    CustomerID INT NOT NULL,
    TransactionDate Datetime NOT NULL,
	PreviousBalance money NULL,
	TransactionAmount money NULL,
	NewBalance money NULL
    CONSTRAINT [PK_dbo.Transactions] PRIMARY KEY CLUSTERED ([TransactionID] ASC),
    CONSTRAINT [FK_dbo.Transactions_dbo.Customer_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([CustomerID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Transactions_dbo.Account_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Account] ([AccountID]) ON DELETE CASCADE
);

GO
CREATE NONCLUSTERED INDEX [IX_AccountID]
    ON [dbo].[Transactions]([AccountID] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_CustomerID]
    ON [dbo].[Transactions]([CustomerID] ASC);