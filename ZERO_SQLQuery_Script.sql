SELECT TOP (1000) [id]
      ,[name]
      ,[address]
      ,[email_address]
      ,[contact_number]
      ,[password]
  FROM [Zero].[dbo].[restaurant]


  delete from restaurant where id = 7;

  UPDATE [Zero].[dbo].[restaurant]
SET [password] = 'bfc@gmail.com'
WHERE [id] = 7;
