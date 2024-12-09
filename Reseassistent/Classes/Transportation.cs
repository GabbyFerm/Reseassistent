namespace Reseassistent.Classes
{
    public class Transportation
    {
        //I den här klassen ska vi distansen mellan städer 
        //hur lång tid det tar mellan stad till stad 
        //Vad kostar resan mellan städer 

       //vi kommer skapa traveltime metod, travelcost() och traveldistance()


        public int distance {  get; set; }
        public int time { get; set; }
        public int cost { get; set; }
        public Travelmetod Travelmetod { get; set; }
       

        public Transportation (int distance, int time, int cost)
        {
            this.distance = distance;
            this.time = time;
            this.cost = cost;

        }

        public void DisplayDetails()
        {
            var option = Transportation.FirstorDefault(option => option.TravelMetod.Equals(travelmetod, stringComparision.OrdinalIgnoreCase));
            if (option != null)
            {
                Console.WriteLine($"Fordonsalternativ{option.TravelMetod}");
                Console.WriteLine($"Distans: {option.Distance}");
                Console.WriteLine($"Tid: {option.Time}");
                Console.WriteLine($"Kostnad: {option.Cost}");
            }
            else
            {
                Console.WriteLine($"Ingen information tillgänglig.");

            }
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
