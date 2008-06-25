using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PrototypMIS
{
    public class FotoInfo
    {
        String titel;
        String pfad;
        String beschreibung;
        int id;

        public FotoInfo(String titel, String pfad, String beschreibung, int id)
        {
            this.id = id;
            this.titel = titel;
            this.pfad = pfad;
            this.beschreibung = beschreibung;
        }

        public String getTitel()
        {
            return titel;
        }

        public String getPfad()
        {
            return pfad;
        }

        public int getId()
        {
            return id;
        }

        public String getBeschreibung()
        {
            return beschreibung;
        }
    }
}
