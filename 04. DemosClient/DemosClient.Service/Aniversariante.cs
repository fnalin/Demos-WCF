using System;
using System.Runtime.Serialization;

namespace DemosClient.Service
{
    [DataContract]
    public class Aniversariante
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public DateTime Data { get; set; }
    }
}
