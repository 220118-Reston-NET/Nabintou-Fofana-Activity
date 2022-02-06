
using ShopModel;

namespace ShopDL
{
    public interface IRepository_p
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_product">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        Product AddProduct(Product b_product);
        
        /// <summary>
        /// Will give a list of book objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name1">Name parameter being used to filter our book</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Product> GetAllProduct();
        
    }

    public interface IRepository_c
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_customer">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        Customer AddCustomer(Customer b_customer);
    
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Customer> GetAllCustomer();  
        
    }

     public interface IRepository_o
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_order">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        Order AddOrder(Order b_order);
    
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Order> GetAllOrder();  
       
    }

     public interface IRepository_s
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_storefront">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        StoreFront AddStoreFront(StoreFront b_storefront);
        
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<StoreFront> GetAllOfStoreFront();  

        /// <summary>
        /// Will give a list of abilities from a pokemon
        /// </summary>
        /// <param name="b_storeID">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Product> GetProductByStoreID(int b_storeID);
        
    }

     public interface IRepository_i
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_lineitem">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        LineItem AddLineItem(LineItem b_lineitem);
        
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<LineItem> GetAllOfLineItem();  
        
    }

    public interface IRepository_v
    {
         /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="b_inventory">This the pokemon object we are adding to the database</param>
        /// <returns>Returns the pokemon that was added</returns>
        Inventory AddInventory(Inventory b_inventory);
        
        /// <summary>
        /// Will give a list of pokemon objects that are related to the searched name
        /// </summary>
        ///// <param name="p_name">Name parameter being used to filter our pokemon</param>
        /// <returns>Gives a filtered list of pokemon via the name</returns>
        List<Inventory> GetAllOfInventory();  

        /// <summary>
        /// Will give a list of abilities from a pokemon
        /// </summary>
        /// <param name="b_inventoryID">The Id of the pokemon it will search</param>
        /// <returns>list collection that holds ability objects</returns>
        List<Product> GetProductByInventoryID(int b_inventoryID);
   
    }
    
}


