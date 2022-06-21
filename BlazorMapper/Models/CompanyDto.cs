namespace BlazorMapper.Models
{
    public class CompanyDto
    {
        public string FiscalEstablishmentId { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }

        public string FormattedCnpj
        {
            get { return Cnpj.Insert(12, "-").Insert(08, "/").Insert(05, ".").Insert(02, "."); }
        }

        public string DisplayName
        {
            get
            {
                return $"({FiscalEstablishmentId}) {Name}";
            }
        }
    }
}
