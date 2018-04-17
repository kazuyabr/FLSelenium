using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace FLAutomation
{
    [TestFixture]
    class AddApprovalGroups : AutomationBase
    {
        public static string AddNewGroupCode = ConfigurationManager.AppSettings["addNewGroupCode"].ToString();
        public static string Code = "101-C0410";
        public static string Description = "Curriculum";
        AddBand addBand = new AddBand();
        [Test]
        public void InsertApprover()
        {
            driver.Navigate().GoToUrl(AddNewGroupCode);
            driver.FindElement(By.Name("txtAuthGroupCode")).Clear();
            driver.FindElement(By.Name("txtAuthGroupCode")).SendKeys(Code);
            driver.FindElement(By.Name("txtDescription")).Clear();
            driver.FindElement(By.Name("txtDescription")).SendKeys(Description);
            driver.FindElement(By.Name("txtAdministrator")).Clear();
            driver.FindElement(By.Name("txtAdministrator")).SendKeys("MANAGER");
            driver.FindElement(By.Name("butSubmit")).Click();
            addBand.AddBand1();
        }
     /*   public void AddWorkflow()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("500");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
        }
        public void AddWorkflow2()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            driver.FindElement(By.Name("txtAuthoriser")).Clear();
            driver.FindElement(By.Name("txtAuthoriser")).SendKeys("BUDGETHOLDER");
            driver.FindElement(By.Name("chkMandatory")).Click();
            //add 10 in sequence
            //click submit

            //go back to original screen
            //click submit
            //change approvers required to 1
            //click submit
            //change send to = 1
            //click submit
            //click back
        }*/

    }
}
