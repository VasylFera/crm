using System;

namespace web.Data.ModelDtos
{
    public class VehicleModelDto
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
        public string FullNameDriver { get; set; }
        public bool TechnicalCondition { get; set; }
    }
}
