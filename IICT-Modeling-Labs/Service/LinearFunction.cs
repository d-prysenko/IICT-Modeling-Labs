namespace IICT_Modeling_Labs.Service
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
}
