USE [Library]
GO


UPDATE  Book 
SET Photo = 
      (SELECT * FROM OPENROWSET(BULK 'G:\1-194.jpg', SINGLE_BLOB) AS image)
WHERE Id = 5


GO



