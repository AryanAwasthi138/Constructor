using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2
{
    public class Sport
    {
        public string type { get; set; }
        public string equipments { get; set; }


        public Sport()
        {
            Console.WriteLine("Default constructor is called on");
        }
        public Sport(string name)
        {
            Console.WriteLine("Parametrized constructor is called on");
        }
        public static void Main()
        {
            int parameter = 5;

            Sport sport = new Sport();
            Sport sport1 = new Sport("Parametrized Constructor");
            sport.type = "Table Tennis";
            sport.equipments = "Racquet,ball,table";




        }
    }
}