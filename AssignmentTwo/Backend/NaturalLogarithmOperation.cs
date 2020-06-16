using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Implementation of base e logarithm UnaryOperation.
     */
    class NaturalLogarithmOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            if (argument <= 0)
            {
                throw new ArithmeticException("Invalid Input: Logarithm is only defined for positive numbers");
            }

            return Math.Log(argument);
        }
    }
}
