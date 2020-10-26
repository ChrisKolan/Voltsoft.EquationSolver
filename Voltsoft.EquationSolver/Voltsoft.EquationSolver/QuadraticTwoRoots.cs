using System;
using System.Collections.Generic;
using System.Text;

namespace Voltsoft.EquationSolver
{
    internal class QuadraticTwoRoots
    {
        internal static QuadraticSolution Solution(double coefficientA, double coefficientB, double discriminant)
        {
            var firstRoot = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            var secondRoot = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);

            return new QuadraticSolution
            {
                FirstRoot = firstRoot,
                SecondRoot = secondRoot,
                FirstComplexRoot = null,
                SecondComplexRoot = null
            };
        }
    }
}
