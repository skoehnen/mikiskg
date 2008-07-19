using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrototypMIS
{
    public class MikiTreeNode : TreeNode
    {
        /// <summary>
        /// Konstruktor zum einfachen erstellen von TreeNodes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        public MikiTreeNode(int id, String text, String typ)
        {
            this.Text = text;
            this.Tag = new MikiDuo(id, typ);
        }
    }

    public class MikiDuo
    {
        public int id;
        public String typ;

        public MikiDuo(int id, String typ)
        {
            this.id = id;
            this.typ = typ;
        }
    }
}
