using Microsoft.EntityFrameworkCore;
using TributechPoC.Core.ApplicationServices.Sensors;
using TributechPoC.Core.Contracts.Data;
using TributechPoC.Domain.Entities;
using TributechPoC.Infra.Data.Sql.Common;

namespace TributechPoC.Endpoints.WebAPI.Extensions
{
    public static class HostingExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            IConfiguration configuration = builder.Configuration;

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            builder.Services.AddDbContext<TributechPoCDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("Db_ConnectionString")));
            builder.Services.AddScoped<IRepository<Sensor>, BaseRepository<Sensor, TributechPoCDbContext>>();
            builder.Services.AddScoped<SensorsServices>();

            return builder.Build();
        }
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {            
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }            

            app.MapControllers();

            app.Run();
            return app;
        }
    }
}
