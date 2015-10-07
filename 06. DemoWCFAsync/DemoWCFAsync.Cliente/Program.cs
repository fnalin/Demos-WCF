using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWCFAsync.Cliente
{
    class Program
    {
        static void Main(string[] args)
        {

            TestandoRetorno();
            Console.WriteLine("\n\nusando Async agora\n\n");
            TestandoRetornoAsync();
            Console.WriteLine("Fim - acabou? tem certeza?");
            Console.ReadLine();
        }

        private static void TestandoRetorno()
        {
            using (var _proxy = new ServiceReference.ServiceTestClient())
            {
                Console.WriteLine("Indo buscar as informações no server");
                Console.WriteLine("Retorno do Método: {0}",_proxy.Retorno());
                Console.WriteLine("Retornando do server");
            }
        }

        private static async void TestandoRetornoAsync() //não esquecer do async na assinatura
        {
            using (var _proxy = new ServiceReference.ServiceTestClient())
            {
                Console.WriteLine("Indo buscar as informações no server");
                var result = await _proxy.RetornoAsync();
                Console.WriteLine("Retorno do Método: {0}", result);
                Console.WriteLine("Retornando do server");

            }
        }
    }
}
