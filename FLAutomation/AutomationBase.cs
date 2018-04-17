using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace FLAutomation
{
    public class AutomationBase
    {
        #region Global Variables
        public static string baseURL = ConfigurationManager.AppSettings["baseURL"].ToString();
      //  public static string UserName = ConfigurationManager.AppSettings["UserName"].ToString();
      //  public static string Password = ConfigurationManager.AppSettings["Password"].ToString();
        public static IWebDriver driver = null;
      //  private string Browser = ConfigurationManager.AppSettings["Browser"].ToString();
        private string DriverPath = AppDomain.CurrentDomain.BaseDirectory + "\\Driver\\";
        public static IJavaScriptExecutor js;

        //public static ExtentReportBase Report = new ExtentReportBase();
        #endregion

        #region CommonMethods
        [OneTimeSetUp]
        public void TestInitialize()
        {
            try
            {
                driver = new ChromeDriver(DriverPath);
                js = driver as IJavaScriptExecutor;
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(baseURL);
                Signin();
            }
            catch (Exception)
            {
                throw;
            }

        }

        [OneTimeTearDown]
        public void TestCleanup()
        {
            try
            {

                driver.Close();
                driver.Quit();
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion


        public void Signin()
        {
            driver.FindElement(By.Id("userid")).Clear();
            driver.FindElement(By.Id("userid")).SendKeys("CANREQ");
            driver.FindElement(By.Name("pwd1")).Clear();
            driver.FindElement(By.Name("pwd1")).SendKeys("Password10");
            driver.FindElement(By.Name("butSignOn")).Click();
        }
    }
}
