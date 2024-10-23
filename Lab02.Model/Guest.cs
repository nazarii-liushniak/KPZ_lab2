using System.Runtime.Serialization;

namespace Lab02.Model
{
    [DataContract]
    public class Guest()
    {
        [DataMember]
        public string Name { get; set; } = "";
        [DataMember]
        public string Surname { get; set; } = "";
        [DataMember]
        public Booking? Booking { get; set; } = null;
    }
}