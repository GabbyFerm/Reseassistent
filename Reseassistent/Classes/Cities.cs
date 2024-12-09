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

    }
}
