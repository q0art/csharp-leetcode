namespace csharp_leetcode.easy._509.Fibonacci_Number;

public class Solution
{
    public int Fib(int n) => (n <= 1) ? n : Fib(n - 1) + Fib(n - 2);
}