using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("tr.entry"));
            foreach (IWebElement element in elements)
            {
                contacts.Add(new ContactData(element.Text));
            }

            return contacts;
        }

        internal ContactHelper RemoveContact()
        {
            manager.Navigator.GoToHomePage();
            Remove();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            InitContactModificator();
            FillContactForm(newData);
            SubmitContactModification();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper CreateContact(ContactData contactData)
        {
            manager.Navigator.GoToHomePage();
            InitNewContactCreation();
            FillContactForm(contactData);
            SubmitCreation();
            manager.Navigator.GoToHomePage();
            return this;
        }

        public ContactHelper IsContactExist()
        {
            if (! IsElementPresent(By.XPath("//img[@alt='Edit']")))
            {
                ContactData defaultData = new ContactData("autocreated 1");
                defaultData.Middlename = "autocreated 2";
                defaultData.Lastname = "autocreated 3";
                defaultData.Nickname = "autocreated 4";
                defaultData.Title = "autocreated 5";
                defaultData.Company = "autocreated 6";
                defaultData.Address = "autocreated 7";
                defaultData.Home = "autocreated 8";
                defaultData.Mobile = "autocreated 9";
                defaultData.Work = "autocreated 10";
                defaultData.Fax = "autocreated 11";
                defaultData.Email = "autocreated 12";
                defaultData.Email2 = "autocreated 13";
                defaultData.Email3 = "autocreated 14";
                defaultData.Homepage = "autocreated 15";
                defaultData.BYear = "autocreated 16";
                defaultData.AYear = "autocreated 17";
                defaultData.Address2 = "autocreated 18";
                defaultData.Phone2 = "autocreated 19";
                defaultData.Notes = "autocreated 20";

                CreateContact(defaultData);
            }
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname); //1
            Type(By.Name("middlename"), contact.Lastname);//2
            Type(By.Name("lastname"), contact.Middlename);//3
            Type(By.Name("nickname"), contact.Nickname);//4
            Type(By.Name("title"), contact.Title);//5
            Type(By.Name("company"), contact.Company);//6
            Type(By.Name("address"), contact.Address);//7
            Type(By.Name("home"), contact.Home);//8
            Type(By.Name("mobile"), contact.Mobile);//9
            Type(By.Name("work"),contact.Work);//10
            Type(By.Name("fax"),contact.Fax);//11
            Type(By.Name("email"), contact.Email);//12
            Type(By.Name("email2"), contact.Email2);//13
            Type(By.Name("email3"), contact.Email3);//14
            Type(By.Name("homepage"), contact.Homepage);//15
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            Type(By.Name("byear"), contact.BYear);//16
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("January");
            Type(By.Name("ayear"), contact.AYear);//17
            Type(By.Name("address2"), contact.Address2);//18
            Type(By.Name("phone2"), contact.Phone2);//19
            Type(By.Name("notes"), contact.Notes);//20
            return this;
        }

        /*public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("//input[@id='" + index + "']")).Click();
            return this;
        }*/

        public ContactHelper InitContactModificator()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click(); // Mark
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }
        public ContactHelper SubmitCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper Remove()
        {
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
