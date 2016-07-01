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
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View ["contacts_form.cshtml"];
      };
      Post["/contacts/created"] = _ => {
        string name = Request.Form["name"];
        string email = Request.Form ["email"];
        string number = Request.Form ["number"];
        Contact newContact = new Contact(name,email,number);
        List<Contact> allContacts = Contact.GetAll();
        return View["/contacts_created.cshtml", newContact];
      };

      Post["/contacts/deleted"] =_ => {
        Contact.DeleteAll();
        return View["contacts_deleted.cshtml"];

      };


    }
  }
}
