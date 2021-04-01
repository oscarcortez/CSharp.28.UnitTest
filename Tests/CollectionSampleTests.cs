using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Tests
{
    [TestClass]
    public class CollectionSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            // arrange
            Customer[] customers = new Customer[2]
            {
                new Customer { FirstName = "jhon", LastName = "ford"},
                new Customer(){ FirstName = "jhon2", LastName = "ford2"}
            };

            int index = 1;
            Customer expectedResult = customers[index];

            // act
            Customer actualResult = CollectionSample.GetCustomer(customers, index);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(Customer));
            Assert.AreEqual(expectedResult, actual: actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutOfRangeException()
        {
            // arrange
            Customer[] customers = new Customer[2]
            {
                new Customer { FirstName = "jhon", LastName = "ford"},
                new Customer(){ FirstName = "jhon2", LastName = "ford2"}
            };

            int index = 3;
            Customer expectedResult = customers[1];

            // act
            Customer actualResult = CollectionSample.GetCustomer(customers, index);

            // assert            
            Assert.AreEqual(expectedResult, actual: actualResult);
        }
    }
}
