namespace BookUI
{
    /*
        MainMenu inherits IMenu interface but since it is a class it needs to give actual implementation details to the methods
        stated inside of the interface
    */
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Book Shop Manager!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Add book to products");
            Console.WriteLine("[2] Add customer");
            Console.WriteLine("[3] Add Order");
            Console.WriteLine("[4] Add storefront information");
            Console.WriteLine("[0] Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddBook";
                case "2":
                    return "AddCustomer";
                case "3":
                    return "AddOrder";
                case "4":
                    return "AddStoreFront";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}