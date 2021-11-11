using System;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Data.Models
{
    public class Root
    {
        /// <summary>
        /// The last time when the data was updated
        /// </summary>
        public string time_last_update_utc { get; set; }

        /// <summary>
        /// Currency rates
        /// </summary>
        public ConversionRate conversion_rates { get; set; }

        public override string ToString()
        {
            return $"{new string('=', 10)}\nCurrency conversion rates for " + time_last_update_utc
                + $"\n\nEuro......{ReverceConversion(conversion_rates.EUR)}"
                + $"\nUS dollar...... {ReverceConversion(conversion_rates.USD)}"
                + $"\nAustralian dollar..... {ReverceConversion(conversion_rates.AUD)}"
                + $"\nUkrainian Hryvnia..... {ReverceConversion(conversion_rates.UAH)}"
                + $"\nTurkish Lira..... {ReverceConversion(conversion_rates.TRY)}"
                + $"\nThai Baht..... {ReverceConversion(conversion_rates.THB)}"
                + $"\nZambian Kwacha..... {ReverceConversion(conversion_rates.ZMW)}";
        }

        private double ReverceConversion(double rate)
        {
            return Math.Round((1 / rate), 4);
        }
    }
}