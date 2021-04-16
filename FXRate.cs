using System;
using System.Collections.Generic;

namespace FXRatesApp
{
    public class FXRate
    {
        public DateTime Date { get; set; }

        public string Base { get; set; }

        public Dictionary<string, decimal> Rates { get; set; }
    }
}
