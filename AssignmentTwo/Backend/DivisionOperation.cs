using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    class DivisionOperation : IBinaryOperation
    {
        public double Compute(double left, double right)
        {
            // We follow windows calculator convention and only explicitly deny division by zero
            if (right == 0)
            {
                throw new ArithmeticException("Invalid input: Division by zero not defined");
            }

            return left / right;
        }
    }
}
