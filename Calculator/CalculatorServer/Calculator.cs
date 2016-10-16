using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//menambahkan CalculatorLib
using CalculatorLib;

// 
using System.ServiceModel;

namespace CalculatorServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.PerCall)]
    class Calculator : ICalculator
    {
        public float penambahan(float a, float b)
        {
            return a + b;
        }

        public float pengurangan(float a, float b)
        {
            return a - b;
        }

        public float perkalian(float a, float b)
        {
            return a * b;
        }

        public float pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
