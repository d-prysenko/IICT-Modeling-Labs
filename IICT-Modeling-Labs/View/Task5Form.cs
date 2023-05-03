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
    public partial class Task5Form : Form
    {
        private const int SAMPLES_COUNT = 20;

        public Task5Form()
        {
            InitializeComponent();
        }

        private void Task5Form_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[] x = randomGenerator.GetDoublesRange(0, 1, SAMPLES_COUNT);
            double[] y = randomGenerator.GetDoublesRange(0, 1, SAMPLES_COUNT);

            SetupTableHeader();

            FillTableRow(1, x, EventA);
            FillTableRow(2, y, EventB);

            double aProbability = MathStat.EventProbability(x, EventA);
            double bProbability = MathStat.EventProbability(y, EventB);

            double c1Probability = SecondaryEventProbability(x, y, EventC1);
            double c2Probability = SecondaryEventProbability(x, y, EventC2);
            double c3Probability = SecondaryEventProbability(x, y, EventC3);
            double c4Probability = SecondaryEventProbability(x, y, EventC4);

            double c1TheorProbability = aProbability * bProbability;
            double c2TheorProbability = (1.0 - aProbability) * bProbability;
            double c3TheorProbability = aProbability * (1.0 - bProbability);
            double c4TheorProbability = (1.0 - aProbability) * (1.0 - bProbability);

            tableOfNumbers.FillCell(SAMPLES_COUNT, 1, aProbability);
            tableOfNumbers.FillCell(SAMPLES_COUNT + 1, 2, bProbability);

            secondaryEventProbTable.FillCell(0, 1, c1Probability);
            secondaryEventProbTable.FillCell(1, 1, c2Probability);
            secondaryEventProbTable.FillCell(2, 1, c3Probability);
            secondaryEventProbTable.FillCell(3, 1, c4Probability);

            secondaryEventProbTable.FillCell(0, 2, c1TheorProbability);
            secondaryEventProbTable.FillCell(1, 2, c2TheorProbability);
            secondaryEventProbTable.FillCell(2, 2, c3TheorProbability);
            secondaryEventProbTable.FillCell(3, 2, c4TheorProbability);
        }

        private void SetupTableHeader()
        {
            for (int i = 0; i < SAMPLES_COUNT; i++)
            {
                tableOfNumbers.FillCell(i, 0, i + 1);
            }

            tableOfNumbers.FillCell(SAMPLES_COUNT, 0, "P'");
            tableOfNumbers.FillCell(SAMPLES_COUNT + 1, 0, "P''");
            
            for (int i = 0; i < 4; i++)
            {
                secondaryEventProbTable.FillCell(i, 0, i+1);
            }

        }

        private double SecondaryEventProbability(double[] x, double[] y, Func<double, double, bool> eventFunc)
        {
            int mi = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (eventFunc(x[i], y[i]))
                {
                    mi++;
                }
            }

            return (double)mi / x.Length;
        }

        private void FillTableRow(int row, double[] doubles, Func<double, bool> eventFunc)
        {
            for (int i = 0; i < SAMPLES_COUNT; i++)
            {
                string text = doubles[i].ToString("F2");

                if (eventFunc(doubles[i]))
                {
                    text += "+";
                }

                tableOfNumbers.FillCell(i, row, text);
            }
        }

        private static bool EventA(double x)
        {
            return x >= 0.3;
        }

        private static bool EventB(double y)
        {
            return y <= 0.7;
        }

        private static bool EventC1(double x, double y)
        {
            return EventA(x) && EventB(y);
        }

        private static bool EventC2(double x, double y)
        {
            return !EventA(x) && EventB(y);
        }

        private static bool EventC3(double x, double y)
        {
            return EventA(x) && !EventB(y);
        }

        private static bool EventC4(double x, double y)
        {
            return !EventA(x) && !EventB(y);
        }
    }
}
