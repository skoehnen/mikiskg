using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrototypMIS
{
    /// <summary>
    /// Die Klasse secureDelete stellt die Methode boolDelete()
    /// zur Verfügung, die eine MessageBox mit einer Sicherheitsabfrage
    /// ausgibt.
    /// </summary>
    class secureDelete
    {
        /// <summary>
        /// Sicherheitsabfrage vor dem löschen
        /// </summary>
        /// <returns></returns>
        public static Boolean boolDelete()
        {
            return MessageBox.Show("Eintrag endgültig löschen?", "Wirklich?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes;
        }
    }
}
