namespace ShopModel
{
public class Customer
{
    public int CustomerID { get; set;}
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerEmail { get; set; }
    public long CustomerPhoneNumber { get; set; }
   

    private List<Order> _orders;
    public List<Order> Orders
        {
            get { return _orders; }
            set 
            { 
                _orders = value;
            }
        }

    
        //Default constructor to add default values to the properties
        public Customer()
        {
            CustomerID = 1;
            CustomerName = "";
            CustomerAddress = "";
            CustomerEmail = "";
            CustomerPhoneNumber = 1122223366;
             _orders = new List<Order>()
            {
                new Order()
            };
            
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"CustomerID: {CustomerID}\nCustomerName: {CustomerName}\nCustomerAddress: {CustomerAddress}\nCustomerEmail: {CustomerEmail}\nCustomerPhoneNumber: {CustomerPhoneNumber}";
        }

    
}
}
