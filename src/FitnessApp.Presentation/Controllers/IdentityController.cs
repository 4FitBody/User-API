namespace FinanceApp.Presentation.Controllers;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using FitnessApp.Presentation.Options;
using FitnessApp.Presentation.Users.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("api/[controller]/[action]")]
public class IdentityController : ControllerBase
{
    private readonly JwtOptions jwtOptions;

    public IdentityController(IOptionsSnapshot<JwtOptions> JwtOptions)
    {
        this.jwtOptions = JwtOptions.Value;
    }

    [HttpPost]
    public string Login(LoginDto loginDto)
    {
        var claims = new List<Claim>()
        {
            new(ClaimTypes.Name, loginDto.Login!)
        };

        var securityKey = new SymmetricSecurityKey(this.jwtOptions.KeyInBytes);

        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var securityToken = new JwtSecurityToken
        (
            issuer: this.jwtOptions.Issuers.First(),
            audience: this.jwtOptions.Audience,
            claims,
            expires: DateTime.Now.AddMinutes(this.jwtOptions.LifetimeInMinutes),
            signingCredentials: signingCredentials
        );

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        var jwt = jwtSecurityTokenHandler.WriteToken(securityToken);

        return jwt;
    }
}