using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;
using System.Diagnostics;

namespace PrototypMIS
{
    /// <summary>
    /// Die Klasse OutlookCommunication dient als Schnittstelle für die
    /// Kommunikation mit Outlook.
    /// 
    /// <methods>
    /// </methods>
    /// </summary>
    
    class OutlookCommunication
    {
        private OutlookSession mySession;

        public OutlookCommunication(){
            this.mySession=new OutlookSession();
        }

/// <summary>
/// Methoden für Tasks
/// </summary>

        public void addTask(string title, DateTime date, string text){
            Task task = new Task();
            task.Subject = title;
            task.DueDate = date;
            task.Body = text;
            task.ReminderSet = false; // Erinnerungen aus
            mySession.Tasks.Items.Add(task);
        }

        public void deleteTask(ItemId id)
        {
            Task task = new Task(id);
            task.Delete();
        }
/// <summary>
/// Ende Methoden für Tasks
/// </summary>

/// <summary>
/// Methoden für Kontakte
/// </summary>
        public void addContact(string name, string firstName, string phone, string mail)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = name;
            contact.HomeTelephoneNumber = phone;
            contact.Email1Address = mail;
            mySession.Contacts.Items.Add(contact);
        }

        public void deleteContact(ItemId id)
        {
            Contact contact = new Contact(id);
            contact.Delete();
        }
/// <summary>
/// Ende Methoden für Kontakte
/// </summary>

/// <summary>
/// Methoden für Termine
/// </summary>
        public void addAppointment(string title, string location, string startTime, DateTime startDate, string endTime, DateTime endDate){
            Appointment appointment = new Appointment();
            appointment.Start = Convert.ToDateTime(startDate);
            appointment.End = Convert.ToDateTime(endTime);
                        
            // 
            appointment.Start = datumZusammenbasteln(startTime, startDate);
            appointment.End=datumZusammenbasteln(endTime,endDate);

            appointment.Location = location;
            appointment.Subject = title;
            appointment.ReminderSet = false;
            mySession.Appointments.Items.Add(appointment);
        }

        public void deleteAppointment(ItemId id)
        {
            Appointment appointment = new Appointment(id);
            appointment.Delete();
        }
/// <summary>
/// Ende Methoden für Termine
/// </summary>


        public OutlookSession getOutlookSession()
        {
            return mySession;
        }

        public DateTime datumZusammenbasteln(string Time, DateTime startDate)
        {
            // Zeiten in int Werte umwandeln:
            int hour = Convert.ToInt32(Time[0].ToString() + Time[1].ToString());
            int minutes = Convert.ToInt32(Time[3].ToString() + Time[4].ToString());
            
            // neues DateTime Objekt zurückgeben:
            return new DateTime(startDate.Year, startDate.Month, startDate.Day, hour, minutes, 0);
        }
    }
}
