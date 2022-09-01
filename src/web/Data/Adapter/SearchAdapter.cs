using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class SearchAdapter
    {
        public static IEnumerable<PersonalDataSearchDto> GetPersonalSearch(PersonalDataSearchDto model)
        {
            var result = new List<PersonalDataSearchDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetPersonDataSearch] {0},{1},{2},{3},{4}",
            //DataBaseHelper.RawSafeSqlString(model.Id),
            DataBaseHelper.SafeSqlString(model.LastName),
            DataBaseHelper.SafeSqlString(model.FirstName),
            DataBaseHelper.SafeSqlString(model.FatherName),
            DataBaseHelper.SafeSqlString(model.IdentityNumber),
            DataBaseHelper.SafeSqlString(model.ResidentialAddress));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new PersonalDataSearchDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        LastName = DataBaseHelper.GetValueFromRowByName(item, "LastName"),
                        FirstName = DataBaseHelper.GetValueFromRowByName(item, "FirstName"),
                        FatherName = DataBaseHelper.GetValueFromRowByName(item, "FatherName"),
                        IdentityNumber = DataBaseHelper.GetValueFromRowByName(item, "IndividualPersonalNumber"),
                        ResidentialAddress = DataBaseHelper.GetValueFromRowByName(item, "VillageName")
                    });
                }
            }

            return result;
        }
    }
}
