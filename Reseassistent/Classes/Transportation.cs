namespace Reseassistent.Classes
{
    public class Transportation : Connection
    {
        //I den här klassen ska vi distansen mellan städer 
        //hur lång tid det tar mellan stad till stad 
        //Vad kostar resan mellan städer 

       

        public Transportation (int distance, int time, int cost)
        {
            Distance = distance;
            Time = time;
            Cost = cost;

        }

        public void DisplayDetails()
        {
           
                Console.WriteLine($"Fordonsalternativ{TravelMethod}");
                Console.WriteLine($"Distans: {Distance}");
                Console.WriteLine($"Tid: {Time}");
                Console.WriteLine($"Kostnad: {Cost}");
            
        }   

        public void DisplayConnection()
        {

        }

        




    }
}
