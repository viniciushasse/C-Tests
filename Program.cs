namespace Operator
{
    class ArithmeticOperator
    {
        public static void Main(string[] args)
        {
            double x = 15, y = 5, result;
            

            // Addition operator
            result = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, result);


            // Subtraction operator
            result = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, result);


            // Multiplication operator
            result = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, result);


            // Division operator
            result = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, result);

       
        }
    }
}