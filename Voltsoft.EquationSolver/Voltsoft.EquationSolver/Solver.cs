using System;

namespace Voltsoft.EquationSolver
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

        public QuadraticSolution FindQuadraticRoots()
        {
            var discriminant = QuadraticDiscriminant.Discriminant(_CoefficientA, _CoefficientB, _CoefficientC);

            if (discriminant == 0)
            {
                return QuadraticOneRoot.Solution(_CoefficientA, _CoefficientB, discriminant);
            }
            if (discriminant > 0)
            {
                return QuadraticTwoRoots.Solution(_CoefficientA, _CoefficientB, discriminant);
            }
            if (discriminant < 0)
            {
                return QuadraticTwoComplexRoots.Solution(_CoefficientA, _CoefficientB, _CoefficientC, discriminant);
            }

            return null;
        }
    }
}
