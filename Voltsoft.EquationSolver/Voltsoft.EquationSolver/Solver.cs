using System;

namespace Voltsoft.QuadraticEquationSolver
{
    public class Solver
    {
        private double _CoefficientA;
        private double _CoefficientB;
        private double _CoefficientC;

        public Solver(double coefficientA, double coefficientB, double coefficientC)
        {
            _CoefficientA = coefficientA;
            _CoefficientB = coefficientB;
            _CoefficientC = coefficientC;
        }

        public Solution FindQuadraticRoots()
        {
            var discriminant = Discriminant.Calculate(_CoefficientA, _CoefficientB, _CoefficientC);

            if (discriminant == 0)
            {
                return OneRoot.Solution(_CoefficientA, _CoefficientB, discriminant);
            }
            if (discriminant > 0)
            {
                return TwoRoots.Solution(_CoefficientA, _CoefficientB, discriminant);
            }
            if (discriminant < 0)
            {
                return TwoComplexRoots.Solution(_CoefficientA, _CoefficientB, _CoefficientC, discriminant);
            }

            return null;
        }
    }
}
