//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadInt("Введите очередное число");
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
int Sum(int[] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0) sum = sum + 1;
    }
    return sum;
}
int lengthmas = ReadInt("Введите число");
int[] massive = CreateArray(lengthmas);
PrintArray(massive);
int summa = Sum (massive);
System.Console.WriteLine($"Число положительных числе во введеном массиве равно {summa}");
