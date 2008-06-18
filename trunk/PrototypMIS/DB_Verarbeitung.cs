using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace PrototypMIS
{
    class DB_Verarbeitung
    {
        private SqlCeConnection DBVerbindung()
        {
            return conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\AppDatabase1.sdf");
        }

        public Boolean verknuepfung_eintragen(ItemId QuellID, ItemId ZielID)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Insert into Verknüpfung (ItemID_Quelle,ItemID_Senke) VALUES ('" + QuellID + "','" + ZielID + "')";
            sqlcommand.ExecuteNonQuery();
            conn.close();
        }

        public Boolean einzelverknuepfung_loeschen(ItemId Quelle, ItemId Ziel)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Delete from Verknüpfung where ItemID_Quelle = '" + Quelle + "' AND ItemId_Senke = '" + Ziel + "'" ;
            sqlcommand.ExecuteNonQuery();
            conn.close();

        }

        public Boolean gesamtverknuepfung_loeschen(ItemId Quelle, ItemId Ziel)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Delete from Verknüpfung where ItemID_Quelle = '" + Quelle + "'";
            sqlcommand.ExecuteNonQuery();
            conn.close();

        }

        public void abfrage(ItemId Quelle)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "SELECT * from Verknüpfung where ItemID_Quelle = '" + Quelle + "'";
            SqlCeDataReader ResultSet;
            ResultSet = sqlcommand.ExecuteReader;
            
            conn.close();
        }
    }
}
