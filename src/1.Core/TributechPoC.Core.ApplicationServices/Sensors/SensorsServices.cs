using Microsoft.Identity.Client.TelemetryCore.TelemetryClient;
using TributechPoC.Core.ApplicationServices.Commands;
using TributechPoC.Core.ApplicationServices.Common;
using TributechPoC.Core.Contracts.Data;
using TributechPoC.Domain.Entities;

namespace TributechPoC.Core.ApplicationServices.Sensors
{
    public class SensorsServices
    {
        protected readonly CommandResult<Guid> result = new CommandResult<Guid>();

        IRepository<Sensor> _repository;
        public SensorsServices(IRepository<Sensor> repository)
        {
            _repository = repository;
        }

        public async Task<CommandResult<Guid>> InsertSensor(Sensor sensor)
        {
            await(_repository.InsertAsync(sensor));
            return Ok(sensor.ID);
        }

        public CommandResult<Guid> DeleteSensor(Guid id)
        {
            _repository.Delete(id);
            return Ok(id);
        }
        

        protected CommandResult<Guid> Ok(Guid data)
        {
            result._data = data;
            result.Status = ApplicationServiceStatus.Ok;
            return result;
        }


    }
}
