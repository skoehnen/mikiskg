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
            this.id = new ItemId(id);
            String typ = id.GetType().ToString();
            
            switch(typ){
                case "Microsoft.WindowsMobile.PocketOutlook.Contact":
                    Contact kontakt = new Contact(this.id);
                    this.name = kontakt.LastName;
                    this.typ = "Kontakt";
                    break;
                case "Microsoft.WindowsMobile.PocketOutlook.Appointment":
                    Appointment termin = new Appointment(this.id);
                    this.name = termin.Subject;
                    this.typ = "Termin";
                    break;
                case "Microsoft.WindowsMobile.PocketOutlook.Task":
                    Task aufgabe = new Task(this.id);
                    this.name = aufgabe.Subject;
                    this.typ = "Task";
                    break;
            }
                            
        }
        
        public string Name // this will be displayed in the column Header in the DataGrid 
        {
            get
            {
                return this.name;
            }
            set
            {
            }
        }

        public string Typ
        {
            get
            {
                return this.typ;
            }
            set { }
        }


        //... Rest of properties
        } 

    }
