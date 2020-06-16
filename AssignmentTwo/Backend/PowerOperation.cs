using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Note: We deviate from Windows calculator and follow mathematics, treating
     * 0^0 as undefined.
     */
    class PowerOperation : IBinaryOperation
    {
        public double Compute(double left, double right)
        {
            if (left == 0 && right == 0)
            {
                throw new ArithmeticException("Invalid input: 0^0 is undefined");
            }
            return Math.Pow(left, right);
        }
    }
}
