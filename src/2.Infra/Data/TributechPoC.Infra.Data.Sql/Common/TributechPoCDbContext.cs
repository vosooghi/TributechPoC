using Microsoft.EntityFrameworkCore;
using TributechPoC.Domain.Entities;
using TributechPoC.Domain.ValueObjects;
using TributechPoC.Infra.Data.Sql.ValueConvertors;

namespace TributechPoC.Infra.Data.Sql.Common
{
    public class TributechPoCDbContext : DbContext
    {
        #region Entities
        public DbSet<Sensor> Sensors { get; set; }
        #endregion

        #region Ctors
        public TributechPoCDbContext(DbContextOptions<TributechPoCDbContext> options) : base(options)
        {
        }
        #endregion

        #region Configs
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<BusinessId>().HaveConversion<BusinessIdConversion>();
            configurationBuilder.Properties<SensorName>().HaveConversion<SensorNameConversion>();
            configurationBuilder.Properties<SensorLocation>().HaveConversion<SensorLocationConversion>();

        }
        #endregion
    }
}
