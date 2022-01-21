
namespace CollectionFood
{
    public class Data
    {
        private List<string> _strings = new List<string>();
        public void Meals()
        {
            Console.WriteLine(" ");
            Console.WriteLine("==================================MENU==================================");
            _strings.Add("Jerk chicken");
            _strings.Add("Jerk fish");
            _strings.Add("Oxtail & rice with plantains");
            _strings.Add("Fish Escovitch");

           // foreach (string item in _strings)
           // {
           //     Console.WriteLine(item);
           // }
            //Console.WriteLine(_strings[1]);
    Console.WriteLine(" ");

    Console.WriteLine(" Enter 1 for Jerk chicken ");
    Console.WriteLine(" Enter 2 for Jerk chicken ");
    Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
    Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
    Console.WriteLine(" Enter 5 for Fish Escovitch ");
    Console.WriteLine(" ");

    

        }

        public void paid()
        {

        }
             
        public void order1()
        {
            Console.WriteLine(" ");
            Console.WriteLine("You orderd " + _strings[0]);
        }    
             
        }

    }
