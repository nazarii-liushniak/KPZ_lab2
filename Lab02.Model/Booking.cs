using System.Runtime.Serialization;

namespace Lab02.Model
{
    [DataContract]
    public class Booking()
    {
        [DataMember]
        public int Id { get; set; } = 0;
        [DataMember]
        public Hotel? Hotel { get; set; } = null;
    }
}