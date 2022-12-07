using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject6
{
    internal class PlanetPage
    {
        private WebDriver driver;

        public PlanetPage(WebDriver driver)
        {
            this.driver = driver;
        }

     

        internal void ExplorePlanet(string planetname)
        {
           
            foreach (var item in driver.FindElements(By.ClassName("planet"))) 
            {
               

                if(item.FindElement(By.ClassName("name")).Text.ToLower()==planetname.ToLower()) 
                {
                    PlanetTile tile = new PlanetTile(item);
                    tile.checknameandClick(item);

                  
                }
            }



               
               
            }

        internal static string PopupMsgMethodForPage(WebDriver driver,string planetname)
        {
            foreach (var item in driver.FindElements(By.ClassName("planet")))
            {
                if (item.FindElement(By.ClassName("name")).Text.ToLower() == planetname.ToLower())
                {
                    PlanetTile tile = new PlanetTile(item);
                    string text = tile.popupmsgmethod(driver);
                    return text;
                }
              
            }

            throw new Exception();
        }
    }
}
