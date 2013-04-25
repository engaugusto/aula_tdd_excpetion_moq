using TesteTdd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraTest
{
    
    
    /// <summary>
    ///This is a test class for CalculadoraTest and is intended
    ///to contain all CalculadoraTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculadoraTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Soma
        ///</summary>
        [TestMethod()]
        public void SomaTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            int num1 = 3; // TODO: Initialize to an appropriate value
            int num2 = 5; // TODO: Initialize to an appropriate value
            int expected = 8; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Soma(num1, num2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            int num1 = 10;
            int num2 = 11;

            int esperado = -1;
            Calculadora target = new Calculadora();
            int atual = target.Subtracao(num1, num2);

            Assert.AreEqual(esperado, atual);
        }
    }
}
