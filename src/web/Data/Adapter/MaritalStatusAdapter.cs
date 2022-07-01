using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class MaritalStatusAdapter
    {
        public static void SaveMaritalStatus(MaritalStatusDto model)
        {
            var sql = string.Empty;
            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveMaritalStatus] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));
                DataBaseHelper.RunSql(sql);
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveMaritalStatus] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));
                DataBaseHelper.RunSql(sql);
            }
        }

        public static List<MaritalStatusDto> GetAllMaritalStatus()
        {
            var result = new List<MaritalStatusDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllMaritalStatus] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new MaritalStatusDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static MaritalStatusDto GetMaritalStatusId(int Id)
        {
            MaritalStatusDto result = new MaritalStatusDto();

            var sql = string.Format(@"EXEC [sp_GetMaritalStatusId] {0}",
               DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new MaritalStatusDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Name = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Name")
                };
            }

            return result;
        }

        public static void DeleteMaritalStatus(int id)
        {
            if (id > 0)
            {
                string sql = string.Format(@"exec sp_DeleteMaritalStatus {0}",
                DataBaseHelper.RawSafeSqlString(id));
                DataBaseHelper.RunSql(sql);
            }
        }
    }
}
