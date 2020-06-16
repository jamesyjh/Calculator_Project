using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Note: We follow Windows calculator convention and allow for modulus by both fractional and 
     * negative numbers. The any number n mod 0 is defined as n to match the behavior of Windows 
     * calculator.
     */
    class ModulusOperation : IBinaryOperation
    {
        public double Compute(double left, double right)
        {
            // Explicitly define n mod 0 as n.
            if (right == 0)
            {
                return left;
            }

            return left % right;
        }
    }
}
