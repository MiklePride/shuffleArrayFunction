class program
{
    static void Main(string[] args)
    {
        int[] arrayNumbers = { 1, 2, 3, 4, 5, 6 };

        DisplayArrayOnScreen(arrayNumbers);
        ArrayShuffle(arrayNumbers);
        DisplayArrayOnScreen(arrayNumbers);
    }

    static void ArrayShuffle(int[] array)
    {
        Random random = new Random();

        for (int i = array.Length - 1; i >= 1; i--)
        {
            int randomIndex = random.Next(i + 1);
            int temporary = array[randomIndex];
            array[randomIndex] = array[i];
            array[i] = temporary;
        }
    }

    static void DisplayArrayOnScreen(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}