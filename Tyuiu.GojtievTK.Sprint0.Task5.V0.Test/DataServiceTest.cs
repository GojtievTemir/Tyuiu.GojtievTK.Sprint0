using Tyuiu.GojtievTK.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GojtievTK.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));

        }
        [TestMethod]
        public void CheckSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));

        }
        [TestMethod]
        public void CheckMultiplicatonValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));

        }
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));

        }
    }
}
