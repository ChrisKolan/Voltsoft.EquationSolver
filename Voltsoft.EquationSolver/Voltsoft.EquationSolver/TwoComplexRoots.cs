using System;

namespace Voltsoft.QuadraticEquationSolver
{
    internal static class TwoComplexRoots
    {
        internal static Solution Solution(double coefficientA, double coefficientB, double coefficientC, double discriminant)
        {
            var real = -coefficientB / (2 * coefficientA);
            var imaginary = (Math.Sqrt(4 * coefficientA * coefficientC - coefficientB * coefficientB)) / (2 * coefficientA);

            return new Solution
            {
                FirstRoot = null,
                SecondRoot = null,
                FirstComplexRoot = new System.Numerics.Complex(real, imaginary),
                SecondComplexRoot = new System.Numerics.Complex(real, -imaginary)
            };
        }
    }
}
