using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Infra.Data.Sql.ValueConvertors
{
    public class SensorLocationConversion : ValueConverter<SensorLocation, string>
    {
        public SensorLocationConversion() : base(c => c.Value, c => new SensorLocation(c))
        {

        }
    }
}
