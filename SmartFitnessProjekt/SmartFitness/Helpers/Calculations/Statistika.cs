using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitness.Helpers.Calculations
{
    public class Statistika
    {
        public static double IzracunajStandardnuDerivaciju(List<int> vrijednosti)
        {
            double average = vrijednosti.Average();
            double sumOfDerivation = 0;
            foreach (double value in vrijednosti)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / (vrijednosti.Count - 1);
            double rezultat = Math.Sqrt(sumOfDerivationAverage - (average * average));
            return rezultat;
        }

    }
}
