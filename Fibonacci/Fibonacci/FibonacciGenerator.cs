namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
