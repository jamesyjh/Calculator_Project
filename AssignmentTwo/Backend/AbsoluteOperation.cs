using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    /**
     * Implementation of the absolute value function for doubles.
     */
    class AbsoluteOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            if (argument < 0)
            {
                return argument * -1;
            }
            return argument;
        }
    }
}
