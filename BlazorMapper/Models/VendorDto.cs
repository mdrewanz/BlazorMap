namespace BlazorMapper.Models
{
    public class VendorDto
    {
        public string VendorAccountNumber { get; set; }
        public string VendorOrganizationName { get; set; }
        public string VendorSearchName { get; set; }
        public string BrazilianCNPJOrCPF { get; set; }
        public string FormattedPrimaryAddress { get; set; }
        public string AddressCountryRegionId { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsSuspended { get; set; }

        public string FormattedTaxId
        {
            get
            {
                if (BrazilianCNPJOrCPF.Length > 11)
                {
                    // CNPJ
                    return BrazilianCNPJOrCPF.Insert(12, "-").Insert(08, "/").Insert(05, ".").Insert(02, ".");
                }

                // CPF
                return BrazilianCNPJOrCPF.Insert(09, "-").Insert(06, ".").Insert(03, ".");


            }
        }


        public string DisplayName
        {
            get
            {
                // TODO: check maximum size for VendorOrganizationName
                return $"{VendorAccountNumber} - {VendorOrganizationName}";
            }
        }
    }
}
