using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookAppFirstStage
{
    internal class ListViewItemComparerDescending : IComparer<ListViewItem>
    {
        public int Compare(ListViewItem i_First, ListViewItem i_Second)
        {
            string firstText = i_First.SubItems[1].Text;
            string secondText = i_Second.SubItems[1].Text;
            double firstPercent = double.Parse(firstText.Substring(0, firstText.Length - 1));
            double secondPercent = double.Parse(secondText.Substring(0, secondText.Length - 1));

            return -1 * firstPercent.CompareTo(secondPercent);
        }
    }
}
