using AdministrationAPI.Contracts.Requests;
using AdministrationAPI.Contracts.Requests.EInvoiceRegistration;
using AdministrationAPI.Models.Vendor;

namespace AdministrationAPI.Services.Interfaces
{
  public interface IAdminEInvoiceService
  {
    public Task<List<EInvoiceRequest>> GetAllInvoiceRequests();

    public Task<List<EInvoiceRequest>> GetInvoiceRequestsByID(int b2bID);

    public Task<EInvoiceRequest> HandleRequestStatus(bool approve, int requestID);

    public Task<Vendor> DefineRequiredDataForVendor(int vendorId, RequiredData data);

    public Task<EInvoiceRequest> AddEInvoiceRequest(EInvoiceRegistrationData eInvoiceRegistrationData, string userId);
  }


}