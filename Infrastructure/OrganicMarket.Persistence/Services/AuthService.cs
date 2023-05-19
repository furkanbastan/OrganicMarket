using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OrganicMarket.Application.Abstractions.Services;
using OrganicMarket.Application.DTOs.Users;
using OrganicMarket.Domain.Entities.Identity;

namespace OrganicMarket.Persistence.Services;

public class AuthService : IAuthService
{
    private readonly IMapper _mapper;
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    public AuthService(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
    }
    public async Task<SignInResult> SignInAsync(UserLoginDto userLoginDto)
    {
        var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
        var result = user != null ? await _signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false) : null;
        return result;
    }
    public async Task<IdentityResult> SignUpAsync(UserAddDto userAddDto)
    {
        var map = _mapper.Map<AppUser>(userAddDto);
        var result = await _userManager.CreateAsync(map, userAddDto.Password);
        return result;
    }
    public async Task SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }
}
