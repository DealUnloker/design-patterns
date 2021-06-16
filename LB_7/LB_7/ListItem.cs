using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public class ListItem : IComparable
    {
        public string Text { get; set; }

        #region IComparable Members

        int IComparable.CompareTo(object obj)
        {
            ListItem otherObj = obj as ListItem;
            if (otherObj == null) { return -1; }

            return this.Text.CompareTo(otherObj.Text);
        }
        #endregion
        public static void Print(IEnumerable<ListItem> items)
        {
            foreach (ListItem currentItem in items)
            {
                Console.WriteLine(currentItem.Text);
            }
        }

        public static void Execute()
        {
            var docItems = new List<ListItem>();
            docItems.Add(new ListItem() { Text = "1"});
            docItems.Add(new ListItem() { Text = "2"});
            docItems.Add(new ListItem() { Text = "3"});

            Print(docItems);

            var docItems2 = new SortedSet<ListItem>();
            docItems2.Add(new ListItem() { Text = "3"});
            docItems2.Add(new ListItem() { Text = "1"});
            docItems2.Add(new ListItem() { Text = "2"});

            Print(docItems2);
        }

    }

}
