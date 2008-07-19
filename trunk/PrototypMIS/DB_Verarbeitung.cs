using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Microsoft.WindowsMobile.PocketOutlook;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace PrototypMIS
{
    class DB_Verarbeitung
    {
        private SqlCeConnection DBVerbindung()
        {
            SqlCeConnection conn = new SqlCeConnection("Data Source = " + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\AppDatabase1.sdf");
            return conn;
        }

        public void verknuepfung_eintragen(int quellID, int zielID, bool typ)
        {
            //Der typ gibt an ob es ein Objekt aus Pocket Outlook ist oder nicht
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "Insert into Verknüpfung (ItemID_Quelle,ItemID_Senke,MikiObject) VALUES ('" + quellID + "','" + zielID + "'," + "0" +")";
            sqlcommand.ExecuteNonQuery();
            sqlcommand.CommandText = "Insert into Verknüpfung (ItemID_Quelle,ItemID_Senke,MikiObject) VALUES ('" + zielID + "','" + quellID + "'," + "0" + ")";
            sqlcommand.ExecuteNonQuery();
            conn.Close();
        }

        public void einzelverknuepfung_loeschen(int quelle, int ziel, bool typ)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "DELETE FROM Verknüpfung WHERE ItemID_Quelle = '" + quelle + "' AND ItemId_Senke = '" + ziel + "' AND MikiObject = " + "0";
            sqlcommand.ExecuteNonQuery();
            sqlcommand.CommandText = "DELETE FROM Verknüpfung WHERE ItemID_Quelle = '" + ziel + "' AND ItemId_Senke = '" + quelle + "' AND MikiObject = " + "0";
            sqlcommand.ExecuteNonQuery();
            conn.Close();

        }

        public void gesamtverknuepfung_loeschen(int quelle, bool typ)
        {
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "DELETE FROM Verknüpfung WHERE ItemID_Quelle = '" + quelle + "' AND MikiObject = " + "0";
            sqlcommand.ExecuteNonQuery();
            conn.Close();
        }

        public ArrayList abfrage(int quelle)
        {
            ArrayList liste = new ArrayList();
            SqlCeConnection conn = DBVerbindung();
            conn.Open();
            SqlCeCommand sqlcommand = conn.CreateCommand();
            sqlcommand.CommandText = "SELECT * FROM Verknüpfung WHERE ItemID_Quelle = '" + quelle + "'";
            SqlCeDataReader ResultSet;
            ResultSet = sqlcommand.ExecuteReader();
            int i ;
            while (ResultSet.Read())
            {
                i = (int)  ResultSet["ItemID_Senke"];
                liste.Add(new LinkInfo(i));
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
            conn.Open();
            SqlCeCommand command2 = conn.CreateCommand();
            command2.CommandText = "SELECT id FROM Fotos WHERE titel = '" + titel + "';";

            SqlCeDataReader ResultSet = command2.ExecuteReader();

            int id = 0;

            while (ResultSet.Read())
            {
                id = (int)ResultSet["id"];
            }

            command.CommandText = "INSERT INTO uniqueIdentity (objectId, objectTyp) VALUES (" + id + ", " + Konstanten.foto + ");";
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

        public void fotoLoeschen(String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command1 = conn.CreateCommand();
            command1.CommandText = "SELECT pfad, id FROM Fotos WHERE titel = '" + titel + "'";

            SqlCeDataReader rs = command1.ExecuteReader();
            
            String pfad = "";
            int id = 0;

            while (rs.Read())
            {
                pfad = rs["pfad"].ToString();
                id = (int)rs["id"];
            }
            SqlCeCommand command = new SqlCeCommand();
            command.CommandText = "DELETE FROM Fotos WHERE id = " + id + ";";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM uniqueIdentity WHERE id = " + id + " AND objectTyp = " + Konstanten.foto + ";";
            command.ExecuteNonQuery();
            File.Delete(pfad);
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
            catch (Exception)
            {
                MessageBox.Show("Titel bereits vergeben");
            }
            conn.Close();
        }

        public void notizSpeichern(NotizInfo notiz)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO Notizen (text, titel) VALUES ('" + notiz.getText() + "', '" + notiz.getTitel() + "')";
           
            command.ExecuteNonQuery();

            command.CommandText = "SELECT id FROM Notizen WHERE titel = '" + notiz.getTitel() + "'";

            SqlCeDataReader ResultSet = command.ExecuteReader();

            int id = 0;

            while (ResultSet.Read())
            {
                id = (int)ResultSet["id"];
            }

            command.CommandText = "INSERT INTO uniqueIdentity (objectId, objectTyp) VALUES (" + id + ", " + Konstanten.notiz + ");";
            command.ExecuteNonQuery();

            
            conn.Close();
        }

        public NotizInfo notizHolen(int id)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT titel, text FROM notizen WHERE id = " + id;

            String text = null;
            String titel = null;

            SqlCeDataReader ResultSet = command.ExecuteReader();

            while (ResultSet.Read())
            {
                text = ResultSet["text"].ToString();
                titel = ResultSet["titel"].ToString();
            }

            conn.Close();

            return new NotizInfo(titel, text, id);
        }

        /// <summary>
        /// Soll die ID und den Titel aus einem DB_Verarbeitung Objekt auslesen
        /// und als Dataset zurückgeben.
        /// 
        /// Als Einlesemöglichkeit für das DataGrid der Notizen gedacht
        /// </summary>
        /// <returns></returns>
        public System.Data.DataSet notizIdUndTitelAuslesen()
        {
            SqlCeConnection conn = this.DBVerbindung();

            SqlCeCommand selectCmd = conn.CreateCommand();
            selectCmd.CommandText = "SELECT titel, id FROM Notizen";

            SqlCeDataAdapter adp = new SqlCeDataAdapter(selectCmd);

            System.Data.DataSet ds = new System.Data.DataSet();

            adp.Fill(ds);

            conn.Close();

            return ds;
        }

        public int notizAnzahl()
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT count(*) FROM Notizen";

            int count = 0;

            SqlCeDataReader ResultSet = command.ExecuteReader();

            while (ResultSet.Read())
            {
                count = (int) ResultSet[0];
            }

            conn.Close();

            return count;
        }

        public System.Data.DataSet notizListe()
        {
            SqlCeConnection conn = this.DBVerbindung();

            SqlCeCommand selectCmd = conn.CreateCommand();
            selectCmd.CommandText = "SELECT titel FROM Notizen";

            SqlCeDataAdapter adp = new SqlCeDataAdapter(selectCmd);

            System.Data.DataSet ds = new System.Data.DataSet();

            adp.Fill(ds);

            conn.Close();

            return ds;
        }

        public System.Data.DataSet notizSuche(String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();

            SqlCeCommand selectCmd = conn.CreateCommand();
            selectCmd.CommandText = "SELECT titel, id FROM Notizen Where titel = '" + titel + "'";

            SqlCeDataAdapter adp = new SqlCeDataAdapter(selectCmd);

            System.Data.DataSet ds = new System.Data.DataSet();

            adp.Fill(ds);

            conn.Close();

            return ds;
        }

        public NotizInfo notizHolenTitel(String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT titel, text FROM notizen WHERE titel = '" + titel + "'";

            String text = null;
            titel = null;

            SqlCeDataReader ResultSet = command.ExecuteReader();

            while (ResultSet.Read())
            {
                text = ResultSet["text"].ToString();
                titel = ResultSet["titel"].ToString();
            }

            conn.Close();

            return new NotizInfo(titel, text);
        }

        public void notizLoeschenTitel(String titel)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();

            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id FROM Notizen WHERE titel = '" + titel + "'";

            SqlCeDataReader ResultSet = command.ExecuteReader();

            int id = 0;

            while (ResultSet.Read())
            {
                id = (int)ResultSet["id"];
            }

            
            command.CommandText = "DELETE FROM Notizen WHERE id = " + id + "";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM uniqueIdentity WHERE objectId = " + id + " AND objectTyp = " + Konstanten.notiz + ";";
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void notizUpdateTitel(String titel, NotizInfo notiz)
        {
            SqlCeConnection conn = this.DBVerbindung();
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE Notizen SET titel = '" + notiz.getTitel() + "', text = '" + notiz.getText() + "' WHERE titel = '" + titel + "'";

            command.ExecuteNonQuery();

            conn.Close();
        }

    }

    class Konstanten
    {
        public static int foto = 0;
        public static int notiz = 1;
    }
}
