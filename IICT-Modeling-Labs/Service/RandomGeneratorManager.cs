п»ї
namespace IICT_Modeling_Labs.Service
{
    internal class RandomGeneratorManager
    {
        readonly Random rand = new Random();

        public double GetDoubleRange(double intervalBegin, double intervalEnd)
        {
            return intervalBegin + rand.NextDouble() * Math.Abs(intervalEnd - intervalBegin);
        }

        public double[] GetDoublesRange(double intervalBegin, double intervalEnd, int count)
        {
            double[] result = new double[count];

            for (int i = 0; i < count; ++i)
            {
                result[i] = GetDoubleRange(intervalBegin, intervalEnd);
            }

            return result;
        }
    }
}
