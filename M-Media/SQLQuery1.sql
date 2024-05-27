--DELETE FROM MMediaGames0123456.dbo.Categories
--WHERE CategoryId = 7
SELECT * FROM MMediaGames0123456.dbo.Categories
--DBCC CHECKIDENT ('MMediaGames0123456.dbo.Categories', RESEED, 0);
--DBCC CHECKIDENT ('MMediaGames0123456.dbo.Categories', NORESEED);
SELECT * FROM MMediaGames0123456.dbo.Games
--DBCC CHECKIDENT ('MMediaGames0123456.dbo.Games', RESEED, 0);
--DBCC CHECKIDENT ('MMediaGames0123456.dbo.Games', NORESEED);