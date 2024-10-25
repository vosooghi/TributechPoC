using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Infra.Data.Sql.ValueConvertors
{
    public class BusinessIdConversion : ValueConverter<BusinessId, Guid>
    {
        public BusinessIdConversion() : base(c => c.Value, c => BusinessId.FromGuid(c))
        {

        }
    }
}
