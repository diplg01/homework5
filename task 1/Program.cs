// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine();
            
int Quant(int len)
{
    int[] array_3zn = new int[len];
    int quantity = 0;
    for (int i = 0; i < len; i++)
    {
    array_3zn[i] = new Random().Next(100, 1000);
    Console.Write(array_3zn[i] + ", ");
    if (array_3zn[i] % 2 == 0) quantity += 1;
    }
    Console.WriteLine("");
    return quantity;
}
    Console.Write("Введите размер массива: ");
    int len2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Количество четных элементов в массиве составляет: {Quant(len2)}");
    Console.ReadKey(true);