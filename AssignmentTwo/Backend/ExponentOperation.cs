using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    class ExponentOperation : IUnaryOperation
    {
        public double Compute(double argument)
        {
            PowerOperation operation = new PowerOperation();
            return operation.Compute(Math.E, argument);
        }
    }
}
