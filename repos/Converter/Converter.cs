using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        double usd, eur, gbp;

        public Converter(double usd, double eur, double gbp)
        {
            this.usd = usd;
            this.eur = eur;
            this.gbp = eur;
        }

        public double ConvertingUsdToRub(double rub)
        {
            double convertingUsdToRub = usd * rub;
            return convertingUsdToRub;
        }

        public double ConvertingEurToRub(double rub)
        {
            double convertingEurToRub = eur * rub;
            return convertingEurToRub;
        }
        public double ConvertingGbpToRub(double rub)
        {
            double convertingGbpToRub = gbp * rub;
            return convertingGbpToRub;
        }

        public double ConvertingRubToUsd(double usd)
        {
            double convertingUsdToRub = usd / this.usd;
            return convertingUsdToRub;
        }

        public double ConvertingRubToEur(double eur)
        {
            double convertingEurToRub = eur / this.eur;
            return convertingEurToRub;
        }
        public double ConvertingRubToGbp(double gbp)
        {
            double convertingGbpToRub = gbp * this.gbp;
            return convertingGbpToRub;
        }


    }
}
