// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double Razn(int len)
{
    double[] array_rand = new double[len];
    double max = 0;
    double min = 0;
    for (int i = 0; i < len; i++)
    {
        array_rand[i] = new Random().Next();
        Console.Write(array_rand[i] + ", ");
        if (i == 0)
        {
        max = array_rand[i];
        min = array_rand[i];
        }
        else 
        {
        if (array_rand[i] > max) max = array_rand[i];
        else if (array_rand[i] < min) min = array_rand[i];
        }               
    }
        Console.WriteLine();
        Console.WriteLine(max);
        Console.WriteLine(min);

        return (max - min);
}
Console.Write("Введите размер массива: ");
int len2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Razn(len2)}");
Console.ReadKey(true);