namespace ShopModel
{
    public class Quality
    {
        //Act as the primary key
        public int QuaId{ get; set;}
        public string Name { get; set; }

        //Full property is needed to add validation
        private int _PP;
        public int PP
        {
            get { return _PP; }
            //You can only set PP above 0
            set 
            {
                if (value > 0)
                {
                    _PP = value; 
                }
                else
                {
                    throw new Exception("You cannot set PP lower than 0!");
                }
            }
        }
        
        public int Durability { get; set; }
        public int Reliability { get; set; }

        public Quality()
        {
            Name = "Conformity";
            PP = 40;
            Durability = 80;
            Reliability = 40;
        }
    }
}