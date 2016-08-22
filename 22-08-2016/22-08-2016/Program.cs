using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_2016
{
    class Program
    {
        public static void Main()
        {

            //var expr = new PlusExpression(new ConstantExpression (2), new ConstantExpression (4));

            // Create your expression here

            //Expression expr = ...;

            // Example:
            Expression expr = new PlusExpression(
                new ConstantExpression(4),
                new PlusExpression(
                    new ConstantExpression(1),
                    new MinusExpression(
                        new ConstantExpression(1),
                        new ConstantExpression(2))));

            // We print the textual representation
            Console.Write(expr.ToString());

            Console.Write(" = ");

            // ... and then the result of evaluating
            Console.WriteLine(expr.Evaluate());

            Console.ReadKey();

        }


    }

    abstract class Expression



    {
        abstract public double Evaluate();
    }

    sealed class ConstantExpression : Expression
    {
        public ConstantExpression(double Value)
        {
            this.Value = Value;
        }


        private readonly double Value;

        public override double Evaluate()
        {
            return Value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }

    }
    abstract class BinaryExpression : Expression

    { 
   public BinaryExpression(Expression Left, Expression Right)
        
    {
   this.Left = Left;
   this.Right = Right; 
    }
     
    
        protected Expression Right;
        protected Expression Left;
        public abstract string OperatorSymbol
        {
            get;
        }

        public override string ToString()
        {
            return "(" + Left.ToString() + " " + OperatorSymbol + " " + Right.ToString() + ")";
        }
    }
    
    class PlusExpression : BinaryExpression
       

    {
        public PlusExpression (Expression Left, Expression Right): base (Left, Right)
        {

        }


        public override string OperatorSymbol
        {
            get
            {
                return "+";
            }
        }

        public override double Evaluate()
        {
            return Left.Evaluate() + Right.Evaluate();
        }
    }

    class MinusExpression : BinaryExpression
    {
        public MinusExpression(Expression Left, Expression Right): base (Left, Right)
        {

        }

        public override string OperatorSymbol
        {
            get
            {
                return "-";
            }
        }
        public override double Evaluate()
        {
            return Left.Evaluate() - Right.Evaluate();
        }

    }
    class MultiplyExpression : BinaryExpression
    {
        public MultiplyExpression(Expression Left, Expression Right): base (Left, Right)
        {

        }

        public override string OperatorSymbol
        {
            get
            {
                return "*";
            }
        }
        public override double Evaluate()
        {
            return Left.Evaluate() * Right.Evaluate();
        }
    }

    abstract class UnaryEkspression : Expression
    {
        protected Expression expr;

    }
    class NegateExpression : UnaryEkspression
    {
        public override string ToString()
        {
            return "-" + expr.ToString();
        }

        public override double Evaluate()
        {
            return -expr.Evaluate();
        }
    }
}
