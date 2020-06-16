using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Implementation of base 10 logarithm UnaryOperation.
     */
    public class LogarithmOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            if (argument <= 0)
            {
                throw new ArithmeticException("Invalid Input: Logarithm is only defined for positive numbers");
            }

            return Math.Log10(argument);
        }
    }
}
