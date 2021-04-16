using System;
using System.Collections.Generic;

namespace FXRatesApp
{
    public class FXRateConfig
    {
        public string ApiUrl(string baseCurrency) => $"{this.BaseUrl}&base={baseCurrency}&symbols={this.Symbols}";

        public string BaseUrl { get; set; }

        public string Base { get; set; }

        public string Symbols { get; set; }
    }
}
