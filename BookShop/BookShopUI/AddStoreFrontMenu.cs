//using BooksBL;
using BookModel;

namespace BookUI
{
    public class AddStoreFrontMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static StoreFront _newStoreFront = new StoreFront();

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
            Console.WriteLine("Enter frontstore information");
            Console.WriteLine("[5] List of orders - " + _newStoreFront.ListOfOrders);
            Console.WriteLine("[4] List of products - " + _newStoreFront.ListOfProducts);
            Console.WriteLine("[3] Address - " + _newStoreFront.Address);
            Console.WriteLine("[2] Name - " + _newStoreFront.Name);
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
                    Console.WriteLine("Please enter the name!");
                    _newStoreFront.Name = Console.ReadLine();
                    return "AddStoreFront";
                case "3":
                    Console.WriteLine("Please enter the address!");
                    _newStoreFront.Address = Console.ReadLine();
                    return "AddStoreFront";
                case "4":
                    Console.WriteLine("Please enter the list of products!");
                    _newStoreFront.ListOfProducts = Console.ReadLine();
                    return "AddStoreFront";
                case "5":
                    Console.WriteLine("Please enter the list of orders!");
                    _newStoreFront.ListOfOrders = Console.ReadLine();
                    return "AddStoreFront";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddStoreFront";
            }
        }
    }
}