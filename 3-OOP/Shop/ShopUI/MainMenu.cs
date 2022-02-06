namespace ShopUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("WELCOME TO THE ONLINE SHOP!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine(" ");
            Console.WriteLine("========================================");
            Console.WriteLine("ENTER PRODUCTS ET CUSTOMERS INFORMATIONS");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Add Order");
            Console.WriteLine("[2] Add product");
            Console.WriteLine("[3] Search product");
            Console.WriteLine("[4] Add customer");
            Console.WriteLine("[5] Search customer");
            Console.WriteLine("[6] Add Line item information");
            Console.WriteLine("[7] Add Store front information");
            Console.WriteLine("[8] Add Store inventory information");
            Console.WriteLine("[9] View Store inventory information");
            Console.WriteLine(" ");
            Console.WriteLine("================================");
            Console.WriteLine("CHOOSE A STORE AND PLACE AN ORDER");
            Console.WriteLine("=================================");
            Console.WriteLine("Welcome to the Shop Manager!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[10] Search product");
            Console.WriteLine("[11] Place Order");
            Console.WriteLine("[0] Exit");
        }

        public MenuType UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases 
            switch (userInput)
            {
                case "0":
                    return MenuType.Exit;
                case "1":
                    return MenuType.AddOrder;
                case "2":
                    return MenuType.AddProduct;
                case "3":
                    return MenuType.SearchProduct;
                case "4":
                    return MenuType.AddCustomer;
                case "5":
                    return MenuType.SearchCustomer;
                case "6":
                    return MenuType.AddLineItems;
                case "7":
                    return MenuType.AddStoreFront;
                case "8":
                    return MenuType.AddInventory;
                case "9":
                    return MenuType.ViewInventory;
                case "10":
                    return MenuType.SearchProduct;
                case "11":
                    return MenuType.PlaceOrder;
               
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
    
}



                