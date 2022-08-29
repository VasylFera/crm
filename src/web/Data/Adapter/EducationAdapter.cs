using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class EducationAdapter
    {
        public static void SaveEducationDataGeneral(EducationDataGeneralDto model)
        {
            var sql = string.Empty;
            //int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveEducationDataGenera] {0},{1},{2},{3},{4},{5},{6}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.RawSafeSqlString(model.PersonId),
                DataBaseHelper.RawSafeSqlString(model.SchoolId),
                DataBaseHelper.RawSafeSqlString(model.ProfessionalTechnicalSchoolId),
                DataBaseHelper.RawSafeSqlString(model.HigherEducationId),
                DataBaseHelper.RawSafeSqlString(model.ProfessionalTechnicalMilitaryId),
                DataBaseHelper.RawSafeSqlString(model.HigherEducationlMilitaryId));
                DataBaseHelper.RunSql(sql);
            }                       
        }


        public static int SaveEducationSchool(EducationSchoolDto model)
        {
            var sql = string.Empty;
            int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveEducationSchool] {0},{1},{2},{3},{4},{5},{6},{7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.NumberOfClasses),
                DataBaseHelper.SafeSqlString(model.NameSchool),
                DataBaseHelper.SafeSqlString(model.SeriaSchoolCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberSchoolCertificate));

                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }
                                
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveEducationSchool] {0}, {1},{2},{3},{4},{5},{6},{7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.NumberOfClasses),
                DataBaseHelper.SafeSqlString(model.NameSchool),
                DataBaseHelper.SafeSqlString(model.SeriaSchoolCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberSchoolCertificate));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static EducationSchoolDto GetEducationSchoolId(int Id)
        {
            EducationSchoolDto result = new EducationSchoolDto();

            var sql = string.Format(@"EXEC [sp_GetEducationSchoolId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

         
            if (sqlResult.Rows.Count > 0)
            {
                result = new EducationSchoolDto()
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Start = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Start"),
                    End = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "End"),
                    StatusSchoolCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "StatusSchoolCertificate"),
                    NumberOfClasses = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NumberOfClasses"),
                    NameSchool = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NameSchool"),
                    SeriaSchoolCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SeriaSchoolCertificate"),
                    NumberSchoolCertificate = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "NumberSchoolCertificate")
                };                    
            }

            return result;
        }

        public static EducationProfessionalTechnicalSchoolDto GetEducationProfessionalTechnicalSchoolId(int Id)
        {
            EducationProfessionalTechnicalSchoolDto result = new EducationProfessionalTechnicalSchoolDto();
                                          
            var sql = string.Format(@"EXEC [sp_GetEducationProfessionalTechnicalSchoolId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new EducationProfessionalTechnicalSchoolDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Start = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Start"),
                    End = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "End"),
                    StatusProfessionalTechnicalSchoolCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "StatusProfessionalTechnicalSchoolCertificate"),
                    NameProfessionalTechnicalSchool = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NameProfessionalTechnicalSchool"),
                    SeriaProfessionalTechnicalSchoolCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SeriaProfessionalTechnicalSchoolCertificate"),
                    NumberProfessionalTechnicalSchoolCertificate = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "NumberProfessionalTechnicalSchoolCertificate"),
                    SpecialtyProfessionalTechnicalSchool = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SpecialtyProfessionalTechnicalSchool")
                };
            }

            return result;
        }

        public static HigherEducationDto GetHightEducationId(int Id)
        {
            HigherEducationDto result = new HigherEducationDto();

            var sql = string.Format(@"EXEC [sp_GetHigherEducationId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new HigherEducationDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Start = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Start"),
                    End = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "End"),
                    StatusHigherEducationlCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "StatusHigherEducationlCertificate"),
                    NameHigherEducation = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NameHigherEducation"),
                    SeriaHigherEducationCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SeriaHigherEducationCertificate"),
                    NumberHigherEducationCertificate = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "NumberHigherEducationCertificate"),
                    SpecialtyHigherEducation = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SpecialtyHigherEducation"),
                    ТameOfTheMilitaryDepartment = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "ТameOfTheMilitaryDepartment"),
                    MilitarySpecialty = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "MilitarySpecialty")
                };
            }

            return result;
        }

        public static EducationProfessionalTechnicalMilitarySchoolDto GetEducationProfessionalTechnicalMilitarySchoolId(int Id)
        {
            EducationProfessionalTechnicalMilitarySchoolDto result = new EducationProfessionalTechnicalMilitarySchoolDto();

            var sql = string.Format(@"EXEC [sp_EducationProfessionalTechnicalMilitarySchoolId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new EducationProfessionalTechnicalMilitarySchoolDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    RVCReferralNumber = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "RVCReferralNumber"),
                    RVCReferralDate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "RVCReferralDate"),
                    NameProfessionalTechnicalMilitarySchool = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NameProfessionalTechnicalMilitarySchool"),
                    Start = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Start"),
                    End = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "End"),                          
                    SpecialtyProfessionalTechnicalMilitarySchool = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SpecialtyProfessionalTechnicalMilitarySchool")                   
                };
            }

            return result;
        }

        public static int SaveEducationProfessionalTechnicalSchool(EducationProfessionalTechnicalSchoolDto model)
        {
            var sql = string.Empty;
            int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveEducationProfessionalTechnicalSchool] {0},{1},{2},{3},{4},{5},{6},{7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.NameProfessionalTechnicalSchool),
                DataBaseHelper.SafeSqlString(model.SeriaProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.SpecialtyProfessionalTechnicalSchool));


                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }

            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveEducationProfessionalTechnicalSchool] {0}, {1},{2},{3},{4},{5},{6},{7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.NameProfessionalTechnicalSchool),
                DataBaseHelper.SafeSqlString(model.SeriaProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberProfessionalTechnicalSchoolCertificate),
                DataBaseHelper.SafeSqlString(model.SpecialtyProfessionalTechnicalSchool));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static List<EducationDataGeneralDto> GetGeneralEducation(int Id)
        {
            List<EducationDataGeneralDto> result = new List<EducationDataGeneralDto>();

            var sql = string.Format(@"EXEC [sp_GetEducationGeneralId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);


            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new EducationDataGeneralDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        PersonId = DataBaseHelper.GetIntegerValueFromRowByName(item, "PersonId"),
                        SchoolId = DataBaseHelper.GetIntegerValueFromRowByName(item, "SchoolId"),
                        ProfessionalTechnicalSchoolId = DataBaseHelper.GetIntegerValueFromRowByName(item, "ProfessionalTechnicalSchoolId"),
                        HigherEducationId = DataBaseHelper.GetIntegerValueFromRowByName(item, "HigherEducationId"),
                        ProfessionalTechnicalMilitaryId = DataBaseHelper.GetIntegerValueFromRowByName(item, "ProfessionalTechnicalMilitaryId"),
                        HigherEducationlMilitaryId = DataBaseHelper.GetIntegerValueFromRowByName(item, "HigherEducationlMilitaryId")
                       
                    });
                }
            }

            return result;
        }

        public static int SaveHigherEducation(HigherEducationDto model)
        {
            var sql = string.Empty;
            int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveHigherEducation] {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusHigherEducationlCertificate),
                DataBaseHelper.SafeSqlString(model.NameHigherEducation),
                DataBaseHelper.SafeSqlString(model.SeriaHigherEducationCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberHigherEducationCertificate),
                DataBaseHelper.SafeSqlString(model.SpecialtyHigherEducation),
                DataBaseHelper.SafeSqlString(model.ТameOfTheMilitaryDepartment),
                DataBaseHelper.SafeSqlString(model.MilitarySpecialty));


                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }

            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveHigherEducation] {0}, {1},{2},{3},{4},{5},{6},{7},{8},{9}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusHigherEducationlCertificate),
                DataBaseHelper.SafeSqlString(model.NameHigherEducation),
                DataBaseHelper.SafeSqlString(model.SeriaHigherEducationCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberHigherEducationCertificate),
                DataBaseHelper.SafeSqlString(model.SpecialtyHigherEducation),
                DataBaseHelper.SafeSqlString(model.ТameOfTheMilitaryDepartment),
                DataBaseHelper.SafeSqlString(model.MilitarySpecialty));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static int SaveEducationProfessionalTechnicalMilitarySchool(EducationProfessionalTechnicalMilitarySchoolDto model)
        {
            var sql = string.Empty;
            int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveEducationProfessionalTechnicalMilitarySchool] {0},{1},{2},{3},{4},{5},{6}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.RVCReferralNumber),
                DataBaseHelper.SafeSqlString(model.RVCReferralDate),
                DataBaseHelper.SafeSqlString(model.NameProfessionalTechnicalMilitarySchool),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),                             
                DataBaseHelper.SafeSqlString(model.SpecialtyProfessionalTechnicalMilitarySchool));

                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }

            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveEducationProfessionalTechnicalMilitarySchool] {0}, {1},{2},{3},{4},{5},{6}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.RVCReferralNumber),
                DataBaseHelper.SafeSqlString(model.RVCReferralDate),
                DataBaseHelper.SafeSqlString(model.NameProfessionalTechnicalMilitarySchool),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.SpecialtyProfessionalTechnicalMilitarySchool));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static int SaveHigherEducationMilitary(HigherEducationMilitaryDto model)
        {
            var sql = string.Empty;
            int Id = 0;
            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveHigherEducationMilitary] {0},{1},{2},{3},{4},{5},{6}, {7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusHigherEducationlMilitaryCertificate),
                DataBaseHelper.SafeSqlString(model.NameHigherEducationMilitary),
                DataBaseHelper.SafeSqlString(model.SeriaHigherEducationMilitaryCertificate),               
                DataBaseHelper.RawSafeSqlString(model.NumberHigherEducationMilitaryCertificate),
                DataBaseHelper.SafeSqlString(model.MilitarySpecialty));

                var dataResult = DataBaseHelper.GetSqlResult(sql);
                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "Id");
                    }
                }

            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveHigherEducationMilitary] {0},{1},{2},{3},{4},{5},{6},{7}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Start),
                DataBaseHelper.SafeSqlString(model.End),
                DataBaseHelper.SafeSqlString(model.StatusHigherEducationlMilitaryCertificate),
                DataBaseHelper.SafeSqlString(model.NameHigherEducationMilitary),
                DataBaseHelper.SafeSqlString(model.SeriaHigherEducationMilitaryCertificate),
                DataBaseHelper.RawSafeSqlString(model.NumberHigherEducationMilitaryCertificate),
                DataBaseHelper.SafeSqlString(model.MilitarySpecialty));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static HigherEducationMilitaryDto GetHigherEducationMilitaryId(int Id)
        {
            HigherEducationMilitaryDto result = new HigherEducationMilitaryDto();

            var sql = string.Format(@"EXEC [sp_EducationHigherEducationMilitaryId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new HigherEducationMilitaryDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Start = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Start"),
                    End = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "End"),
                    StatusHigherEducationlMilitaryCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "StatusHigherEducationlMilitaryCertificate"),
                    NameHigherEducationMilitary = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "NameHigherEducationMilitary"),
                    SeriaHigherEducationMilitaryCertificate = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "SeriaHigherEducationMilitaryCertificate"),                   
                    NumberHigherEducationMilitaryCertificate = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "NumberHigherEducationMilitaryCertificate"),
                    MilitarySpecialty = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "MilitarySpecialty"),
                };
            }

            return result;
        }
    }
}
