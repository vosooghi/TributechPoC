using TributechPoC.Core.ApplicationServices.Commands;
using TributechPoC.Core.ApplicationServices.Common;
using TributechPoC.Core.Contracts.Data;
using TributechPoC.Core.Contracts.DTOs;
using TributechPoC.Domain.Entities;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Core.ApplicationServices.Sensors
{
    public class SensorsServices
    {
        protected readonly CommandResult<long> result = new CommandResult<long>();

        IRepository<Sensor> _repository;
        public SensorsServices(IRepository<Sensor> repository)
        {
            _repository = repository;
        }

        public async Task<CommandResult<long>> InsertSensor(SensorDTO sensorDTO)
        {
            Sensor sensor = new Sensor(new SensorName(sensorDTO.SensorName),new SensorLocation(sensorDTO.SensorLocation)
                ,sensorDTO.UpperWarningLimit,sensorDTO.LowerWarningLimit);
            await(_repository.InsertAsync(sensor));
            return Ok(sensor.ID);
        }

        public CommandResult<long> DeleteSensor(long id)
        {
            _repository.Delete(id);
            return Ok(id);
        }
        

        protected CommandResult<long> Ok(long data)
        {
            result._data = data;
            result.Status = ApplicationServiceStatus.Ok;
            return result;
        }


    }
}
