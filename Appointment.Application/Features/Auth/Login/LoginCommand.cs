using Appointment.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace Appointment.Application.Features.Auth.Login;
public sealed record class LoginCommand(string UserNameOrEmail, string Password) : IRequest<Result<LoginCommandResponse>>;
public sealed record LoginCommandResponse(string Token);
internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
{
    public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        

        AppUser? appUser =
           await userManager.Users.FirstOrDefaultAsync(p =>
           p.UserName == request.UserNameOrEmail ||
           p.Email == request.UserNameOrEmail, cancellationToken);

        if (appUser is null)
        {
            return Result<LoginCommandResponse>.Failure("User Not Found");
        }
        return Result<LoginCommandResponse>.Succeed(null!);
    }
}
