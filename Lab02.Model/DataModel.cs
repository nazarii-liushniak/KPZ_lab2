using System.Runtime.Serialization;
using Lab02.Model.Serialization;

namespace Lab02.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Guest> Guests { get; set; } = new List<Guest>();
        [DataMember]
        public IEnumerable<Hotel> Hotels { get; set; } = new List<Hotel>();
        [DataMember]
        public IEnumerable<Booking> Bookings { get; set; } = new List<Booking>();

        public static string DataPath = "C:\\Users\\im_luft\\Desktop\\KPZ\\Labs\\Lab02\\Lab02.View\\bin\\Debug\\net8.0-windows\\hotels.xml";
        public static DataModel Load()
        {
            if (!File.Exists(DataPath)) File.Create(DataPath);
            return DataSerializer.Deserialize(DataPath);
        }

        public void Save()
        {
            DataSerializer.Serialize(DataPath, this);
        }
    }
}