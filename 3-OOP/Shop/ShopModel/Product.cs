namespace ShopModel
{
public class Product
{
    public int StoreID { get; set; }
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductCategory { get; set; }
    public int ProductPrice { get; set; }

    //Full properties are required to do validation
        private List<Quality> _qualities;
        public List<Quality> Qualities
        {
            get { return _qualities; }
            set 
            { 
                //Cannot set abilities to have more than 4
                if (value.Count < 3)
                {
                    _qualities = value;
                }
                else
                {
                    throw new Exception("A product cannot hold more than 3 conditions!");
                }
            }

        }
    
        //Default constructor to add default values to the properties
        public Product()
        {
            StoreID = 1;
            ProductID = 1;
            ProductName = "";
            ProductDescription = "";
            ProductCategory = "";
            ProductPrice = 0;
            _qualities = new List<Quality>()
            {
                new Quality()
            };
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nProductID: {ProductID}\nProductName: {ProductName}\nProductDescription: {ProductDescription}\nProductCategory: {ProductCategory}\nProductPrice: {ProductPrice}";
        }

    }
}
