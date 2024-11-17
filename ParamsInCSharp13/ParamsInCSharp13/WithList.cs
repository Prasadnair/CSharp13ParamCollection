namespace ParamsInCSharp13
{
    internal static class WithList
    {
        public static void Display(params List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write($"{number},");
            }
        }
    }
}
