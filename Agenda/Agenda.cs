using System;
using System.Collections.Generic;

namespace Agenda
{
    public class Agenda
    {
        private string userName;
        public List<Contact> contactsList = new List<Contact>();
        public Agenda()
        {
        }

        public void SetUserName(string newUserName)
        {
            userName = newUserName;
        }

        public void ShowContacts()           
        {
            int indexContacts;
            for (indexContacts = 0; indexContacts < contactsList.Count; indexContacts++ )
            {
                Console.WriteLine("\n{0}."+ contactsList[indexContacts], indexContacts+1);               
            }
        }
        public void AddNewContact(string newNameContact, int newTelfNumber)
        {
            contactsList.Add(new Contact(newNameContact, newTelfNumber));
        }

        public void DeleteContact(int pos)
        {
            contactsList.RemoveAt(pos);
        }

        public void DeleteContactByIndexOne(int pos)
        {
            contactsList.RemoveAt(pos-1);
        }

        public void EditContact(int pos, string dataUpdate, string newValue)
        {
            contactsList[pos].ModifyContact(dataUpdate, newValue);
        }

    }
}
