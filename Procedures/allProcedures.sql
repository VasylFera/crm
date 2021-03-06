USE [CRM]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCountry]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteCountry] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Country
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDistrict]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteDistrict] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Districts
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMaritalStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteMaritalStatus] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from MaritalStatuses
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteOtg]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteOtg] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Otgs
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRegion]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteRegion] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Regions
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteStatus] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Status
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteVillage]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_DeleteVillage] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from Villages
		 where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAddressId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAddressId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       pd.Id
			  ,pd.CountryId
			  ,pd.RegionId
			  ,pd.DistrictId
			  ,pd.OtgId
			  ,pd.VillageId
			  
			  ,pd.DateCreated
			  ,pd.DateModified
			  ,pd.IsImported
			  ,pd.NeedToReimport
			  ,pd.ImportDate
			  ,pd.IsActive				 
			  
		  From  PersonalDataCountries pd		 
		  WHERE pd.IdPersonal = @Id
	END	
	
END

--  EXEC [sp_GetPersonalDataId] 1077

	--select * from PersonalData
	--select * from PersonalDataCountries
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllAddressId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllAddressId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id			 	  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  PersonalDataCountries 
		  WHERE IdPersonal = @Id
	END	
	
END
-- exec [sp_GetAllAddressId] 1071

 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCountries]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllCountries] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Country 
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistricts]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllDistricts] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,RegionId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Districts 
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForOtg]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllDistrictsForOtg] 
		@DistringId int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,DistrictId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Otgs dis
		  WHERE dis.DistrictId = @DistringId
		 
	END	
	
END



 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForRegion]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllDistrictsForRegion] 
		@RegionId int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,RegionId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Districts dis
		  WHERE dis.RegionId = @RegionId
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForVillages]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllDistrictsForVillages] 
		@OtgId int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,OtgId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Villages vill
		  WHERE vill.OtgId = @OtgId
		 
	END	
	
END



 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllMaritalStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllMaritalStatus] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Name			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  From  MaritalStatuses 
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOtgs]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllOtgs] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,DistrictId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Otgs 		 
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRegion]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllRegion] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Regions 		 
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRegionsForCountry]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllRegionsForCountry] 
		@CountryId int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,CountryId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Regions dis
		  WHERE dis.CountryId = @CountryId
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetAllStatus] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Description			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  From  Status 
		 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllVehicles]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllVehicles] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Consignment
			  ,[DateTime] as YearOfGraduation
			  ,CurrentNumberFactory
			  ,FactoryName
			  ,MinistryCode
			  ,TypeCar
			  ,BrandOfMmachine
			  ,StateCarNumber
			  ,YearManufactureCar
			  ,FullNameDriver3
			  ,TechnicalCondition
			  ,FullNameDriver1
			  ,FullNameDriver2


			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Vehicles
		 
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllVillages]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllVillages] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]	
			  ,OtgId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 		  
		  From  Villages vill
		 
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCountryId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetCountryId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Country 
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetDistrictId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetDistrictId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive 
		  
		  From  Districts 
		  WHERE Id = @Id
	END	
	
END

 
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaritalStatusId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetMaritalStatusId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  MaritalStatuses 
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOtgId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetOtgId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive 
		  
		  From  Otgs 
		  WHERE Id = @Id
	END	
	
END

 
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetPersonalDataId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetPersonalDataId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       pd.Id
			  ,LastName
			  ,FirstName
			  ,FatherName
			  ,PreviousLastName
			  ,FullNamePatronymicInTheGenitiveCase
			  ,NoneFatherName
			  ,Sex
			  ,DateOfBirth
			  ,IndividualPersonalNumber
			  ,Email
			  ,pd.DateCreated
			  ,pd.DateModified
			  ,pd.IsImported
			  ,pd.NeedToReimport
			  ,pd.ImportDate
			  ,pd.IsActive	
			  ,pd.MaritalStatusNameId
			  ,pd.Phone1
			  ,pd.Phone2
		  From  PersonalData pd		 
		  WHERE pd.Id = @Id
	END	
	
END

