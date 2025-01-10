using IICT_Modeling_Labs.Service;

namespace IICT_Modeling_Labs
{
    public class LinearFunction
    {
        public double a { get; set; }
        public double b { get; set; }

        public LinearFunction()
        {
            this.a = 1;
            this.b = 0;
        }

        public LinearFunction(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double call(double x)
        {
            return a * x + b;
        }

        public static double call(double x, double a, double b)
        {
            return a * x + b;
        }
    }

    public partial class MainForm : Form
    {
        private const int SAMPLES_COUNT = 10;
        private const double INTERVAL_BEGIN = -1;
        private const double INTERVAL_END = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RandomGeneratorManager randomGenerator = new RandomGeneratorManager();

            double[] noise = randomGenerator.GetDoublesRange(INTERVAL_BEGIN, INTERVAL_END, SAMPLES_COUNT);

            const double initial_a = 2;
            const double initial_b = 5;

            LinearFunction y = new LinearFunction(initial_a, initial_b);

            double deltaX = 1.0 / SAMPLES_COUNT;

            double[] x_coords = new double[SAMPLES_COUNT];
            double[] y_coords = new double[SAMPLES_COUNT];

            double current_x_coord = 0.0;

            FillTableHeader();

            for (int i = 0; i < SAMPLES_COUNT; i++, current_x_coord += deltaX)
            {
                x_coords[i] = current_x_coord;
                y_coords[i] = y.call(current_x_coord) + noise[i];

                tableOfNumbers.FillCell(1, i + 1, x_coords[i]);
                tableOfNumbers.FillCell(2, i + 1, y_coords[i]);
                tableOfNumbers.FillCell(3, i + 1, y.call(current_x_coord));
            }

            LinearFunction approximated_y = linearApproximation(x_coords, y_coords, SAMPLES_COUNT);

            a.Text = String.Format("a = {0:f3}", approximated_y.a);
            b.Text = String.Format("b = {0:f3}", approximated_y.b);

            double[] y_approximation_coords = new double[SAMPLES_COUNT];

            for (int i = 0; i < SAMPLES_COUNT; i++, current_x_coord += deltaX)
            {
                y_approximation_coords[i] = approximated_y.call(x_coords[i]);

                tableOfNumbers.FillCell(4, i + 1, y_approximation_coords[i]);
            }

            formsPlot1.Plot.AddScatter(x_coords, y_approximation_coords, label: "y^");
            formsPlot1.Plot.AddScatter(x_coords, y_coords, label: "y");
            formsPlot1.Plot.Legend();
            formsPlot1.Refresh();
        }

        private void FillTableHeader()
        {
            tableOfNumbers.FillCell(0, 0, "N");
            tableOfNumbers.FillCell(1, 0, "xi");
            tableOfNumbers.FillCell(2, 0, "yi");
            tableOfNumbers.FillCell(3, 0, "yi~");
            tableOfNumbers.FillCell(4, 0, "yi^");

            for (int i = 1; i < tableOfNumbers.RowCount; i++)
            {
                tableOfNumbers.FillCell(0, i, i);
            }
        }

        // getting this after solving system dI/da = 0 and dI/db = 0
        private LinearFunction linearApproximation(double[] x, double[] y, int N)
        {
            double t = 0;
            double z = 0;
            double u = 0;
            double v = 0;

            for (int i = 0; i < N; i++)
            {
                t += x[i] * x[i];
                z += x[i];
                u += x[i] * y[i];
                v += y[i];
            }

            double b = _approx_b(N, v, t, z, u);
            double a = _approx_a(b, t, z, u);

            return new LinearFunction(a, b);
        }

        private double _approx_b(double N, double v, double t, double z, double u)
        {
            return ((v * t) - (z * u)) / ((N * t) - (z * z));
        }

        private double _approx_a(double b, double t, double z, double u)
        {
            return (u - (b * z)) / t;
        }
    }
}