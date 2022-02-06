using ShopBL;
using ShopModel;

namespace ShopUI
{
    public class PlaceOrder : IMenu
    {
        private List<StoreFront> _listOfStoreFront;
        private IStoreFrontBL _storefrontBL;
        public PlaceOrder(IStoreFrontBL b_storefrontBL)
        {
            _storefrontBL = b_storefrontBL;
            
            _listOfStoreFront = _storefrontBL.GetAllOfStoreFront();
        }
        
        public void Display()
        {
            
            foreach (var item in _listOfStoreFront)
            {
                Console.WriteLine("====================");
                Console.WriteLine(item);
            }
            Console.WriteLine("Choose a store to place your order");
            Console.WriteLine("[1] Select store by Id");
            Console.WriteLine("[0] Go Back");
            Console.WriteLine(" ");
        }
        
       // MenuType IMenu UserChoice()
        public MenuType UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return MenuType.MainMenu;
                case "1":
                    Console.WriteLine("Enter StoreID:");
                    try
                    {
                        //int storeID = Console.ReadLine();
                        int storeID = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Products");
                        List<Product> listOfProduct = _storefrontBL.GetProductByStoreID(storeID);
                       
                        
                        foreach (var item in listOfProduct)
                        {
                            Console.WriteLine("======================");
                            Console.WriteLine(item);

                        
                        Console.WriteLine("ENTER [1] to ORDER NOW the store products");
                        Console.ReadLine();
                        if(userInput == "1")
                        {
                        Console.WriteLine("ORDER COMPLETE.");
                        Console.WriteLine("SEE YOU NEXT TIME.");
                        }
                        else
                        {
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();

                        return MenuType.PlaceOrder;
                        }
                        }
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();

                        return MenuType.PlaceOrder;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return MenuType.PlaceOrder;
                    }
                    
                    return MenuType.PlaceOrder;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return MenuType.PlaceOrder;

            }
        }
    }
}