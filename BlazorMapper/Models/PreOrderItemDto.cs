namespace BlazorMapper.Models
{
    public class PreOrderItemDto
    {
        public int LineNumber { get; set; }
        public CostCenterDto CostCenter { get; set; }
        public ProjectDto Project { get; set; }
        public double Amount { get; set; }
        public bool IsRefundable { get; set; }

        #region WARNING :: to be filled on fiscal review step only

        public ProductDto ItemNumber { get; set; }
        public TaxItemGroupDto TaxItemGroup { get; set; }
        public TaxGroupDto TaxGroup { get; set; }
        public WithholdingTaxCodeDto WithholdingTaxCode { get; set; }
        public WithholdingGroupDto WithholdingGroup { get; set; }

        #endregion

    }
}
