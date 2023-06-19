namespace CRMMager.Contracts.Requests.Customer
{
    public record CreateCustomerRequest
     (
         string Name,
         string TaxNumber,
         string Street
     );
}