--  EXEC [sp_GetPersonalDataId] 1077

	--select * from PersonalData
	--select * from PersonalDataCountries
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetRegionId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetRegionId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Regions 
		  WHERE Id = @Id
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStatusId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetStatusId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Description			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Status 
		  WHERE Id = @Id
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVillageId]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetVillageId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive 
		  
		  From  Villages 
		  WHERE Id = @Id
	END	
	
END

 
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveAllAddress]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveAllAddress] 
		@Id int,		
		@UserId nvarchar(50),
		@CountryId int,
		@RegionId int,
		@DistrictId int,
		@OtgId int,
		@VillageId int,
		@IdPerson nvarchar(25)
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT PersonalDataCountries Off	

	if(@Id > 0)

	begin			
		Update PersonalDataCountries
			Set 
		 	CountryId = @CountryId
			,RegionId = @RegionId
			,DistrictId = @DistrictId
			,OtgId = @OtgId
			,VillageId = @VillageId

			,DateCreated = GETDATE()
					,DateModified = GETDATE()
					,IsImported = 0
					,NeedToReimport = 0
					,ImportDate = GETDATE()
					,IsActive = 0
		WHERE IdPersonal=@Id
 	   end	
    else
	  BEGIN 	
		 Insert Into PersonalDataCountries
			(
		
			 CountryId
			 ,RegionId
			 ,DistrictId
			 ,OtgId
			 ,VillageId

		     ,DateCreated
			 ,DateModified
			 ,IsImported
			 ,NeedToReimport
			 ,ImportDate
			 ,IsActive
			 ,IdPersonal
			)
			 Values
		    (	
			 @CountryId
			,@RegionId
			,@DistrictId
			,@OtgId
			,@VillageId

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0	
			,@IdPerson
		    )
		  Select SCOPE_IDENTITY() As ID 
		  
	END		
