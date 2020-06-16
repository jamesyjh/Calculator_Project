using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnaryOperation operation;
            

            // Factorial tests
            operation = new FactorialOperation();

            Console.WriteLine("10! = " + operation.Compute(10));
            try
            {
                operation.Compute(-1);
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                operation.Compute(1.1);
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Absolute value tests
            operation = new AbsoluteOperation();
            Console.WriteLine("|-1| = " + operation.Compute(-1));
            Console.WriteLine("|1.23| = " + operation.Compute(1.23));

            // Reciprocal tests
            operation = new ReciprocalOperation();
            Console.WriteLine("1/100 = " + operation.Compute(100));

            try
            {
                operation.Compute(0);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Logarithm tests
            operation = new LogarithmOperation();
            Console.WriteLine("Log(1) = " + operation.Compute(1));
            Console.WriteLine("Log(101.4) = " + operation.Compute(101.4));
            try
            {
                operation.Compute(0);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                operation.Compute(-1.1);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Ln tests
            operation = new NaturalLogarithmOperation();
            Console.WriteLine("Log(1) = " + operation.Compute(1));
            Console.WriteLine("Log(101.4) = " + operation.Compute(101.4));
            try
            {
                operation.Compute(0);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                operation.Compute(-1.1);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Square root
            operation = new SquareRootOperation();
            Console.WriteLine("sqrt(100) = " + operation.Compute(100));
            Console.WriteLine("sqrt(101) = " + operation.Compute(101));
            Console.WriteLine("sqrt(0) = " + operation.Compute(0));
            try
            {
                operation.Compute(-1.1);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Exponent
            operation = new ExponentOperation();
            Console.WriteLine("e^0 = " + operation.Compute(0));
            Console.WriteLine("e^1 = " + operation.Compute(1));
            Console.WriteLine("e^ln(5) = " + operation.Compute(Math.Log(5)));

            // Binary opertations

            // Addition
            IBinaryOperation binary = new AdditionOperation();

            Console.WriteLine("0 + 1 = " + binary.Compute(0, 1));
            Console.WriteLine("1 + 0 = " + binary.Compute(1, 0));
            Console.WriteLine("3.14 + 5.67 = " + binary.Compute(3.14, 5.67));

            // Subtraction
            binary = new SubtractionOperation();
            Console.WriteLine("0 - 1 = " + binary.Compute(0, 1));
            Console.WriteLine("1 - 0 = " + binary.Compute(1, 0));
            Console.WriteLine("1.1 - (-1.1) = " + binary.Compute(1.1, -1.1));

            // Multiplicaiton
            binary = new MultiplicaitonOperation();
            Console.WriteLine("0 * 1 = " + binary.Compute(0, 1));
            Console.WriteLine("1 * 0 = " + binary.Compute(1, 0));
            Console.WriteLine("1.1 * (-1.1) = " + binary.Compute(1.1, -1.1));
            Console.WriteLine("1.1 * 4 = " + binary.Compute(1.1, 4));

            // Division
            binary = new DivisionOperation();
            Console.WriteLine("0 / 1 = " + binary.Compute(0, 1));
            Console.WriteLine("1.1 / (-1.1) = " + binary.Compute(1.1, -1.1));
            Console.WriteLine("1 / 4 = " + binary.Compute(1, 4));
            try
            {
                binary.Compute(1, 0);
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Modulus
            binary = new ModulusOperation();
            Console.WriteLine("0 % 1 = " + binary.Compute(0, 1));
            Console.WriteLine("10 % (-5) = " + binary.Compute(10, -5));
            Console.WriteLine("4 % 2 = " + binary.Compute(4, 2));
            Console.WriteLine("3 % 2 = " + binary.Compute(3, 2));
            Console.WriteLine("4 % 0 = " + binary.Compute(4, 0));
            Console.WriteLine("-44 % 0 = " + binary.Compute(-44, 0));
            Console.WriteLine("-1.5 % 3 = " + binary.Compute(-1.5, 3));
            Console.WriteLine("-1.5 % -3 = " + binary.Compute(-1.5, -3));

            // Power
            binary = new PowerOperation();
            Console.WriteLine("0 ^ 1 = " + binary.Compute(0, 1));
            Console.WriteLine("1 ^ (-5) = " + binary.Compute(1, -5));
            Console.WriteLine("2 ^ 4 = " + binary.Compute(2, 4));
            Console.WriteLine("0 ^ 4 = " + binary.Compute(0, 4));
            Console.WriteLine("-1.5 ^ 3 = " + binary.Compute(-1.5, 3));
            Console.WriteLine("-1.5 ^ -3 = " + binary.Compute(-1.5, -3));

            try
            {
                binary.Compute(0, 0);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
