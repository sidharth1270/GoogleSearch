using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearch.Action
{
    public class GoogleHomePageObjects
    {
        public By searchBoxInput = By.XPath("//input[@name='q']");

        public By linkText = By.CssSelector("div.rc > h3 > a");
    }
}
