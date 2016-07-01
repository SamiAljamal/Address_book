using System;
using System.IO;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private int _number;
    private static List<Contact> _contactList = new List<Contact> {};
    private int _id;


    public Contact (string name, string email, int number)
    {
      _name = name;
      _email = email;
      _number = number;
      _contactList.Add(this);
      _id = _carList.Count;

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

    public int GetNumber()
    {
      return _number;

    }

    public void SetNumber (int newNumber)
    {
      _number = newNumber;
    }

    public static List<Contact> Getall()
    {
      return _contactList;
    }

    public void Save()
    {
      _contactList.Add(this);
    }

    public static void ClearAll()
    {
      _contactList.Clear();
    }

    public int GetId()
    {
      return_id;
    }

    public static Car Find (int id)
    {
      return _contactList[id -1];
    }
  }
}
