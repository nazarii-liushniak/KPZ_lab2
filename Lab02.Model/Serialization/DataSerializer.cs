using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Model.Serialization
{
    static class DataSerializer
    {
        public static void Serialize(string fileName, DataModel model)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            formatter.WriteObject(stream, model);
            stream.Close();
        }

        public static DataModel Deserialize(string fileName)
        {
            var stream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
            var formatter = new DataContractSerializer(typeof(DataModel));

            if (new FileInfo(fileName).Length == 0) return new DataModel();

            var result = formatter.ReadObject(stream);
            if (result != null) return (DataModel)result;
            else return new DataModel();
        }
    }
}
