using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDSpecflowproject
{
    public class Browserinitial
    {
        
        static IWebDriver? driver;
        public Browserinitial(string browsername)
        {
            switch(browsername)
            {
                case "Chrome":
                   driver = new ChromeDriver();
                    break;
                default:
                    driver = new FirefoxDriver();
                    break;
            }


        }

        internal static IWebDriver GetDriverInstance()
        {
            if (driver != null)
                return driver;
            else
            {
                return null;
                Console.WriteLine("pleaase initialise the driver");
            }
        }
    }
}
