using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            {
                Console.WriteLine($" celsius {celsius}");
            }
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            {
                Console.WriteLine($" fahrenheit {fahrenheit}");
            }

        }
    }
}
