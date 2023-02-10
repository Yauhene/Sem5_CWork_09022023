// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] createRandArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        arr[i] = random.Next(min, max+1);
        Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
    return arr;
}

void printArr(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.WriteLine(str);
}

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123    (-150; 150)
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int [] array = CreateRandomArray(10, 1, 10); 
printArray(array);
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
        //Console.WriteLine($"array[{i}] = {array[i]}");
    }
    return array;
}

void printArray(int[] array)
{
    string str = "";
    for (int i = 0; i <= array.Length-1; i++)
    {
        if (i != array.Length-1 )
        {
            str = str  + array[i] + ", ";
        }
        else str = str  + array[i] + ".";
    }
    Console.WriteLine(str);
}









//int [] array_1 = CreateRandomArray(150, 5, 150); 
//printArray(array);
/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
        //Console.WriteLine($"array[{i}] = {array[i]}");
    }
    return array;
}
*/
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        Console.WriteLine($"Элемент массива номер: {string.Join(" ", i)} равен {array[i]} и входит в указанный промежуток");
        count++;
    }
}

/*

Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Задача 37: Найдите произведение пар чисел в одномерном массиве."); 
Console.WriteLine("Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");

for (int i = 0; i <= array.Length / 2; i++)
{
    Console.WriteLine(array[i] * array[(array.Length-1 -i)]);
}
