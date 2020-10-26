using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Voltsoft.EquationSolver
{
    public class QuadraticSolution
    {
        public double? FirstRoot { get; set; }
        public double? SecondRoot { get; set; }
        public Complex? FirstComplexRoot { get; set; }
        public Complex? SecondComplexRoot { get; set; }
    }
}
