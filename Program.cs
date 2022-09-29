namespace Operator
{
    class ArithmeticOperator
    {
        public static void Main(string[] args)
        {
            double x = 15, y = 5, result;
            

            // Addition
            result = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, result);


            // Subtraction
            result = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, result);


            // Multiplication
            result = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, result);


            // Division
            result = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, result);

       
        }
    }
}
