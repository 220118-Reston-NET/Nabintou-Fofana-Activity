/*using ShopBL;
using ShopModel;

namespace BookUI
{
    public class AddProductMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Product _newProduct = new Product();

        //Dependency Injection
        //==========================
        
        private IProductBL _productBL;
        public AddProductMenu(IProductBL b_productBL)
        {
            _productBL = b_productBL;
        }
        
        //==========================
        public void Display()
        {
            Console.WriteLine("Enter Book information");
            Console.WriteLine("[5] Price - " + _newProduct.ProductPrice);
            Console.WriteLine("[4] Category - " + _newProduct.ProductCategory);
            Console.WriteLine("[3] Description - " + _newProduct.ProductDescription);
            Console.WriteLine("[2] Name - " + _newProduct.ProductName);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
               
                   //Exception handling to have a better user experience
                    try
                    {
                        Log.Information("Adding product \n" + _newProduct);
                        _productBL.AddProduct(_newProduct);
                        Log.Information("Successful at adding product!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Failed to add product due to reaching total capacity (100)");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter the name!");
                    _newProduct.ProductName = Console.ReadLine();
                    return "AddProduct";
                case "3":
                    Console.WriteLine("Please enter the type!");
                    _newProduct.ProductDescription = Console.ReadLine();
                    return "AddProduct";
                case "4":
                    Console.WriteLine("Please enter the format!");
                    _newProduct.ProductCategory = Console.ReadLine();
                    return "AddProduct";
                case "5":
                    Console.WriteLine("Please enter the price!");
                    _newProduct.ProductPrice = Convert.ToInt32(Console.ReadLine());
                    return "AddProduct";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddProduct";
            }
        }
    }
}
*/