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
    public class ContactCreationTests : AuthTestBase
    {    

        [Test]
        public void ContactCreationTest()
        {          
            ContactData contactData = new ContactData("1");
            contactData.Middlename = "2";
            contactData.Lastname = "3";
            contactData.Nickname = "4";
            contactData.Title = "5";
            contactData.Company = "6";
            contactData.Address = "7";
            contactData.Home = "8";
            contactData.Mobile = "9";
            contactData.Work = "10";
            contactData.Fax = "11";
            contactData.Email = "12";
            contactData.Email2 = "13";
            contactData.Email3 = "14";
            contactData.Homepage = "15";
            contactData.BYear = "16";
            contactData.AYear = "17";
            contactData.Address2 = "18";
            contactData.Phone2 = "19";
            contactData.Notes = "20";

            app.Contact.CreateContact(contactData);
        }
    }
}
