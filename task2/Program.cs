// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Summa(int len)
{
    int[] array_rand = new int[len];
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        array_rand[i] = new Random().Next(-999, 1000);
        Console.Write(array_rand[i] + ", ");
        if (i % 2 != 0) sum = sum + array_rand[i];
    }
    Console.WriteLine("");
    return sum;
}
Console.Write("Введите размер массива: ");
int len2 = Convert.ToInt32(Console.ReadLine());
if (len2 < 2) Console.WriteLine("Нет элементов, стоящих на нечётных позициях");
else Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, составляет: {Summa(len2)}");
Console.ReadKey(true);