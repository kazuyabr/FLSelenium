using OpenQA.Selenium;
using System.Threading;

namespace FLAutomation
{
    public class AddBand : AutomationBase
    {
        AddApprover addApprover = new AddApprover();
        MaintainCostApproves costApproves = new MaintainCostApproves();
        public void AddBand1()
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
            addApprover.BudegtHolder();
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("1");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboSendTo")).SendKeys("1");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            AddBand2();

        }
        public void AddBand2()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("10000");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            addApprover.BudegtHolder();
            addApprover.SmallSpend();
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("2");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboSendTo")).SendKeys("2");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            AddBand3();
        
        }
        public void AddBand3()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("20000");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            addApprover.BudegtHolder();
            addApprover.SmallSpend();
            addApprover.MediumSpend();
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("3");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboSendTo")).SendKeys("3");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            AddBand4();
        }
        public void AddBand4()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNew")).Click();
            driver.FindElement(By.Name("txtBand")).Clear();
            driver.FindElement(By.Name("txtBand")).SendKeys("99999999");
            driver.FindElement(By.Name("chkAppliesTo1")).Click();
            driver.FindElement(By.Name("chkAppliesTo2")).Click();
            driver.FindElement(By.Name("chkAppliesTo3")).Click();
            driver.FindElement(By.Name("chkAppliesTo4")).Click();
            driver.FindElement(By.Name("chkLineManagerReqd")).Click();
            driver.FindElement(By.Name("butSubmit")).Click();
            addApprover.BudegtHolder();
            addApprover.SmallSpend();
            addApprover.MediumSpend();
            addApprover.LargeSpend();
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboAuthorisersReqd")).SendKeys("4");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("cboSendTo")).SendKeys("4");
            driver.FindElement(By.Name("butSubmit")).Click();
            driver.FindElement(By.Name("butBack")).Click();
            costApproves.ApprovalCosts();
        }
    }
}
