USE [VEHICLESDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertVehicle]    Script Date: 2020/10/18 7:42:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--For Insert

ALTER procedure [dbo].[SP_InsertVehicle]
(
	@Make varchar(50)='',
	@Model varchar(50)='',
	@Price int = 0,
	@Features varchar(50)=''
)
as
BEGIN
	Insert into Vehicle(Make,Model,Price,Features)
	Values(@Make,@Model,@Price,@Features)
END