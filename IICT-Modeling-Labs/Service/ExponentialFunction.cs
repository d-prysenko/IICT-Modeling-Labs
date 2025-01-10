namespace IICT_Modeling_Labs.Service
{
    /**
        b * (basement)^(a * x) 
    */
    public class ExponentialFunction
    {
        public double a { get; set; }
        public double b { get; set; }
        public double basement { get; set; }

        public ExponentialFunction()
        {
            this.basement = Math.E;
            this.a = 1;
            this.b = 1;
        }

        /// <summary>
        /// b * (basement)^(a * x)
        /// </summary>
        public ExponentialFunction(double a, double b, double basement = Math.E)
        {
            this.basement = basement;
            this.a = a;
            this.b = b;
        }

        public double call(double x)
        {
            return b * Math.Pow(basement, a * x);
        }

        /**
            b * (basement)^(a * x) 
        */
        public static double call(double x, double a, double b, double basement = Math.E)
        {
            return b * Math.Pow(basement, a * x);
        }
    }
}
