// See https://aka.ms/new-console-template for more information
global using Serilog;
using ShopBL;
using ShopDL;
using ShopUI;

//Creating and configuring our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("logs/user.txt") //We configure our logger to save in this file
    .CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    MenuType ans = menu.UserChoice();
    
    switch (ans)
    {
        case MenuType.MainMenu:
            Log.Information("Displaying MainMenu to user");
            menu = new MainMenu();
            break;   
        case MenuType.AddProduct:
            Log.Information("Displaying AddProduct Menu to user");
            menu = new AddProductMenu(new ProductBL(new Repository_p()));
            break;
        case MenuType.AddCustomer:
            Log.Information("Displaying AddCustomer Menu to user");
            menu = new AddCustomerMenu(new CustomerBL(new Repository_c()));
            break;
        case MenuType.AddOrder:
            Log.Information("Displaying AddOrder Menu to user");
            menu = new AddOrderMenu(new OrderBL(new Repository_o()));
            break;
        case MenuType.PlaceOrder:
            Log.Information("Displaying AddOrder Menu to user");
            menu = new PlaceOrder(new StoreFrontBL(new Repository_s()));
            break;
        
        case MenuType.AddStoreFront:
            Log.Information("Displaying StoreFront Menu to user");
            menu = new AddStoreFrontMenu(new StoreFrontBL(new Repository_s()));
            break;    
        case MenuType.SearchCustomer:
            Log.Information("Displaying SearchCustomer Menu to user");
            menu = new SearchCustomerMenu(new CustomerBL(new Repository_c()));
            break;
        case MenuType.AddLineItems:
            Log.Information("Displaying SearchCustomer Menu to user");
            menu = new AddLineItemsMenu(new LineItemBL(new Repository_i()));
            break;
        case MenuType.SearchProduct:
            Log.Information("Displaying SearchProduct Menu to user");
            menu = new SearchProductMenu(new ProductBL(new Repository_p()));
            break;
        case MenuType.AddInventory:
            Log.Information("Displaying Inventory Menu to user");
            menu = new AddInventoryMenu(new InventoryBL(new Repository_v()));
            break;
        case MenuType.ViewInventory:
            Log.Information("Displaying Inventory to user");
            menu = new SearchInventoryMenu(new InventoryBL(new Repository_v()));
            break;
        case MenuType.CustomerMainMenu:
            Log.Information("Displaying Customer MainMenu to user");
            menu = new MainMenu();
            break;
        case MenuType.Exit:
            Log.Information("Exiting application");
            Log.CloseAndFlush(); //To close our logger resource
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }
}



   
