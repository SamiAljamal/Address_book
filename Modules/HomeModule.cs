using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule ()
    {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };

      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts_created.cshtml", allContacts];
      };

    }
  }
}
