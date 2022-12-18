/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double [] GetArray(int size)
{
    double[] res = new double [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

void PrintArray(double [] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{Math.Round(arr[i], 2)} ");
        }
}
double[] array = GetArray(10);
PrintArray(array);

double DifMaxMin(double [] array)
{
    double max = array[0];
    double min = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
            i++;
        }
        else if (array[i] < min)
        {
            min = array[i];
            i++;
        }
        else
        {
            i++;
        }
    }
    return Math.Round(max-min, 2);
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {DifMaxMin(array)}");