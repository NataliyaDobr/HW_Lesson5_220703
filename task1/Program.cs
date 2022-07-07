// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int lenght = 10, int min = 100, int max = 1000)
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


int CntNum(int[] array)
{
    int cntEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            cntEvenNum = cntEvenNum + 1;
        }
    }
    return cntEvenNum;
}

int[] array = GenerateArray();
PrintArray(array);
int itog = CntNum(array);
System.Console.WriteLine($"Количество четных чисел в массиве = {itog}");
