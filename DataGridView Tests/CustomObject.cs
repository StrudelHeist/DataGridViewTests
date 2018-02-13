using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Tests
{
    public class CustomObject : IComparable
    {
        private string _name;
        private int _value;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CustomObject(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public int CompareTo(object obj)
        {
            // Get other object
            CustomObject other = obj as CustomObject;
            return Name.CompareTo(other.Name);
        }
    }
}
