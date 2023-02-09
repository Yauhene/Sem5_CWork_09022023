// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



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






int[] Task(int size, int min, int max)
{
    int[] yarra = createRandArr(size, min, max);
    printArr(yarra);
    for(int i =0; i <= yarra.Length-1; i++)
    {
        yarra[i] = yarra[i] * (-1);
    }

    //printArr(yarra);
    return yarra;
}
bool findExist(int[] arr, int wanted)
{

for (int i =0; i <= arr.Length-1; i++)
{
    if (arr[i] == wanted || arr[i] == wanted*(-1))
    {
       Console.WriteLine($"Число {wanted} входит в данный массив");
       return true;
    }
    
}
return false;
}
    
Console.WriteLine(findExist(createRandArr(5, -9, 9), 4));

