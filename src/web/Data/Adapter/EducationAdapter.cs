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
            int Id = 0;
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
    }
}
