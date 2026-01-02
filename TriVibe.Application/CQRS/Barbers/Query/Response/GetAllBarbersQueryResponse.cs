using TriVibe.Domain;
using TriVibe.Domain.DTOs;

namespace TriVibe.Application.CQRS.Barbers.Query.Response;

public class GetAllBarbersQueryResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public UserType UserType { get; set; }
}
