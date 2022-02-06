namespace ShopModel
{
public class LineItem
{
    public int ProductID{ get; set; }
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }

     public LineItem()
        {
            ProductID = 1;
            ProductName = "";
            ProductQuantity = 0;
        }

        //ToString() method is the string version of your object
        public override string ToString()
        {
            return $"ProductID: {ProductID}\nProductName: {ProductName}\nProductQuantity: {ProductQuantity}";
        }
}
}