using CleanCode.Application.UseCases.DeleteUser;
using MediatR;

namespace CleanCode.Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(int Id) : IRequest<DeleteUserResponse>;
