﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Math;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var abby = new Person();
            abby.FirstName = "Abby";
            abby.LastName = "Shea";
            abby.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
