using System;
using System.Collections.Generic;
using System.Text;

namespace Voltsoft.EquationSolver
{
    internal static class QuadraticOneRoot
    {
        internal static QuadraticSolution Solution(double coefficientA, double coefficientB, double discriminant)
        {
            double root = ((-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA));

            return new QuadraticSolution
            {
                FirstRoot = root,
                SecondRoot = null,
                FirstComplexRoot = null,
                SecondComplexRoot = null
            };
        }
    }
}
