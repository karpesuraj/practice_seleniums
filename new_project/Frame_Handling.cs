using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project
{
    internal class Frame_Handling
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://netbanking.hdfcbank.com/netbanking/");
            Thread.Sleep(3000);
            Driver.SwitchTo().Frame(0);
            Driver.FindElement(By.XPath("//*[@id=\"pageBody\"]/div[1]/form/div[3]/div/div/div[2]/div[2]/div[1]/div[2]/input")).SendKeys("1245");
            Driver.FindElement(By.XPath("//*[@id=\"pageBody\"]/div[1]/form/div[3]/div/div/div[2]/div[2]/div[2]/div[2]/a")).Click();
            Thread.Sleep(9000);
            Driver.Quit();
        }
     
    }
}
