using System.Numerics;
namespace Calculation.API.Services
{
    public interface ICalculation
    {
        public BigInteger Add(BigInteger value1, BigInteger value2);
    }
}
