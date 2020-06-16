using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    class AdditionOperation : IBinaryOperation {
        public double Compute(double left, double right)
        {
            return left + right;
        }
    }
}
