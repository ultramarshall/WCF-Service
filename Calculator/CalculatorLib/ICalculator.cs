using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace CalculatorLib
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        float penambahan(float a, float b);
        [OperationContract]
        float pengurangan(float a, float b);
        [OperationContract]
        float perkalian(float a, float b);
        [OperationContract]
        float pembagian(float a, float b);

    }
}
