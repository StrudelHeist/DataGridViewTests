using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expanding_View_Tests
{
    public partial class NodeView : UserControl
    {
        private List<PictureBox> _nodePics;

        public NodeView()
        {
            InitializeComponent();

            _nodePics = new List<PictureBox>();
        }

        public void AddNodes()
        {
            for (int i = 0; i < 20; i++)
            {
                PictureBox box = new PictureBox();
                _nodePics.Add(box);
            }
        }
    }
}
