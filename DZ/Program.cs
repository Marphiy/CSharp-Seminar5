void FillArray(int[] arr, int startNum = -9, int endNum = 10)
{
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = new Random().Next(startNum, endNum);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Массив [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void SumOfNegPos(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNeg += arr[i];
        else sumPos += arr[i];
    }
    Console.WriteLine($"Сумма отрицательных чисел массива = {sumNeg}");
    Console.WriteLine($"Сумма положительных чисел массива = {sumPos}");
}

int[] ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

void FindNumInArray(int[] arr, int findNum)
{
    bool find = false;
    for (int i = 0; i < arr.Length && !find; i++)
    {
        find = findNum == arr[i];
    }
    if (find) Console.WriteLine($"В массиве присутствует число {findNum}.");
    else Console.WriteLine($"В массиве числа {findNum} нет!");
}

void CountNumsInArrayRange(int[] arr, int start, int end)
{
    int count = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] > start && arr[i] < end) count++;
    }
    Console.WriteLine($"В заданном массиве в диапазоне от {start} до {end} лежит {count} элементов!");
}

int[] FindPowOfPairs(int[] arr)
{
    int i =0;
    int newArrSize = arr.Length / 2 + 1;
    if (arr.Length % 2 == 0) newArrSize = arr.Length / 2;
    int[] newArr = new int[newArrSize];
    for (i = 0; i < arr.Length / 2; i++)
    {
         newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 == 1) newArr[i] = arr[i];
    return newArr;
}

int CountOfEvenNums(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int CountOfOddIndNums(int[] arr)
{
    int count = 0;
    for(int i= 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) count += arr[i];
    }
    return count;
}

void CreateNFillDoubleArray(double[] arr)
{
    Random rand = new Random();
    int j = 0;
    double[] bas = new double[] {0.72, -6.01, 78.11, 42.0, 91.83, -15.19, 1.99, 54.06, 27.48, -99,38, 21.7, 0.12, 66.3, 8.49};
    Console.Write("Массив псевдослучайных вещественных чисел [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        j = rand.Next(0, bas.Length);
        arr[i] = bas[j];
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}

void MaxMinSub(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine($"Минимальный элемент массива {min}");
    Console.WriteLine($"Максимальный элемент массива {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {max - min}");
}

void Zadacha31()
{
    //Задайте массив из 12 элементов, заполненный
    //случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива.
    
    int size = 12;
    int[] arr = new int[size];
    FillArray(arr, -9, 10);
    PrintArray(arr);
    SumOfNegPos(arr);
}

void Zadacha32()
{
    //Напишите программу замены элементов
    //массива: положительные элементы замените на
    //соответствующие отрицательные, и наоборот.
    
    int size = 12;
    int[] arr = new int[size];
    FillArray(arr, -20, 21);
    PrintArray(arr);
    ChangeSign(arr);
    PrintArray(arr);

}

void Zadacha33()
{
    //Задайте массив. Напишите программу, которая
    //определяет, присутствует ли заданное число в массиве.
    int size = new Random().Next(2, 10);
    int[] arr = new int[size];
    FillArray(arr, -20, 21);
    PrintArray(arr);
    FindNumInArray(arr, 12);
}

void Zadacha34()
{
    //Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = new Random().Next(2, 10);
    int[] arr = new int[size];
    FillArray(arr, 100, 1000);
    PrintArray(arr);
    Console.WriteLine($"Четных чисел в массиве {CountOfEvenNums(arr)}");
}

void Zadacha35()
{
    //Задайте одномерный массив из 123 случайных чисел.
    //Найдите количество элементов массива, значения которых лежат в
    //отрезке [10,99].
    
    int size = 123;
    int[] arr = new int[size];
    FillArray(arr, -99, 100);
    PrintArray(arr);
    CountNumsInArrayRange(arr, 10, 99);
}

void Zadacha36()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
    //элементов, стоящих на нечётных позициях.
    
    int size = new Random().Next(3, 10);
    int[] arr = new int[size];
    FillArray(arr, -19, 26);
    PrintArray(arr);
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива = {CountOfOddIndNums(arr)}");
}

void Zadacha37()
{
    // Найдите произведение пар чисел в одномерном массиве.
    //Парой считаем первый и последний элемент, второй и предпоследний
    //и т.д. Результат запишите в новом массиве.
    
    int size = new Random().Next(3, 6);
    int[] arr = new int[size];
    FillArray(arr, 0, 10);
    PrintArray(arr);
    PrintArray(FindPowOfPairs(arr));
}

void Zadacha38()
{
    //Задайте массив вещественных чисел. Найдите разницу между 
    //максимальным и минимальным элементов массива.

    int size = new Random().Next(4, 8);
    double[] arr = new double[size]; 
    CreateNFillDoubleArray(arr);
    MaxMinSub(arr);
}

//Zadacha31();
//Zadacha32();
//Zadacha33();
//Zadacha34();
//Zadacha35();
//Zadacha36();
//Zadacha37();
//Zadacha38();
