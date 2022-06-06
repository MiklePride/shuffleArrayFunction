class program
{
    static void Main(string[] args)
    {
        int[] arrayNumbers = { 1, 2, 3, 4, 5, 6 };
        ArrayScreen(arrayNumbers);
        arrayNumbers = ArrayShuffle(arrayNumbers);
        ArrayScreen(arrayNumbers);

    }

    static int[] ArrayShuffle(int[] array)
    {
        Random random = new Random();

        for (int i = array.Length - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            int temporary = array[j];
            array[j] = array[i];
            array[i] = temporary;
        }
        return array;
    }

    static void ArrayScreen(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}