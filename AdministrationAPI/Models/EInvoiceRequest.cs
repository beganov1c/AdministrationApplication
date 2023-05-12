using System.ComponentModel.DataAnnotations.Schema;
namespace AdministrationAPI.Models.Vendor;

public class EInvoiceRequest
{
  public int EInvoiceRequestId { get; set; }
  [ForeignKey("User")]
  public string UserId { get; set; }
  public User User { get; set; }
  [ForeignKey("Vendor")]
  public int VendorId { get; set; }
  public Vendor Vendor { get; set; }
  public string? Param1 { get; set; }
  public string? Param2 { get; set; }
  public string? Param3 { get; set; }
  public string? Param4 { get; set; }
}