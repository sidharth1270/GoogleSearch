using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GoogleSearch
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            BrowserUtil.LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BrowserUtil.CloseBrowser();
        }
    }
}
