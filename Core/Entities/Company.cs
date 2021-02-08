namespace Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string BusinessName { get; set; }
        public CompanyType CompanyType { get; set; }
        public int CompanyTypeId { get; set; }
        public CompanySize CompanySize { get; set; }

        public int CompanySizeId { get; set; }
    }
}