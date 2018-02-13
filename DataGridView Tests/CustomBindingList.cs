using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Tests
{
    public class CustomBindingList<T> : BindingList<T>
    {
        protected override bool SupportsSortingCore { get { return true; } }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var sortedList = new ArrayList();
            Type interfaceType = prop.PropertyType.GetInterface("IComparable");
            if (interfaceType != null)
            {
                // Sort the list
                List<T> unsortedItems = Items as List<T>;
                unsortedItems.Sort();

                // Update the list
                for (int i = 0; i < Count; i++)
                    this[i] = unsortedItems[i];

                // Trigger the event
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            else
                throw new NotSupportedException("Can't sort by " + prop.Name + ". This "
                    + prop.PropertyType.ToString() + " doesn't implement IComparable");
        }
    }
}
