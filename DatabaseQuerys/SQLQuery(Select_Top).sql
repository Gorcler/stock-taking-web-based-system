/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ID]
      ,[Make]
      ,[Model]
      ,[Price]
      ,[Features]
  FROM [VEHICLESDB].[dbo].[Vehicle]