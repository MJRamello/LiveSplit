using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit
{
    public static class BindingListExtensions
    {
        #region Public Methods

        public static BindingList<T> ClearAndAddRange<T>(this BindingList<T> list, IEnumerable<T> items)
        {
            list.Clear();
            foreach (var item in items)
            {
                list.Add(item);
            }

            return list;
        }

        #endregion Public Methods
    }
}