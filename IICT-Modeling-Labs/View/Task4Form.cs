п»їusing IICT_Modeling_Labs.Service;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IICT_Modeling_Labs.View
{
    public partial class Task4Form : Form
    {
        private const int SAMPLES_COUNT = 6;

        public Task4Form()
        {
            InitializeComponent();
        }

        private void Task3Form_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[][] samples = new double[SAMPLES_COUNT][];

            for (int i = 0; i < SAMPLES_COUNT; i++)
            {
                samples[i] = randomGenerator.GetDoublesRange(0, 1, 10);
            }

            double[] mean = ArrayMean(samples);

            double[] dispersion = ArrayDispersion(samples, mean);

            double[] r = ArrayR(samples);

            double[] p = ArrayP(r);

            SetupTableHeader();

            for (int i = 0; i < SAMPLES_COUNT;i++)
            {
                int row = i + 1;

                FillTableRow(row, samples[i]);
                FillCell(10, row, mean[i]);
                FillCell(11, row, dispersion[i]);
                FillCell(12, row, r[i]);
                FillCell(13, row, p[i]);
            }

            labelP.Text = "Sum(P) = " + p.Sum();
        }
        private void SetupTableHeader()
        {
            for (int i = 0; i < 10; i++)
            {
                FillCell(i, 0, i + 1);
            }

            FillCell(10, 0, "m");
            FillCell(11, 0, "D");
            FillCell(12, 0, "R");
            FillCell(13, 0, "P");
        }

        private void FillCell(int col, int row, double val)
        {
            FillCell(col, row, val.ToString("F2"));
        }

        private void FillCell(int col, int row, int val)
        {
            FillCell(col, row, val.ToString());
        }

        private void FillCell(int col, int row, string val)
        {
            Label text = new Label();
            text.Text = val;

            tableOfNumbers.Controls.Add(text, col, row);
        }

        private void FillTableRow(int row, double[] doubles)
        {
            for (int i = 0; i < doubles.Length; i++)
            {
                Label text = new Label();
                text.Text = doubles[i].ToString("F2");

                if (A(doubles[i], row - 1))
                {
                    text.Text += "*";
                }

                tableOfNumbers.Controls.Add(text, i, row);
            }
        }

        private static double[] ArrayMean(double[][] numbers)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = Mean(numbers[i]);
            }

            return res;
        }

        private static double Mean(double[] numbers)
        {
            return numbers.Average();
        }

        private static double[] ArrayDispersion(double[][] numbers, double[] mean)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = Dispersion(numbers[i], mean[i]);
            }

            return res;
        }

        private static double Dispersion(double[] numbers, double mean)
        {
            double res = 0;

            foreach (double n in numbers)
            {
                res += (n - mean) * (n - mean);
            }

            return res / numbers.Length;
        }

        private static double[] ArrayR(double[][] numbers)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = R(numbers[i], i);
            }

            return res;
        }

        private static double R(double[] numbers, int i)
        {
            int mi = 0;

            foreach (double n in numbers)
            {
                if (A(n, i))
                {
                    mi++;
                }
            }

            return (double) mi / 10.0;
        }

        private static bool A(double x, int i)
        {
            return x <= (0.1 * i);
        }

        private static double[] ArrayP(double[] r)
        {
            double[] res = new double[r.Length];

            double sum = r.Sum();

            for (int i = 0; i < r.Length; i++)
            {
                res[i] = r[i] / sum;
            }

            return res;
        }
    }
}
