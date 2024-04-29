using MediatR;

namespace CleanCode.Application.UseCases.UpdateUser;

public sealed record UpdateUserRequest(int Id,
                      string Email, string Name)
                      : IRequest<UpdateUserResponse>;
