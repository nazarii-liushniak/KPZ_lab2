using System.Runtime.Serialization;

namespace Lab02.Model
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public int Id { get; set; } = 0;
        [DataMember]
        public string Name { get; set; } = "";
        [DataMember]
        public float Rating { get; set; } = 0.0f;
        [DataMember]
        public HotelType Type { get; set; } = HotelType.Business;
    }

    [DataContract]
    public enum HotelType
    {
        [EnumMember]
        Business,
        [EnumMember]
        Resort,
        [EnumMember]
        Hostel
    }
}