using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Microsoft.WindowsMobile.PocketOutlook;
using System.IO;
using System.Windows.Forms;

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

        public bool fotoEinfuegen(String pfad, String beschreibung, String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Fotos (pfad, beschreibung, titel) VALUES ('" + pfad + "', '" + beschreibung + "', '" + titel + "')";
            command.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public int fotoIDholen(string titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id FROM Fotos WHERE titel = '" + titel + "'";
            command.ExecuteNonQuery();

            SqlCeDataReader ResultSet = command.ExecuteReader();

            int i = -1;

            while (ResultSet.Read())
            {
                i = (int)ResultSet["id"];
            }

            conn.Close();

            return i;
        }

        public FotoInfo fotoHolen(String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id, beschreibung, pfad, titel FROM Fotos WHERE titel = '" + titel + "'";
            command.ExecuteNonQuery();

            SqlCeDataReader ResultSet = command.ExecuteReader();

            int id = -1;
            String beschreibung = "";
            String pfad = "";

            while (ResultSet.Read())
            {
                id = (int)ResultSet["id"];
                beschreibung = ResultSet["beschreibung"].ToString();
                pfad = ResultSet["pfad"].ToString();
            }

            conn.Close();

            return new FotoInfo(titel, pfad, beschreibung, id);
        }

        public void fotoLoeschen(FotoInfo foto)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM Fotos WHERE id = '" + foto.getId() + "'";
            command.ExecuteNonQuery();
            File.Delete(foto.getPfad());
            conn.Close();
        }

        public void fotoAendern(FotoInfo foto)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Fotos SET titel = '" + foto.getTitel() + "', beschreibung = '" + foto.getBeschreibung() + "' WHERE id = " + foto.getId();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Titel bereits vergeben");
            }
            conn.Close();
        }
    }
}
