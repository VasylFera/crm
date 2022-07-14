using System.Collections.Generic;
using System.Data;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class VehicleAdapter
    {
        public static void SaveVehicle(VehicleDto model)
        {
           if(model.TechnicalCondition == "справний")
            {
                model.IsTechnicalCondition = true;
            }
            else
            {
                model.IsTechnicalCondition = false;
            }
            var sql = string.Empty;
            sql = string.Format(@"EXEC [sp_SaveVehicle] {0}, {1}, {2}, {3}, {4},{5}, {6}, {7}, {8},{9},{10}, {11}, {12},{13}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.RawSafeSqlString(model.Consignment),
                DataBaseHelper.SafeSqlString(model.YearOfGraduation),
                DataBaseHelper.RawSafeSqlString(model.CurrentNumberFactory),
                DataBaseHelper.SafeSqlString(model.FactoryName),
                DataBaseHelper.RawSafeSqlString(model.MinistryCode),
                DataBaseHelper.SafeSqlString(model.TypeCar),
                DataBaseHelper.SafeSqlString(model.BrandOfMmachine),
                DataBaseHelper.SafeSqlString(model.StateCarNumber),
                DataBaseHelper.SafeSqlString(model.YearManufactureCar),
                DataBaseHelper.SafeSqlString(model.FullNameDriver1),
                DataBaseHelper.SafeSqlString(model.FullNameDriver2),
                DataBaseHelper.SafeSqlString(model.FullNameDriver3),
                DataBaseHelper.SafeSqlString(model.IsTechnicalCondition));
            DataBaseHelper.RunSql(sql);
            //if (model.Id > 0)
            //{
               
            //}
            //else
            //{

            //}
              
            
        }

        public static List<VehicleDto> GetAllVehicles()
        {
            var result = new List<VehicleDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllVehicles] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new VehicleDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Consignment = DataBaseHelper.GetIntegerValueFromRowByName(item, "Consignment"),
                        YearOfGraduation = DataBaseHelper.GetDateTimeValueFromRowByName(item, "YearOfGraduation"),
                        CurrentNumberFactory = DataBaseHelper.GetIntegerValueFromRowByName(item, "CurrentNumberFactory"),
                        FactoryName = DataBaseHelper.GetValueFromRowByName(item, "FactoryName"),
                        MinistryCode = DataBaseHelper.GetIntegerValueFromRowByName(item, "MinistryCode"),
                        TypeCar = DataBaseHelper.GetValueFromRowByName(item, "TypeCar"),
                        BrandOfMmachine = DataBaseHelper.GetValueFromRowByName(item, "BrandOfMmachine"),
                        StateCarNumber = DataBaseHelper.GetValueFromRowByName(item, "StateCarNumber"),
                        YearManufactureCar = DataBaseHelper.GetValueFromRowByName(item, "YearManufactureCar"),
                        FullNameDriver1 = DataBaseHelper.GetValueFromRowByName(item, "FullNameDriver1"),
                        TechnicalCondition = DataBaseHelper.GetValueFromRowByName(item, "TechnicalCondition"),
                        FullNameDriver2 = DataBaseHelper.GetValueFromRowByName(item, "FullNameDriver2"),
                        FullNameDriver3 = DataBaseHelper.GetValueFromRowByName(item, "FullNameDriver3")
                    });
                }
            }

            return result;
        }
    }
}
