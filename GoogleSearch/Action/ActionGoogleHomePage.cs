using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearch.Action
{
    public class ActionGoogleHomePage 
    {
        public GoogleHomePageObjects googleLocator = new GoogleHomePageObjects();

        public void EnterSearchKeyword(String keyword)
        {
            BrowserUtil.driver.FindElement(googleLocator.searchBoxInput).SendKeys(keyword);
        }

        public void PerformSearch()
        {
            Actions btnclick = new Actions(BrowserUtil.driver);
            btnclick.SendKeys(Keys.Enter).Build().Perform();
        }

        public int GetLinkCount()
        {
            return BrowserUtil.driver.FindElements(googleLocator.linkText).Count();
        }

        public string GetLinkTextAtPosition(int index)
        {
            if (GetLinkCount() > (index - 1))
            {
                return BrowserUtil.driver.FindElements(googleLocator.linkText)[index - 1].Text;
            }
            else
                return "No link at " +index + " found.";
        }
    }
}
