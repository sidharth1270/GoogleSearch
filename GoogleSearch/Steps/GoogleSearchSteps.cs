using GoogleSearch.Action;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GoogleSearch.Test.Steps
{
    [Binding]
    public sealed class GoogleSearchSteps
    {
        public ActionGoogleHomePage actionGooglePage = new ActionGoogleHomePage();

        [Given(@"I am on Google homepage")]
        public void GivenIAmOnGoogleHomepage()
        {
            BrowserUtil.OpenUrl("https://google.com");
        }

        [When(@"I enter '(.*)' for search")]
        public void WhenIEnterForSearch(string searchText)
        {
            actionGooglePage.EnterSearchKeyword(searchText);
        }

        [When(@"I perform search")]
        public void WhenIPerformSearch()
        {
            actionGooglePage.PerformSearch();
        }

        [Then(@"I should see (.*) main links populated in the search page")]
        public void ThenIShouldSeeLinksMainPopulatedInTheSearchPage(int expectedLinks)
        {
            int actualLinkCount = actionGooglePage.GetLinkCount();
            Console.WriteLine("Number of links present :" + actualLinkCount);
            Assert.IsTrue(expectedLinks==actualLinkCount);
        }

        [Then(@"I should see and print the link text at (.*)th position")]
        public void ThenIShouldSeeAndPrintTheLinkTextAtThPosition(int index)
        {
            string linkText = actionGooglePage.GetLinkTextAtPosition(index);
            Console.WriteLine(linkText);
        }
    }
}
