using BlazorMapper.Enums;

namespace BlazorMapper.Models
{
    public class PreOrderDto
    {
        public string Requester { get; set; }
        public DateTime RequestedOn { get; set; }
        public CompanyDto Company { get; set; }
        public VendorDto Vendor { get; set; }
        public string ApprovalCode { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool HasInstallments { get; set; }
        public int NumberOfInstallments { get; set; }
        public double TotalAmount { get; set; }
        public List<PreOrderItemDto> CostAllocation { get; set; }
        public List<FileAttachmentDto> Documents { get; set; }

        public PreOrderDto()
        {
            CostAllocation = new List<PreOrderItemDto>();
            Documents = new List<FileAttachmentDto>();
        }
    }
}
