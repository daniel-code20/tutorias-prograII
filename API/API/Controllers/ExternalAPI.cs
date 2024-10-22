using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalAPI : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ExternalAPI(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }

        [HttpGet("consume")]
        public async Task<IActionResult> ConsumeExternalApi()
        {
            var externalApiUrl = "https://api.breakingbadquotes.xyz/v1/quotes";

            HttpResponseMessage response = await _httpClient.GetAsync(externalApiUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Error al consumir la API externa.");
            }
        }


       
    }
}
