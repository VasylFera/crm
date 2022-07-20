using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web.EF;
using web.Extension;

namespace web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            if (!string.IsNullOrEmpty(Database.GetDbConnection().ConnectionString))
            {
                ConnectionString.Value = Database.GetDbConnection().ConnectionString;
            }
        }

        public DbSet<EF.PersonalDataModel> PersonalData { get; set; }
        public DbSet<PlaceOfBirthModel> PlaceOfBirth { get; set; }
        public DbSet<BloodTypeModel> BloodType { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<VehicleModel> Vehicles { get; set; }        
        public DbSet<CountryModel> Country { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        public DbSet<DistrictModel> Districts { get; set; }
        public DbSet<VillageModel> Villages { get; set; }
        public DbSet<OtgModel> Otgs { get; set; }
        public DbSet<PersonalDataCountryModel> PersonalDataCountries { get; set; }
        public DbSet<AccountConscriptModel> AccountConscrip { get; set; }
        public DbSet<AccountSoldierModel> AccountSoldier { get; set; }
        public DbSet<AccountSergeantModel> AccountSergeant { get; set; }
        public DbSet<AccountOfficerModel> AccountOfficer { get; set; }
        public DbSet<MaritalStatusModel> MaritalStatuses { get; set; }   
        public DbSet<OfficerMilitaryAccountingSpecialtyModel> OfficerMilitaryAccountingSpecialties { get; set; }
        public DbSet<SoldierAndSergeantMilitaryAccountingSpecialtyModel> SoldierAndSergeantMilitaryAccountingSpecialties { get; set; }
        public DbSet<CodeMilitaryAccountingSpecialtyModel> CodeMilitaryAccountingSpecialties { get; set; }
    }
}
