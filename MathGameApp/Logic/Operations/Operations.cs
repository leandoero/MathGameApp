using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MathGameApp.Logic.Operations
{
    public class Operations : IOperation
    {
        public int Execute(int firstNum, int secondNum) => firstNum + secondNum;
    }
    public class Division : IOperation
    {
        public int Execute(int firstNum, int secondNum) => firstNum / secondNum;
    }
    public class Multiplication : IOperation
    {
        public int Execute(int firstNum, int secondNum) => firstNum * secondNum;
    }
    public class Subtraction : IOperation
    {
        public int Execute(int firstNum, int secondNum) => firstNum - secondNum;
    }

}
 