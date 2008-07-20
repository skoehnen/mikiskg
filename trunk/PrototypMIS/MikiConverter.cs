using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    /// <summary>
    /// Klasse mit static-Methoden die wir zum Umwandeln verschiedener Formate brauchen
    /// </summary>
    class MikiConverter
    {

        /// <summary>
        /// Wandelt Objekte in ItemId-Objekte um
        /// </summary>
        /// <param name="id">Object das umgewandelt werden soll</param>
        /// <returns>ItemId die aus Object erzeugt wurde</returns>
        public static ItemId objectToItemId(Object id)
        {
            return new ItemId(Convert.ToInt32(id.ToString()));
        }
        
        /// <summary>
        /// Erzeugt aus DateTime-Objekten einen String mit der Zeit
        /// </summary>
        /// <param name="date">DateTime-Objekt aus dem die Zeit geholt werden soll</param>
        /// <returns>String der die Zeit aus dem DateTime-Objekt repräsentiert</returns>
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

        /// <summary>
        /// Wandel ItemId in int-Zahl um
        /// </summary>
        /// <param name="id">ItemId die umgewandelt werden soll</param>
        /// <returns>int-Zahl die ItemId repräsentiert</returns>
        public static int itemIdToInt(ItemId id)
        {
            return Convert.ToInt32(id.ToString());
        }

        public static int stringToMikiObjectTyp(String typ)
        {
            switch (typ)
            {
                case "Aufgabe":
                    return Konstanten.aufgabe;

                case "Foto":
                    return Konstanten.foto;

                case "Kontakt":
                    return Konstanten.kontakt;

                case "Kunde":
                    return Konstanten.kunde;

                case "Notiz":
                    return Konstanten.notiz;

                case "Termin":
                    return Konstanten.termin;
            }
            return -1;
        }

        public static String mikiObjectToString(int typ)
        {
            switch (typ)
            {
                case Konstanten.aufgabe:
                    return "Aufgabe";

                case Konstanten.foto:
                    return "Foto";

                case Konstanten.kontakt:
                    return "Kontakt";

                case Konstanten.kunde:
                    return "Kunde";

                case Konstanten.notiz:
                    return "Notiz";

                case Konstanten.termin:
                    return "Termin";
            }
            return "FEHLER";
        }
    }
}
