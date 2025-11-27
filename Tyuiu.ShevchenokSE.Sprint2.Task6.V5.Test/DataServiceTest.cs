using Tyuiu.ShevchenokSE.Sprint2.Task6.V5.Lib;
namespace Tyuiu.ShevchenokSE.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCardValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.FindCardValue(6), "Шестерка");
            Assert.AreEqual(ds.FindCardValue(7), "Семерка");
            Assert.AreEqual(ds.FindCardValue(8), "Восьмерка");
            Assert.AreEqual(ds.FindCardValue(9), "Девятка");
            Assert.AreEqual(ds.FindCardValue(10), "Десятка");
            Assert.AreEqual(ds.FindCardValue(11), "Валет");
            Assert.AreEqual(ds.FindCardValue(12), "Дама");
            Assert.AreEqual(ds.FindCardValue(13), "Король");
            Assert.AreEqual(ds.FindCardValue(14), "Туз");
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardValue(15);
            });
        }
    }
}