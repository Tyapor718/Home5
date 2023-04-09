//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int length, int min, int max)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 2);
    }
    return array;
}
void PrintArray(double[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:F2}\t");
    }
    System.Console.WriteLine();
}
double Min(double[] mas, int maxM)
{
    double min = maxM;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
    }
    return min;
}
double Max(double[] mas)
{
    double max = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
    }
    return max;
}
int lenMas = ReadInt("Длина массива >");
int masMin = ReadInt("Минимальное значение >");
int masMax = ReadInt("Максимальное значение >");
double[] massive = CreateArray(lenMas, masMin, masMax);
PrintArray(massive);
double maxMassive = Max(massive);
double minMassive = Min(massive, masMax);
double sum = minMassive + maxMassive;
System.Console.WriteLine($"Сумма максимимума и минимума равна {sum}");