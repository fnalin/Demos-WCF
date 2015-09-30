using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string retorno;

            using (var _proxy = new Servico.HelloWorldClient("WSHttpBinding_IHelloWorld"))
            {
                var person = new Servico.Name { First="Fabiano", Last="Teste do WSHttp"};
                retorno = _proxy.SayHello(person);
            }

            Console.WriteLine(retorno);


            Console.WriteLine("FIM");
            Console.ReadLine();
        }
    }
}
