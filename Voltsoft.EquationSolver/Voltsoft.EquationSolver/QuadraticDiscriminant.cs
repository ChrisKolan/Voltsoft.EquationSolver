using System;
using System.Collections.Generic;
using System.Text;

namespace Voltsoft.EquationSolver
{
    internal static class QuadraticDiscriminant
    {
        internal static double Discriminant(double coefficientA, double coefficientB, double coefficientC)
        {
            return coefficientB * coefficientB - 4 * coefficientA * coefficientC;
        }
    }
}
