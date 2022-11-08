using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        //variables for ShoppingCart
        private Customer _Customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;
        private List<ShoppingCartItem> Products;

        //constructor for receiving Customer
        public ShoppingCart(Customer cust)
        {
            _Customer = cust;
            Products = new List<ShoppingCartItem>();
        }

        //methods
        public int GetCustomerId()
        {
            return _Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            //Check for quantity
            if (quantity < 0)
            {
                return null;
            }

            //Use Linq query to find product and add
            var newItems =
                from p in Products
                select p;

            //add product it quantity is found?
            if (newItems != null)
            {
                return Products.SingleOrDefault(p => p.GetProduct().GetId() == prod.GetId());
            }
            
            //add new product if there is none?
            if (newItems == null)
            {
                Products = new List<ShoppingCartItem>();
            }

            return null;
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            //check for quantity and remove if found
            if (quantity > 1)
            {
                return null;
            }

            //linq query to find product and remove it
            var removeItems =
                from p in Products
                select p;

            //remove product if found
            if (removeItems != null)
            {
                return null;
            }

            return null;
        }
                
        public ShoppingCartItem GetProductById(int id)
        {
            return Products.FirstOrDefault(x => x.GetProduct().GetId() == id);
        }

        public decimal GetTotal()
        {
            //var total =
                //from p in Products
                //let Total = p.GetQuantity() * p.GetProduct().GetPrice()
                //select p; 

            decimal _p1 =  _product1.GetQuantity() * _product1.GetProduct().GetPrice() ;
            decimal _p2 =  _product2.GetQuantity() * _product2.GetProduct().GetPrice() ;
            decimal _p3 =  _product3.GetQuantity() * _product3.GetProduct().GetPrice() ;

            return _p1 + _p2 + _p3;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }







        //public ShoppingCartItem AddProduct(Product prod, int quantity)
        //{
        // checks for valid quantity
        //if (quantity < 1)
        //{
        //return null;
        //}

        // checking for product and adds the quantity if its found
        //if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
        //{
        //_product1.SetQuantity(_product1.GetQuantity() + quantity);
        //return _product1;
        //}

        //if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
        //{
        //_product2.SetQuantity(_product2.GetQuantity() + quantity);
        //return _product2;
        //}

        //if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
        //{
        //    _product3.SetQuantity(_product3.GetQuantity() + quantity);
        //   return _product3;
        ///}

        // adding new product if there is none
        //if (_product1 == null)
        //{
        //   _product1 = new ShoppingCartItem(prod, quantity);
        //   return _product1;
        //}

        //if (_product2 == null)
        //{
        //    _product2 = new ShoppingCartItem(prod, quantity);
        //    return _product2;
        //}

        //if (_product3 == null)
        //{
        //    _product3 = new ShoppingCartItem(prod, quantity);
        //    return _product3;
        //}

        //return null;
        //}





        //public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        //{
        // checking for quantity and removes it if found
        //if (quantity >1)
        //{
        //return null;
        //}

        //if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
        //{
        //_product1.SetQuantity(_product1.GetQuantity() - quantity);

        //if (_product1.GetQuantity() < 1)
        //{
        //return null;
        //}

        //return _product1;
        //}

        //if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
        //{
        //_product2.SetQuantity(_product2.GetQuantity() - quantity);

        //if (_product2.GetQuantity() < 1)
        //{
        //return null;
        //}

        //return _product2;
        //}

        //if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
        //{
        //_product3.SetQuantity(_product3.GetQuantity() - quantity);

        //if (_product3.GetQuantity() < 1)
        //{
        // return null;
        //}

        //return _product3;
        //}

        //return null;
        //}
    }
}
