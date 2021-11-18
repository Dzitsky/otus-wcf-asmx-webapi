using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WcfConsoleApplicationConsumer.ServiceReference1;

namespace WcfConsoleApplicationConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            Service1Client service1Client = new Service1Client();

            var compositeType = new CompositeType()
            {
                BoolValue = true,
                StringValue = "This string will have been added by "
            };

            var result = service1Client.GetDataUsingDataContract(compositeType); // GetDataUsingDataContractAsync

            Console.WriteLine(result.StringValue);

            var nextResult = service1Client.GetData(100); // GetDataAsync

            Console.WriteLine(nextResult);

            Console.ReadKey();
        }
    }
}
