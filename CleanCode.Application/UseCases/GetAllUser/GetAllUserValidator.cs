using CleanCode.Application.UseCases.GetAllUser;
using FluentValidation;

namespace CleanCode.Application.UseCases.GetAllUser;

public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
{
    public GetAllUserValidator()
    {
        //sem validação    
    }
}
