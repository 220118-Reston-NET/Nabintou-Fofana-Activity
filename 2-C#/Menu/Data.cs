
namespace CollectionFood
{
    public class Data
    {
        public List<string> _foods = new List<string>();
        public List<string> _drinks = new List<string>();


        public void _addFoods()
        {
            _foods.Add("Jerk chicken");
            _foods.Add("Jerk fish");
            _foods.Add("Oxtail & rice with sweet plantains");
            _foods.Add("Oxtail & rice with salty plantains");
            _foods.Add("Fish Escovitch");

            Console.WriteLine("=====Foods:=====");
            foreach (string item in _foods)
            {
             Console.WriteLine(item);
            }

            //Console.WriteLine(_foods[0] + " , " + _foods[1] + " , " + _foods[2] + " , " + _foods[3] + " , " + _foods[4]);

            _drinks.Add("Pineapple juice");
            _drinks.Add("Ginger juice");
            _drinks.Add("Lemon juice");
            _drinks.Add("passion fruit juice");
            _drinks.Add("Mango juice");
            Console.WriteLine(" ");

            Console.WriteLine("=====Drinks:=====");
            foreach (string item in _drinks)
            {
                Console.WriteLine(item);
            }
    
            Console.WriteLine(" ");
            Console.WriteLine("Place your order here");
        }

        public void _orderFoods()
        {
            Console.WriteLine("==================================FOODS==================================");
    
            Console.WriteLine(" Enter 1 for Jerk chicken ");
            Console.WriteLine(" Enter 2 for Jerk chicken ");
            Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
            Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
            Console.WriteLine(" Enter 5 for Fish Escovitch ");
        }
        public void _removeFoods()
        {
            _foods.Remove("Fish Escovitch");
        }
         
        public void _removeDrinks()
        {
            _drinks.Remove("Mango juice");
        }
         
        public void _orderMeal1()
        {
            Console.WriteLine("Ok, You will love it! Someone is taking care of your order!");
            Console.WriteLine("Do you want a drink?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");
        }

        public void _orderMeal2()
        {
            Console.WriteLine("Ok, You want Jerk fish. Someone is taking care of your order!");
            Console.WriteLine("Do you want a drink?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");
        }

        public void _orderMeal3()
        {
            Console.WriteLine("Ok, Like me. I love sweet plantains.");
            Console.WriteLine("Ok, You want oxtail & rice with sweet plantains");
            Console.WriteLine("Someone is taking care of your order!");
            Console.WriteLine("Do you want a drink?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");
        }

        public void _orderMeal4()
        {
            Console.WriteLine("Ok, you prefer salty plantains");
            Console.WriteLine("Someone is taking care of your order!");
            Console.WriteLine("Do you want a drink?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");
        }

       
        
        public void _checkout()
        {
            Console.WriteLine("You paid, Thanks for your order!");
            Console.WriteLine("Everything will be ready soon!");
        }
             
        public void _orderDrink()
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

    

        public void _searchMeal()
        {
            _removeFoods();
            var myItem = _foods.Find(item => item == "Fish Escovitch");
            Console.WriteLine("Ok. You want Fish Escovitch.");
            Console.WriteLine("Sorry, there is no more 'Fish Escovitch'.");
            Console.WriteLine("Do you want something else?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");

        }
             
        }
    }
