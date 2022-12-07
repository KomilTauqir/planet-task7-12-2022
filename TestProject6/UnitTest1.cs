using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace TestProject6
{
    [TestClass]
    public class UnitTest1
    {
       
        private WebDriver driver = new ChromeDriver();
        [TestInitialize]
        public void Initialize()
        {
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";
        
        }
        [TestMethod]
        public void explore_planet()
        {
            new Toolbar(driver).ClickPlanetsButton();

            var planet = new Planet(driver);
            planet.ExplorePlanet("Earth");
            String popupmsgtext = planet.popupmsgmethod();
            Assert.AreEqual(expected: "Exploring Earth", actual: popupmsgtext);
        }
        [TestMethod]
        public void entername_clicksubmit()
        {

            new Toolbar(driver).ClickFormButton();

            var form = new Form(driver);

            form.SetName("Komil");
            form.SetEmail("komiltauqir@gmail.com");
            form.ClickAgree();
            form.ClickState();
            form.SelectState();
            form.ClickSubmit();


           // driver.FindElement(By.CssSelector("[aria-label=forms].v-btn")).Click();
           // driver.FindElement(By.Id("name")).SendKeys("komil");
           // driver.FindElement(By.Id("email")).SendKeys("komil@gmail.com");
           // driver.FindElement(By.CssSelector("[for=agree]")).Click();
            
           // driver.FindElement(By.CssSelector("[aria-haspopup=listbox]")).Click();
     
           // driver.FindElement(By.CssSelector("state")).Click();
           // System.Threading.Thread.Sleep(1000);
           // driver.FindElement(By.Id("list-item-451-2")).Click();
          
          //  driver.FindElement(By.XPath("//*[text()='QLD']")).Click();
           // driver.FindElement(By.XPath("//*[contains(text(),'submit')]")).Click();
            
         


        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

 
    }

}