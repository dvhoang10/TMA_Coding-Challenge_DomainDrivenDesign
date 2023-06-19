namespace CRMMager.Contracts.Requests.Customer
{
    public record UpdateCustomerRequest
    (
      int Id,
      string Name,
      string TaxNumber,
      string Street
    );
}
