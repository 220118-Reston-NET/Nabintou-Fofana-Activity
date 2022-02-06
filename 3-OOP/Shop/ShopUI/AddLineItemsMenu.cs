using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class AddLineItemsMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static LineItem _newLineItem = new LineItem();

        //Dependency Injection
        //==========================
        
        private ILineItemBL _LineItemBL;
        public AddLineItemsMenu(ILineItemBL b_LineItemBL)
        {
           _LineItemBL = b_LineItemBL;
        }
        
        //==========================
        public void Display()
        {
            Console.WriteLine("Enter product informations");
            Console.WriteLine("[4] Product quantity - " + _newLineItem.ProductQuantity);
            Console.WriteLine("[3] Product name - " + _newLineItem.ProductName);
            Console.WriteLine("[2] Product ID - " + _newLineItem.ProductID);
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
                   /*
                   //Exception handling to have a better user experience
                    try
                    {
                        Log.Information("Adding product \n" + _newLineItem);
                        _LineItemBL.AddLineItem(_newLineItem);
                        Log.Information("Successful at product!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Failed to add product due to reaching total capacity (50)");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "MainMenu";
                    */
                    _LineItemBL.AddLineItem(_newLineItem);
                    return MenuType.MainMenu;
                case "2":
                    Console.WriteLine("Please enter the product id!");
                    _newLineItem.ProductID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddLineItems;
                case "3":
                    Console.WriteLine("Please enter the product name!");
                    _newLineItem.ProductName = Console.ReadLine();
                    return MenuType.AddLineItems;
                 case "4":
                    Console.WriteLine("Please enter the product quantity!");
                    _newLineItem.ProductQuantity = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddLineItems;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddLineItems;
            }
        }
    }
}