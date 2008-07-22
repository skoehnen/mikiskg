using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    class LinkInfo
    {
        int id = -1;
        private String name;
        private int typ;

        public LinkInfo(int id, int typ)
        {
            this.id = id;
            this.typ = typ;

            switch (typ)
            {
                case Konstanten.aufgabe:
                    Task aufgabe = new Task(new ItemId(id));
                    this.name = aufgabe.Subject;
                    break;

                case Konstanten.foto:
                    FotoInfo foto = new DB_Verarbeitung().fotoHolen(id);
                    this.name = foto.getTitel();
                    break;

                case Konstanten.kontakt:
                    Contact kontakt = new Contact(new ItemId(id));
                    this.name = kontakt.LastName + ", " + kontakt.FirstName;
                    break;

                case Konstanten.kunde:
                    System.Data.DataTable table = new DB_Verarbeitung().kunde_suchen(id.ToString(), false);
                    //this.name = table.Rows[3].ToString();
                    break;

                case Konstanten.notiz:
                    NotizInfo notiz = new DB_Verarbeitung().notizHolen(id);
                    this.name = notiz.getTitel();
                    break;

                case Konstanten.termin:
                    Appointment termin = new Appointment(new ItemId(id));
                    this.name = termin.Subject;
                    break;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set { }
        }

        public String Typ
        {
            get
            {
                return MikiConverter.mikiObjectToString(typ);
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
