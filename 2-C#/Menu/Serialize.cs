using System.Text.Json;
using DataFunction;

namespace SerializeFunction
{
    public class Serialize
    {
        public static string _filepath = "./Database/Data.json";

        public static void SerialMain()
        {
            Console.WriteLine("===Serialization Demo===");
            
            Console.WriteLine("=Converting object to JSON=");
            
            //Created a list of datas
            List<Data> listOfMeals = new List<Data>();

            Data data1 = new Data()
            {
                meal1 = "Jerk chicken",
                meal2 = "Jerk fish",
                meal3 = "Oxtail rice with sweet plantains",
                meal4 = "Oxtail rice with salty plantains",
                meal5 = "Fish Escovitch",
            };

            listOfMeals.Add(data1);

            //converting C# object into a string
            string jsonString = JsonSerializer.Serialize(listOfMeals,new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            //File class will create a JSON file (if there isn't one already) or overwrite
            File.WriteAllText(_filepath, jsonString);

        }
    }
}