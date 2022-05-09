using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using web.Data.ModelDtos;
using web.Helpers;

namespace web.Data.Adapter
{
    public static class RegionAdapter
    {
        public static int SaveRegion(RegionDto model)
        {
            var sql = string.Empty;
            var regionId = 0;
            
            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveRegion] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));        
                var sqlResult = DataBaseHelper.RunSql(sql);
                return 0;
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveRegion] {0}, {1}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name));
                var  dataResult = DataBaseHelper.GetSqlResult(sql);

                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        regionId = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "RegionId");
                    }
                }
            }

            return regionId;
        }


        public static  RegionDto GetRegionId(int Id)
        {
            RegionDto result = new RegionDto();

            var sql = string.Format(@"EXEC [sp_GetRegionId] {0}",
               DataBaseHelper.RawSafeSqlString(Id));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                result = new RegionDto
                {
                    Id = DataBaseHelper.GetIntegerValueFromRowByName(sqlResult.Rows[0], "Id"),
                    Name = DataBaseHelper.GetValueFromRowByName(sqlResult.Rows[0], "Name")                   
                };
            }

            return result;
        }

        public static  List<RegionDto> GetAllRegions()
        {
            var result = new List<RegionDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllRegion] ");           
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new RegionDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")                        
                    });
                }
            }

            return result;
        }

        public static int SaveDistrict(DistrictDto model)
        {
            var sql = string.Empty;
            var districtId = 0;

            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveDistrict] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.RegionId));
                var sqlResult = DataBaseHelper.RunSql(sql);
                return 0;
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveDistrict] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.RegionId));
                var dataResult = DataBaseHelper.GetSqlResult(sql);

                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        districtId = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "DistrictId");
                    }
                }
            }

            return districtId;
        }

        public static List<DistrictDto> GetAllDistricts()
        {
            var result = new List<DistrictDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllDistricts] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new DistrictDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static List<DistrictDto> GetAllDistrictsForRegion(int regionId)
        {
            var result = new List<DistrictDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllDistrictsForRegion] {0}",
            DataBaseHelper.RawSafeSqlString(regionId));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new DistrictDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static int SaveOtg(OtgDto model)
        {
            var sql = string.Empty;
            var otgId = 0;

            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveOtg] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.DistrictId));
                var sqlResult = DataBaseHelper.RunSql(sql);
                return 0;
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveOtg] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.DistrictId));
                var dataResult = DataBaseHelper.GetSqlResult(sql);

                if (dataResult != null && dataResult.Rows.Count > 0)
                {
                    foreach (DataRow row in dataResult.Rows)
                    {
                        otgId = DataBaseHelper.GetIntegerValueFromRowByName(dataResult.Rows[0], "OtgId");
                    }
                }
            }

            return otgId;
        }

        public static List<OtgDto> GetAllOtgs()
        {
            var result = new List<OtgDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllOtgs] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new OtgDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static List<OtgDto> GetAllDistrictsForOtg(int districtId)
        {
            var result = new List<OtgDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllDistrictsForOtg] {0}",
            DataBaseHelper.RawSafeSqlString(districtId));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new OtgDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static int SaveVillage(VillageDto model)
        {
            var sql = string.Empty;
       
            if (model.Id > 0)
            {
                sql = string.Format(@"EXEC [sp_SaveVillage] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.OtgId));
                var sqlResult = DataBaseHelper.RunSql(sql);
                return 0;
            }
            else
            {
                sql = string.Format(@"EXEC [sp_SaveVillage] {0}, {1}, {2}",
                DataBaseHelper.RawSafeSqlString(model.Id),
                DataBaseHelper.SafeSqlString(model.Name),
                DataBaseHelper.RawSafeSqlString(model.OtgId));
                var sqlResult = DataBaseHelper.RunSql(sql);
                return 0;
            }
                       
        }

        public static List<VillageDto> GetAllVillages()
        {
            var result = new List<VillageDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllVillages] ");
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new VillageDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }

        public static List<VillageDto> GetAllDistrictsForVillages(int otgId)
        {
            var result = new List<VillageDto>();

            string sql = null;
            sql = string.Format(@"exec [sp_GetAllDistrictsForVillages] {0}",
            DataBaseHelper.RawSafeSqlString(otgId));
            var sqlResult = DataBaseHelper.GetSqlResult(sql);

            if (sqlResult.Rows.Count > 0)
            {
                foreach (DataRow item in sqlResult.Rows)
                {
                    result.Add(new VillageDto
                    {
                        Id = DataBaseHelper.GetIntegerValueFromRowByName(item, "Id"),
                        Name = DataBaseHelper.GetValueFromRowByName(item, "Name")
                    });
                }
            }

            return result;
        }
    }
}
