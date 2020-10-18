USE [VEHICLESDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteVehicle]    Script Date: 2020/10/18 7:45:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Delete

ALTER procedure [dbo].[SP_DeleteVehicle]
(
	@VehicleID int
)
as
BEGIN
	Delete From Vehicle Where ID=@VehicleID
END