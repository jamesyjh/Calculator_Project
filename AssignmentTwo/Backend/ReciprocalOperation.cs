using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    public class ReciprocalOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            // We follow windows calculator convention and only explicity deny 1/0.
            if (argument == 0)
            {
                throw new ArithmeticException("Invalid Input: Reciprocal of zero undefined");
            }
            return 1 / argument;
        }
    }
}
