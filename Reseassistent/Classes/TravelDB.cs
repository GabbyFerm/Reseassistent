using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Reseassistent.Classes
{
    public class TravelDB
    {
        public List<TravelCity> Cities { get; set; }

        // Konstruktor för att ladda data från JSON-filen
        public TravelDB()
        {
            Cities = LoadCitiesFromJson();
        }

        // Metod för att läsa och deserialisera JSON-filen
        private List<TravelCity> LoadCitiesFromJson()
        {
            try
            {
                // Ange sökvägen till JSON-filen
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Json", "travel_data.json");

                // Läs filen och deserialisera den till en lista av TravelCity
                string json = File.ReadAllText(filePath);
                var travelData = JsonConvert.DeserializeObject<Dictionary<string, List<TravelCity>>>(json);

                return travelData["cities"];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid inläsning av JSON-fil: {ex.Message}");
                return new List<TravelCity>();
            }
        }

    }
}