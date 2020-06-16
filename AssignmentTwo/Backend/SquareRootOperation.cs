using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    class SquareRootOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            if (argument < 0)
            {
                throw new ArithmeticException("Invalid Input: Square root only defined for non-negative numebrs");
            }

            return Math.Sqrt(argument);
        }
    }
}
