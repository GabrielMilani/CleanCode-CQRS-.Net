using CleanCode.Application.UseCases.CreateUser;
using CleanCode.Application.UseCases.DeleteUser;
using CleanCode.Application.UseCases.GetAllUser;
using CleanCode.Application.UseCases.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanCode.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRequest request)
    {
        var userId = await _mediator.Send(request);
        return Ok(userId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateUserResponse>>
        Update(int id, UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id,
        CancellationToken cancellationToken)
    {
        var deleteUserRequest = new DeleteUserRequest(id);

        var response = await _mediator.Send(deleteUserRequest, cancellationToken);
        return Ok(response);
    }
}