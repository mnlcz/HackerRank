int factorial(int n) => n <= 1 ? 1 : n * factorial(n - 1);

Console.WriteLine(factorial(3));