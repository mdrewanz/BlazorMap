namespace BlazorMapper.Data
{
    public class PreOrderItem
    {
        public int LineNumber { get; set; }
        public int CostCenter { get; set; }
        public string Project { get; set; }
        public double Amount { get; set; }
        public bool IsRefundable { get; set; }

        #region WARNING :: to be filled on fiscal review step only

        public string ItemNumber { get; set; }
        public string TaxItemGroup { get; set; }
        public string TaxGroup { get; set; }
        public string WithholdingTaxCode { get; set; }
        public string WithholdingGroup { get; set; }

        #endregion
    }
}
