using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    class LinkInfo
    {
        ItemId id = null;

        public LinkInfo(int id)
        {
            this.id = new ItemId(id);
        }
        
        public string Name // this will be displayed in the column Header in the DataGrid 
        {
            get
            {
                return this.id.ToString(); // this will be displayed in the data field of the DataGrid 
            }
            set
            {
            }
        }

        //... Rest of properties
        } 

    }
