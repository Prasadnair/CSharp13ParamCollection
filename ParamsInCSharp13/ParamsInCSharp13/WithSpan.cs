namespace ParamsInCSharp13
{
    internal static class WithSpan
    {
        public static void Display(params ReadOnlySpan<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number},");
            }
        }
    }
}
