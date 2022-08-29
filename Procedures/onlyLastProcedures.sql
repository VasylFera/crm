USE [CRM]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCountry]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteDistrict]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteMaritalStatus]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteOtg]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteRegion]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteStatus]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteVillage]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EducationHigherEducationMilitaryId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_EducationHigherEducationMilitaryId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		         Id					
			    ,[Start]
			    ,[End]
				,StatusHigherEducationlMilitaryCertificate
				,NameHigherEducationMilitary
				,SeriaHigherEducationMilitaryCertificate
				,NumberHigherEducationMilitaryCertificate
				,MilitarySpecialty			   

			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From HigherEducationMilitary 
		  
		  WHERE Id = @Id
	END	
	
END


-- EXEC [sp_EducationHigherEducationMilitaryId] 1
GO
/****** Object:  StoredProcedure [dbo].[sp_EducationProfessionalTechnicalMilitarySchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_EducationProfessionalTechnicalMilitarySchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		         Id	
				,RVCReferralNumber
				,RVCReferralDate
				,NameProfessionalTechnicalMilitarySchool
			    ,[Start]
			    ,[End]
			    ,SpecialtyProfessionalTechnicalMilitarySchool
			   

			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From EducationProfessionalTechnicalMilitarySchool 
		  
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAddressId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllAddressId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllCodeMilitaryAccountingSpecialties]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllCodeMilitaryAccountingSpecialties]  
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Code
			  ,Description as NameMilitaryAccountingSpecialty				  
		     
		  From  CodeMilitaryAccountingSpecialties 
		 Where SoldierAndSergeantMilitaryAccountingSpecialtiesId =@Id

	END	
	
END


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllCountries]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistricts]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForOtg]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForRegion]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllDistrictsForVillages]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllMaritalStatus]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllMilitaryAccountingSpecialties]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllMilitaryAccountingSpecialties] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,MilitaryAccountingSpecialty as MilitaryAccountingSpecialtyCode
			  ,Description as NameMilitaryAccountingSpecialty				 	 
		  
		  From  SoldierAndSergeantMilitaryAccountingSpecialties 
		 

	END	
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllMilitaryAccountingSpecialtiyLetters]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllMilitaryAccountingSpecialtiyLetters]  
	
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Letter
			  ,DescriptionLetter				  
		     
		  From  MilitaryAccountingSpecialtyLetteries 
		

	END	
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllOtgs]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllOtgs] 
		
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllRegion]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllRegionsForCountry]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllStatus]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetAllStatus] 
		
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,[Description]	
			 
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	 
		  
		  From  Status 		 
	END	
	
END

  --  EXEC [sp_GetAllStatus] 
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllVehicles]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetAllVillages]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetCountryId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetDistrictId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetEducationGeneralId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetEducationGeneralId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		        Id
			   ,PersonId
			   ,SchoolId
			   ,ProfessionalTechnicalSchoolId
			   ,HigherEducationId
			   ,ProfessionalTechnicalMilitaryId
			   ,HigherEducationlMilitaryId
			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From  EducationDataGenerals
		  WHERE PersonId = @Id
	END	
	
END

--select * from EducationSchool
--select * from EducationDataGenerals
-- EXEC [sp_GetEducationGeneralId] 5
--EXEC [sp_GetEducationSchoolId] 4
GO
/****** Object:  StoredProcedure [dbo].[sp_GetEducationProfessionalTechnicalSchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetEducationProfessionalTechnicalSchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		        Id			 
			   ,[Start]
			   ,[End]
			   ,StatusProfessionalTechnicalSchoolCertificate
			   ,NameProfessionalTechnicalSchool			  
			   ,SeriaProfessionalTechnicalSchoolCertificate
			   ,NumberProfessionalTechnicalSchoolCertificate
			   ,SpecialtyProfessionalTechnicalSchool

			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From  EducationProfessionalTechnicalSchool 		  
		  WHERE Id = @Id
	END	
	
END


 
-- exec sp_GetEducationProfessionalTechnicalSchoolId 4
GO
/****** Object:  StoredProcedure [dbo].[sp_GetEducationSchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetEducationSchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		        Id			   
			   ,[Start]
			   ,[End]
			   ,StatusSchoolCertificate
			   ,NumberOfClasses			  
			   ,NameSchool
			   ,SeriaSchoolCertificate
			   ,NumberSchoolCertificate

			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From  EducationSchool 
		  WHERE Id = @Id
	END	
	
END

 select * from EducationSchool
 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHigherEducationId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_GetHigherEducationId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select 
		        Id			
			   ,[Start]
			   ,[End]
			   ,StatusHigherEducationlCertificate
			   ,NameHigherEducation			  
			   ,SeriaHigherEducationCertificate
			   ,NumberHigherEducationCertificate
			   ,SpecialtyHigherEducation
			   ,ТameOfTheMilitaryDepartment
			   ,MilitarySpecialty

			  --,DateCreated
			  --,DateModified
			  --,IsImported
			  --,NeedToReimport
			  --,ImportDate
			  --,IsActive	 
		  
		  From HigherEducation 
		  
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaritalStatusId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetMilitaryAccountingSpecialtyLetterId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetMilitaryAccountingSpecialtyLetterId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Letter
			  ,DescriptionLetter
			  			  
		  From  MilitaryAccountingSpecialtyLetteries 
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetOtgId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetPersonalDataId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetRegionId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetStatusId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetVehicleId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_GetVehicleId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Select
		       Id
			  ,Consignment
			  ,DateTime as YearOfGraduation
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
		  From  Vehicles 
		  WHERE Id = @Id
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVillageId]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationDataGeneralEducationProfessionalTechnicalSchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveEducationDataGeneralEducationProfessionalTechnicalSchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationDataGenerals
		  where ProfessionalTechnicalSchoolId = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationDataGeneralHigherMilitaryId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_RemoveEducationDataGeneralHigherMilitaryId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationDataGenerals
		  where HigherEducationlMilitaryId = @Id 
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationDataGeneralHightEducationId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveEducationDataGeneralHightEducationId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationDataGenerals
		  where HigherEducationId = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationDataGeneralProfessionalTechnicalMilitarySchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveEducationDataGeneralProfessionalTechnicalMilitarySchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationDataGenerals
		  where ProfessionalTechnicalMilitaryId = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationDataGeneralSchool]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveEducationDataGeneralSchool] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationDataGenerals
		  where SchoolId = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneral 4
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveEducationProfessionalTechnicalSchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveEducationProfessionalTechnicalSchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationProfessionalTechnicalSchool
		  where Id = @Id 
	END	
	
END

   --select * FROM EducationProfessionalTechnicalSchool
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveHigherEducationMilitaryId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveHigherEducationMilitaryId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from HigherEducationMilitary
		  where Id = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0

   -- select * from EducationProfessionalTechnicalMilitarySchool
    --delete from EducationProfessionalTechnicalMilitarySchool 
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveHightEducationId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveHightEducationId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from HigherEducation
		  where Id = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveProfessionalTechnicalMilitarySchoolId]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveProfessionalTechnicalMilitarySchoolId] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationProfessionalTechnicalMilitarySchool
		  where Id = @Id 
	END	
	
END

   --select * FROM EducationDataGenerals
   --sp_RemoveEducationDataGeneralSchool 0
  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveSchool]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_RemoveSchool] 
		@Id int
AS
BEGIN	
		
    BEGIN 	
		  Delete from EducationSchool
		  where Id = @Id 
	END	
	
END

  
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveAllAddress]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveCountry]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveDistrict]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveEducationDataGenera]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveEducationDataGenera] 
		@Id int,
		@PersonId int,
		@SchoolId int,
		@ProfessionalTechnicalSchoolId int,
		@HigherEducationId int,
		@ProfessionalTechnicalMilitaryId int,
		@HigherEducationlMilitaryId int		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT EducationDataGenerals Off	

	if(@Id > 0)

	begin
		Update EducationDataGenerals
		SET 
			 PersonId = @PersonId	
			,SchoolId = @SchoolId
			,ProfessionalTechnicalSchoolId =@ProfessionalTechnicalSchoolId
			,HigherEducationId = @HigherEducationId
			,ProfessionalTechnicalMilitaryId = @ProfessionalTechnicalMilitaryId
			,HigherEducationlMilitaryId =@HigherEducationlMilitaryId					
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into EducationDataGenerals 
		  (		    
			   PersonId	
			  ,SchoolId
			  ,ProfessionalTechnicalSchoolId
			  ,HigherEducationId
			  ,ProfessionalTechnicalMilitaryId
			  ,HigherEducationlMilitaryId
			 
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @PersonId	
			 ,@SchoolId
			 ,@ProfessionalTechnicalSchoolId
			 ,@HigherEducationId
			 ,@ProfessionalTechnicalMilitaryId
			 ,@HigherEducationlMilitaryId
			
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveEducationProfessionalTechnicalMilitarySchool]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveEducationProfessionalTechnicalMilitarySchool] 
		@Id int,
		@RVCReferralNumber nvarchar(25),
		@RVCReferralDate nvarchar(25),
		@NameProfessionalTechnicalMilitarySchool nvarchar(25),
		@Start nvarchar(25),
		@End nvarchar(25),			
		@SpecialtyProfessionalTechnicalMilitarySchool nvarchar(25)
	   
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT EducationProfessionalTechnicalMilitarySchool Off	

	if(@Id > 0)

	begin
		Update EducationProfessionalTechnicalMilitarySchool
		SET 
		      RVCReferralNumber =@RVCReferralNumber
			 ,RVCReferralDate = @RVCReferralDate
			 ,NameProfessionalTechnicalMilitarySchool = @NameProfessionalTechnicalMilitarySchool
			,[Start] = @Start	
			,[End] = @End
			,SpecialtyProfessionalTechnicalMilitarySchool = @SpecialtyProfessionalTechnicalMilitarySchool			
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into EducationProfessionalTechnicalMilitarySchool 
		  (		
		       RVCReferralNumber
			  ,RVCReferralDate
			  ,NameProfessionalTechnicalMilitarySchool
			  ,[Start]	
			  ,[End]
			  ,SpecialtyProfessionalTechnicalMilitarySchool
			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		      @RVCReferralNumber
			 ,@RVCReferralDate
			 ,@NameProfessionalTechnicalMilitarySchool
			 ,@Start	
			 ,@End
			 ,@SpecialtyProfessionalTechnicalMilitarySchool
			 
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveEducationProfessionalTechnicalSchool]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveEducationProfessionalTechnicalSchool] 
		@Id int,
		@Start nvarchar(25),
		@End nvarchar(25),
		@StatusProfessionalTechnicalSchoolCertificate nvarchar(25),
		@NameProfessionalTechnicalSchool nvarchar(25),
		@SeriaProfessionalTechnicalSchoolCertificate nvarchar(25),
	    @NumberProfessionalTechnicalSchoolCertificate int,
		@SpecialtyProfessionalTechnicalSchool  nvarchar(25)
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT EducationProfessionalTechnicalSchool Off	

	if(@Id > 0)

	begin
		Update EducationProfessionalTechnicalSchool
		SET 
			 [Start] = @Start	
			,[End] = @End
			,StatusProfessionalTechnicalSchoolCertificate =@StatusProfessionalTechnicalSchoolCertificate
			,NameProfessionalTechnicalSchool = @NameProfessionalTechnicalSchool
			,SeriaProfessionalTechnicalSchoolCertificate = @SeriaProfessionalTechnicalSchoolCertificate
			,NumberProfessionalTechnicalSchoolCertificate =@NumberProfessionalTechnicalSchoolCertificate
			,SpecialtyProfessionalTechnicalSchool =@SpecialtyProfessionalTechnicalSchool			
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into EducationProfessionalTechnicalSchool 
		  (		    
			  [Start]	
			  ,[End]
			  ,StatusProfessionalTechnicalSchoolCertificate
			  ,NameProfessionalTechnicalSchool
			  ,SeriaProfessionalTechnicalSchoolCertificate
			  ,NumberProfessionalTechnicalSchoolCertificate
			  ,SpecialtyProfessionalTechnicalSchool

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @Start	
			 ,@End
			 ,@StatusProfessionalTechnicalSchoolCertificate
			 ,@NameProfessionalTechnicalSchool
			 ,@SeriaProfessionalTechnicalSchoolCertificate
			 ,@NumberProfessionalTechnicalSchoolCertificate
			 ,@SpecialtyProfessionalTechnicalSchool

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveEducationSchool]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveEducationSchool] 
		@Id int,
		@Start nvarchar(25),
		@End nvarchar(25),
		@StatusSchoolCertificate nvarchar(25),
		@NumberOfClasses nvarchar(25),
		@NameSchool nvarchar(25),
		@SeriaSchoolCertificate nvarchar(25),
		@NumberSchoolCertificate int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT EducationSchool Off	

	if(@Id > 0)

	begin
		Update EducationSchool
		SET 
			 [Start] = @Start	
			,[End] = @End
			,StatusSchoolCertificate =@StatusSchoolCertificate
			,NumberOfClasses = @NumberOfClasses
			,NameSchool = @NameSchool
			,SeriaSchoolCertificate =@SeriaSchoolCertificate
			,NumberSchoolCertificate =@NumberSchoolCertificate			
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into EducationSchool 
		  (		    
			  [Start]	
			  ,[End]
			  ,StatusSchoolCertificate
			  ,NumberOfClasses
			  ,NameSchool
			  ,SeriaSchoolCertificate
			  ,NumberSchoolCertificate

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @Start	
			 ,@End
			 ,@StatusSchoolCertificate
			 ,@NumberOfClasses
			 ,@NameSchool
			 ,@SeriaSchoolCertificate
			 ,@NumberSchoolCertificate

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveHigherEducation]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveHigherEducation] 
		@Id int,
		@Start nvarchar(25),
		@End nvarchar(25),
		@StatusHigherEducationlCertificate nvarchar(25),
		@NameHigherEducation nvarchar(25),
		@SeriaHigherEducationCertificate nvarchar(25),
	    @NumberHigherEducationCertificate int,
		@SpecialtyHigherEducation  nvarchar(25),
		@ТameOfTheMilitaryDepartment nvarchar(25),
		@MilitarySpecialty nvarchar(25)
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT HigherEducation Off	

	if(@Id > 0)

	begin
		Update HigherEducation
		SET 
			 [Start] = @Start	
			,[End] = @End
			,StatusHigherEducationlCertificate =@StatusHigherEducationlCertificate
			,NameHigherEducation = @NameHigherEducation
			,SeriaHigherEducationCertificate = @SeriaHigherEducationCertificate
			,NumberHigherEducationCertificate =@NumberHigherEducationCertificate
			,SpecialtyHigherEducation =@SpecialtyHigherEducation
			,ТameOfTheMilitaryDepartment =@ТameOfTheMilitaryDepartment
			,MilitarySpecialty = @MilitarySpecialty
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into HigherEducation 
		  (		    
			  [Start]	
			  ,[End]
			  ,StatusHigherEducationlCertificate
			  ,NameHigherEducation
			  ,SeriaHigherEducationCertificate
			  ,NumberHigherEducationCertificate
			  ,SpecialtyHigherEducation
			  ,ТameOfTheMilitaryDepartment
			  ,MilitarySpecialty

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		   
			  @Start	
			 ,@End
			 ,@StatusHigherEducationlCertificate
			 ,@NameHigherEducation
			 ,@SeriaHigherEducationCertificate
			 ,@NumberHigherEducationCertificate
			 ,@SpecialtyHigherEducation
			 ,@ТameOfTheMilitaryDepartment
			 ,@MilitarySpecialty

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveHigherEducationMilitary]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveHigherEducationMilitary] 
		@Id int,	
		@Start nvarchar(25),
		@End nvarchar(25),			
		@StatusHigherEducationlMilitaryCertificate nvarchar(25),
	   	@NameHigherEducationMilitary nvarchar(25),
		@SeriaHigherEducationMilitaryCertificate nvarchar(25),
		@NumberHigherEducationMilitaryCertificate int,
		@MilitarySpecialty nvarchar(25)
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT HigherEducationMilitary Off	

	if(@Id > 0)

	begin
		Update HigherEducationMilitary
		SET 
		     [Start] =@Start
			,[End] = @End
		    ,StatusHigherEducationlMilitaryCertificate = @StatusHigherEducationlMilitaryCertificate
			,NameHigherEducationMilitary = @NameHigherEducationMilitary	
			,SeriaHigherEducationMilitaryCertificate = @SeriaHigherEducationMilitaryCertificate
			,NumberHigherEducationMilitaryCertificate = @NumberHigherEducationMilitaryCertificate			
			,MilitarySpecialty = @MilitarySpecialty
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into HigherEducationMilitary 
		  (		
		       [Start]
			  ,[End]
			  ,StatusHigherEducationlMilitaryCertificate
			  ,NameHigherEducationMilitary	
			  ,SeriaHigherEducationMilitaryCertificate
			  ,NumberHigherEducationMilitaryCertificate
			  ,MilitarySpecialty

			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive			  
		  )
		  Values
		  (	
		      @Start
			 ,@End
			 ,@StatusHigherEducationlMilitaryCertificate
			 ,@NameHigherEducationMilitary	
			 ,@SeriaHigherEducationMilitaryCertificate
			 ,@NumberHigherEducationMilitaryCertificate
			 ,@MilitarySpecialty
			 
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END


 


-- EXEC [sp_SaveEducationProfessionalTechnicalMilitarySchool] 0,'12345','12.07.2020',Авто-коледж,'2020','2022','Двигуни внутрішнього згорання'
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveMaritalStatus]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveMilitaryAccountingSpecialty]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveMilitaryAccountingSpecialty] 
		@Id int,
		@MilitaryAccountingSpecialtyCode int,		
		@NameMilitaryAccountingSpecialty nvarchar(35)
		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT SoldierAndSergeantMilitaryAccountingSpecialties Off	

	if(@Id > 0)

	begin
		Update SoldierAndSergeantMilitaryAccountingSpecialties
		SET 
			  MilitaryAccountingSpecialty = @MilitaryAccountingSpecialtyCode			
		     ,Description = @NameMilitaryAccountingSpecialty
			
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into SoldierAndSergeantMilitaryAccountingSpecialties 
		  (		    
			  MilitaryAccountingSpecialty
			 
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	
			  ,Description			 
		  )
		  Values
		  (	
		   
			 @MilitaryAccountingSpecialtyCode
			
			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0		
			 ,@NameMilitaryAccountingSpecialty			 
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END

 

-- EXEC [sp_SaveMilitaryAccountingSpecialty] 0,100,'Стрілок'
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveMilitaryAccountingSpecialtyCode]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveMilitaryAccountingSpecialtyCode] 
		@Id int,
		@NameCode nvarchar(35),
		@CodeId int,
	    @SoldierAndSergeantMilitaryAccountingSpecialtiesId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT CodeMilitaryAccountingSpecialties Off	

	if(@Id > 0)

	begin
		Update CodeMilitaryAccountingSpecialties
		SET 
			 Code = @CodeId
		    ,Description = @NameCode			
			,SoldierAndSergeantMilitaryAccountingSpecialtiesId = @SoldierAndSergeantMilitaryAccountingSpecialtiesId
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into CodeMilitaryAccountingSpecialties 
		  (		    
			  Code
			
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	
			  ,Description
			  ,SoldierAndSergeantMilitaryAccountingSpecialtiesId
		  )
		  Values
		  (	
		   
			  @CodeId			 

			 ,GETDATE ( )
			 ,GETDATE ( )
			 ,0
			 ,0
			 ,GETDATE ( )
			 ,0		
			 ,@NameCode
			 ,@SoldierAndSergeantMilitaryAccountingSpecialtiesId
		  )		 
		  Select SCOPE_IDENTITY() As Id	
	END	
	
END

 

--  EXEC [sp_SaveMilitaryAccountingSpecialtyCode] 0,'Оператор вводу',100,'ф'
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveMilitaryAccountingSpecialtyGeneral]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveMilitaryAccountingSpecialtyGeneral] 
		@Id int,
		@MilitaryAccountingSpecialtyCodeId int,
		@CodeId int,
		@LetterId int,
		@PersonId int
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT MilitaryAccountingSpecialtyGenerals Off	
	if(@Id > 0)

	begin
		Update MilitaryAccountingSpecialtyGenerals
		SET 
			 MilitaryAccountingSpecialtyCodeId = @MilitaryAccountingSpecialtyCodeId
			 ,CodeId = @CodeId
			 ,LetterId =@LetterId
			 ,PersonId=@PersonId
		WHERE Id = @Id
 	end
	else
    BEGIN 	
		  INSERT Into MilitaryAccountingSpecialtyGenerals 
		  (	    
			   MilitaryAccountingSpecialtyCodeId
			   ,CodeId
			   ,LetterId
			   ,PersonId

		       ,DateCreated
			   ,DateModified
			   ,IsImported
			   ,NeedToReimport
			   ,ImportDate
			   ,IsActive			  
		  )
		  Values
		  (			   
			  @MilitaryAccountingSpecialtyCodeId
		     ,@CodeId
			 ,@LetterId
			 ,@PersonId
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
/****** Object:  StoredProcedure [dbo].[sp_SaveMilitaryAccountingSpecialtyLetter]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
Create procedure [dbo].[sp_SaveMilitaryAccountingSpecialtyLetter] 
		@Id int,
		@Letter nvarchar(35),
		@DescriptionLetter nvarchar(35)	   
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT MilitaryAccountingSpecialtyLetteries Off	

	if(@Id > 0)

	begin
		Update MilitaryAccountingSpecialtyLetteries
		SET 
			 Letter =@Letter
		    ,DescriptionLetter = @DescriptionLetter		
			
		WHERE Id =@Id
 	end
	else
    BEGIN 	
		  INSERT Into MilitaryAccountingSpecialtyLetteries 
		  (		    
			  Letter
			  ,DescriptionLetter
			  
			  ,DateCreated
			  ,DateModified
			  ,IsImported
			  ,NeedToReimport
			  ,ImportDate
			  ,IsActive	
			 
			  
		  )
		  Values
		  (	
		   
			  @Letter
			 ,@DescriptionLetter
			 
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
/****** Object:  StoredProcedure [dbo].[sp_SaveOtg]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SavePersonalData]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveRegion]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveStatus]    Script Date: 29.08.2022 14:43:00 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_SaveStatusIdForPersonalData]    Script Date: 29.08.2022 14:43:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		
-- Create date: 
-- Description:
-- =============================================
CREATE procedure [dbo].[sp_SaveStatusIdForPersonalData] 
		@Id int,
		@MilitaryRankId int,
		@ServedDescription nvarchar(15)			
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT PersonalData Off	
	if(@Id > 0)

	BEGIN
		Update PersonalData
		SET 
			  StatusId = @MilitaryRankId	
			 ,ServedDescription =@ServedDescription			 			 
		WHERE Id = @Id
 	END
	
END

  
 --EXEC [sp_SaveStatusIdForPersonalData] 5, 0,'Приймав присягу',11
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveVehicle]    Script Date: 29.08.2022 14:43:00 ******/
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
		@YearOfGraduation datetime2(7),
		@CurrentNumberFactory int,
		@FactoryName nvarchar(25),
		@MinistryCode int,
		@TypeCar nvarchar(25),
		@BrandOfMmachine nvarchar(25),
		@StateCarNumber nvarchar(25),
		@YearManufactureCar nvarchar(25),
		@FullNameDriver1 nvarchar(25),
		@FullNameDriver2 nvarchar(25),
		@FullNameDriver3 nvarchar(25),
		@TechnicalCondition nvarchar(25)
		
AS
BEGIN	
	--SET NOCOUNT ON;
	SET IDENTITY_INSERT Vehicles Off	
	if(@Id > 0)

	begin
		Update Vehicles
		SET 
			 Consignment = @Consignment	
			 ,[DateTime] = CONVERT(datetime2,@YearOfGraduation,103) 		
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
			 ,@YearManufactureCar
			
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

 -- select * from Vehicles
 
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveVillage]    Script Date: 29.08.2022 14:43:00 ******/
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
