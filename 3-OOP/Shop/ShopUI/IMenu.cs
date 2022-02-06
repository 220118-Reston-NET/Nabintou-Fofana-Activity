namespace ShopUI
{
    public enum MenuType
    {
        MainMenu,
        ManagerMainMenu,
        CustomerMainMenu,
        Exit,
        AddProduct,
        SearchProduct,
        AddCustomer,
        SearchCustomer,
        AddOrder,
        AddStoreFront,
        AddLineItems,
        AddInventory,
        ViewInventory,
        PlaceOrder,  
    
        
    }

        public interface IMenu
    {
        /// <summary>
        /// Will display the menu and user choices in the terminal
        /// </summary>
        void Display();
        
        

        /// <summary>
        /// Will record the user's choice and change/route your menu based on that choice
        /// </summary>
        /// <returns>Return the menu that will change your screen</returns>
        MenuType UserChoice();
    }
    
}