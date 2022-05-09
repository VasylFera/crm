namespace web.EF
{
    public class OtgModel:BasicModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual DistrictModel District { get; set; }
    }
}
