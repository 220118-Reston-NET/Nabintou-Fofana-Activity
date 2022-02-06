using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class SearchInventoryMenu : IMenu
    {
        private IInventoryBL _inventoryBL;
        public SearchInventoryMenu(IInventoryBL i_inventoryBL)
        {
            _inventoryBL = i_inventoryBL;
        }

        public void Display()
        {

            Console.WriteLine("Please select an option to filter the store inventory database");
            Console.WriteLine("[1] By Name");
            //Console.WriteLine("[2] By ID");

            Console.WriteLine("[0] Go back");
        }
        
        public MenuType UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return  MenuType.MainMenu;
                case "1":
            
                    //Logic to grab user input
                    Console.WriteLine("Please enter a name");
                    string name = Console.ReadLine();

                    //Logic to display the result
                    //List<Inventory> ListOfInventory = new List<Inventory>();
                    List<Inventory> listOfInventory = _inventoryBL.SearchInventory(name);
                    
                    foreach (var item in listOfInventory)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(item);
                    }
                    
                    
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return  MenuType.PlaceOrder;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return  MenuType.ViewInventory;

            }

            
        }
    }
}
