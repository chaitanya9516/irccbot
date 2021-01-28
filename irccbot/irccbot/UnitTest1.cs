using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;  

namespace irccbot
{
    public class Tests
    {
        
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
           
            driver = new ChromeDriver();
           
        }

        [Test]
        public void Test1()
        {
            //goto provided url
            driver.Navigate().GoToUrl("https://www.canada.ca/en/immigration-refugees-citizenship/services/application/account.html");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            //capturing the element to variable
            IWebElement ele = driver.FindElement(By.XPath("/html/body/main/div[1]/div[7]/div[1]/div[1]/section/div/p[2]/a"));
            ele.Click();
            Thread.Sleep(5000);
            IWebElement ele2 = driver.FindElement(By.Name("token1"));            
            ele2.SendKeys("Chaitanyacegep");
            Thread.Sleep(2000);
            IWebElement ele3 = driver.FindElement(By.Name("token2"));
            ele3.SendKeys("Access13*");
            Thread.Sleep(3000);
            IWebElement ele4 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[2]/div/div/div/div/div/div[2]/div[2]/form/div[3]/div/button"));
            ele4.Click();
            Thread.Sleep(5000);
            IWebElement ele5 = driver.FindElement(By.Id("continue"));
            ele5.Click();
            Thread.Sleep(6000);
            IWebElement ele6 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/form/div/input[1]"));
            ele6.Click();
            Thread.Sleep(6000);
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/main/form/div[1]/label/strong[1]"));           
            String text = element.Text;
            if (text == "\"favorite color\"")
            {
                IWebElement ele7 = driver.FindElement(By.Name("answer"));
                ele7.SendKeys("red");
            }
            else if (text == "\"favorite person\"")
            {
                IWebElement ele7 = driver.FindElement(By.Name("answer"));
                ele7.SendKeys("mother");
            }
            else if (text == "\"favorite pet\"")
            {
                IWebElement ele7 = driver.FindElement(By.Name("answer"));
                ele7.SendKeys("tommy");
            }
            else
            {
                IWebElement ele7 = driver.FindElement(By.Name("answer"));
                ele7.SendKeys("jan");
            }
            IWebElement ele8 = driver.FindElement(By.Name("_continue"));
            ele8.Click();
            IWebElement ele9 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[1]/div/table/tbody/tr/td[7]/form/div/input[5]"));
            ele9.Click();
            IWebElement ele10 = driver.FindElement(By.XPath("/html/body/div[1]/main/div[5]/div[2]/div[2]/div[2]/div[2]/div[2]/div[1]/ul"));
            String text1 = ele10.Text;
            if (text1 == "Your application is in progress. We will send you a message once the final decision has been made.")
            {
                IWebElement ele11 = driver.FindElement(By.XPath("/html/body/div[1]/header/section/div/div/div/a[4]"));
                ele11.Click();
                Thread.Sleep(9000);
                IWebElement ele12 = driver.FindElement(By.Name("_continue"));
                ele12.Submit();
            }


        }

        [TearDown]
        public void EndTest()
        {
              
           driver.Close();
        }
    }
}