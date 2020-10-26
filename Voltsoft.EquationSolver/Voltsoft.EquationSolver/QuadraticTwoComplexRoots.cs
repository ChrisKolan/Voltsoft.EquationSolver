using System;
using System.Collections.Generic;
using System.Text;

namespace Voltsoft.EquationSolver
{
    internal static class QuadraticTwoComplexRoots
    {
        internal static QuadraticSolution Solution(double coefficientA, double coefficientB, double coefficientC, double discriminant)
        {
            var real = -coefficientB / (2 * coefficientA);
            var imaginary = (Math.Sqrt(4 * coefficientA * coefficientC - coefficientB * coefficientB)) / (2 * coefficientA);

            return new QuadraticSolution
            {
                FirstRoot = null,
                SecondRoot = null,
                FirstComplexRoot = new System.Numerics.Complex(real, imaginary),
                SecondComplexRoot = new System.Numerics.Complex(real, -imaginary)
            };
        }
    }
}
