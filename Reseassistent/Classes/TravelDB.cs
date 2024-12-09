using System.Text.Json;
using System.Text.Json.Serialization;

namespace Reseassistent.Classes
{
    public class TravelDB
    {
        public List<Cities> Cities { get; set; } = new List<Cities>();

        private readonly string _filePath;

        public TravelDB(string filePath)
        {
            _filePath = filePath;

            LoadData();
        }

        public void LoadData()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                Cities = JsonSerializer.Deserialize<List<Cities>>(json) ?? new List<Cities>();
            }
        }

        public void SaveData()
        {
            string json = JsonSerializer.Serialize(Cities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
