using OpenQA.Selenium;
using System.Threading;

namespace FLAutomation
{
    class MaintainCostApproves : AutomationBase
    {
        //AddApprovalGroups addApproval = new AddApprovalGroups();
       
        public void ApprovalCosts()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butMaintain")).Click();
            driver.FindElement(By.Name("txt1Col1")).SendKeys(AddApprovalGroups.Code);
            driver.FindElement(By.Name("txt2Col1")).SendKeys(AddApprovalGroups.Code);
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            //driver.FindElement(By.Name("butBack")).Click();
        }
    }
}
