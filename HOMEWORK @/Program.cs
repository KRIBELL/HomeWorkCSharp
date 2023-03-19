public class Program
{
    public static void Main()
    {
        Console.Write("Введите размер массива: ");
        int numbersSIZE = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[numbersSIZE];
        int max = 0;
        int secondmax = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (secondmax < numbers[i] && numbers[i] < max)
            {
                secondmax = numbers[i];
            }
        }
        Console.WriteLine(secondmax);
        Console.Read();

    }
}
