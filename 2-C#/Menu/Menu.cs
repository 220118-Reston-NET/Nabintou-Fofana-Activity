namespace JamaicanFood
{
    public class Meal
    {
        private string _meal1 = "Jerk chicken";
        private string _meal2 = "Jerk fish";
        private string _meal3 = "Oxtail & rice with sweet plantains";
        private string _meal4 = "Oxtail & rice with salty plantains";
        private string _meal5 = "Fish Escovitch";

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
        public string Meal4 
        {
            get {return "Ok! You ordered " + _meal4;}
            set {_meal4 = value;}
        }

        public string Meal5 
        {
            get {return "Ok! You ordered " + _meal5;}
            set {_meal5 = value;}
        }

        public void OrderM()
        {
            Console.WriteLine("Hello, How may I help you today?");
        }
    }
}