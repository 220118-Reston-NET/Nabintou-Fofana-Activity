//using ShopDL;
namespace ShopModel
{
public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public int StoreID { get; set; }
    public string StoreLocation{get; set;}
    public int TotalPrice { get; set; }
    private List<LineItem> _lineitems;
    public List<LineItem> LineItems
        {
            get { return _lineitems; }
            set 
            { 
                _lineitems = value;
            }
        }

    //public int TotalPrice { get; set; };

    public Order()
        {
            OrderID = 1;
            CustomerID = 1;
            StoreID = 1;
            StoreLocation = "";
            _lineitems = new List<LineItem>()
            {
                new LineItem()
            };
            
            TotalPrice = 0;
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"OrderID: {OrderID}\nCustomerID: {CustomerID}\nStoreID: {StoreID}\nStoreLocation: {StoreLocation}\n_lineitems: {_lineitems}\nTotalPrice: {TotalPrice}";
            /* \nListOfLineItem: {ListOfLineItem}*/
        }

}
}
