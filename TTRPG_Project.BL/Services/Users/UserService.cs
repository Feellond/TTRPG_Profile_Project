using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using TTRPG_Project.BL.Const;
using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Auth.Request;
using TTRPG_Project.BL.DTO.Auth.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace TTRPG_Project.BL.Services.Users
{
    public class UserService : BaseService<User, string>
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public UserManager<User> UserManager { get { return _userManager; } }

        public UserService(UserManager<User> userManager, ApplicationDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext)
        {
            _userManager = userManager;
            _config = config;
            _mapper = mapper;
        }

        public async Task<IdentityResult> CreateUserViaManagerAsync(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);

            return result;
        }

        public override async Task<ICollection<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserByNameAsync(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IList<string>> GetRolesAsync(User user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<IdentityResult> UpdateViaManagerAsync(User user)
        {
            return await _userManager.UpdateAsync(user);
        }

        public override async Task<User?> GetByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<ActionResult<LoginResponse>> LoginAsync(User user, bool isRemember)
        {
            var jwtService = new JwtService(_config);
            var claims = await jwtService.GetClaimByUser(user, UserManager);
            //var userRoles = await GetRolesAsync(user);

            var token = jwtService.CreateToken(claims);
            var refreshToken = JwtService.GenerateRefreshToken();

            int refreshTokenValidityInDays;

            _ = isRemember ?
                int.TryParse(_config["JWT:RefreshTokenValidityInDaysIsRemebmer"], out refreshTokenValidityInDays) :
                int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.IsRemember = isRemember;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
            user.LastActivity = DateTime.Now;

            await UpdateAsync(user);

            return new LoginResponse
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = refreshToken
            };
        }

        public async Task<ActionResult<LoginResponse>> RegisterAsync(RegisterRequest registerRequest)
        {
            var userMapped = _mapper.Map<User>(registerRequest);

            IdentityResult result = await CreateUserViaManagerAsync(userMapped, registerRequest.Password);
            if (!result.Succeeded)
                throw new CustomException("Ошибка при создании пользователя. Проверьте корректность данных!");

            await _userManager.AddToRolesAsync(userMapped, new List<string>
                {
                    Roles.USER,
                });

            var user = await GetUserByNameAsync(userMapped.UserName);

            var jwtService = new JwtService(_config);
            var claims = await jwtService.GetClaimByUser(user, UserManager);
            //var userRoles = await GetRolesAsync(user);

            var token = jwtService.CreateToken(claims);
            var refreshToken = JwtService.GenerateRefreshToken();

            int.TryParse(_config["JWT:RefreshTokenValidityInDaysNotRemeber"], out int refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.IsRemember = false;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

            await UpdateAsync(user);

            return new LoginResponse
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = refreshToken
            };
        }
    }
}
