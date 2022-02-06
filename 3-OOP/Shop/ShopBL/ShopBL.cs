using ShopModel;
using ShopDL;

namespace ShopBL
{
    public class ProductBL : IProductBL
    {
        private IRepository_p _repo_p;
        public ProductBL(IRepository_p p_repo_p)
        {
            _repo_p = p_repo_p;
        }

        public Product AddProduct(Product b_product)
        {
            //Validation process
            //List<Product> listOfProduct = new List<Product>();
            List<Product> listOfProduct = _repo_p.GetAllProduct();
            if (listOfProduct.Count < 100)
            {
                return _repo_p.AddProduct(b_product);
            }
            else
            {
               throw new Exception("You cannot have more than 100 products!");
            }
      
            // //return the filtered/another list
            return _repo_p.AddProduct(b_product);
        }

        public List<Product> SearchProduct(string p_name)
        {
             {
            List<Product> listOfProduct = _repo_p.GetAllProduct();


            // LINQ library
            return listOfProduct
                        .Where(product => product.ProductName.Contains(p_name)) //Where method is designed to filter a collection based on a condition
                        .ToList(); //ToList method just converts into a list collection that our method needs to return
        
           }
        }
        
    }

public class CustomerBL: ICustomerBL
    {
        private IRepository_c _repo_c;
        public CustomerBL(IRepository_c p_repo_c)
        {
            _repo_c = p_repo_c;
        }

        public Customer AddCustomer(Customer b_customer)
        {
             //return _repo_c.AddCustomer(b_customer);
             //List<Customer> listOfCustomer = new List<Customer>();
             List<Customer> listOfCustomer = _repo_c.GetAllCustomer();

             if (listOfCustomer.Count < 20)
             {
                 return _repo_c.AddCustomer(b_customer);
             }
             else
             {
                 throw new Exception("You cannot have more than 20 customers!");
             }
            return _repo_c.AddCustomer(b_customer);
        }

        public List<Customer> SearchCustomer(string p_name)
        {
            {
            List<Customer> listOfCustomer = _repo_c.GetAllCustomer();

            // LINQ library
            return listOfCustomer
                        .Where(customer => customer.CustomerName.Contains(p_name)) //Where method is designed to filter a collection based on a condition
                        .ToList(); //ToList method just converts into a list collection that our method needs to return
         
            }
        }
    }

     public class OrderBL : IOrderBL
    {
        private IRepository_o _repo_o;
        public OrderBL(IRepository_o p_repo_o)
        {
            _repo_o = p_repo_o;
        }

        public Order AddOrder(Order b_order)
        {
            //Validation process
            //List<Order> listOfOrder = new List<Order>();
            List<Order> listOfOrder = _repo_o.GetAllOrder();
            if (listOfOrder.Count < 100)
            {
                return _repo_o.AddOrder(b_order);
            }
            else
            {
               throw new Exception("You cannot have more than 100 orders!");
            }
    
            // //return the filtered/another list
            return _repo_o.AddOrder(b_order);
        }
    }

    public class StoreFrontBL : IStoreFrontBL
      {
        private IRepository_s _repo_s;
        public StoreFrontBL(IRepository_s p_repo_s)
        {
            _repo_s = p_repo_s;
        }
        
        public StoreFront AddStoreFront(StoreFront b_storefront)
        {
    
            //List<StoreFront> listOfStoreFront = new List<StoreFront>();
            List<StoreFront> listOfStoreFront = _repo_s.GetAllOfStoreFront();
            if (listOfStoreFront.Count < 10)
            {
                return _repo_s.AddStoreFront(b_storefront);
                //StoreFront AddStoreFront(StoreFront b_storefront);
            }
            else
            {
               throw new Exception("You cannot have more than 10 orders!");
            }
        }
        
        public List<Product> GetProductByStoreID(int b_storeID)
        {
            return _repo_s.GetProductByStoreID(b_storeID);
        }

        public List<StoreFront> GetAllOfStoreFront()
        {
            return _repo_s.GetAllOfStoreFront();
        }


        public List<StoreFront> SearchStoreFront(string p_name)
        {
            List<StoreFront> listOfStoreFront = _repo_s.GetAllOfStoreFront();


            // LINQ library
            return listOfStoreFront
                        .Where(storefront => storefront.StoreName.Contains(p_name)) //Where method is designed to filter a collection based on a condition
                        .ToList(); //ToList method just converts into a list collection that our method needs to return
        }
    }


    public class LineItemBL : ILineItemBL
    {
        private IRepository_i _repo_i;
        public LineItemBL(IRepository_i p_repo_i)
        {
            _repo_i = p_repo_i;
        }

        public LineItem AddLineItem(LineItem b_lineitem)
        {
            //Validation process
            //List<LineItem> listOfLineItem = new List<LineItem>();
            List<LineItem> listOfLineItem = _repo_i.GetAllOfLineItem();
            if (listOfLineItem.Count < 50)
            {
                return _repo_i.AddLineItem(b_lineitem);
            }
            else
            {
               throw new Exception("You cannot have more than 50 products!");
            }
      
            // //return the filtered/another list
            return _repo_i.AddLineItem(b_lineitem);
        }
    }

     public class InventoryBL : IInventoryBL
    {
        private IRepository_v _repo_v;
        public InventoryBL(IRepository_v p_repo_v)
        {
            _repo_v = p_repo_v;
        }

        public Inventory AddInventory(Inventory b_inventory)
        {
            //Validation process
            //List<Inventory> listOfInventory = new List<Inventory>();
            List<Inventory> listOfInventory = _repo_v.GetAllOfInventory();
            /*
            if (listOfLineItem.Count < 50)
            {
                return _repo_i.AddLineItem(b_lineitem);
            }
            else
            {
               throw new Exception("You cannot have more than 50 products!");
            }
      
            */

            // //return the filtered/another list
            return _repo_v.AddInventory(b_inventory);
        }

       public List<Product> GetProductByInventoryID(int b_inventoryID)
        {
            return _repo_v.GetProductByInventoryID(b_inventoryID);
        }

        public List<Inventory> GetAllOfInventory()
        {
            return _repo_v.GetAllOfInventory();
        }

       public List<Inventory> SearchInventory(string p_name)
       //public List<Inventory> SearchInventory()
        {
             
            List<Inventory> listOfInventory = _repo_v.GetAllOfInventory();


            // LINQ library
            return listOfInventory
                        .Where(inventory => inventory.StoreName.Contains(p_name)) //Where method is designed to filter a collection based on a condition
                        .ToList(); //ToList method just converts into a list collection that our method needs to return
        

           }
        }
        
    }


