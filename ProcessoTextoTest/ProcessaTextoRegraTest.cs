using ProcessaTextoBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoTextoTest
{
    
    
    /// <summary>
    ///This is a test class for ProcessaTextoRegraTest and is intended
    ///to contain all ProcessaTextoRegraTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcessaTextoRegraTest
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
        ///A test for ConverteEntradaEmDias
        ///</summary>
        [TestMethod()]
        public void ConverteEntradaEmDiasTest()
        {
            ProcessaTextoRegra target = new ProcessaTextoRegra(); // TODO: Initialize to an appropriate value

            StringBuilder entradaSimuladaUsuario = new StringBuilder();
            for (int i = 0; i < 30; i++)
            {
                entradaSimuladaUsuario.Append("X");
            }
            entradaSimuladaUsuario.Remove(0, 1);
            entradaSimuladaUsuario.Insert(0, "B");
            
            List<int> expected = new List<int>();
            expected.Add(1);

            List<int> actual = target.ConverteEntradaEmDias(entradaSimuladaUsuario.ToString());

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void VerificaExcecaoLimiteTamanhoTest()
        { 
            ProcessaTextoRegra target = new ProcessaTextoRegra(); // TODO: Initialize to an appropriate value

            StringBuilder entradaSimuladaUsuario = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                entradaSimuladaUsuario.Append("X");
            }
            target.ConverteEntradaEmDias(entradaSimuladaUsuario.ToString());
        }
    }
}
