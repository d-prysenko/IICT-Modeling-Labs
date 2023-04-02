п»їusing IICT_Modeling_Labs.Service;

namespace IICT_Modeling_Labs
{
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void Task1Form_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[] sample1 = randomGenerator.GetDoublesRange(0, 1, 10);

            FillTableRow(0, sample1);

            double[] sample2 = randomGenerator.GetDoublesRange(2, 5, 15);

            FillTableRow(1, sample2);

            double[] sample3 = randomGenerator.GetDoublesRange(-1, 1, 20);

            FillTableRow(2, sample3);
        }

        private void FillTableRow(int row, double[] doubles)
        {
            for (int i = 0; i < doubles.Length; i++)
            {
                Label text = new Label();
                text.Text = doubles[i].ToString("F2");

                tableOfNumbers.Controls.Add(text, i, row);
            }
        }
    }
}
