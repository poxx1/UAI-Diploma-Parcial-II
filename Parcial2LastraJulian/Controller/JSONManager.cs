using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2LastraJulian.Controller
{
    public class JSONManager
    {
        internal void SerializeJSON(List<Object> product)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"C:\JSONs\jsonA.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }
        }

        public void SerializeJSON(List<Form> listaFormulariosVuelos)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter(@"C:\JSONs\jsonB.txt"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, listaFormulariosVuelos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error serializando el objeto: {ex.Message}");
            }
        }
    }
}