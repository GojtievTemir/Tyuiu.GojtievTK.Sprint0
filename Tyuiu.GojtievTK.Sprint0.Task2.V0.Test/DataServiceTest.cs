using Tyuiu.GojtievTK.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GojtievTK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckMethodValid()
        {
            var name = "Темир";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Темир", res);
        }
    }
}
