using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FXRatesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FXRatesController : ControllerBase
    {
        private readonly ILogger<FXRatesController> _logger;
        private readonly IHttpClientFactory _clientFactory;

        private readonly FXRateConfig _fxRateconfig;

        public FXRatesController(
            ILogger<FXRatesController> logger,
            IHttpClientFactory clientFactory,
            FXRateConfig fxRateconfig)
        {
            _logger = logger;
            _clientFactory = clientFactory;
            _fxRateconfig = fxRateconfig;
        }

        [HttpGet("{baseCurrency}")]
        public async Task<FXRate> Get(string baseCurrency)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _fxRateconfig.ApiUrl(baseCurrency));
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<FXRate>(responseStream, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
            }
            else
            {
                _logger.LogError(await response.Content.ReadAsStringAsync());
                throw new ArgumentException("An unexpected server error occured. Please try again later.");
            }
        }

        [HttpOptions]
        public IEnumerable<string> GetCurrencies()
        {
            return _fxRateconfig.Symbols.Split(',');
        }
    }
}
