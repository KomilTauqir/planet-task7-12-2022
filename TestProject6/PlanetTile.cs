using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject6
{
    internal class PlanetTile
    {
        public PlanetTile(IWebElement planetname)
        {
        }

        internal void checknameandClick(IWebElement item)
        {
            item.FindElement(By.TagName("button")).Click();
            Thread.Sleep(1000);
            return;

        }
        internal string popupmsgmethod(WebDriver driver)
        {
            var popup = driver.FindElement(By.ClassName("mr-auto"));
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => popup.Displayed);
            return popup.Text;
        }
    }
}