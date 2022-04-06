namespace Calculation.API.Services
{
    public class Calculation : ICalculation
    {
        public long Add(long value1, long value2)
        {
            return value1 + value2;
        }
    }
}
