using System;

namespace Voltsoft.QuadraticEquationSolver
{
    internal static class OneRoot
    {
        internal static Solution Solution(double coefficientA, double coefficientB, double discriminant)
        {
            double root = ((-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA));

            return new Solution
            {
                FirstRoot = root,
                SecondRoot = null,
                FirstComplexRoot = null,
                SecondComplexRoot = null
            };
        }
    }
}
