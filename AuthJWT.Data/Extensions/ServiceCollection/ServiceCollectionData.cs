using AuthJWT.Data.Context;
using AuthJWT.Data.Repository.User;
using AuthJWT.Entites.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWT.Data.Extensions.ServiceCollection
{
    public static class ServiceCollectionData
    {

        public static IServiceCollection AddServiceData(this IServiceCollection services)
        {
            services.TryAddScoped<IUserRepo, UserRepo>();
            services.AddDbContext<AppDbContext>();
            services.AddIdentity<UserEntity, IdentityRole>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
                o.User.RequireUniqueEmail = true;
                o.SignIn.RequireConfirmedEmail = false;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            return services;

        }
    }
}
