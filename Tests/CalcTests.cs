using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Tests
{
    /// <summary>
    /// 
    /// aprender decorators
    /// </summary>
    [TestClass]
    public class CalcTests
    {
        [DataRow(5,5,10)]
        [DataRow(5, 15, 20)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue(int a, int b, int expectedResult)
        {
            // arrange            
            // Act
            int actualResult = Calcs.Sum(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Sum_ShouldCalcAndReturnAnInteger()
        {
            // arrange
            int a = 4, b = 5;
            // Act
            int actualResult = Calcs.Sum(a, b);
            // Assert
            Assert.IsNotNull(actualResult);
        }


    }
}
