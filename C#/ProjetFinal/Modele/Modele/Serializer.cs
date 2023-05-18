using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml.Linq;
using Modele;

namespace Modele
{
    [Serializable]
    public class Serializer
    {
        public static void SerializeJson(Conteneur testCont, String filename)
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };

            File.WriteAllText(filename, JsonSerializer.Serialize(testCont, options));
        }

        public static Conteneur DeserializeJson(string fileName)
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<Conteneur>(File.ReadAllText(fileName), options)!;
        }
    }
}