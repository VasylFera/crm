using System;

namespace web.Data.ModelDtos
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public int Consignment { get; set; }
        public string YearOfGraduation { get; set; }
        public int CurrentNumberFactory { get; set; }
        public string FactoryName { get; set; }
        public int MinistryCode { get; set; }
        public string TypeCar { get; set; }
        public string BrandOfMmachine { get; set; }
        public string StateCarNumber { get; set; }
        public string YearManufactureCar { get; set; }
        public string FullNameDriver1 { get; set; }
        public string FullNameDriver2 { get; set; }
        public string FullNameDriver3 { get; set; }
        public string TechnicalCondition { get; set; }
        public bool IsTechnicalCondition { get; set; }
        public int PersonalDriverId { get; set; }
    }
}
