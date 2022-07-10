void Task31()
{
Console.WriteLine("Задача 31: Задайте массив из 12 элементов, заполненный случайными числами. Найдите сумму отрицательных и положительных элементов массива.");

int size = 12;
int [] array = new int[size];
FillArray(array, -5, 5);
PrintArray(array);
Console.WriteLine("Сумма отрицательных элементов массива: " + SumNegative(array));
Console.WriteLine("Сумма положительных элементов массива: " + SumPositive(array));

}
int SumNegative(int [] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] < 0) sumNegative += array[i];    
    }
    return sumNegative;
    
}

int SumPositive(int [] array)
{    
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

void FillArray(int[] array, int startNumber = 0, int endNumber = 0)
{
    endNumber++;
    Random random = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = random.Next(startNumber,endNumber);
        
    }
        
}
void PrintArray (int [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
}
Task31();