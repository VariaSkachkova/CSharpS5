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
//Task31();

void Task32()
{
Console.WriteLine("Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.");
int size = 8;
int [] array = new int[size];
FillArray(array, -8, 8);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
ReverseValues(array);
Console.WriteLine("Вывод обработанного массива: ");
PrintArray(array);
}
void ReverseValues (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i]= array[i]*(-1);    
    }
      
}

//Task32();

void Task33()
{
Console.WriteLine("Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.");
int size = 8;
int [] array = new int[size];
bool flag = false; // переменная true/false
FillArray(array, 0, 10);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());  
FindNumber(array, number, flag);
}
void FindNumber (int [] array, int number, bool flag)
{
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] == number)
    {
        flag = true;
        break;
        
    }    
    
    }
    if(flag == true) Console.WriteLine("Это число есть в массиве.");
    else Console.WriteLine("Этого числа нет в массиве.");
    
      
}
//Task33();

void Task35()
{
Console.WriteLine("Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].");
int size = 8;
int [] array = new int[size];
FillArray(array, 0, 100);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] > 10 && array[i] < 99)
    {
        count++;
              
    }    
        
}
Console.WriteLine($"Числа в отрезке [10,99] встречаются в массиве {count} раз");

} 

//Task35();

void Task37()
{
Console.WriteLine("Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
Random random = new Random();
int size = random.Next(4,12);
int[] array = new int [size];
FillArray(array, 0, 10);
Console.WriteLine("Вывод массива: ");
PrintArray(array);
Console.WriteLine();
int maxIndex = array.Length - 1;
for (int i = 0; i < array.Length/2; i++)
{
    Console.WriteLine($"{array[i]} * {array[maxIndex - i]} = {array[i] * array[maxIndex - i]}");
}
if (array.Length % 2 == 1) Console.WriteLine("Элемент без пары: " + array[array.Length/2]);

}
Task37();