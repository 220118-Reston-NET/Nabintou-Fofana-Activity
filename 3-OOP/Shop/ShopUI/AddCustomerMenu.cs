using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class AddCustomerMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddCustomerMenu
        private static Customer _newCustomer = new Customer();

        //Dependency Injection
        //==========================
        
        private ICustomerBL _customerBL;
        public AddCustomerMenu(ICustomerBL b_customerBL)
        {
            _customerBL = b_customerBL;
        }
    
        //==========================
    
        public void Display()
        {
            Console.WriteLine("Enter Customer information");
            //Console.WriteLine("[7] Phone Number - " + _newCustomer. _orders = new List<Order>());
            Console.WriteLine("[6] Phone Number - " + _newCustomer.CustomerPhoneNumber);
            Console.WriteLine("[5] Email - " + _newCustomer.CustomerAddress);
            Console.WriteLine("[4] Address - " + _newCustomer.CustomerEmail);
            Console.WriteLine("[3] Name - " + _newCustomer.CustomerName);
            Console.WriteLine("[2] Name - " + _newCustomer.CustomerID);
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
                        Log.Information("Adding new customer " + _newCustomer);
                        _customerBL.AddCustomer(_newCustomer);
                        Log.Information("Successful at adding customer!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Failed to add customer due to reaching total capacity (20)");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                
                   _customerBL.AddCustomer(_newCustomer);
                    return MenuType.MainMenu;
                case "2":
                    Console.WriteLine("Please enter the customer id!");
                    _newCustomer.CustomerID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddCustomer;
                case "3":
                    Console.WriteLine("Please enter the customer name!");
                    _newCustomer.CustomerName = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "4":
                    Console.WriteLine("Please enter the customer address!");
                    _newCustomer.CustomerAddress = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "5":
                    Console.WriteLine("Please enter the customer Email!");
                    _newCustomer.CustomerEmail = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "6":
                    Console.WriteLine("Please enter the customer phone number!");
                    _newCustomer.CustomerPhoneNumber = Convert.ToInt64(Console.ReadLine());
                    return MenuType.AddCustomer;
                    /*
                case "7":
                    Console.WriteLine("Please enter the customer list of order!");
                    _newCustomer. _orders = new List<Order>() = Console.ReadLine();
                    return "AddCustomer";
                    */
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
   }
}