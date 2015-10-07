using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DemoHandlingExceptions.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var pacService = new PacienteServiceReference.PacienteServiceClient();

            try
            {



                var dados = pacService.ObterTodos();
                Console.WriteLine("Obtendo todos os pacientes...\n");
                dados.ToList().ForEach(pac =>
                {
                    Console.WriteLine("ID: {0} | Nome: {1} | Idade: {2} | Sexo: {3}",
                        pac.ID, pac.Nome, pac.Idade, pac.Sexo
                    );
                });


                //Console.WriteLine("Tentando excluir o Pac 1...\n");
                //pacService.Excluir(1);


                Console.WriteLine("\n\n... Obtendo o cliente 2, vai disparar um timeoutexception");
                var pac2 = pacService.ObterPorID(2); //Tá com Sleep de 5 na thread e com 2s no sendTimeout do binding no app.config

                pacService.Close();

                Console.WriteLine("\nFIM!");
                Console.ReadLine();
            }
            catch (FaultException fex)
            {
                Console.WriteLine("Fault Exception - Msg: {0} | Type: {1}",
                    fex.Message, fex.GetType());
                pacService.Abort();
            }
            catch (CommunicationException commex)
            {
                Console.WriteLine("Communication Exception - Msg: {0} | Type: {1}",
                    commex.Message, commex.GetType());
                pacService.Abort();
            }
            catch (TimeoutException toex)
            {
                Console.WriteLine("TimeOut Exception - Msg: {0} | Type: {1}",
                    toex.Message, toex.GetType());
                pacService.Abort();
            }
        }
    }
}
