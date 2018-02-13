using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Tests
{
    public partial class Form1 : Form
    {
        private DataGridView _dataGridView;
        private CustomBindingList<CustomObject> _baseObjects;
        private BindingSource _bindingSource;
        private Random _rand;
        private readonly static string[] NAMES = new string[]{ "Jenny", "Hassid", "Mildred", "James", "Carlos", "Kevin", "Claus" };

        public Form1()
        {
            InitializeComponent();

            // Initialize
            _rand = new Random();
            _bindingSource = new BindingSource();
            _dataGridView = new DataGridView();
            _baseObjects = new CustomBindingList<CustomObject>();

            // Add items to binding source
            _baseObjects.Add(new CustomObject("Mario", 0));
            _baseObjects.Add(new CustomObject("Danny", 1));
            _baseObjects.Add(new CustomObject("Putin", 2));
            _baseObjects.Add(new CustomObject("Alfred", 3));
            foreach (CustomObject obj in _baseObjects)
                _bindingSource.Add(obj);

            // Setup datagrid
            _dataGridView.AutoSize = true;
            _dataGridView.DataSource = _baseObjects;
            _dataGridView.Dock = DockStyle.Fill;
            _dataGridView.CellPainting += OnPaintCell;
            //_dataGridView.AutoGenerateColumns = false;
            //_dataGridView.Columns.Add("Name", "Name");
            _dataGridView.ColumnHeadersVisible = false;
            _dataGridView.RowHeadersVisible = false;
            _dataGridView.BindingContextChanged += OnValidated;

            _tableLayoutPanel.Controls.Add(_dataGridView, 0, 0);
        }

        private void OnValidated(object sender, EventArgs e)
        {
            _dataGridView.Columns[1].Visible = false;
        }

        private void OnDataGridViewSort(object sender, DataGridViewSortCompareEventArgs e)
        {
            // Get the actual objects
            CustomObject obj1 = _bindingSource[e.RowIndex1] as CustomObject;
            CustomObject obj2 = _bindingSource[e.RowIndex2] as CustomObject;
            e.SortResult = obj1.Name.CompareTo(obj2.Name);
            e.Handled = true;
        }

        private void OnPaintCell(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgView = sender as DataGridView;
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (dgView.Columns[e.ColumnIndex].Name != "Name") return;

            // Get value at cell
            CustomObject obj = _baseObjects[e.RowIndex] as CustomObject;
            Rectangle backgroundRect = e.CellBounds;
            backgroundRect.Inflate(1, 1);
            Brush backgroundBrush = new SolidBrush(GetColorFromNumber(obj.Value));
            e.Graphics.FillRectangle(backgroundBrush, backgroundRect);

            backgroundRect.Width = 41;
            backgroundRect.X += 16;
            backgroundRect.Y += 6;
            backgroundRect.Height = 14;
            backgroundBrush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(backgroundBrush, backgroundRect);

            Rectangle r = e.CellBounds;
            r.Width -= 18;
            r.X += 18;
            e.Graphics.DrawString(obj.Name, this.Font, new SolidBrush(Color.Black), r);

            e.Handled = true;
        }

        private Color GetColorFromNumber(int i)
        {
            switch (i)
            {
                case 0:
                    return Color.Blue;
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Purple;
                default:
                    return Color.Orange;
            }
        }

        private void _changeButton_Click(object sender, EventArgs e)
        {
            foreach(CustomObject obj in _baseObjects)
            {
                obj.Name = NAMES[_rand.Next() % NAMES.Length];
            }
            _dataGridView.Refresh();
        }

        private void _sortButton_Click(object sender, EventArgs e)
        {
            _dataGridView.Sort(_dataGridView.Columns[1], ListSortDirection.Ascending);
        }
    }
}
