using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    internal class ListViewItemComparer : IComparer<ListViewItem>
    {
        private Func<ListViewItem, ListViewItem, int> m_Strategy;

        public ListViewItemComparer(Func<ListViewItem, ListViewItem, int> i_Strategy)
        {
            m_Strategy = i_Strategy;
        }

        public int Compare(ListViewItem i_First, ListViewItem i_Second)
        {
            return m_Strategy(i_First, i_Second);
        }
    }
}
