using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class AddStoreFrontMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static StoreFront _newStoreFront = new StoreFront();

        //Dependency Injection
        //==========================
        
        private IStoreFrontBL _storefrontBL;
        public AddStoreFrontMenu(IStoreFrontBL b_storefrontBL)
        {
            _storefrontBL = b_storefrontBL;
        }
        
        //==========================

        public void Display()
        {
            Console.WriteLine("Enter Store information");
            //Console.WriteLine("[6] List of orders of the store- " + _newStoreFront._orders);
            //Console.WriteLine("[5] List of products of the store - " + _newStoreFront._products);
            Console.WriteLine("[4] Store Address - " + _newStoreFront.StoreLocation);
            Console.WriteLine("[3] Store Name - " + _newStoreFront.StoreName);
            Console.WriteLine("[2] Store id - " + _newStoreFront.StoreID);
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
                 try
                    {
                        Log.Information("Adding Store front information \n" + _newStoreFront);
                        _storefrontBL.AddStoreFront(_newStoreFront);
                        Log.Information("Successful at adding Store front information!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Failed to add book due to reaching total capacity (20)");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return MenuType.MainMenu;

                    //_storefrontBL.AddStoreFront(_newStoreFront);
                    //return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter the store id!");
                    _newStoreFront.StoreID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddStoreFront;
                case "3":
                    Console.WriteLine("Please enter the store name!");
                    _newStoreFront.StoreName = Console.ReadLine();
                    return MenuType.AddStoreFront;
                case "4":
                    Console.WriteLine("Please enter the store location!");
                    _newStoreFront.StoreLocation = Console.ReadLine();
                    return MenuType.AddStoreFront;
                    /*
                case "5":
                    Console.WriteLine("Please enter the list of products!");
                    _newStoreFront._products = Console.ReadLine();
                    return "AddStoreFront";
                case "6":
                    Console.WriteLine("Please enter the list of orders!");
                    _newStoreFront._orders= Console.ReadLine();
                    return "AddStoreFront";
                    */
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddStoreFront;
            }
        }
    }
}