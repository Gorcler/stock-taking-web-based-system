USE [VEHICLESDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetVehicleID]    Script Date: 2020/10/18 7:47:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Get By ID
ALTER procedure [dbo].[SP_GetVehicleID]
(
	@VehicleID int
)
as
BEGIN
	Select * From Vehicle Where ID =@VehicleID
END