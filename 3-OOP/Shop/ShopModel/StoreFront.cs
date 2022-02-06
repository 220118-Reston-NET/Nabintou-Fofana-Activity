namespace ShopModel
{
public class StoreFront
{
    public int StoreID { get; set; }
    public string StoreName { get; set; }
    public string StoreLocation { get; set; }
    //public List<Product> ListOfProduct { get; set; }   
    //public List<Order> ListOfOrder { get; set; }

    private List<Order> _orders;
    public List<Order> Orders
        {
            get { return _orders; }
            set 
            { 
                _orders = value;
            }
        }
    
    private List<Product> _products;
    public List<Product> Products
        {
            get { return _products; }
            set 
            { 
                _products = value;
            }
        }

     public StoreFront()
        {
            StoreID = 1;
            StoreName = "";
            StoreLocation = "";
             _orders = new List<Order>()
            {
                new Order()
            };
           

            _products = new List<Product>()
            {
                new Product()
            };
            
            //ListOfProduct = new List<Product>() { new Product() };
            //ListOfOrder= new List<Order>() { new Order() };
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"StoreID: {StoreID}\nStoreName: {StoreName}\nStoreLocation: {StoreLocation}";
        }
}
}
