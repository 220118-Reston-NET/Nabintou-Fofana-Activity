//using BooksBL;
using BookModel;

namespace BookUI
{
    public class AddCustomerMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddPokeMenu
        private static Customer1 _newCustomer1 = new Customer1();

        //Dependency Injection
        //==========================
        /*
        private IBookBL b_bookBL;
        public AddCustomerMenu(IBookBL b_bookBL)
        {
            _bookBL = b_bookBL;
        }
        */
        //==========================

        public void Display()
        {
            Console.WriteLine("Enter Customer information");
            Console.WriteLine("[6] List of Order - " + _newCustomer1.ListOfOrder);
            Console.WriteLine("[5] Phone Number - " + _newCustomer1.PhoneNumber);
            Console.WriteLine("[4] Email - " + _newCustomer1.Address);
            Console.WriteLine("[3] Address - " + _newCustomer1.Email);
            Console.WriteLine("[2] Name - " + _newCustomer1.Name);
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
                    _newCustomer1.Name = Console.ReadLine();
                    return "AddCustomer";
                case "3":
                    Console.WriteLine("Please enter the address!");
                    _newCustomer1.Address = Console.ReadLine();
                    return "AddCustomer";
                case "4":
                    Console.WriteLine("Please enter the Email!");
                    _newCustomer1.Email = Console.ReadLine();
                    return "AddCustomer";
                case "5":
                    Console.WriteLine("Please enter the phone number!");
                    _newCustomer1.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    return "AddCustomer";
                case "6":
                    Console.WriteLine("Please enter the list of order!");
                    _newCustomer1.ListOfOrder = Console.ReadLine();
                    return "AddCustomer";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddCustomer";
            }
        }
    }
}