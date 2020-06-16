using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo.Backend
{
    public interface IUnaryOperation
    {
        double Compute(double argument);
    }
}
