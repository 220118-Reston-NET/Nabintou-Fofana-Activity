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

            //Converting C# object into a JSON formatted string datatype
            //Just means converting C# object into a string
            string jsonString = JsonSerializer.Serialize(data1,new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonString);

            //File class will create a JSON file (if there isn't one already) or overwrite
            File.WriteAllText(_filepath, jsonString);

            //Console.WriteLine("=Converting JSON to object=");
            //File.ReadAllText() static method will read our JSON file and store it in our jsonString2
            string jsonString2 = File.ReadAllText(_filepath);

            //JsonSerializer converts the JSON object into a C# object
            List<Data> data2 = JsonSerializer.Deserialize<List<Data>>(jsonString2);


            Console.WriteLine(data2[0].meal1);
            Console.WriteLine(data2[0].meal2);
            Console.WriteLine(data2[0].meal3);
            Console.WriteLine(data2[0].meal4);
            Console.WriteLine(data2[0].meal5);
            


        }
    }
}