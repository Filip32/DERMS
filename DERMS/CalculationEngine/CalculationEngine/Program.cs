﻿using CalculationEngineService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceManager serviceManager = new ServiceManager();
            ClientSideCE n = ClientSideCE.Instance;
            Console.ReadLine();
        }
    }
}
