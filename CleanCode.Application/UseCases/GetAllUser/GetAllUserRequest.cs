using MediatR;

namespace CleanCode.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
