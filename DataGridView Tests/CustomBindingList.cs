using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Tests
{
    public class CustomBindingList : BindingList<CustomObject>
    {
        protected override bool SupportsSortingCore { get { return true; } }
        protected override bool SupportsSearchingCore { get { return true; } }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var sortedList = new ArrayList();
            Type interfaceType = prop.PropertyType.GetInterface("IComparable");
            if (interfaceType != null)
            {
                // Sort the list
                List<CustomObject> unsortedItems = Items as List<CustomObject>;
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
