using Microsoft.AspNetCore.Mvc;
using System.Net;
using TributechPoC.Core.ApplicationServices.Common;
using TributechPoC.Core.ApplicationServices.Sensors;
using TributechPoC.Core.Contracts.DTOs;

namespace TributechPoC.Endpoints.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private readonly SensorsServices _sensorsServices;

        public SensorController(SensorsServices sensorsServices)
        {
            _sensorsServices = sensorsServices;
        }
        [HttpGet("Delete")]
        public async Task<IActionResult> Delete([FromQuery]long id) 
        {            
            var result = _sensorsServices.DeleteSensor(id);
            if (result.Status == ApplicationServiceStatus.Ok)
            {
                return StatusCode((int)HttpStatusCode.NoContent, result.Data);
            }
            else if (result.Status == ApplicationServiceStatus.NotFound)
            {
                return StatusCode((int)HttpStatusCode.NotFound, "Delete");
            }
            return BadRequest(result.Messages);
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] CreateSensorDTO sensor)
        {
            var result = await _sensorsServices.InsertSensor(sensor);
            if (result.Status == ApplicationServiceStatus.Ok)
            {
                return StatusCode((int)HttpStatusCode.Created);
            }
            return BadRequest(result.Messages);
        }

        [HttpGet("GetAll")]
        public Task<List<SensorDTO>> GetAll()
        {
            var query =  _sensorsServices.GetAllSensors();

            var result = query.Select(i => new SensorDTO
            {
                ID = i.ID.ToString(),
                BusinessId = i.BusinessId.Value.ToString(),
                CreationTime = i.CreationTime.ToString(),
                SensorLocation = i.SensorLocation.ToString(),
                SensorName = i.SensorName.Value.ToString(),
                LowerWarningLimit = i.LowerWarningLimit,
                UpperWarningLimit = i.UpperWarningLimit
            }).ToList();

            return Task.FromResult(result);
        }
    }
}
