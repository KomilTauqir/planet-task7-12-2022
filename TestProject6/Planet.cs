using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject6
{
    internal class Planet
    {
        private WebDriver driver;

        public Planet(WebDriver driver)
        {
            this.driver = driver;
        }

     

        internal void ExplorePlanet(string planetname)
        {
           
            foreach (var item in driver.FindElements(By.ClassName("planet"))) 
            {
                var planettile = new PlanetTile(planetname);
                planettile.checknameandClick(planetname);

                if(item.FindElement(By.ClassName("name")).Text.ToLower()==planetname.ToLower()) 
                {
                    item.FindElement(By.TagName("button")).Click();
                    Thread.Sleep(1000);
                    return;
                }
            }



               
               
            }

        internal string popupmsgmethod()
        {
            var popup = driver.FindElement(By.ClassName("mr-auto"));
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => popup.Displayed);
            return popup.Text;  
        }
    }
    }
