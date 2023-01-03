// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Console.Write("Enter a size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// CounterNums(numbers);
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void CounterNums(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// int [] CreateArray(int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// int size = 123;
// int min = -10;
// int max = 10;
// int [] createdArray = CreateArray(size, min, max);
// ShowArray(createdArray);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int [] SummOddElem(int num)
// {
// int n, sum1 = 0, sum2 = 0;
// int[] a;
// n = Convert.ToInt32(Console.ReadLine());
// a = new int [n];
// for (int i = 0; i < n; i++)
// {
//     a[i] = new Random().Next(-10,10);
//     Console.Write(a[i]+" ");
// }
// Console.WriteLine();
// for (int i = 0; i < n; i++)
// {
//     if (i % 2 == 0)
//         sum1 = sum1 + a[i];
//     else
//         sum2 = sum2 + a[i];
// }

// Console.WriteLine($"Summ of odd elems is: {sum1}");
// Console.WriteLine($"Summ of even elems: {sum2} ");
// return a;
// }
// Console.Write("Enter a size: ");
// int res = Convert.ToInt32(Console.ReadLine());
// SummOddElem(res);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// int[] Main(int args)
// {
//     int[] d = new int[5];
//     int max=1, min=100;
//     for (int i = 0; i<d.Length; i++ )  d[i] = new Random().Next(1,100);
//     for (int i = 0; i < d.Length; i++)
//     {
//         if (d[i] > max) max = d[i];
//         if (d[i] < min) min = d[i];
//     }  
//     for (int i = 0; i < d.Length; i++) Console.Write(d[i]+" ");
//         Console.WriteLine();
//         Console.WriteLine("max:  " + max);
//         Console.WriteLine("min  " +min);
//         Console.WriteLine("Разница максимального и минимального:  "+(max - min));
//         return d;
// }
// int res = Convert.ToInt32(Console.ReadLine());
// Main(res);
 
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// void Main(int size, int minValue, int maxValue)
// {
//     int[] a = new int[size];
//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = new Random().Next(minValue,maxValue+1);
//         Console.Write(a[i] + " ");
//     }
//     int umnoj = 1;
//     int umnoje = 1;
//     for (int i = 0; i < a.Length / 2; i++)
//         umnoj = a[i] * a[i + 1];
//         Console.WriteLine($"Произведение пар чисел равен {umnoj}");
// }
// int min = -10;
// int max = 10;
// Console.Write("Enter a size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Main(size, min, max);