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

        public void addAppointment(string title, string location, string startTime, DateTime startDate, string endTime, DateTime endDate){
            Appointment appointment = new Appointment();
            appointment.Start = Convert.ToDateTime(startDate);
            appointment.End = Convert.ToDateTime(endTime);
            // Uhrzeit läuft noch nicht ganz koorekt
            appointment.Start.AddHours(Convert.ToDouble(startTime[0] + startTime[1]));
            appointment.Start.AddMinutes(Convert.ToDouble(startTime[3] + startTime[4]));
            appointment.End.AddHours(Convert.ToDouble(endTime[0] + endTime[1]));
            appointment.End.AddMinutes(Convert.ToDouble(endTime[3] + endTime[4]));
            appointment.Location = location;
            appointment.Subject = title;
            mySession.Appointments.Items.Add(appointment);
        }

        public OutlookSession getOutlookSession()
        {
            return mySession;
        }
    }
}
