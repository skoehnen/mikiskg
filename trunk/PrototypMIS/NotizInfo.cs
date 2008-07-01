using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PrototypMIS
{
    public class NotizInfo
    {
        String titel;
        String text;

        public NotizInfo(String titel, String text)
        {
            this.titel = titel;
            this.text = text;
        }

        public String getText()
        {
            return this.text;
        }

        public String getTitel()
        {
            return this.titel;
        }
    }
}
