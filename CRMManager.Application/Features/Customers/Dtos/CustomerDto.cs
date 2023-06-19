namespace CRMManager.Application.Features.Customers.Dtos
{
    public record CustomerDto
    (
        int Id,
        string Name,
        string TaxNumber,
        string Street
    );
}
