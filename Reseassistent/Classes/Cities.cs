namespace Reseassistent.Classes
{
    public class Cities
    {
        public string Name { get; set; }
        public List<Connection> Connections { get; set; }

        public Cities(string name)
        {
            Name = name;
        }

        public void DepartureCity(TravelDB travelDB)
        {
           
        }
        public static List<string> GetDepartureCities(TravelDB travelDB)
        {
            
            Console.WriteLine("Available departure cities are:");

            // Get a list of all unique departure city names
            var departureCities = travelDB.Cities.Select(city => city.Name).Distinct().ToList();

            // Print each departure city
            foreach (var city in departureCities)
            {
                Console.WriteLine($"- {city}");
            }
            return departureCities;
        }
        // Method to display all connections for the selected city
        public void DisplayConnections()
        {
            if (Connections == null || Connections.Count == 0)
            {
                Console.WriteLine($"No connections available from {Name}.");
                return;
            }

            Console.WriteLine($"\nAvailable connections from {Name}:");
            foreach (var connection in Connections)
            {
                Console.WriteLine($"- To: {connection.Destination}, Distance: {connection.Distance} km, Time: {connection.Time} min, Cost: {connection.Cost} SEK, Method: {connection.TravelMethod}");
            }
        }
    }
}
