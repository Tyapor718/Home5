//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}
int SumEvenPosition(int[] massive)
{
    int sum = 0;
    for (int i = 1; i < massive.Length; i = i + 2)
    {
        sum = sum + massive[i];
    }
    return sum;
}
int lenMas = ReadInt("Длина массива >");
int masMin = ReadInt("Минимальное значение >");
int masMax = ReadInt("Максимальное значение >");
int[] massive = CreateArray(lenMas, masMin, masMax);
PrintArray(massive);
System.Console.Write(SumEvenPosition(massive));