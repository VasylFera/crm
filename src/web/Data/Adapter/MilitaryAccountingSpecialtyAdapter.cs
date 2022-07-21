using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class MilitaryAccountingSpecialtyAdapter
    {
        public static int SaveMilitaryAccountingSpecialtyCode(MilitaryAccountingSpecialtyCodeDto model)
        {
            var sql = string.Empty;
            var Id = 0;

            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialtyCode] {0},{1},{2},{3}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.NameCode),
                DataBaseHelper.RawSafeSqlString(model.Code),            
                DataBaseHelper.RawSafeSqlString(model.SoldierAndSergeantMilitaryAccountingSpecialtiesId));              

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
               sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialtyCode] {0},{1},{2},{3}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.NameCode),
                DataBaseHelper.RawSafeSqlString(model.Code),              
                DataBaseHelper.RawSafeSqlString(model.SoldierAndSergeantMilitaryAccountingSpecialtiesId));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static int SaveMilitaryAccountingSpecialty(MilitaryAccountingSpecialtyDto model)
        {
            var sql = string.Empty;
            var Id = 0;

            if (model.Id == 0)
            {
                sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialty] {0},{1},{2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.RawSafeSqlString(model.MilitaryAccountingSpecialtyCode),                              
                DataBaseHelper.SafeSqlString(model.NameMilitaryAccountingSpecialty));               

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
                sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialty] {0},{1},{2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.RawSafeSqlString(model.MilitaryAccountingSpecialtyCode),                
                DataBaseHelper.SafeSqlString(model.NameMilitaryAccountingSpecialty));
                DataBaseHelper.RunSql(sql);
            }

            return Id;
        }

        public static List<MilitaryAccountingSpecialtyDto> GetAllMilitaryAccountingSpecialty()
        {
            var result = new List<MilitaryAccountingSpecialtyDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllMilitaryAccountingSpecialties] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new MilitaryAccountingSpecialtyDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        MilitaryAccountingSpecialtyCode = DataBaseHelper.GetIntegerValueFromRowByName(item, "MilitaryAccountingSpecialtyCode"),
                        NameMilitaryAccountingSpecialty = DataBaseHelper.GetValueFromRowByName(item, "NameMilitaryAccountingSpecialty")                       
                    });
                }
            }

            return result;
        }

        public static List<MilitaryAccountingSpecialtyCodeDto> GetAllCodeMilitaryAccountingSpecialtyId(int id)
        {
            var result = new List<MilitaryAccountingSpecialtyCodeDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllCodeMilitaryAccountingSpecialties] {0}",
                 DataBaseHelper.RawSafeSqlString(id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new MilitaryAccountingSpecialtyCodeDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Code = DataBaseHelper.GetIntegerValueFromRowByName(item, "Code"),
                        NameCode = DataBaseHelper.GetValueFromRowByName(item, "NameMilitaryAccountingSpecialty")                       
                    });
                }
            }

            return result;
        }

        public static void SaveMilitaryAccountingSpecialtyLetter(MilitaryAccountingSpecialtyLetterDto model)
        {           
            var sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialtyLetter] {0},{1},{2}",
            DataBaseHelper.RawSafeSqlString(model.Id),
            DataBaseHelper.SafeSqlString(model.Letter),
            DataBaseHelper.SafeSqlString(model.DescriptionLetter));
            DataBaseHelper.RunSql(sql);
        }

        public static List<MilitaryAccountingSpecialtyLetterDto> GetAllMilitaryAccountingSpecialtyLetter()
        {
            var result = new List<MilitaryAccountingSpecialtyLetterDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllMilitaryAccountingSpecialtiyLetters] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new MilitaryAccountingSpecialtyLetterDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),                       
                        Letter = DataBaseHelper.GetValueFromRowByName(item, "Letter"),
                        DescriptionLetter = DataBaseHelper.GetValueFromRowByName(item, "DescriptionLetter")
                    });
                }
            }

            return result;
        }

        public static MilitaryAccountingSpecialtyLetterDto GetMilitaryAccountingSpecialtyLetterId(int Id)
        {
            MilitaryAccountingSpecialtyLetterDto result = new MilitaryAccountingSpecialtyLetterDto();

            var sql = string.Format(@"EXEC [sp_GetMilitaryAccountingSpecialtyLetterId] {0}",
               DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new MilitaryAccountingSpecialtyLetterDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Letter = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Letter"),
                    DescriptionLetter = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "DescriptionLetter")
                };
            }

            return result;
        }
    }
}
