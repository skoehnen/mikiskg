using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    class MikiConverter
    {
        public static ItemId objectToItemId(Object id)
        {
            return new ItemId(Convert.ToInt32(id.ToString()));
        }
        
        public static String zeitAusDateTime(DateTime date)
        {
            int h = date.Hour;
            int m = date.Minute;

            String hour;
            String minute;

            if (h < 10)
            {
                hour = "0" + h.ToString();
            }
            else
            {
                hour = h.ToString();
            }

            if (m < 10)
            {
                minute = "0" + m.ToString();
            }
            else
            {
                minute = m.ToString();
            }

            return hour + ":" + minute;
        }

        public static String amToPM(int h)
        {
            return null;
        }
    }
}
