// See https://aka.ms/new-console-template for more information
// using PokeModel;
//using BooksBL;
//using BookDL;
using BookUI;
// Console.WriteLine("Hello, World!");
// Ability ab = new Ability();
// ab.PP = -1; //Validation is working since can't input a negative value

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();
    
    switch (ans)
    {
        case "AddBook":
            menu = new AddBookShopMenu();
            //(new BookShopBL(new Repository()));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "AddCustomer":
            menu = new AddCustomerMenu();
            break;
        case "AddOrder":
            menu = new AddOrderMenu();
            break;
        case "AddStoreFront":
            menu = new AddStoreFrontMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            break;
    }
}
