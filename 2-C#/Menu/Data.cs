
namespace DataFunction
{
    public class Data
    {
        private string _meal1;
        private string _meal2;
        private string _meal3;
        private string _meal4;
        private string _meal5;
        private string _meal6;
        private string _meal7;
        private string _meal8;
        private string _meal9;
        private string _meal10;


        public List<string> _foods = new List<string>();
        public List<string> _drinks = new List<string>();

        public string meal1
        {
            get { return " The meal 1 is " + _meal1;}
            set { _meal1 = value;}
        }

        public string meal2
        {
            get { return " The meal 2 is " + _meal2;}
            set { _meal2 = value;}
        }

        public string meal3
        {
            get { return " The meal 3 is " + _meal3;}
            set { _meal3 = value;}
        }

        public string meal4
        {
            get { return " The meal 4 is " + _meal4;}
            set { _meal4 = value;}
        }

        public string meal5
        {
            get { return " The meal 5 is " + _meal5;}
            set { _meal5 = value;}
        }
/*
        public string meal6
        {
            get { return " The meal 6 is " + _meal6;}
            set { _meal6 = value;}
        }
        public string meal7
        {
            get { return " The meal 7 is " + _meal7;}
            set { _meal7 = value;}
        }
        public string meal8
        {
            get { return " The meal 8 is " + _meal8;}
            set { _meal8 = value;}
        }
        public string meal9
        {
            get { return " The meal 9 is " + _meal9;}
            set { _meal9 = value;}
        }
        public string meal10
        {
            get { return " The meal 10 is " + _meal10;}
            set { _meal10 = value;}
        }
*/
        public Data()
        {
            _meal1 = "Jerk chicken";
            _meal2 = "Jerk Fish";
            _meal3 = "Oxtail, rice with sweet plantains";
            _meal4 = "Oxtail, rice with salty plantains";
            _meal5 = "Fish Escovitch";

            _meal6 = "Pineapple juice";
            _meal7 = "Ginger juice";
            _meal8 = "Lemon juice";
            _meal9 = "Passion fruit juice";
            _meal10 = "Mango juice";
        }

        public void _addFoods()
        {
            _foods.Add(_meal1);
            _foods.Add(_meal2);
            _foods.Add(_meal3);
            _foods.Add(_meal4);
            _foods.Add(_meal5);

            Console.WriteLine("=====Foods:=====");
            foreach (string item in _foods)
            {
             Console.WriteLine(item);
            }

            //Console.WriteLine(_foods[0] + " , " + _foods[1] + " , " + _foods[2] + " , " + _foods[3] + " , " + _foods[4]);

            _drinks.Add(_meal6);
            _drinks.Add(_meal7);
            _drinks.Add(_meal8);
            _drinks.Add(_meal9);
            _drinks.Add(_meal10);
            Console.WriteLine(" ");

            Console.WriteLine("=====Drinks:=====");
            foreach (string item in _drinks)
            {
                Console.WriteLine(item);
            }
    
            Console.WriteLine(" ");
            Console.WriteLine("Each food cost $10 and each drink $3. You can place your order here");
        }

        public void _orderFoods()
        {
            Console.WriteLine("==================================FOODS==================================");
    
            Console.WriteLine(" 1 ===> " + _meal1);
            Console.WriteLine(" 2 ===> " + _meal2);
            Console.WriteLine(" 3 ===> " + _meal3);
            Console.WriteLine(" 4 ===> " + _meal4);
            Console.WriteLine(" 5 ===> " + _meal5 );
        }
        public void _removeFoods()
        {
            _foods.Remove(_meal5);
        }
         
        public void _removeDrinks()
        {
            _drinks.Remove(_meal10);
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
            Console.WriteLine("You have to pay $13.");
            Console.WriteLine("You paid, Thanks for your order!");
            Console.WriteLine("Everything will be ready soon!");
        }
             
        public void _orderDrink()
        {
            Console.WriteLine("==================================DRINKS==================================");
        
            Console.WriteLine(" 1 ===> " + _meal6);
            Console.WriteLine(" 2 ===> " + _meal7);
            Console.WriteLine(" 3 ===> " + _meal8);
            Console.WriteLine(" 4 ===> " + _meal9);
            Console.WriteLine(" 5 ===> " + _meal10);

            string userInput3 = Console.ReadLine();

            if(userInput3 == "1")
            {
                Console.WriteLine("Ok, You want " + _meal6);  
            }
    
        }   

    
        public void _searchMeal()
        {
            _removeFoods();
            var myItem = _foods.Find(item => item == _meal6);
            Console.WriteLine("Ok. You want " + _meal6);
            Console.WriteLine("Sorry, there is no more" + _meal6);
            Console.WriteLine("Do you want something else?");
            Console.WriteLine("1===> Yes ");
            Console.WriteLine("2===> No ");

        }
             
        }
    }