END
--EXEC [sp_SaveAllAddress] 0, '1','1', '1','1', '2002','1080'
	
		  
	
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveCountry]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveCountry] 
		@Id int,
		@Name nvarchar(25)		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Country Off	

	if(@Id > 0)

	begin
		Update Country
		SET 
			Name = @Name		
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into Country 
		  (		    
			  [Name]			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			 @Name		
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As CountryId	
	END	
	
END

 

GO
/****** Object:  StoredProcedure [dbo].[sp_SaveDistrict]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveDistrict] 
		@Id int,
		@Name nvarchar(25),
		@RegionId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Districts Off	

	if(@Id > 0)

	begin
		Update Districts
		SET 
			Name = @Name		
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into Districts 
		  (		    
			  [Name]	
			  ,RegionId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			 @Name	
			 ,@RegionId
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As DistrictId	
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveMaritalStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveMaritalStatus] 
		@Id int,
		@Description nvarchar(25)		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Status Off	
	if(@Id > 0)

	begin
		Update MaritalStatuses
		SET 
			 Name = @Description				
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into MaritalStatuses 
		  (	    
			   Name
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (			   
			  @Description			
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )
		 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveOtg]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveOtg] 
		@Id int,
		@Name nvarchar(25),
		@DistrictId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Otgs Off	

	if(@Id > 0)

	begin
		Update Otgs
		SET 
			 Name = @Name
			,DistrictId = @DistrictId			
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into Otgs 
		  (		    
			  [Name]	
			  ,DistrictId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @Name	
			 ,@DistrictId
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As OtgtId	
	END	
	
END

  --  EXEC [sp_SaveRegion] 0,'Львівська'
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SavePersonalData]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SavePersonalData] 
		@Id int,		
		@FatherName nvarchar(25),
		@NoneFatherName nvarchar(25),
		@LastName nvarchar(25),
		@PreviousLastName nvarchar(25),
	    @FullNamePatronymicInTheGenitiveCase nvarchar(25),
		@Sex nvarchar(25),
		@DateOfBirth nvarchar(25),
		@RefusalOfIndividualPersonalNumber nvarchar(25),
		@IndividualPersonalNumber int,
		@Email nvarchar(25),
		@MaritalStatus nvarchar(25),
		@Note nvarchar(25),
		@UserId nvarchar(50),
		--@CountryId nvarchar(25),
		--@RegionId nvarchar(25),
		--@DistrictId nvarchar(25),
		--@OtgId nvarchar(25),
		--@VillageId nvarchar(25),
		@FirstName nvarchar(25),
		@Phone1 nvarchar(25),
		@Phone2 nvarchar(25),
		@ServiceNote nvarchar(max),
		@MaritalStatusNameId int		 
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT PersonalData Off	

	if(@Id > 0)

	begin			
		Update PersonalData
		SET 
			 FatherName = @FatherName
			,NoneFatherName = @NoneFatherName
			,LastName = @LastName
			,PreviousLastName = @PreviousLastName
			,FullNamePatronymicInTheGenitiveCase = @FullNamePatronymicInTheGenitiveCase
			,Sex =@Sex
			,DateOfBirth=@DateOfBirth
			,RefusalOfIndividualPersonalNumber = @RefusalOfIndividualPersonalNumber			
			,IndividualPersonalNumber =@IndividualPersonalNumber
			,Email =@Email
			,MaritalStatus = 0
			,Note = @Note			
			,UserId = @UserId
			,PlaceOfBirthId = null
			,BloodTypeId = null
			,StatusId = null
			,DateCreated = GETDATE()
			,DateModified = GETDATE()
			,IsImported = 0
			,NeedToReimport = 0
			,ImportDate = GETDATE()
			,IsActive = 0
			,[FirstName] = @FirstName
			,Phone1 =@Phone1
			,Phone2 = @Phone2
			,ServiceNote =@ServiceNote
			,MaritalStatusNameId =@MaritalStatusNameId			
		WHERE Id = @Id					
 	   end	
    else
	  BEGIN 	
		  INSERT Into PersonalData 
		  (		  
			   FatherName
			  ,NoneFatherName
			  ,LastName
			  ,PreviousLastName
			  ,FullNamePatronymicInTheGenitiveCase
			  ,Sex
			  ,DateOfBirth
			  ,RefusalOfIndividualPersonalNumber
			  ,IndividualPersonalNumber
			  ,Email

			  ,MaritalStatus
			  ,Note
			  ,UserId
			  ,PlaceOfBirthId
			  ,BloodTypeId
			  ,StatusId

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	
			  ,[FirstName]
			  ,Phone1
			  ,Phone2
			  ,ServiceNote
			  ,MaritalStatusNameId			  
		  )
		  Values
		  (			   
			 	
			  @FatherName
			 ,@NoneFatherName
			 ,@LastName
			 ,@PreviousLastName
			 ,@FullNamePatronymicInTheGenitiveCase
			 ,@Sex
			 ,@DateOfBirth
			 ,@RefusalOfIndividualPersonalNumber
			 ,@IndividualPersonalNumber
			 ,@Email

			 ,0
			 ,@Note
			 ,@UserId
			 ,null
			 ,null
			 ,null

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0	
			 ,@FirstName
			 ,@Phone1
			 ,@Phone2
			 ,@ServiceNote
			 ,@MaritalStatusNameId			
		  )		 
		  Select SCOPE_IDENTITY() As ID 
		  Declare @IdPerson nvarchar(25) =  SCOPE_IDENTITY()  
	END		
END

		-- select *  from PersonalData
		--  select *  from PersonalDataCountries
 --EXEC [sp_GetPersonalDataId] 1077
 
    --   INSERT Into PersonalData 
		  --(		   
			 	
			 --  FatherName
			 -- ,NoneFatherName
			 -- ,LastName
			 -- ,PreviousLastName
			 -- ,FullNamePatronymicInTheGenitiveCase
			 -- ,Sex
			 -- ,DateOfBirth
			 -- ,RefusalOfIndividualPersonalNumber
			 -- ,IndividualPersonalNumber
			 -- ,Email

			 -- ,MaritalStatus
			 -- ,Note
			 -- ,UserId
			 -- ,PlaceOfBirthId
			 -- ,BloodTypeId
			 -- ,StatusId

			 -- ,DateCreated
			 -- ,DateModified
			 -- ,IsImported
			 -- ,NeedToReimport
			 -- ,ImportDate
			 -- ,IsActive	
			 -- ,[FirstName]
		  --)
		  --Values
		  --(	
		   
			 	
			 -- 'FatherName'
			 --, 'NoneFatherName'
			 --, 'LastName'
			 --, 'PreviousLastName'
			 --, 'FullNamePatronymicInTheGenitiveCase'
			 --, 'Sex'
			 --, 'DateOfBirth'
			 --, 0
			 --, 222222222
			 --, 'Email'

			 --,0
			 --,'www'
			 --,'970c2976-c1ad-4ddb-9f40-0910c5eeb3f1'
			 --,null
			 --,null
			 --,null

			 --,GETDATE ( )
			 --,GETDATE ( )
			 --,0
			 --,0
			 --,GETDATE ( )
			 --,0	
			 --, '[FirstName]'
		  --)
		  
	
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveRegion]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveRegion] 
		@Id int,
		@Name nvarchar(25),
		@CountryId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Regions Off	

	if(@Id > 0)

	begin
		Update Regions
		SET 
			Name = @Name		
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into Regions 
		  (		    
			  [Name]	
			  ,CountryId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			 @Name	
			 ,@CountryId
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As RegionId	
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveStatus]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveStatus] 
		@Id int,
		@Description nvarchar(25)		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Status Off	
	if(@Id > 0)

	begin
		Update Status
		SET 
			 Description = @Description				
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into Status 
		  (	    
			   Description
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (			   
			  @Description			
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )
		 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveVehicle]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveVehicle] 
		@Id int,
		@Consignment int,
		@YearOfGraduation nvarchar(25),
		@CurrentNumberFactory int,
		@FactoryName nvarchar(25),
		@MinistryCode int,
		@TypeCar nvarchar(25),
		@BrandOfMmachine nvarchar(25),
		@StateCarNumber nvarchar(25),
		@YearManufactureCar dateTime2,
		@FullNameDriver1 nvarchar(25),
		@FullNameDriver2 nvarchar(25),
		@FullNameDriver3 nvarchar(25),
		@TechnicalCondition bit
		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Vehicles Off	
	if(@Id > 0)

	begin
		Update Vehicles
		SET 
			 Consignment = @Consignment	
			 ,[DateTime] = GETDATE ( )			
			 ,CurrentNumberFactory = @CurrentNumberFactory
			 ,FactoryName = @FactoryName
			 ,MinistryCode = @MinistryCode
			 ,TypeCar = @TypeCar
			 ,BrandOfMmachine = @BrandOfMmachine
			 ,StateCarNumber = @StateCarNumber
			 ,YearManufactureCar = @YearManufactureCar
			 ,FullNameDriver1 = @FullNameDriver1
			 ,FullNameDriver2 = @FullNameDriver2
			 ,FullNameDriver3 = @FullNameDriver3
			 ,TechnicalCondition = @TechnicalCondition
			
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into Vehicles 
		  (	    
			   Consignment
			   ,[DateTime]
			   ,CurrentNumberFactory
			   ,FactoryName
			   ,MinistryCode
			   ,TypeCar
			   ,BrandOfMmachine
			   ,StateCarNumber
			   ,YearManufactureCar			  
			   ,FullNameDriver3
			   ,TechnicalCondition
			  

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	
			  ,FullNameDriver1
			  ,FullNameDriver2
		  )
		  Values
		  (			   
			  @Consignment	
			 ,@YearOfGraduation
			 ,@CurrentNumberFactory
			 ,@FactoryName
			 ,@MinistryCode
			 ,@TypeCar
			 ,@BrandOfMmachine
			 ,@StateCarNumber
			 ,GETDATE ( )
			
			 ,@FullNameDriver3
			 ,@TechnicalCondition
			 

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0		
			 ,@FullNameDriver1
			 ,@FullNameDriver2
		  )
		 
	END	
	
END

  
 --EXEC [sp_SaveVehicle] 0, 1, '12/02/1999', 1, 'Назва підприємства',1, 'Тип', 'Марка', 'Державний номер','12.02.2022','П.І.П основного водія', 'П.І.П основного водія', 'П.І.П основного водія',1
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveVillage]    Script Date: 14/07/2022 12:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveVillage] 
		@Id int,
		@Name nvarchar(25),
		@OtgId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Villages Off	

	if(@Id > 0)

	begin
		Update Villages
		SET 
			 Name = @Name
			,@OtgId = @OtgId			
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into Villages 
		  (		    
			  [Name]	
			  ,OtgId
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @Name	
			 ,@OtgId
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )	 
		
	END	
	
END

 
 
GO
