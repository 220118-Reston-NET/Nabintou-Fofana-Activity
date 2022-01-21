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
 
    Console.WriteLine("                   LOOK AT OUR FOODS AND DRINKS:");
    data._addFoods();

    
    Console.WriteLine("==================================FOODS==================================");
    
            Console.WriteLine(" Enter 1 for Jerk chicken ");
            Console.WriteLine(" Enter 2 for Jerk chicken ");
            Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
            Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
            Console.WriteLine(" Enter 5 for Fish Escovitch ");
    

    string userInput = Console.ReadLine();
    
    if (userInput == "1")
    {
    data._orderMeal1();
    string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }


    }


    else if (userInput == "2")
    {
     data._orderMeal2();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }

    }


    else if (userInput == "3")
    {
     data._orderMeal3();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }
    
    }


    else if (userInput == "4")
    {
    data._orderMeal3();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }
    }


    else if (userInput == "5")
    {
    data._searchMeal();
    string userInput4 = Console.ReadLine();
    if (userInput4 == "1")
    {
    Console.WriteLine("==================================FOODS==================================");
    
            Console.WriteLine(" Enter 1 for Jerk chicken ");
            Console.WriteLine(" Enter 2 for Jerk chicken ");
            Console.WriteLine(" Enter 3 for Oxtail & rice with sweety plantains ");
            Console.WriteLine(" Enter 4 for Oxtail & rice with salty plantains ");
            Console.WriteLine(" Enter 5 for Fish Escovitch ");
    

    string userInput5 = Console.ReadLine();
    
    if (userInput5 == "1")
    {
    data._orderMeal1();
    string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }


    }


    else if (userInput == "2")
    {
     data._orderMeal2();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }

    }


    else if (userInput == "3")
    {
     data._orderMeal3();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    else
    {
        data._checkout();
    }
    
    }


    else if (userInput == "4")
    {
    data._orderMeal3();
     string userInput2 = Console.ReadLine();
    
    if (userInput2 == "1")
    {
        data._orderDrink();
        data._checkout();
    }
    
    else
    {
        data._checkout();
    }
    }


    


    //Console.WriteLine("Someone is taking care of your order!");
    }
    else
    {
        Console.WriteLine("Sorry, bye");
    }
   
    }
    else
    {
    Console.WriteLine("Sorry");
    }
    
    Console.ReadLine();
    


//}



