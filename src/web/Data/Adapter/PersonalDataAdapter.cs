﻿using System;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class PersonalDataAdapter
    {
            public static int SavePersonalData(PersonalDataDto personalDataModel)
            {
              var sql = string.Empty;
              var Id = 0;          
              var userId = "970c2976-c1ad-4ddb-9f40-0910c5eeb3f1";
            
            if(personalDataModel.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SavePersonalData] {0}, {1}, {2}, {3}, {4},{5}, {6}, {7}, {8},{9},{10}, {11},{12}, {13}, {14},{15},{16},{17},{18}",
                DataBaseHelper.RawSafeSqlString(personalDataModel.Id),
                DataBaseHelper.SafeSqlString(personalDataModel.FatherName),
                DataBaseHelper.SafeSqlString(personalDataModel.NoneFatherName),
                DataBaseHelper.SafeSqlString(personalDataModel.LastName),
                DataBaseHelper.SafeSqlString(personalDataModel.PreviousLastName),
                DataBaseHelper.SafeSqlString(personalDataModel.FullNamePatronymicInTheGenitiveCase),
                DataBaseHelper.SafeSqlString(personalDataModel.Sex),
                DataBaseHelper.SafeSqlString(personalDataModel.DateOfBirth),
                DataBaseHelper.SafeSqlString(personalDataModel.RefusalOfIndividualPersonalNumber),
                DataBaseHelper.SafeSqlString(personalDataModel.IndividualPersonalNumber),
                DataBaseHelper.SafeSqlString(personalDataModel.Email),
                DataBaseHelper.SafeSqlString(personalDataModel.MaritalStatus),
                DataBaseHelper.SafeSqlString(personalDataModel.Note),
                DataBaseHelper.SafeSqlString(userId),
                //DataBaseHelper.RawSafeSqlString(countryId),
                //DataBaseHelper.RawSafeSqlString(regionId),
                //DataBaseHelper.RawSafeSqlString(districtId),
                //DataBaseHelper.RawSafeSqlString(otgId),
                //DataBaseHelper.RawSafeSqlString(villageId),
                DataBaseHelper.SafeSqlString(personalDataModel.FirstName),
                DataBaseHelper.SafeSqlString(personalDataModel.Phone1),
                DataBaseHelper.SafeSqlString(personalDataModel.Phone2),
                DataBaseHelper.SafeSqlString(personalDataModel.ServiceNote),
                DataBaseHelper.SafeSqlString(personalDataModel.MaritalStatusNameId));
                                
                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }

                return Id;
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SavePersonalData] {0}, {1}, {2}, {3}, {4},{5}, {6}, {7}, {8},{9},{10}, {11},{12}, {13}, {14},{15},{16},{17},{18}",
                DataBaseHelper.RawSafeSqlString(personalDataModel.Id),
                DataBaseHelper.SafeSqlString(personalDataModel.FatherName),
                DataBaseHelper.SafeSqlString(personalDataModel.NoneFatherName),
                DataBaseHelper.SafeSqlString(personalDataModel.LastName),
                DataBaseHelper.SafeSqlString(personalDataModel.PreviousLastName),
                DataBaseHelper.SafeSqlString(personalDataModel.FullNamePatronymicInTheGenitiveCase),
                DataBaseHelper.SafeSqlString(personalDataModel.Sex),
                DataBaseHelper.SafeSqlString(personalDataModel.DateOfBirth),
                DataBaseHelper.SafeSqlString(personalDataModel.RefusalOfIndividualPersonalNumber),
                DataBaseHelper.SafeSqlString(personalDataModel.IndividualPersonalNumber),
                DataBaseHelper.SafeSqlString(personalDataModel.Email),
                DataBaseHelper.SafeSqlString(personalDataModel.MaritalStatus),
                DataBaseHelper.SafeSqlString(personalDataModel.Note),
                DataBaseHelper.SafeSqlString(userId),
                //DataBaseHelper.RawSafeSqlString(countryId),
                //DataBaseHelper.RawSafeSqlString(regionId),
                //DataBaseHelper.RawSafeSqlString(districtId),
                //DataBaseHelper.RawSafeSqlString(otgId),
                //DataBaseHelper.RawSafeSqlString(villageId),
                DataBaseHelper.SafeSqlString(personalDataModel.FirstName),
                DataBaseHelper.SafeSqlString(personalDataModel.Phone1),
                DataBaseHelper.SafeSqlString(personalDataModel.Phone2),
                DataBaseHelper.SafeSqlString(personalDataModel.ServiceNote),
                DataBaseHelper.SafeSqlString(personalDataModel.MaritalStatusNameId));
                DataBaseHelper.RunSql(sql);                
            }

            return Id;
        }

        public static PersonalDataDto GetPersonalDataId(int Id)
        {
            PersonalDataDto result = new PersonalDataDto();

            var sql = string.Format(@"EXEC [sp_GetPersonalDataId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new PersonalDataDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    LastName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "LastName"),
                    FirstName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "FirstName"),
                    FatherName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "FatherName"),
                    PreviousLastName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "PreviousLastName"),
                    FullNamePatronymicInTheGenitiveCase = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "FullNamePatronymicInTheGenitiveCase"),
                    NoneFatherName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NoneFatherName"),
                    Sex = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Sex"),
                    DateOfBirth = DataBaseHelper.GetDateTimeValueFromRowByName(sqlResult.Rows[0], "DateOfBirth"),
                    IndividualPersonalNumber = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "IndividualPersonalNumber"),
                    Email = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Email"),
                    VillageId = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "VillageId"),
                    VillageName = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "VillageName"),
                    MaritalStatusNameId = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "MaritalStatusNameId")
                };
            }

            return result;
        }             
    }
}
