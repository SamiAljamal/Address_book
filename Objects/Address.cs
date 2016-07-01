using System;
using System.IO;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _number;
    private static List<Contact> _contactList = new List<Contact> {};


    public Contact (string name, string email, string number)
    {
      _name = name;
      _email = email;
      _number = number;
      _contactList.Add(this);

    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

    public string GetNumber()
    {
      return _number;

    }

    public void SetNumber (string newNumber)
    {
      _number = newNumber;
    }

    public static List<Contact> GetAll()
    {
      return _contactList;
    }


    public static void DeleteAll()
    {
      _contactList.Clear();
    }

  }
}
