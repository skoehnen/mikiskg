using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    class DB_Verarbeitung
    {
        private SqlCeConnection DBVerbindung()
        {
            SqlCeConnection conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\AppDatabase1.sdf");
            return conn;
        }

        public void verknuepfung_eintragen(ItemId QuellID, ItemId ZielID)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            int quelle = int.Parse(QuellID.ToString());
            int ziel = int.Parse(ZielID.ToString());
            sqlcommand.CommandText = "Insert into Verknüpfung (ItemID_Quelle,ItemID_Senke) VALUES ('" + quelle + "','" + ziel+ "')";
            sqlcommand.ExecuteNonQuery();
            conn.Close();
        }

        public void einzelverknuepfung_loeschen(ItemId Quelle, ItemId Ziel)
        {
            int quelle = int.Parse(Quelle.ToString());
            int ziel = int.Parse(Ziel.ToString());
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Delete from Verknüpfung where ItemID_Quelle = '" + quelle + "' AND ItemId_Senke = '" + ziel + "'" ;
            sqlcommand.ExecuteNonQuery();
            conn.Close();

        }

        public void gesamtverknuepfung_loeschen(ItemId Quelle)
        {
            SqlCeConnection conn = DBVerbindung();
            int quelle = int.Parse(Quelle.ToString());
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Delete from Verknüpfung where ItemID_Quelle = '" + quelle + "'";
            sqlcommand.ExecuteNonQuery();
            conn.Close();
        }

        public LinkedList<ItemId> abfrage(ItemId Quelle)
        {
            LinkedList<ItemId> liste = new LinkedList<ItemId>();
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "SELECT * from Verknüpfung where ItemID_Quelle = '" + Quelle + "'";
            SqlCeDataReader ResultSet;
            ResultSet = sqlcommand.ExecuteReader();
            int i ;
            while (ResultSet.Read())
            {
                i = (int)  ResultSet["ItemID_Senke"];
                liste.AddLast(new ItemId(i));
            }
            conn.Close();
            return liste;
        }
    }
}
