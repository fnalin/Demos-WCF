using DemosClient.ClienteAddServRef.AniversarianteServiceReference;
using System;
using System.Linq;

namespace DemosClient.ClienteAddServRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicione aniversariantes pelo wcftestclient e press enter");
            Console.ReadLine();
            using (var proxy = new AniversarianteServiceClient())
            {
                var aniversariantes = proxy.GetAniversariantes().ToList();
                aniversariantes.ForEach(dados =>
                {
                    Console.WriteLine("Nome: {0} = Data: {1}",
                        dados.Nome, dados.Data.ToShortDateString()
                        );
                });
            }
            Console.WriteLine("Fim");
        }
    }
}
