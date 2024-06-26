﻿namespace CleanCode.Application.UseCases.CreateUser;

public sealed record CreateUserResponse
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
};
