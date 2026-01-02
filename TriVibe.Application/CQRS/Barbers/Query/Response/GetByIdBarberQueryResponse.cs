namespace TriVibe.Application.CQRS.Barbers.Query.Response;

public class GetByIdBarberQueryResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
}
