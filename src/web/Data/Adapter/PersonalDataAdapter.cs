﻿using System;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class PersonalDataAdapter
    {
            public static int SavePersonalData(PersonalDataDto personalDataModel,  int countryId,
                                                                                   int regionId,
                                                                                   int districtId,
                                                                                   int otgId,
                                                                                   int villageId)
            {
            var sql = string.Empty;
            var Id = 0;
            var email = "test@outlook.com";
            var userId = "970c2976-c1ad-4ddb-9f40-0910c5eeb3f1";
            //, {12},{13}, {14}, {15}, {16},{17}, {18}, {19}, {20},{21},{22}
            if(personalDataModel.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SavePersonalData] {0}, {1}, {2}, {3}, {4},{5}, {6}, {7}, {8},{9},{10}, {11},{12}, {13}, {14},{15},{16},{17},{18},{19}",
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
                DataBaseHelper.SafeSqlString(email),
                DataBaseHelper.SafeSqlString(personalDataModel.MaritalStatus),
                DataBaseHelper.SafeSqlString(personalDataModel.Note),
                DataBaseHelper.SafeSqlString(userId),
                DataBaseHelper.RawSafeSqlString(countryId),
                DataBaseHelper.RawSafeSqlString(regionId),
                DataBaseHelper.RawSafeSqlString(districtId),
                DataBaseHelper.RawSafeSqlString(otgId),
                DataBaseHelper.RawSafeSqlString(villageId),
                DataBaseHelper.SafeSqlString(personalDataModel.FirstName));

                //DataBaseHelper.RawSafeSqlString(villageId),
                //DataBaseHelper.SafeSqlString(personalDataModel.BloodType),
                //DataBaseHelper.SafeSqlString(personalDataModel.RezusTypeBlood));
                //   DataBaseHelper.SafeSqlString(personalDataModel.Phone1),
                //  DataBaseHelper.SafeSqlString(personalDataModel.Phone2),
                //  DataBaseHelper.SafeSqlString(personalDataModel.FamilyStatus),
                //  DataBaseHelper.SafeSqlString(personalDataModel.ServiceNote));
                //  var sqlResult = DataBaseHelper.RunSql(sql);
                //  return 0;
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
                //sql = string.Format(@"EXEC [sp_SavePersonalData] {0}, {1}, {2}",
                //DataBaseHelper.RawSafeSqlString(model.Id),
                // DataBaseHelper.SafeSqlString(model.FirstName),
                //DataBaseHelper.SafeSqlString(model.FatherName),
                //DataBaseHelper.SafeSqlString(model.LastName));
                //var dataResult = DataBaseHelper.GetSqlResult(sql);

                //if (dataResult != null && dataResult.Rows.Count > 0)
                //{
                //    foreach (DataRow row in dataResult.Rows)
                //    {
                //        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                //    }
                //}
             
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
                };
            }

            return result;
        }
    }
}
