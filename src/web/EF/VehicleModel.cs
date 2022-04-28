using System;

namespace web.EF
{
    public class VehicleModel: BasicModel
    {
        public int Id { get; set; }
        public int Consignment { get; set; }
        public DateTime DateTime { get; set; }
        public int CurrentNumberFactory { get; set; }
        public string FactoryName { get; set; }
        public int MinistryCode { get; set; }
        public string TypeCar { get; set; }
        public string BrandOfMmachine { get; set; }
        public int StateCarNumber { get; set; }
        public DateTime YearManufactureCar { get; set; }
        public string FullNameDriver { get; set; }
        public bool TechnicalCondition { get; set; }
        public virtual PersonalDataModel PersonalDriver { get; set; }
    }
}
