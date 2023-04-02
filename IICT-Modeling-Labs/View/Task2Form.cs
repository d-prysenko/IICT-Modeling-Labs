п»їusing IICT_Modeling_Labs.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IICT_Modeling_Labs.View
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void Task2Form_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[] sample1 = randomGenerator.GetDoublesRange(0, 1, 20);

            SetupTableHeader();

            FillTable(sample1);
        }

        private void SetupTableHeader()
        {
            for (int i = 0; i < tableOfNumbers.ColumnCount; i++)
            {
                Label text = new Label();
                text.Text = i.ToString();

                tableOfNumbers.Controls.Add(text, i, 0);
            }
        }

        private void FillTable(double[] doubles)
        {
            for (int i = 0; i < doubles.Length; i++)
            {
                Label text = new Label();
                text.Text = doubles[i].ToString("F2");

                tableOfNumbers.Controls.Add(text, i, 1);

                Label res = new Label();
                res.Text = EventModel(doubles[i]) ? "+" : "-";

                tableOfNumbers.Controls.Add(res, i, 2);
            }
        }

        private static bool EventModel(double x)
        {
            return x <= 0.5;
        }
    }
}
