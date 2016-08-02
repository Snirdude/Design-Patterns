using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppFirstStage
{
    class ListViewItemComparerDescending : IComparer<ListViewItem>
    {
        public int Compare(ListViewItem x, ListViewItem y)
        {
            string xText = x.SubItems[1].Text;
            string yText = y.SubItems[1].Text;
            double xPercent = double.Parse(xText.Substring(0, xText.Length - 1));
            double yPercent = double.Parse(yText.Substring(0, yText.Length - 1));

            return -1 * xPercent.CompareTo(yPercent);
        }
    }
}
