using AutoMapper;
using CleanCode.Domain.Entities;

namespace CleanCode.Application.UseCases.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}
