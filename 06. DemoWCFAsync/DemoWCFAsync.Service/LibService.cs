using System.ServiceModel;

namespace DemoWCFAsync.Service
{
    [ServiceContract]
    public interface IServiceTest
    {
        [OperationContract]
        string Retorno();
    }

    public class ServiceTest : IServiceTest
    {

        public string Retorno()
        {
            //simulando um processamento de 5 segundos
            System.Threading.Thread.Sleep(5000);
            return "oieee... retornei";
        }
    }
}
