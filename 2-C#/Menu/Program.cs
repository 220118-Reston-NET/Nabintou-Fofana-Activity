// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using JamaicanFood;
using CollectionFood;

    Data data = new Data();

    Console.WriteLine(" ");
    Console.WriteLine("*************************************************************************");
    Console.WriteLine("*************************************************************************");
    Console.WriteLine("*** Hello, Welcome to my restaurant, our speciality is Jamaican food! ***");
    Console.WriteLine("*************************************************************************");
    Console.WriteLine("*************************************************************************");
 
    Console.WriteLine("                   Here is our menu, make your choices:");
 

    //Console.WriteLine("Welcome to my restaurant, our speciality is Jamaican food");
    //Console.WriteLine("Here is our menu, make your choices:");

    Console.WriteLine(" ");
    Console.WriteLine("==================================FOODS==================================");
    
    Console.WriteLine(" Enter 1 for Jerk chicken ");
    Console.WriteLine(" Enter 2 for Jerk chicken ");
    Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
    Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
    Console.WriteLine(" Enter 5 for Fish Escovitch ");

    //data.Meals();

    string userInput = Console.ReadLine();
    
    if (userInput == "1")
    {
    data._order1();
    string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._addDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }


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
    
    Console.ReadLine();



//}



