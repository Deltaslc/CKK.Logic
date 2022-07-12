using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;

namespace StructuredProject1.Logic.TestsForStudents
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProduct_FirstGo()
        {
            try
            {
                //assemble
                ShoppingCart shoppingCart = new();  
                var expected = new Product();
                shoppingCart.AddProduct(expected);

                //act
                var actual = shoppingCart.GetProduct(1).GetProduct();

                //assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                //assert failure
                throw new XunitException("Opps.. you don't know what you are doing!");
            }

        }

        [Fact]
        public void AddProduct_SecondGo()
        {
            try
            {
                //assemble
                ShoppingCart shoppingCart = null;
                var product1 = new Product();
                var expected = new Product();
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(expected);

                //act
                var actual = shoppingCart.GetProduct(2).GetProduct();

                //assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                //assert failure
                throw new XunitException("Really, you do not!");
            }
        }

        [Fact]
        public void AddProduct_ThirdGo()
        {
            try
            {
                //assemble
                ShoppingCart shoppingCart = null;
                var product1 = new Product();
                var product2 = new Product();
                var expected = new Product();
                shoppingCart.AddProduct(product1);
                shoppingCart.AddProduct(product2);
                shoppingCart.AddProduct(expected);

                //act
                var actual = shoppingCart.GetProduct(3).GetProduct();

                //assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                //assert failure
                throw new XunitException("Why do you do this, figure it out!");
            }
        }

        [Fact]
        public void RemovingProductTest()
        {
            try
            {
                //assemble

                //act

                //assert
            }
            catch
            {
                //assert failure
                throw new XunitException("What are you doing!");
            }

        }

        [Fact]
        public void GettingTotal()
        {
            try
            {
                //assemble

                //act

                //assert
            }
            catch
            {
                //assert failure
                throw new XunitException("You can do this correctly, do not give up!");
            }
        }
    }
}
