using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class AddOrderMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Order _newOrder = new Order();

        //Dependency Injection
        //==========================
        
        private IOrderBL _orderBL;
        public AddOrderMenu(IOrderBL b_orderBL)
        {
            _orderBL = b_orderBL;
        }
        

        //==========================

        public void Display()
        {
            Console.WriteLine("Enter order information");
            Console.WriteLine("[2] Order id - " + _newOrder.OrderID);
            Console.WriteLine("[3] Customer id - " + _newOrder.CustomerID);
            Console.WriteLine("[4] Store id - " + _newOrder.StoreID);
            Console.WriteLine("[5] Store location - " + _newOrder.StoreLocation);
            Console.WriteLine("[6] Total price - " + _newOrder.TotalPrice);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public MenuType UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                
                //Exception handling to have a better user experience
                    try
                    {
                        Log.Information("Adding order \n" + _newOrder);
                        _orderBL.AddOrder(_newOrder);
                        Log.Information("Successful at adding the order!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Failed to add book due to reaching total capacity (100)");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return MenuType.MainMenu;
                    
                    //_orderBL.AddOrder(_newOrder);
                    //return MenuType.MainMenu;
                case "2":
                    Console.WriteLine("Please enter the order id!");
                    _newOrder.OrderID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddOrder;
                case "3":
                    Console.WriteLine("Please enter the customer id!");
                   _newOrder.CustomerID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddOrder;
                case "4":
                    Console.WriteLine("Please enter the store id!");
                    _newOrder.StoreID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddOrder;
                case "5":
                    Console.WriteLine("Please enter the store location!");
                    _newOrder.StoreLocation = Console.ReadLine();
                    return MenuType.AddOrder;
                case "6":
                    Console.WriteLine("Please enter the total price!");
                    _newOrder.TotalPrice = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddOrder;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddOrder;
            }
        }
    }
}