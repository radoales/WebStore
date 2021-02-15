namespace WebStore.MVC.Infrastructure.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Data;
    using Services;
    using Services.Implementations;
    using Data.Models;
    using Microsoft.AspNetCore.Identity;
    using AutoMapper;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
            => services
                .AddDbContext<WebStoreDbContext>(options => options
                    .UseSqlServer(
                        configuration.GetDefaultConnectionString()));

        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.
                  AddTransient<IIdentityService, IdentityService>()
                 .AddTransient<IUserService, UserService>()
                 .AddTransient<IProductService, ProductService>()
                 .AddTransient<IOrderService, OrderService>()
                 .AddTransient<IAddressService, AddressService>();

            return services;
        }

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = false;
            })
               .AddEntityFrameworkStores<WebStoreDbContext>();

            return services;
        }

        public static IServiceCollection AddDefaultLoginPath(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Identity/LogIn");

            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            return services;
        }
    }
}
