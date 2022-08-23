using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using RestSharp;
using System.Diagnostics;
using Newtonsoft.Json;
using RestClassLib;


namespace RestTest
{
    [TestClass]
    public class UnitTest1
    {
       private TestContext testcontextInstance;
       public TestContext TestContext
       {
        get{return testcontextInstance;}
        set{testcontextInstance=value;}
       }


        [TestMethod]
        public void TestMethod1()
        {
            string r =APIClass.GetMethod();
            TestContext.WriteLine("Get method output \n\n\n"+r);
            Assert.AreEqual("hi","Hello","string not matched ");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string P =APIClass.PostMethod();
            TestContext.WriteLine("post method output \n\n\n"+P);
            Assert.AreEqual("hi","Hlo","string not matched ");
        }
         [TestMethod]
        public void TestMethod3()
        {
            string d =APIClass.DeleteMethod();
            TestContext.WriteLine("Delete method output \n\n\n"+d);
            Assert.AreEqual("hi","Hlo","string not matched ");
        }
        [TestMethod]
        public void TestMethod4()
        {
            string d =APIClass.PutMethod();
            TestContext.WriteLine("put method output \n\n\n"+d);
            Assert.AreEqual("hi","Hlo","string not matched ");
        }



        }
       
    }
