﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Temperatureconversion
    {
        public  float Fahrenherit, C, F, Celsius;
        public void TempertatureConversionFind()
        {
            Fahrenherit = (C * 9 / 5) + 32;
            Console.WriteLine("Celsius to Fahrenheit: " + Fahrenherit);
        }
        public void temperaturConversionToCelsius()
        {
            Celsius = (F - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to Celsius : " + Celsius);
        }
    }
}
