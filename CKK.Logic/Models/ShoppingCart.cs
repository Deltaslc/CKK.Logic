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

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (quantity >= 1 && prod == _product1.GetProduct())
            {
                return _product1;
            }

            if (quantity >= 1 && prod == _product2.GetProduct())
            {
                return _product2;
            }

            if (quantity >= 1 && prod == _product3.GetProduct())
            {
                return _product3;
            }

            return null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            if (prod == null)
            {
                return _product1;
            }

            if (prod == null)
            {
                return _product2;
            }

            if (prod == null)
            {
                return _product3;
            }

            return null;
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (prod == _product1.GetProduct() && quantity <= 0)
            {
                _product1 = null;
            }

            if (prod == _product2.GetProduct() && quantity <= 0)
            {
                _product2 = null;
            }

            if (prod == _product3.GetProduct() && quantity <= 0)
            {
                _product3 = null;
            }

            return null;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (id == _product1.GetProduct().GetId())
            {
                return _product1;
            }

            else if (id == _product2.GetProduct().GetId())
            {
                return _product2;
            }

            else if (id == _product3.GetProduct().GetId())
            {
                return _product3;
            }

            return null;
        }

        public decimal GetTotal()
        { 
            decimal _p1 = ( _product1.GetQuantity() * _product1.GetProduct().GetPrice() );
            decimal _p2 = ( _product2.GetQuantity() * _product2.GetProduct().GetPrice() );
            decimal _p3 = ( _product3.GetQuantity() * _product3.GetProduct().GetPrice() );

            return _p1 + _p2 + _p3;

        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum == 1)
            {
                return _product1;
            }

            else if (productNum == 2)
            {
                return _product2;
            }

            else if (productNum == 3)
            {
                return _product3;
            }

            return null;
        }
    }
}
