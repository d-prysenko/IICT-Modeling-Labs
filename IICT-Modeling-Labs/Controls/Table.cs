п»їusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IICT_Modeling_Labs.Components
{
    public partial class Table : TableLayoutPanel
    {
        public Table()
        {
            InitializeComponent();
        }

        public void FillCell(int col, int row, double val)
        {
            FillCell(col, row, val.ToString("F2"));
        }

        public void FillCell(int col, int row, int val)
        {
            FillCell(col, row, val.ToString());
        }

        public void FillCell(int col, int row, string val)
        {
            Label text = new Label();
            text.Text = val;

            Controls.Add(text, col, row);
        }
    }
}
