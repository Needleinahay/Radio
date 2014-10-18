namespace Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
