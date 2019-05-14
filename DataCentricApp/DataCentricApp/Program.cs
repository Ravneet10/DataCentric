using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCentricApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://apply.dataprocessors.com.au/");
            driver.FindElement(By.Name("jobref")).SendKeys("PO162");
            int unFilled = driver.FindElements(By.XPath("//img[contains(@src, 'unfilledO.gif')]")).Count();
            int imageCount = driver.FindElements(By.TagName("img")).Count();
            int FilledImages = imageCount - unFilled;
            driver.FindElement(By.Name("valuee")).SendKeys(FilledImages.ToString());
            driver.FindElement(By.XPath("//input[@type='Submit']")).Submit();


        }
    }
}
