using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace FLAutomation
{
    public class AddApprover : AutomationBase
    {
       

        public void BudegtHolder()
        {
            Thread.Sleep(200);
            var currentWindow = driver.CurrentWindowHandle;
            var availableWindows = new List<string>(driver.WindowHandles);
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            foreach (string w in availableWindows)
            {
                if (w != currentWindow)
                {
                    driver.SwitchTo().Window(w);
                    
                    driver.FindElement(By.Name("txtAuthoriser")).Clear();
                    driver.FindElement(By.Name("txtAuthoriser")).SendKeys("BUDGETHOLDER");
                    driver.FindElement(By.Name("chkMandatory")).Click();
                    driver.FindElement(By.Name("txtSequence")).SendKeys("10");
                    driver.FindElement(By.Name("butSubmit")).Click();

                }
            }
            
        }
        
        public void SmallSpend()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            driver.FindElement(By.Name("txtAuthoriser")).Clear();
            driver.FindElement(By.Name("txtAuthoriser")).SendKeys("SMALLSPEND");
            driver.FindElement(By.Name("chkMandatory")).Click();
            driver.FindElement(By.Name("txtSequence")).SendKeys("20");
            driver.FindElement(By.Name("butSubmit")).Click();
        }

        public void MediumSpend()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            driver.FindElement(By.Name("txtAuthoriser")).Clear();
            driver.FindElement(By.Name("txtAuthoriser")).SendKeys("MEDIUMSPEND");
            driver.FindElement(By.Name("chkMandatory")).Click();
            driver.FindElement(By.Name("txtSequence")).SendKeys("30");
            driver.FindElement(By.Name("butSubmit")).Click();
        }

        public void LargeSpend()
        {
            Thread.Sleep(200);
            driver.FindElement(By.Name("butAddNewAppr")).Click();
            driver.FindElement(By.Name("txtAuthoriser")).Clear();
            driver.FindElement(By.Name("txtAuthoriser")).SendKeys("LARGESPEND");
            driver.FindElement(By.Name("chkMandatory")).Click();
            driver.FindElement(By.Name("txtSequence")).SendKeys("30");
            driver.FindElement(By.Name("butSubmit")).Click();
        }
       

    }
}
