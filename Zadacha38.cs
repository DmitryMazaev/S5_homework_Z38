/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
}
int[] array = GetArray(8, -10, 10);
PrintArray(array);

int DifMaxMin(int [] array)
{
    int max = array[0];
    int min = array[0];
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
    return max-min;
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {DifMaxMin(array)}");