using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Reseassistent.Classes
{
    public class TravelDB
    {
        public List<Cities> Cities { get; set; }

        public TravelDB()
        {
            Cities = LoadCitiesFromJson();
        }

        private List<Cities> LoadCitiesFromJson()
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Json", "cities.json");
                string json = File.ReadAllText(filePath);

                var travelData = JsonConvert.DeserializeObject<TravelData>(json); // Deserialisera till TravelData-objekt

                return travelData?.Cities ?? new List<Cities>(); // Returnera Cities-listan eller en tom lista om det är null
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid inläsning av JSON-fil: {ex.Message}");
                return new List<Cities>();
            }
        }
    }
}