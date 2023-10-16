using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;
        private IMessageChannel messageChannel;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();

            this.messageChannel = new WhatsAppChannel();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void AddContact(Contact contact)
        {
            //Contact contact = new Contact(name, phone, email);
            persons.Add(contact);
        }

        public void DeleteContact(Contact contact)
        {
            persons.Remove(contact);
        }

        public Contact GetContact(string contactName)
        {
            foreach (Contact contact in persons)
            {
                if (contact.Name == contactName)
                {
                    return contact;
                }
            }
            return null;
        }

        public void SendMessage(Contact from, Contact to, string text)
        {
            Message message = messageChannel.CreateMessage(from, to, text);
            messageChannel.Send(message);
        }
    }
}