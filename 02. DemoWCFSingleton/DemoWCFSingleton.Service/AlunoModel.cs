using System;
using System.Runtime.Serialization;

namespace DemoWCFSingleton.Service
{
    [DataContract]
    public class AlunoModel
    {
        [DataMember]
        public string ID { get; private set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public DateTime Cadastro { get; set; }

        public AlunoModel()
            : this(Guid.NewGuid().ToString())
        { }

        public AlunoModel(string guid)
        {
            this.ID = guid;
        }

    }
}
