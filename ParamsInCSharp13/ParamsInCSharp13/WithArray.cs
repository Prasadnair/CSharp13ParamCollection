namespace ParamsInCSharp13
{
    internal static class WithArray
    {
        public static void Display(params int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number},");
            }
        }
    }
}
