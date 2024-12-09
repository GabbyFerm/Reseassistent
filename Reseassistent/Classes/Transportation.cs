namespace Reseassistent.Classes
{
    public class Transportation
    {
        //I den här klassen ska vi distansen mellan städer 
        //hur lång tid det tar mellan stad till stad 
        //Vad kostar resan mellan städer 

        //vi kommer skapa traveltime metod, travelcost() och traveldistance()

        public int distance { get; set; }
        public int time { get; set; }
        public int cost { get; set; }
        public Travelmethod TravelMethod { get; set; }


        public Transportation(int distance, int time, int cost, Travelmethod travelMethod)
        {
            this.distance = distance;
            this.time = time;
            this.cost = cost;
            TravelMethod = travelMethod;

        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Fordonsalternativ: {TravelMethod}");
            Console.WriteLine($"Distans: {distance} km");
            Console.WriteLine($"Tid: {time} minuter");
            Console.WriteLine($"Kostnad: {cost} SEK");
        }

        public void TravelOption()
        {
            Console.WriteLine($"Resan med {TravelMethod} är {distance} km långt");
        }
      

        //public int TravelDistance()
        //{
        //    Console.WriteLine($"Distans: {distance} km");
        //    return distance;

        //}

        //public int TravelTime()
        //{
        //    Console.WriteLine($"Tid: {time} ");
        //    return time;
        //}

        //public int TravleCost()
        //{
        //    Console.WriteLine($"Kostar: {cost} SEK");
        //    return cost;

        //}


    }
}
