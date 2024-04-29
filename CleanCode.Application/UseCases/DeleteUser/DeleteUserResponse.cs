namespace CleanCode.Application.UseCases.DeleteUser;

public sealed record DeleteUserResponse
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
}
