// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

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
        array[i] = random.Next(-100, 101);
    }
    return array;
}

int[] array = generateArray(lengthOfArr);

int sumOfOddElements(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < lengthOfArr; i++)
    {
        if (i % 2 != 0)
        {
            sum += mas[i];
        }
        System.Console.WriteLine(mas[i]);
    }
    return sum;
}

int totalSum = sumOfOddElements(array);

System.Console.WriteLine($"Сумма элементов на нечётных позициях = {totalSum}");