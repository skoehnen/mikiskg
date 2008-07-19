using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    class LinkInfo
    {
        ItemId id = null;
        private String name;
        private String typ;

        public LinkInfo(int id)
        {
            //Das ist so ziemlich die unsauberste Lösung die es gibt, aber die beste die wir haben
            this.id = new ItemId(id);
            
            Contact kontakt = null;
            try
            {
                kontakt = new Contact(this.id);
                this.name = kontakt.LastName;
                this.typ = "Kontakt";
            }
            catch (Exception) { }
            
            Appointment termin = null;
            try
            {
                termin = new Appointment(this.id);
                this.name = termin.Subject;
                this.typ = "Termin";
            }
            catch (Exception) { }

            Task aufgabe = null;
            try
            {
                aufgabe = new Task(this.id);
                this.name = aufgabe.Subject;
                this.typ = "Task";
            }
            catch (Exception) { }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set { }
        }

        public string Typ
        {
            get
            {
                return this.typ;
            }
            set { }
        }

        public String ItemId
        {
            get
            {
                return this.id.ToString();
            }
            set { }
        } 
    }    
}
