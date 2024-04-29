using MediatR;

namespace CleanCode.Application.UseCases.CreateUser;

public record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;