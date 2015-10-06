using DemosClient.ClienteViaChannel.AniversarianteServiceReference;
using System;
using System.Linq;
using System.ServiceModel;

namespace DemosClient.ClienteViaChannel
{
    class Program
    {
        static void Main(string[] args)
        {

            ChannelFactory<IAniversarianteServiceChannel> cf =
                new ChannelFactory<IAniversarianteServiceChannel>("BasicHttpBinding_IAniversarianteService");

            IAniversarianteServiceChannel channel = cf.CreateChannel();

            var aniversariante = new Aniversariante { Nome = "José da Silva",Data=new DateTime(1999,08,20)};
            channel.AddAniversariante(aniversariante);
            channel.AddAniversariante(aniversariante);
            channel.AddAniversariante(aniversariante);

            var aniversariantes = channel.GetAniversariantes();
            aniversariantes.ToList().ForEach(d => { Console.WriteLine("Nome: {0} - Data: {1}",d.Nome,d.Data.ToShortDateString()); });


            channel.Close();



        }
    }
}
