//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] GenerateArray(int lenght = 5)
{
    double[] newArray = new double[lenght];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.NextDouble() * 100;
    }
    return newArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}


double SerchMax(double[] array)
{
    double maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double SerchMin(double[] array)
{
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}

double[] array = GenerateArray();
PrintArray(array);
double itogMax = SerchMax(array);
double itogMin = SerchMin(array);
System.Console.WriteLine($"Максимальный элемент массива = {itogMax}");
System.Console.WriteLine($"Максимальный элемент массива = {itogMin}");
System.Console.WriteLine($"Разница между max и min элементом = {itogMax-itogMin}");
