using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class StatusAdapter
    {
        public static void SaveStatus(StatusDto model)
        {
            var sql = string.Empty;   
            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveStatus] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));
                DataBaseHelper.RunSql(sql);               
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveStatus] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));
                DataBaseHelper.RunSql(sql);                               
            }                       
        }

        public static List<StatusDto> GetAllStatus()
        {
            var result = new List<StatusDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllStatus] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new StatusDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Description")
                    });
                }
            }

            return result;
        }

        public static StatusDto GetDistrictId(int Id)
        {
            StatusDto result = new StatusDto();

            var sql = string.Format(@"EXEC [sp_GetStatusId] {0}",
            DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new StatusDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Name = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Description")
                };
            }

            return result;
        }

        public static void Delete(int id)
        {
            if (id > 0)
            {
                string sql = string.Format(@"exec sp_DeleteStatus {0}",
                DataBaseHelper.RawSafeSqlString(id));
                DataBaseHelper.RunSql(sql);
            }
        }
    }
}
