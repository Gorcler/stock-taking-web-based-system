USE [VEHICLESDB]
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAllVehicles]    Script Date: 2020/10/18 7:47:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_GetAllVehicles]
as
BEGIN
	select * from Vehicle
END