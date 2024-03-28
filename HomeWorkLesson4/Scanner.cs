using System.Runtime.InteropServices.JavaScript;

namespace HomeWorkLesson4;

public static class Scanner
{
    private static Random random = new Random(); 
    
    private static bool IsArrayContainsNumber(int num)
    {
        int[] numberArray = { 10, 2, 3, 23, 5, 9, 7, 8, 9 };
        // Array.Sort(numberArray);
        // var result= Array.BinarySearch(numberArray, num);
        var result= Array.Exists(numberArray, i =>  i == num);
        return result;
    }

    public static int[] DeleteNumFromArray()
    {
        Console.Write("Введите число: ");
        var num = Convert.ToInt32(Console.ReadLine());
        int[] numberArray = new int[10];
        for (int i = 0; i < numberArray.Length; i++)
        {
            int value = random.Next(10);
            numberArray.SetValue(value, i);
        }
        Console.WriteLine(string.Join(" ", numberArray));

        bool isNumberExistsInArray = IsArrayContainsNumber(num);
        if (isNumberExistsInArray == false)
        {
            Console.WriteLine($"Массив не содержит число: {num}");
            return numberArray;
        }
        
        var newArrayNumber = numberArray.Where(x => x != num).ToArray();
        Console.WriteLine(string.Join(" ", newArrayNumber));
        return newArrayNumber;
    }

    public static void WriteMaxMinValueArray()
    {
        Console.WriteLine("Введите размер массива");
        var lengthArray = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Размер массива {lengthArray}");
        
        int[] arrayNumbers = new int[lengthArray];
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            int value = random.Next(100);
            arrayNumbers.SetValue(value, i);
        }
        Console.WriteLine(string.Join(" ", arrayNumbers));
        Console.WriteLine($"Максимальное число в массиве {arrayNumbers.Max()}");
        Console.WriteLine($"Минимальное число в массиве {arrayNumbers.Min()}");
        Console.WriteLine($"Средние значение в массиве {arrayNumbers.Average():N0}");
    }

    public static void CompareTwoArray()
    {
        var arrayOne = CreateArray(5);
        var arrayTwo = CreateArray(5);
        var averageArrayOne = arrayOne.Average();
        var avaregeArrayTwo = arrayTwo.Average();
        Console.WriteLine();
    }
    
    private static int[] CreateArray(int lengthArray)
    {
        int[] arrayNumbers = new int[lengthArray];
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            int value = random.Next(100);
            arrayNumbers.SetValue(value, i);
        }

        return arrayNumbers;
    }
}