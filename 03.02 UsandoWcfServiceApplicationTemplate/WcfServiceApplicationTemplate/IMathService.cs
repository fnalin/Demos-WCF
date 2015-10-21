using System.ServiceModel;

namespace WcfServiceApplicationTemplate
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(int n1, int n2);

        [OperationContract]
        int Substract(int n1, int n2);

        [OperationContract]
        int Multiply(int n1, int n2);

        [OperationContract]
        int Divide(int n1, int n2);
    }
}
