using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class SingleItem
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemAuthor { get; set; }
        public bool itemStatus { get; set; }

        public SingleItem(int itID, string itName, string itAuthor, bool itStatus) {
            itemID = itID;
            itemName = itName;
            itemAuthor = itAuthor;
            itemStatus = itStatus;
        }


    }
}
