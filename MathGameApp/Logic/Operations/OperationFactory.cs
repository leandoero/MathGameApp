using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGameApp.Logic.Operations
{
    public class OperationFactory
    {
        public static IOperation GetOperation(char operation)
        {
            return operation switch
            {
                '+' => new Operations(),
                '-' => new Subtraction(),
                '*' => new Multiplication(),
                '/' => new Division(),
                _ => throw new InvalidOperationException($"Unsupported operation: {operation}")
            };
        }
    }
}
