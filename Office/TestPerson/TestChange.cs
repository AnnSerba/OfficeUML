using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace TestPerson
{
    [TestClass]
    public class PersonTest
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Trace.WriteLine("Инициализация теста началася в " + DateTime.Now);
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Trace.WriteLine("Инициализация тестового класса началася в " + DateTime.Now);
        }
        [TestMethod]
        public void TestChange1()
        {
            IPerson person = new Person();
            Assert.IsFalse(person.Change("", ""));
        }
        [TestMethod]
        public void TestChangeError1()
        {
            IPerson person = new Person();
            string actualValError = person.ChangeErrorToString("", "");
            string expectedError = "Имя не может быть пустым Тип не может быть пустым ";
            Assert.AreEqual(expectedError, actualValError);
        }
        [TestMethod]
        public void TestChange2()
        {
            IPerson person = new Person();
            Assert.IsTrue(person.Change("Семён Семёнович Семёнов", "Физическое лицо"));
        }
        [TestMethod]
        public void TestChangeError2()
        {
            IPerson person = new Person();
            string actualValError = person.ChangeErrorToString("Семён Семёнович Семёнов", "Физическое лицо");
            string expectedError = "";
            Assert.AreEqual(expectedError, actualValError);
        }
        [TestMethod]
        public void TestChange3()
        {
            IPerson person = new Person();
            Assert.IsFalse(person.Change("ТигранТигранович", "Физическое лицо"));
        }
        [TestMethod]
        public void TestChangeError3()
        {
            IPerson person = new Person();
            string actualValError = person.ChangeErrorToString("ТигранТигранович", "Физическое лицо");
            string expectedError = "Имя должно быть из 3-х слов ";
            Assert.AreEqual(expectedError, actualValError);
        }
        [TestMethod]
        public void TestChange4()
        {
            IPerson person = new Person();
            Assert.IsTrue(person.Change("ОО Издатель", "Юридическое лицо"));
        }
        [TestMethod]
        public void TestChangeError4()
        {
            IPerson person = new Person();
            string actualValError = person.ChangeErrorToString("ОО Издатель", "Юридическое лицо");
            string expectedError = "";
            Assert.AreEqual(expectedError, actualValError);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine("Сборка начата в " + DateTime.Now);
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("Тест завершон в " + DateTime.Now);
        }
    }
}
