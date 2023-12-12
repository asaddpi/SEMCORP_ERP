using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using TOCOMA_API_Service.Service.Website;

namespace TOCOMA_API_Service
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        readonly string CorsPolicy = "_corsPolicy ";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();            
            services.AddScoped<SetupService>();
            services.AddScoped<TransectionService>();
            services.AddScoped<AuthenticationService>();
            services.AddScoped<DepartmentService>();
            services.AddScoped<ProductService>();
            services.AddScoped<PurchaseService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<StockService>();
            services.AddScoped<BankService>();
            services.AddScoped<VendorService>();
            services.AddScoped<SalesServices>();
            services.AddScoped<AccounceService>();
            //services.AddScoped<BrandService>();
            services.AddScoped<CustomerService>();
            //----------
            services.AddScoped<ReferenceProjectTypeService>();
            services.AddScoped<AboutTocomaService>();
            services.AddScoped<OurClientService>();
            services.AddDbContext<ApplicationDbContex>(options => options.UseSqlServer(Configuration.GetConnectionString("TocomaERPDBContext")));
            services.AddDbContext<AppDbContex>(options => options.UseSqlServer(Configuration.GetConnectionString("SupplyochainDBContext")));
            Global.ConnectionString = Configuration.GetConnectionString("TocomaERPDBContext");
            Global.SOC_ConnectionString = Configuration.GetConnectionString("SupplyochainDBContext");


            //services
            //.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy",
            //        builder => builder
            //        .AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        );

            //    options.AddPolicy("signalr",
            //        builder => builder
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()

            //        .AllowCredentials()
            //        .SetIsOriginAllowed(hostName => true));
            //});

            services.AddControllers();
            services.AddCors();
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("https://localhost:44311", "http://103.169.100.126:8050", "http://localhost:30001/", "http://localhost:3000/", "https://demo.tocoma.com.bd/", "https://localhost:8050", "https://localhost:8060", "https://localhost:44348/", "http://erp-tocoma.baburchisheba.com/").AllowAnyHeader().AllowAnyMethod();
                                  });
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TOCOMA_API_Service", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TOCOMA_API_Service v1"));
            }
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://demo.tocoma.com.bd"));
            app.UseHttpsRedirection();
            //app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:30001"));
            //app.UseCors("CorsPolicy");
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
