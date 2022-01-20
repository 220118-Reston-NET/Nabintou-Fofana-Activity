// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using JamaicanFood;
using CollectionFood;


bool repeat = true;

while (repeat)
{
    Console.WriteLine("Welcome to my restaurant, our speciality is Jamaican food");
    Console.WriteLine("Here is our menu, make your choices:");
    Console.WriteLine(" Enter 1 for Jerk chicken ");
    Console.WriteLine(" Enter 2 for Jerk chicken ");
    Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
    Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
    Console.WriteLine(" Enter 5 for Fish Escovitch ");

    Console.WriteLine(" ");
 Console.WriteLine("*************************************************************************");
 Console.WriteLine("*************************************************************************");
 Console.WriteLine("*** Hello, Welcome to my restaurant, our speciality is Jamaican food! ***");
 Console.WriteLine("*************************************************************************");
 Console.WriteLine("*************************************************************************");
 
 Console.WriteLine("                   Here is our menu, make your choices:");
 
 Data data = new Data();
 
 
     

 data.Meals();
 
 data.order1();
 
 data.paid();


    string userInput = Console.ReadLine();

    if (userInput == "1")
    {
    Console.WriteLine("Ok, You will love it! Someone is taking care of your order!");
    }
    else if (userInput == "2")
    {
    Console.WriteLine("Ok, You want Jerk fish. Someone is taking care of your order!");
    }
    else if (userInput == "3")
    {
    Console.WriteLine("Ok, Like me. I love sweet plantains.");
    Console.WriteLine("Ok, You want oxtail & rice with sweet plantains");
    Console.WriteLine("Someone is taking care of your order!");
    }
    else if (userInput == "4")
    {
    Console.WriteLine("Ok, you prefer salty plantains");
    Console.WriteLine("Someone is taking care of your order!");
    }
    else if (userInput == "5")
    {
    Console.WriteLine("Ok. You want Fish Escovitch.");
    Console.WriteLine("Someone is taking care of your order!");
    }
    else
    {
    Console.WriteLine("Sorry");
    }
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}
