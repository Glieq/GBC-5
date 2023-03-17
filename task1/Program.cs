// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int lengthOfArr = Promt("Введите длинну массива: ");

int[] generateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int[] array = generateArray(lengthOfArr);

int countingEvenElements(int[] mas)
{
    int needCount = 0;
    for (int i = 0; i < lengthOfArr; i++)
    {
        if (mas[i] % 2 == 0)
        {
            needCount++;
        }
        System.Console.WriteLine(mas[i]);
    }
    return needCount;
}

int count = countingEvenElements(array);

System.Console.WriteLine($"Кол-во четных чисел в массиве: {count}");
