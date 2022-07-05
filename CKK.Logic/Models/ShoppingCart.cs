using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class ShoppingCart
    {
        //variables for ShoppingCart
        private Customer _Customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        //constructor for receiving Customer
        public ShoppingCart(Customer cust)
        {
            _Customer = cust;
        }

        //methods
        public int GetCustomerId()
        {
            return _Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod)
        {

        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity <= 1 && prod == _product1.GetProduct())
            {
                return _product1;
            }

            if (quantity <= 1 && prod == _product2.GetProduct())
            {
                return _product2;
            }

            if (quantity <= 1 && prod == _product3.GetProduct())
            {
                return _product3;
            }

            return null;
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {

        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (id = _product1.GetProduct())
            {
                return _product1;
            }

            if (id = _product2.GetProduct())
            {
                return _product2;
            }

            if (id = _product3.GetProduct())
            {
                return _product3;
            }

            return null;
        }

        public decimal GetTotal()
        {

        }

        public ShoppingCartItem GetProduct(int productNum)
        {

        }
    }
}
