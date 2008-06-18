using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{

    class OutlookCommunication
    {
        private OutlookSession mySession;

        public OutlookCommunication(){
            this.mySession=new OutlookSession();
        }

        public void addTask(string title, DateTime date, string text){
            Task task = new Task();
            task.Subject = title;
            task.DueDate = date;
            task.Body = text;
            task.ReminderSet = false; // Erinnerungen aus
            mySession.Tasks.Items.Add(task);
        }

        public void deleteTask()
        {

        }

        public void addContact(string name, string firstName, string phone, string mail)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = name;
            contact.HomeTelephoneNumber = phone;
            contact.Email1Address = mail;
            mySession.Contacts.Items.Add(contact);
        }
    }
}
