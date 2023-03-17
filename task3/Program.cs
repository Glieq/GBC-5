// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int lengthOfArr = Promt("Введите длинну массива: ");

double[] generateArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.NextDouble() * 100; //Генерация чисел между 0 и 100
    }
    return array;
}
double[] array = generateArray(lengthOfArr);

// Вывод чисел массива на экран:
// for (int i = 0; i < lengthOfArr; i++)
// {
//     System.Console.WriteLine(array[i]);
// }

double differenceBetweenMaxAndMin(double[] mas)
{
    double minDoubleNumber = mas[0];
    double maxDoubleNumber = mas[0];
    for (int i = 1; i < lengthOfArr; i++)
    {
        if (mas[i] < minDoubleNumber)
        {
            minDoubleNumber = mas[i];
        }
        if (mas[i] > maxDoubleNumber)
        {
            maxDoubleNumber = mas[i];
        }
    }
    return maxDoubleNumber - minDoubleNumber;
}

double dif = differenceBetweenMaxAndMin(array);

System.Console.WriteLine($"Разница между максимальным и минимальным элементами = {dif}");
