using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_08_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<string> e2 = new ConstantExpression<string>("Hej");
            Console.WriteLine(e2);
                Console.ReadKey();
        }
    }

    public abstract class Expression<Generic>
                        
    {
        abstract public Generic Evaluate();
    }

    public sealed class ConstantExpression<Generic> : Expression<Generic>
    {
        public ConstantExpression(Generic Value)
        {
            this.Value = Value;
        }


        private readonly Generic Value;

        public override Generic Evaluate()
        {
            return Value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }

    }


}
