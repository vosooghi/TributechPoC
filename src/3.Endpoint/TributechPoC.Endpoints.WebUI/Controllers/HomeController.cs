using Ground.Extensions.Serializers.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TributechPoC.Endpoints.WebUI.DTOs;
using TributechPoC.Endpoints.WebUI.Models;

namespace TributechPoC.Endpoints.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IJsonSerializer _serializer;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory, IJsonSerializer serializer)
        {
            _httpClientFactory = httpClientFactory;
            _serializer = serializer;
        }

        public async Task<IActionResult> Index()
        {
            var pocWebApiClient = _httpClientFactory.CreateClient("PoCWebAPI");
            string sensorsAsJsonString = await pocWebApiClient.GetStringAsync("Sensor/GetAll");
            IList<SensorDTO> sensorsList = _serializer.Deserialize<List<SensorDTO>>(sensorsAsJsonString);
            return View(sensorsList);
        }

        public async Task<IActionResult> Delete(long ID)
        {
            var pocWebApiClient = _httpClientFactory.CreateClient("PoCWebAPI");
            await pocWebApiClient.GetStringAsync(string.Format("Sensor/Delete?id={0}",ID));                        
            return View("Index");
        }

        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateSensorViewModel model)
        {
            
            var pocWebApiClient = _httpClientFactory.CreateClient("PoCWebAPI");
            model.CreationTime = DateTimeOffset.Now.ToString();
            var httpContnt = new StringContent(_serializer.Serialize(model), System.Text.Encoding.UTF8, "application/json");

            var result = await pocWebApiClient.PostAsync("Sensor/Insert", httpContnt);
            return result.IsSuccessStatusCode ? Redirect("Index") : Redirect("Insert");
        }

        public async Task<IActionResult> GetSensorValues(string streamId)
        {
            string query = string.Format("StreamId={0}&From={1}&To={2}",streamId,DateTimeOffset.Now.AddDays(-1).ToString(),DateTimeOffset.Now);
            var testPlatformClient = _httpClientFactory.CreateClient("testPlatform");
            var result = await testPlatformClient.GetStringAsync(query);

            List<SensorValueItemDTO> sensorValuesList = _serializer.Deserialize<List<SensorValueItemDTO>>(result);
            return View(sensorValuesList);
        }
    }
}
