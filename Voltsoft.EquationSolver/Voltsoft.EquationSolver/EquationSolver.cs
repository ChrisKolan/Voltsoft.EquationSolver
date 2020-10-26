using System;

namespace Voltsoft.EquationSolver
{
    public class EquationSolver
    {
        private readonly double _CoefficientA;
        private readonly double _CoefficientB;
        private readonly double _CoefficientC;

        public EquationSolver(double coefficientA, double coefficientB, double coefficientC)
        {
            _CoefficientA = coefficientA;
            _CoefficientB = coefficientB;
            _CoefficientC = coefficientC;
        }

        public QuadraticEquationSolver.Solution Solve()
        {
            QuadraticEquationSolver.Solution result = null;

            if (_CoefficientA !=0)
            {
                result = new QuadraticEquationSolver.Solver(_CoefficientA, _CoefficientB, _CoefficientC).FindQuadraticRoots();
            }

            return result;
        }
    }
}
