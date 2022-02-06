//using System.Collections.Generic;
using System.Text.Json;
using ShopModel;

namespace ShopDL
{
    public class Repository_p : IRepository_p
    {
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public Product AddProduct(Product b_product)
        {
           string path = _filepath + "Product.json";
           //List<Product> listOfProduct = new List<Product>();

           List<Product> listOfProduct = GetAllProduct();

           listOfProduct.Add(b_product);


           _jsonString = JsonSerializer.Serialize(listOfProduct, new JsonSerializerOptions {WriteIndented = true});
           
            File.WriteAllText(path, _jsonString);

            return b_product;
        }
       
        public List<Product> GetAllProduct()
        {
            //grab information from the json file and store it in a string
            _jsonString = File.ReadAllText(_filepath + "Product.json");
            //Deserialize a string into a list<Book> object and return it
            return JsonSerializer.Deserialize<List<Product>>(_jsonString);
            
        }
    }

    public class Repository_c : IRepository_c
    {
        
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public Customer AddCustomer(Customer b_customer)
        {
           string path = _filepath + "Customer.json";
           
           //List <Customer> listOfCustomer = new List<Customer>();
           List<Customer> listOfCustomer = GetAllCustomer();

           listOfCustomer.Add(b_customer);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions {WriteIndented = true});
          
            File.WriteAllText(path, _jsonString);

            return b_customer;
        }
       public List<Customer> GetAllCustomer()
       {
           //grab information from the json file and store it in a string
          _jsonString = File.ReadAllText(_filepath + "Customer.json");
           //Deserialize a string into a list<Book> object and return it
           return JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText(_filepath + "Customer.json"));

       }
    }


     public class Repository_o : IRepository_o
    {
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public Order AddOrder(Order b_order)
        {
           string path = _filepath + "Order.json";
           
          // List <Order> listOfOrder = new List<Order>();
           List<Order> listOfOrder = GetAllOrder();

           listOfOrder.Add(b_order);

            _jsonString = JsonSerializer.Serialize(listOfOrder, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return b_order;
        }

        public List<Order> GetAllOrder()
       {
           //grab information from the json file and store it in a string
          _jsonString = File.ReadAllText(_filepath + "Order.json");
           //Deserialize a string into a list<Book> object and return it
           return JsonSerializer.Deserialize<List<Order>>(File.ReadAllText(_filepath + "Order.json"));

       }
       
    }

    public class Repository_s : IRepository_s
    {
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public StoreFront AddStoreFront(StoreFront b_storefront)
        {
           string path = _filepath + "Storefront.json";
           
           //List <StoreFront> listOfStoreFront = new List<StoreFront>();
           List<StoreFront> listOfStoreFront = GetAllOfStoreFront();

           listOfStoreFront.Add(b_storefront);

            _jsonString = JsonSerializer.Serialize(listOfStoreFront, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return b_storefront;
        }
        public List<Product> GetProductByStoreID(int b_storeID)
        {
            //grab information from the json file and store it in a string
          _jsonString = File.ReadAllText(_filepath + "Storefront.json");
           //Deserialize a string into a list<product> object and return it
           return JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(_filepath + "Storefront.json"));

        }

        public List<StoreFront> GetAllOfStoreFront()
       {
           //grab information from the json file and store it in a string
          _jsonString = File.ReadAllText(_filepath + "Storefront.json");
           //Deserialize a string into a list<storefront> object and return it
           return JsonSerializer.Deserialize<List<StoreFront>>(File.ReadAllText(_filepath + "Storefront.json"));

       }
    }

     public class Repository_i : IRepository_i
    {
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public LineItem AddLineItem(LineItem b_lineitem)
        {
           string path = _filepath + "Lineitem.json";
           
           //List<LineItem> listOfLineItem = new List<LineItem>();
           List<LineItem> listOfLineItem = GetAllOfLineItem();

           listOfLineItem.Add(b_lineitem);

            _jsonString = JsonSerializer.Serialize(listOfLineItem, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return b_lineitem;
        }

        public List<LineItem> GetAllOfLineItem()
       {
           //grab information from the json file and store it in a string
         // _jsonString = File.ReadAllText(_filepath + "Lineitems.json");
           //Deserialize a string into a list<Book> object and return it
           return JsonSerializer.Deserialize<List<LineItem>>(File.ReadAllText(_filepath + "Lineitem.json"));

       }  
    }

    
     public class Repository_v : IRepository_v
    {
        private string _filepath = "../ShopDL/Database/";
        private string _jsonString;
        public Inventory AddInventory(Inventory b_inventory)
        {
           string path = _filepath + "Inventory.json";
           
           //List<Inventory> listOfInventory = new List<Inventory>();
           List<Inventory> listOfInventory = GetAllOfInventory();

           listOfInventory.Add(b_inventory);

            _jsonString = JsonSerializer.Serialize(listOfInventory, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return b_inventory;
        }
        
        public List<Product> GetProductByInventoryID(int b_inventoryID)
        {
            throw new NotImplementedException();
        }
       
        public List<Inventory> GetAllOfInventory()
       {
           //grab information from the json file and store it in a string
         // _jsonString = File.ReadAllText(_filepath + "Lineitems.json");
           //Deserialize a string into a list<Book> object and return it
           return JsonSerializer.Deserialize<List<Inventory>>(File.ReadAllText(_filepath + "Inventory.json"));

       }
    }

}

