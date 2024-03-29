using Distributor.Domain.SeedWork;
using Distributor.Infrastructure.Repository.Profile;
using Distributor.Infrastructure.Repository.User;
using Distributor.Service.Service.Profile;
using Distributor.Service.Service.User;

namespace Distributor.Api
{
    public class Startup : IStartup
    {
        private readonly string _allowPolicy = "_AllowPolicy";
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: _allowPolicy, builder => builder.WithOrigins("*")
                                                                    .AllowAnyMethod()
                .AllowAnyHeader());
            });

            services.AddScoped<Domain.SeedWork.ILogger, Logger>();

            services.AddScoped<IProfileRepository, ProfileRepository>();

            services.AddScoped<IProfileService, ProfileService>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();
        }

        public void Configure(WebApplication webApplication, IWebHostEnvironment webHostEnvironment)
        {
            if (webApplication.Environment.IsDevelopment() || webApplication.Environment.IsProduction())
            {
                webApplication.UseDeveloperExceptionPage();

                webApplication.UseSwagger();

                webApplication.UseSwaggerUI();

                webApplication.MapSwagger();
            }

            webApplication.UseHttpsRedirection();

            webApplication.UseCors(_allowPolicy);

            webApplication.UseAuthorization();

            webApplication.MapControllers();

            webApplication.Run();
        }

    }
}