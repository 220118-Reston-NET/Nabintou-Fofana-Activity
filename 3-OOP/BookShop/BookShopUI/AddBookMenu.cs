//using BooksBL;
using BookModel;

namespace BookUI
{
    public class AddBookShopMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Book _newBook1 = new Book();

        //Dependency Injection
        //==========================
        /*
        private IBookBL b_bookBL;
        public AddBookShopMenu(IBookBL b_bookBL)
        {
            _bookBL = b_bookBL;
        }
        */
        //==========================

        public void Display()
        {
            Console.WriteLine("Enter Book information");
            Console.WriteLine("[5] Price - " + _newBook1.Price);
            Console.WriteLine("[4] Format - " + _newBook1.Format);
            Console.WriteLine("[3] Type - " + _newBook1.Type);
            Console.WriteLine("[2] Name - " + _newBook1.Name);
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
                    _newBook1.Name = Console.ReadLine();
                    return "AddBook";
                case "3":
                    Console.WriteLine("Please enter the type!");
                    _newBook1.Type = Console.ReadLine();
                    return "AddBook";
                case "4":
                    Console.WriteLine("Please enter the format!");
                    _newBook1.Format = Console.ReadLine();
                    return "AddBook";
                case "5":
                    Console.WriteLine("Please enter the price!");
                    _newBook1.Price = Convert.ToInt32(Console.ReadLine());
                    return "AddBook";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddBook";
            }
        }
    }
}