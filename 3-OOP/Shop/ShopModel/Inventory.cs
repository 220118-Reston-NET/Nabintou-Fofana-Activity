namespace ShopModel
{
  public class Inventory
  {
    public int InventoryID { get; set; }
    public int StoreID { get; set; }
    public string StoreName { get; set; }
    public int ProductID { get; set; }
    public int ProductQuantity { get; set; }

    public Inventory()
    {
      InventoryID = 0;
      StoreID = 0;
      StoreName = "";
      ProductID = 0;
      ProductQuantity = 0;
    }

    public override string ToString()
    {
      return $"InventoryID: {InventoryID}\nStoreID: {StoreID}\nStoreName: {StoreName}\nProductID: {ProductID}\nProductQuantity: {ProductQuantity}";
    }
  }
}