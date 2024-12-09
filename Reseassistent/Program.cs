using Newtonsoft.Json;
using Reseassistent.Classes;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        TravelDB travelDB = new TravelDB();

        // Nu har travelDB.Cities listan av städer från JSON
        Console.WriteLine("Data inläst från cities.json.");
        Console.WriteLine($"Antal städer: {travelDB.Cities.Count}");
    }
}