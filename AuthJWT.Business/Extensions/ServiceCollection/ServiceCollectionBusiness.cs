using AuthJWT.Business.Services.Auth;
using AuthJWT.Business.Services.Token;
using AuthJWT.Business.Services.User;
using AuthJWT.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthJWT.Business.Extensions.ServiceCollection
{
    public static class ServiceCollectionBusiness
    {
        public static IServiceCollection AddServiceBusiness(this IServiceCollection services)
        {
            services.TryAddScoped<IUserService, UserService>();
            services.TryAddScoped<IAuthService, AuthService>();
            services.TryAddScoped<ITokenService, TokenService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Settings.Default.JwtSecretKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });
            return services;
        }
    }
}
