using Microsoft.AspNetCore.Mvc;
using System.Net;
using TributechPoC.Core.ApplicationServices.Common;
using TributechPoC.Core.ApplicationServices.Sensors;
using TributechPoC.Core.Contracts.DTOs;
using TributechPoC.Domain.Entities;

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
        [HttpGet("DeleteSensor")]
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
        [HttpPost("CreateSensor")]
        public async Task<IActionResult> Insert([FromBody] SensorDTO sensor)
        {
            var result = await _sensorsServices.InsertSensor(sensor);
            if (result.Status == ApplicationServiceStatus.Ok)
            {
                return StatusCode((int)HttpStatusCode.Created);
            }
            return BadRequest(result.Messages);
        }
    }
}
