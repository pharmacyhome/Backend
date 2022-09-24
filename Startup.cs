using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;

using PharmacyHome.Database;
using PharmacyHome.Services;


namespace PharmacyHome
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {           
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.Formatting = Formatting.Indented;
                JsonConvert.DefaultSettings = () => options.SerializerSettings;
            });
            services.AddMvc().AddControllersAsServices();

            services.AddSingleton<IDbContextFactory<DatabaseContext>, DatabaseContextFactory>();
            services.AddSingleton<IDatabase, DatabaseService>();

            bool useSSL = configuration.GetValue<bool>("UseSSL");
            if (useSSL)
            {
                int httpsPort = configuration.GetValue<int>("HttpsPort");
                services.AddHttpsRedirection(options =>
                {
                    options.HttpsPort = httpsPort;
                });
            }

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
