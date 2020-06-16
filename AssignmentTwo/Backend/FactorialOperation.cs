using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Implementation of the factorial fucntion for integers. If a double is passed
     * that does not satisfy arguemnt % 1 == 0, it is treated as a non integer, and an
     * error is thrown.
     */
    public class FactorialOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            // Compare the modulous of argument against 1 to determine if it is an integer.
            if (argument % 1 != 0)
            {
                throw new ArithmeticException("Invalid Input: Non-integers are invalid for factorial");
            }

            // Ensure positivity
            if (argument < 0)
            {
                throw new ArithmeticException("Invalid Input: Negative numbers are invalid for factorial");
            }

            int n = (int)argument;
            return Factorial(n);
        }

        /**
         * Recursive calculation of n!
         */
        private int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
