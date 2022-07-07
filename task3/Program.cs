// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int lenght = 6, int min = 1, int max = 10)
{
    int[] newArray = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int SumArr(int[] array)
{
    int sumOddPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumOddPos = sumOddPos + array[i];
        i = i + 1;
    }
    return sumOddPos;
}

int[] array = GenerateArray();
PrintArray(array);
int itogSum = SumArr(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях = {itogSum}");