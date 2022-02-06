using ShopModel;

namespace ShopBL
{
    public interface IProductBL
    {
        /// <summary>
        /// Will add a book data to the database
        /// Initial addition of a book will give it some sort of a randomize stats
        /// Can only have the total of 20 books in the database
        /// </summary>
        /// <param name="b_product"></param>
        /// <returns></returns>
        Product AddProduct(Product b_product);
        
        /// <summary>
        /// Will give a list of book objects that are related to the searched name
        /// </summary>
        /// <param name="p_name">Name parameter being used to filter our book</param>
        /// <returns>Gives a filtered list of book via the name</returns>
        List<Product> SearchProduct(string p_name); 
    }

     public interface ICustomerBL
    {
        /// <summary>
        /// Will add a pokemon data to the database
        /// Initial addition of a pokemon will give it some sort of a randomize stats
        /// Can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name="b_customer"></param>
        /// <returns></returns>
        Customer AddCustomer(Customer b_customer);
        
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        /// 
        /// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Customer> SearchCustomer(string p_name);    
    }

     public interface IOrderBL
    {
        /// <summary>
        /// Will add a pokemon data to the database
        /// Initial addition of a pokemon will give it some sort of a randomize stats
        /// Can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name="b_order"></param>
        /// <returns></returns>
        Order AddOrder(Order b_order);
    }

     public interface IStoreFrontBL
    {
        /// <summary>
        /// Will add a pokemon data to the database
        /// Initial addition of a pokemon will give it some sort of a randomize stats
        /// Can only have the total of 4 pokemons in the database
        /// </summary>
        /// <param name="b_storefront"></param>
        /// <returns></returns>
        StoreFront AddStoreFront(StoreFront b_storefront);
      
        /// <summary>
        /// Will give a list of store objects that are related to the searched name
        /// </summary>
        /// <param name="p_name">Name parameter being used to filter our store</param>
        /// <returns>Gives a filtered list of store via the name</returns>
        List<StoreFront> SearchStoreFront(string p_name);

        /// <summary>
        /// Will give a list of storefront from the database
        /// </summary>
        /// <returns>list collection with pokemon objects</returns>
        List<StoreFront> GetAllOfStoreFront();

        /// <summary>
        /// Will give a list of abilities from a store
        /// </summary>
        /// <param name="b_storeID">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Product> GetProductByStoreID(int b_storeID);
        
    }

    public interface ILineItemBL
    {
        /// <summary>
        /// Will add a line items data to the database
        /// </summary>
        /// <param name="b_lineitem"></param>
        /// <returns></returns>
        
        LineItem AddLineItem(LineItem b_lineitem);
    }

    public interface IInventoryBL
    {
        /// <summary>
        /// Will add inventory data to the database
        /// </summary>
        /// <param name="b_inventory"></param>
        /// <returns></returns>
        
        Inventory AddInventory(Inventory b_inventory);
     
        // <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        /// 
        /// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Inventory> SearchInventory(string p_name);
        //List<Inventory> SearchInventory();

        /// <summary>
        /// Will give a list of storefront from the database
        /// </summary>
        /// <returns>list collection with pokemon objects</returns>
        List<Inventory> GetAllOfInventory();

        /// <summary>
        /// Will give a list of abilities from a store
        /// </summary>
        /// <param name="b_inventoryID">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Product> GetProductByInventoryID(int b_InventoryID);
        
    }
}