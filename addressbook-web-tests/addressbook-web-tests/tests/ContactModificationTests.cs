using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("11");
            newData.Middlename = "21";
            newData.Lastname = "31";
            newData.Nickname = "41";
            newData.Title = "51";
            newData.Company = "61";
            newData.Address = "71";
            newData.Home = "81";
            newData.Mobile = "91";
            newData.Work = "101";
            newData.Fax = "111";
            newData.Email = "121";
            newData.Email2 = "131";
            newData.Email3 = "141";
            newData.Homepage = "151";
            newData.BYear = "161";
            newData.AYear = "171";
            newData.Address2 = "181";
            newData.Phone2 = "191";
            newData.Notes = "201";

            app.Contact.Modify(newData);
        }
    }
}
