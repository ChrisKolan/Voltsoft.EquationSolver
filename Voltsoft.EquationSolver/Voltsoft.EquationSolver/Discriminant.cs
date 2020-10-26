namespace Voltsoft.QuadraticEquationSolver
{
    internal static class Discriminant
    {
        internal static double Calculate(double coefficientA, double coefficientB, double coefficientC)
        {
            return coefficientB * coefficientB - 4 * coefficientA * coefficientC;
        }
    }
}
