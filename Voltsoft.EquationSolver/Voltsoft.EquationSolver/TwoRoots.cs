using System;

namespace Voltsoft.QuadraticEquationSolver
{
    internal class TwoRoots
    {
        internal static Solution Solution(double coefficientA, double coefficientB, double discriminant)
        {
            var firstRoot = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            var secondRoot = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);

            return new Solution
            {
                FirstRoot = firstRoot,
                SecondRoot = secondRoot,
                FirstComplexRoot = null,
                SecondComplexRoot = null
            };
        }
    }
}
