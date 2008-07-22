using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PrototypMIS
{
    public class NotizInfo
    {
        int id;
        String titel;
        String text;

        public NotizInfo(String titel, String text)
        {
            this.titel = titel;
            this.text = text;
            DB_Verarbeitung db = new DB_Verarbeitung();
            NotizInfo notiz = db.notizHolenTitel(titel);
            this.id = notiz.id;
        }

        public NotizInfo(String titel, String text, int id)
        {
            this.id = id;
            this.titel = titel;
            this.text = text;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getText()
        {
            return this.text;
        }

        public String getTitel()
        {
            return this.titel;
        }

        public int getId()
        {
            return this.id;
        }
    }
}
