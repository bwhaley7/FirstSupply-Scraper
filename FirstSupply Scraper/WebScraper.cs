using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstSupply_Scraper
{
    internal class WebScraper
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Braden\source\repos\FirstSupply Scraper\FirstSupply Scraper\bin\Debug\net6.0 - windows");
        IList<IWebElement> crumbs;
        public void Navigate(string model, Product prod)
        {
            if (model != null)
            {
                if (model.Contains("-"))
                {
                    string temp = model.Replace("-", String.Empty);
                    driver.Navigate().GoToUrl(String.Format("https://www.firstsupply.com/Product/AAE{0}", temp));
                }
                else
                    driver.Navigate().GoToUrl(String.Format("https://www.firstsupply.com/Product/AAE{0}", model));
            }
        }

        public bool getBreadcrumbs(Product prod)
        {
            crumbs = null;
            Thread.Sleep(2000);
            crumbs = driver.FindElements(By.XPath("//a[@ng-if='crumb.url']"));
            if (crumbs != null || crumbs.Count >= 1)
            {
                log("Gathered crumbs for product: " + prod.prodNum + ". Crumbs found where: " + showCrumbs());
                return true;
            }
            else
            {
                log("No crumbs found for product: " + prod.prodNum + ".");
                return false;
            }
        }

        public void assignCategories(Product prod)
        {
            for(int i = 0; i < crumbs.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        prod.cat1 = crumbs[i].Text;
                        break;
                    case 2:
                        prod.cat2 = crumbs[i].Text;
                        break;
                    case 3:
                        prod.cat3 = crumbs[i].Text;
                        break;
                    case 4:
                        prod.cat4 = crumbs[i].Text;
                        break;
                    case 5:
                        prod.cat5 = crumbs[i].Text;
                        break;
                    default:
                        break;
                }
            }
        }

        private void log(string text)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\FirstSupplyScraper\log.txt", true))
            {
                writer.WriteLine(text);
            }
        }

        public string showCrumbs()
        {
            var crumb = "";
            foreach(IWebElement c in crumbs)
            {
                crumb += c.GetAttribute("innerHTML") + " ";
            }
            return crumb;
        }
    }
}
