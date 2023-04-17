п»їusing IICT_Modeling_Labs.Service;

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
                tableOfNumbers.FillCell(i, 0, i.ToString());
            }
        }

        private void FillTable(double[] doubles)
        {
            for (int i = 0; i < doubles.Length; i++)
            {
                string val = doubles[i].ToString("F2");

                tableOfNumbers.FillCell(i, 1, val);

                string res = EventModel(doubles[i]) ? "+" : "-";

                tableOfNumbers.FillCell(i, 2, res);
            }
        }

        private static bool EventModel(double x)
        {
            return x <= 0.5;
        }
    }
}
