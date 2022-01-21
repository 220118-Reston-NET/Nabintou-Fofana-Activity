
namespace CollectionFood
{
    public class Data
    {
        public List<string> _foods = new List<string>();
        public List<string> _drinks = new List<string>();


        public void Meals()
        {
            _foods.Add("Jerk chicken");
            _foods.Add("Jerk fish");
            _foods.Add("Oxtail & rice with sweet plantains");
            _foods.Add("Oxtail & rice with salty plantains");
            _foods.Add("Fish Escovitch");

            // foreach (string item in _foods)
            //{
            //  Console.WriteLine(" Check our menu again " + item);
            // }

            //Console.WriteLine(_foods[0] + " , " + _foods[1] + " , " + _foods[2] + " , " + _foods[3] + " , " + _foods[4]);

            _drinks.Add("Pineapple juice");
            _drinks.Add("Ginger juice");
            _drinks.Add("Lemon juice");
            _drinks.Add("passion fruit juice");
            _drinks.Add("Mango juice");
            Console.WriteLine(" ");

            foreach (string item in _drinks)
            {
                Console.WriteLine(item);
            }
    
            Console.WriteLine(" ");
        }

        public void _order1()
        {
            Console.WriteLine("Ok, You will love it! Someone is taking care of your order!");
            Console.WriteLine("Do you want a drink?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");
        }
        public void _checkout()
        {
            Console.WriteLine("You paid, Thanks for your order!");
            Console.WriteLine("Everything will be ready soon!");
        }
             
        public void _addDrink()
        {
            Console.WriteLine("==================================DRINKS==================================");
        
            Console.WriteLine(" 1 ===> Pineapple juice ");
            Console.WriteLine(" 2 ===> Ginger juice ");
            Console.WriteLine(" 3 ===> Lemon juice ");
            Console.WriteLine(" 4 ===> passion fruit juice ");
            Console.WriteLine(" 5 ===> Mango juice ");

            string userInput3 = Console.ReadLine();
            //Console.ReadLine();

            if(userInput3 == "1")
            {
                Console.WriteLine("Ok, You want pineapple juice ");  
            }
    
            //Console.WriteLine("ORDER ");
            //Console.WriteLine("You ordered ");
            //Console.WriteLine(_foods[1]);
        }   

        public void _removeMeal()
        {

        } 

        public void _searchMeal()
        {

        }
             
        }

    }
