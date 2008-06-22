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
    }
}
