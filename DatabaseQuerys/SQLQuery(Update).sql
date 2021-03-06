USE [VEHICLESDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateVehicle]    Script Date: 2020/10/18 7:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--For Update

ALTER procedure [dbo].[SP_UpdateVehicle]
(
	@VehicleID int = 0,
	@Make varchar(50)='',
	@Model varchar(50)='',
	@Price int = 0,
	@Features varchar(50)=''
)
as
BEGIN
	Update Vehicle Set Make=@Make, Model=@Model, Price= @Price, Features=@Features Where ID=@VehicleID
END