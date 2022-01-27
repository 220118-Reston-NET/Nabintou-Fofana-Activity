//using BooksBL;
using BookModel;

namespace BookUI
{
    public class AddOrderMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Order1 _newOrder1 = new Order1();

        //Dependency Injection
        //==========================
        /*
        private IBookBL b_bookBL;
        public AddOrderMenu(IBookBL b_bookBL)
        {
            _bookBL = b_bookBL;
        }
        */
        //==========================

        public void Display()
        {
            Console.WriteLine("Enter order information");
            Console.WriteLine("[4] List of Line items - " + _newOrder1.ListOfLineItems);
            Console.WriteLine("[3] Total price - " + _newOrder1.TotalPrice);
            Console.WriteLine("[2] See the storefront - " + _newOrder1.StoreFront);
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
                    /*_bookBL.AddBook(_newBook1);*/
                    return "MainMenu";
                case "2":
                    //console.WriteLine("Please enter the name!");
                    _newOrder1.StoreFront = Console.ReadLine();
                    return "StoreFront";
                case "3":
                    Console.WriteLine("Please enter the total price!");
                   _newOrder1.TotalPrice = Convert.ToInt32(Console.ReadLine());
                    return "AddOrder";
                case "4":
                    Console.WriteLine("Please enter the list of line items!");
                    _newOrder1.ListOfLineItems = Console.ReadLine();
                    return "AddOrder";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddOrder";
            }
        }
    }
}