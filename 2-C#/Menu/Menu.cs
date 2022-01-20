namespace JamaicanFood
{
    public class Meal
    {
        private string _meal1 = "Jerk chicken/fish";
        private string _meal2 = "Oxtail & rice";
        private string _meal3 = "Fish Escovitch";

        public string Meal1
        {
            get {return " You ordered " + _meal1;}
            set { _meal1 = value; } 
        }

        public string Meal2 
        {
            get {return " You ordered " + _meal2;}
            set {_meal2 = value;}
        }

        public string Meal3 
        {
            get {return "Ok! You ordered " + _meal3;}
            set {_meal3 = value;}
        }

        public void Order()
        {
            Console.WriteLine("Someone is taking care of your order!");
        }
    }
}