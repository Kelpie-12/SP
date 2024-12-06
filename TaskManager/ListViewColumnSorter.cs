using System;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
	internal class ListViewColumnSorter : IComparer
	{
		int columnToSort;
		SortOrder orderSort;
		CaseInsensitiveComparer objectComparer;
		public ListViewColumnSorter()
		{
			columnToSort = 0;
			orderSort = SortOrder.None;
			objectComparer = new CaseInsensitiveComparer();
		}
		public int Compare(object x, object y)
		{
			int compareResult;
			ListViewItem listViewX = (ListViewItem)x;
			ListViewItem listViewY = (ListViewItem)y;
			if (double.TryParse(listViewX.SubItems[columnToSort].Text, out _))
				compareResult = objectComparer.Compare(Convert.ToDouble(listViewX.SubItems[columnToSort].Text), Convert.ToDouble(listViewY.SubItems[columnToSort].Text));
			else
				compareResult = objectComparer.Compare(listViewX.SubItems[columnToSort].Text, listViewY.SubItems[columnToSort].Text);

			if (orderSort == SortOrder.Ascending)
				return compareResult;
			else if (orderSort == SortOrder.Descending)
				return -compareResult;
			else return compareResult;
		}
		public int SortColumn
		{
			set => columnToSort = value;
			get => columnToSort;
		}
		public SortOrder Order
		{
			get => orderSort;
			set => orderSort = value;
		}
	}
}
