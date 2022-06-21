namespace BlazorMapper.Data
{
    public class PreOrder : BaseDocument
    {
        public string Requester { get; set; }
        public DateTime RequestedOn { get; set; }
        public string CompanyId { get; set; }
        public string VendorAccountNumber { get; set; }
        public string ApprovalCode { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool HasInstallments { get; set; }
        public int NumberOfInstallments { get; set; }
        public double TotalAmount { get; set; }
        public List<PreOrderItem> CostAllocation { get; set; }
        public List<FileAttachment> Documents { get; set; }

    }
}
