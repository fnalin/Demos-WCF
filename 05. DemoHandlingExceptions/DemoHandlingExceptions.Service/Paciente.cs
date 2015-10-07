
namespace DemoHandlingExceptions.Service
{

    using System.Runtime.Serialization;


    public enum Sexo { Feminino, Masculino }

    [DataContract]
    public class Paciente
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public int Idade { get; set; }
        [DataMember]
        public Sexo Sexo { get; set; }
    }
}
