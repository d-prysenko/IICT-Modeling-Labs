using IICT_Modeling_Labs.Service;

namespace IICT_Modeling_Labs
{
    public partial class MainForm : Form
    {
        private const int SAMPLES_COUNT = 100;
        private const int INTERVAL_BEGIN = 5;
        private const int INTERVAL_END = 6;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[] doubles = randomGenerator.GetDoublesRange(INTERVAL_BEGIN, INTERVAL_END, SAMPLES_COUNT);

            double pAccum = 0.0;

            double[] x = new double[10];
            double[] p = new double[10];
            double[] pSum = new double[10];

            for (int i = 0; i < 10; i++)
            {
                double begin = INTERVAL_BEGIN + (INTERVAL_END - INTERVAL_BEGIN) * i / 10.0;
                double end = INTERVAL_BEGIN + (INTERVAL_END - INTERVAL_BEGIN) * (i+1) / 10.0;
                double middle = (end + begin) / 2.0;

                x[i] = middle;
                tableOfNumbers.FillCell(i, 0, x[i]);

                int numbersCount = GetCountInInterval(doubles, begin, end);
                p[i] = (double)numbersCount / SAMPLES_COUNT;
                pAccum += p[i];
                pSum[i] = pAccum;
                double pUniformDistrib = GetProbabilityUniformDistribution(INTERVAL_BEGIN, INTERVAL_END, middle);

                tableOfNumbers.FillCell(i, 1, numbersCount);
                tableOfNumbers.FillCell(i, 2, p[i]);
                tableOfNumbers.FillCell(i, 3, pSum[i]);
                tableOfNumbers.FillCell(i, 4, pUniformDistrib);
            }

            double mean = MathStat.Mean(doubles);
            double dispersion = MathStat.Dispersion(doubles, mean);
            double variationCoeff = MathStat.VariationCoefficient(doubles, mean, dispersion);

            mxLabel.Text += mean.ToString("F2");
            dxLabel.Text += dispersion.ToString("F2");
            yxLabel.Text += variationCoeff.ToString("F2");

            formsPlot1.Plot.AddScatter(x, p, label: "плотность распределения");
            formsPlot1.Plot.AddScatter(x, pSum, label: "функция распределения");
            formsPlot1.Plot.Legend();
            formsPlot1.Refresh();
        }

        private int GetCountInInterval(double[] numbers, double begin, double end)
        {
            int count = 0;

            foreach (double number in numbers)
            {
                if (number >= begin && number < end)
                {
                    count++;
                }
            }

            return count;
        }

        private double GetProbabilityUniformDistribution(double begin, double end, double u)
        {
            if (u < begin) return 0;
            if (u >= end) return 1;

            return (u - begin) / (end - begin);
        }

    }
}