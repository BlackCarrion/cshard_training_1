using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {    

        [Test]
        public void ContactCreationTest()
        {          
            ContactData contact = new ContactData("1");
            contact.Middlename = "2";
            contact.Lastname = "3";
            contact.Nickname = "4";
            contact.Title = "5";
            contact.Company = "6";
            contact.Address = "7";
            contact.Home = "8";
            contact.Mobile = "9";
            contact.Work = "10";
            contact.Fax = "11";
            contact.Email = "12";
            contact.Email2 = "13";
            contact.Email3 = "14";
            contact.Homepage = "15";
            contact.BYear = "16";
            contact.AYear = "17";
            contact.Address2 = "18";
            contact.Phone2 = "19";
            contact.Notes = "20";
            app.Contact
                .InitNewContactCreation()
                .FillContactForm(contact)
                .SubmitCreation();
            app.Navigator.GoToHomePage();
            app.Auth.Logout();
        }
    }
}
