using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class MilitaryAccountingSpecialtyAdapter
    {
        public static void SaveMilitaryAccountingSpecialty(MilitaryAccountingSpecialtyDto model)
        {
            var sql = string.Empty;
            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveMilitaryAccountingSpecialty] {0},{1},{2},{3}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.MilitaryAccountingSpecialty),
                DataBaseHelper.SafeSqlString(model.Code),
                DataBaseHelper.SafeSqlString(model.Letter));
                DataBaseHelper.RunSql(sql);
            }           
        }
    }
}
