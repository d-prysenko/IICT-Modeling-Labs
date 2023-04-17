п»їnamespace IICT_Modeling_Labs.Service
{
    internal class MathStat
    {
        public static double[] ArrayMean(double[][] numbers)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = Mean(numbers[i]);
            }

            return res;
        }

        public static double Mean(double[] numbers)
        {
            return numbers.Average();
        }

        public static double[] ArrayDispersion(double[][] numbers, double[] mean)
        {
            double[] res = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                res[i] = Dispersion(numbers[i], mean[i]);
            }

            return res;
        }

        public static double Dispersion(double[] numbers, double mean)
        {
            double res = 0;

            foreach (double n in numbers)
            {
                res += (n - mean) * (n - mean);
            }

            return res / numbers.Length;
        }

        public static double EventProbability(double[] numbers, Func<double, bool> eventModel)
        {
            int mi = 0;

            foreach (double n in numbers)
            {
                if (eventModel(n))
                {
                    mi++;
                }
            }

            return (double) mi / numbers.Length;
        }

        public static double[] ArrayEventProbabilityInGroup(double[] r)
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
