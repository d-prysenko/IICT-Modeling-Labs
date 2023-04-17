п»їusing IICT_Modeling_Labs.Service;

namespace IICT_Modeling_Labs.View
{
    public partial class Task3Form : Form
    {
        private const int ARRAYS_COUNT = 6;
        private const int SAMPLES_COUNT = 10;

        public Task3Form()
        {
            InitializeComponent();
        }

        private void Task3Form_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[][] samples = new double[ARRAYS_COUNT][];

            for (int i = 0; i < ARRAYS_COUNT; i++)
            {
                samples[i] = randomGenerator.GetDoublesRange(0, 1, SAMPLES_COUNT);
            }

            double[] mean = MathStat.ArrayMean(samples);

            double[] dispersion = MathStat.ArrayDispersion(samples, mean);

            double[] r = ArrayEventProbability(samples);

            SetupTableHeader();

            for (int i = 0; i < ARRAYS_COUNT;i++)
            {
                int row = i + 1;

                FillTableRow(row, samples[i]);
                tableOfNumbers.FillCell(SAMPLES_COUNT, row, mean[i]);
                tableOfNumbers.FillCell(SAMPLES_COUNT + 1, row, dispersion[i]);
                tableOfNumbers.FillCell(SAMPLES_COUNT + 2, row, r[i]);
            }
        }

        private void SetupTableHeader()
        {
            for (int i = 0; i < SAMPLES_COUNT; i++)
            {
                tableOfNumbers.FillCell(i, 0, i + 1);
            }

            tableOfNumbers.FillCell(SAMPLES_COUNT, 0, "m");
            tableOfNumbers.FillCell(SAMPLES_COUNT + 1, 0, "D");
            tableOfNumbers.FillCell(SAMPLES_COUNT + 2, 0, "R");
        }

        private void FillTableRow(int row, double[] doubles)
        {
            for (int i = 0; i < doubles.Length; i++)
            {
                string text = doubles[i].ToString("F2");

                if (A(doubles[i], row - 1))
                {
                    text += "*";
                }

                tableOfNumbers.FillCell(i, row, text);
            }
        }

        public static double[] ArrayEventProbability(double[][] numbers)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = MathStat.EventProbability(numbers[i], (double x) => A(x, i));
            }

            return res;
        }

        private static bool A(double x, int i)
        {
            return x <= (0.1 * i);
        }
    }
}
