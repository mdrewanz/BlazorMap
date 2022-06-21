using System.ComponentModel.DataAnnotations;

namespace BlazorMapper.Enums
{
    public enum PaymentMethod
    {
        [Display(Name = "Boleto")] BankSlip = 1,
        [Display(Name = "Transferência Bancária")] WireTransfer = 2,
        [Display(Name = "Pix")] Pix = 3
    }
}
