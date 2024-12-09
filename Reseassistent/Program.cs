using Newtonsoft.Json;
using Reseassistent.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
    {
        TravelDB travelDB = new TravelDB();

        // Nu har travelDB.Cities listan av städer från JSON
        Console.WriteLine("Data inläst från cities.json.");
        Console.WriteLine($"Antal städer: {travelDB.Cities.Count}");

        Console.WriteLine("Hi, welcome to your travel assitant!");
        Console.WriteLine("Please pick where you want to departure from: ");

        List<string> departureCities = Cities.GetDepartureCities(travelDB.Cities);
        for (int i = 0; i < departureCities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {departureCities[i]}");
        }

        Console.WriteLine("\nEnter the number corresponding to your departure city:");

        // Step 4: Handle user input and select a departure city
        bool validInput = int.TryParse(Console.ReadLine(), out int cityChoice);

        if (!validInput || cityChoice < 1 || cityChoice > departureCities.Count)
        {
            Console.WriteLine("❌ Invalid input. Please restart and enter a valid number.");
            return; // Exit the program
        }

        // Get the selected city name and find the city object from the travelDB
        string selectedCityName = departureCities[cityChoice - 1];
        Cities selectedCity = travelDB.Cities.Find(city => city.Name == selectedCityName);

        Console.WriteLine($"\n You selected: {selectedCityName}\n");

        // Use a switch case to determine which city was selected
        switch (selectedCityName)
        {
            case "Stockholm":
                Console.WriteLine(" You selected Stockholm. Here are the available routes:");
                selectedCity.DisplayConnections();
                break;

            case "Oslo":
                Console.WriteLine(" You selected Oslo. Here are the available routes:");
                selectedCity.DisplayConnections();
                break;

            case "Berlin":
                Console.WriteLine(" You selected Berlin. Here are the available routes:");
                selectedCity.DisplayConnections();
                break;

            case "Köpenhamn":
                Console.WriteLine(" You selected Köpenhamn. Here are the available routes:");
                selectedCity.DisplayConnections();
                break;

            case "Paris":
                Console.WriteLine(" You selected Paris. Here are the available routes:");
                selectedCity.DisplayConnections();
                break;

            default:
                Console.WriteLine(" No routes available for the selected city.");
                break;
        }

        Console.WriteLine("\n Thank you for using the Travel Assistant. Have a great trip! ✈️");
    }
}
    }
}