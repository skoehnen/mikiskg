using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    public partial class Kontakte : Form
    {
        DataTable table;
        DataColumn column;
        DataRow row;

        public Kontakte()
        {
            InitializeComponent();
            ContactCollection collection;
            collection = new OutlookCommunication().getOutlookSession().Contacts.Items;

            table = new DataTable("Kontakte");
            this.createTable();
            foreach (PimItem item in collection)
            {
                row = table.NewRow();
                row["Vorname"] = item.Properties[ContactProperty.FirstName];
                row["Nachname"] = item.Properties[ContactProperty.LastName];
                row["Telefon"] = item.Properties[ContactProperty.HomeTelephoneNumber];
                row["eMail"] = item.Properties[ContactProperty.Email1Address];
                row["ItemId"] = item.ItemId.ToString();
                table.Rows.Add(row);
            }

            // Create new Table Style
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "Kontakte";
            dataGridKontakte.TableStyles.Clear();
            dataGridKontakte.TableStyles.Add(ts);

            dataGridKontakte.DataSource = table;
            
            // Spaltenbreite anpassen
            
            //for (int i = 0; i < table.Columns.Count; i++)
            //{
            //    fitColumnWidth(table.TableName, table.Columns[i].ColumnName);
            //}

            dataGridKontakte.TableStyles["Kontakte"].GridColumnStyles["Vorname"].Width = 70;
            dataGridKontakte.TableStyles["Kontakte"].GridColumnStyles["Nachname"].Width = 70;
            dataGridKontakte.TableStyles["Kontakte"].GridColumnStyles["Telefon"].Width = 50;
            dataGridKontakte.TableStyles["Kontakte"].GridColumnStyles["Nachname"].Width = 70;

            dataGridKontakte.Update();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            new Kontakt().Show();
        }

        private void dataGridKontakte_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridKontakte.CurrentRowIndex;
            int columnIndex = 4;
            object oid = dataGridKontakte[rowIndex, columnIndex];
            Dispose();
            new Kontakt(MikiConverter.objectToItemId(oid)).Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                int index = dataGridKontakte.CurrentRowIndex;
                OutlookCommunication outlookCom = new OutlookCommunication();
                object Id = dataGridKontakte[index, 4]; // weil in Spalte 4 die ID des Kontakts steht
                outlookCom.deleteContact(MikiConverter.objectToItemId(Id));
                Dispose();
                new Kontakte().Show();
            }
        }

       /// <summary>
        /// CreateTable() formatiert die Ergebnistabelle
        /// </summary>
        private void createTable()
        {
            // 1. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Vorname";
            
            table.Columns.Add(column);

            // 2. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nachname";
            table.Columns.Add(column);

            // 3. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Telefon";
            table.Columns.Add(column);

            // 4. Spalte
            // benötigt um den Type mitzuübergeben
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            table.Columns.Add(column);

            // 5. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ItemId";
            table.Columns.Add(column);
        }

        /// <summary>
        /// passt die Spaltenbreite einer Tabelle automatisch an
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="tabName"></param>
        /// <param name="colName"></param>
        private void fitColumnWidth(string tabName, string colName)
        {
            int newwidth = LongestField(tabName, colName);

            // Create new Table Style
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "Kontakte";
            dataGridKontakte.TableStyles.Clear();
            dataGridKontakte.TableStyles.Add(ts);

            // Assign New Width to DataGrid column
            this.dataGridKontakte.TableStyles[tabName].GridColumnStyles[colName].Width = newwidth;
        }

        /// <summary>
        /// LongestField() sucht nach dem längsten Eintrag einer Spalte
        /// und gibt die länge +1 als integer zurück
        /// 
        /// !!! der DataGrid Name muss hier bei Wiederverwendung angepasst werden!!!
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="TableName"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        private int LongestField(string TableName, string ColumnName)
        {
            int maxlength = 0;
            int tot = this.table.Rows.Count;// ds.Tables[TableName].Rows.Count;
            string straux = "";
            int intaux = 0;

            Graphics g = dataGridKontakte.CreateGraphics();

            // Take width one balnk space to add to the new width to the Column   
            int offset = Convert.ToInt32(Math.Ceiling(g.MeasureString(" ", dataGridKontakte.Font).Width));

            for (int i = 0; i < tot; ++i)
            {
                straux = this.table.Rows[i][ColumnName].ToString(); //ds.Tables[TableName].Rows[i][ColumnName].ToString();

                // Get the width of Current Field String according to the Font
                intaux = Convert.ToInt32(Math.Ceiling(g.MeasureString(straux, dataGridKontakte.Font).Width));
                if (intaux > maxlength)
                {
                    maxlength = intaux;
                }
            }// End of For Loop

            return maxlength + offset;
        }

        /// <summary>
        /// TestButton für die Spaltenbreiten-Anpassung ruft eben diese Funktion auf
        /// 
        /// Quelle: http://support.microsoft.com/kb/812422/de
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemFitColumnWidth_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < table.Columns.Count; i++)
            {
                fitColumnWidth(table.TableName, table.Columns[i].ColumnName);
            }
            this.dataGridKontakte.DataSource = table;
            dataGridKontakte.Show();
        }
    }
}