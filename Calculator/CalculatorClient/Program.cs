using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorLib;
namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://192.168.99.3/Calculator/";
            var serviceName = "ServiceCalculator";

            var objProxy = GetHttpProxy<ICalculator>(url, serviceName);

            var nilaiA = 5;
            var nilaiB = 2;

            var hasil = objProxy.penambahan(nilaiA, nilaiB);

            Console.WriteLine(string.Format("hasil penjumlahan {0} + {1} = {2}", nilaiA, nilaiB, hasil));
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();


        }

        private static T GetHttpProxy<T>(string url, string serviceName)
        {
            var httpBinding = new BasicHttpBinding();
            httpBinding.Security.Mode = BasicHttpSecurityMode.None;

            var ep = new EndpointAddress(url + serviceName + ".svc");
            var proxy = ChannelFactory<T>.CreateChannel(httpBinding, ep);
            return proxy;

        }
    }
}
 