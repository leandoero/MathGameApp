using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameApp.Logic.Operations
{
    public interface IOperation
    {
        public int Execute(int firstNum, int secondNum);
    }
}
