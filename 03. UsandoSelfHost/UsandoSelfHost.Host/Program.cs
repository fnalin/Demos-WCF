using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using UsandoSelfHost.Service;

namespace UsandoSelfHost.Host
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Instanciar o servicehost passando o servico
            var host = new ServiceHost(typeof(ClienteService)
                //
                //,new Uri[]
                //  {
                //      new Uri("net.tcp://localhost:8081"),
                //      new Uri("http://localhost:8076/cliserv")
                //  }
            );

            // Criar EndPoints explicitamente

            //host.AddServiceEndpoint(typeof(IClienteService),
            //    new BasicHttpBinding(),
            //    "basic"
            //);

            //host.AddServiceEndpoint(typeof(IClienteService),
            //    new WSHttpBinding(),
            //    "ws"
            //);

            //host.AddServiceEndpoint(typeof(IClienteService),
            //    new NetTcpBinding(),
            //    "dados"
            //);


            //host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });
            //host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "meta");


            //Disponibilizando o serviço
            try
            {
                host.Open();
                PrintServiceInfo(host);
                Console.WriteLine("\nPressione enter para encerrar");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                host.Abort();
            }

        }

        private static void PrintServiceInfo(ServiceHost host)
        {
            Console.WriteLine("{0} está online e disponível nesses endpoints:\n",
                host.Description.ServiceType);

            foreach (var se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address);    
            }
        }
    }
}
