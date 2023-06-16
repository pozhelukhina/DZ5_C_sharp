// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine ("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[size];

void FillArray(int size)
{
    for (int i = 0; i < randomArray.Length; i++)
        randomArray[i] = new Random().Next(99, 999);
}

int chet (int[] randomArray)
{
int chet = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
chet = chet + 1;
}
return chet;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


FillArray(size);
PrintArray(randomArray);
Console.WriteLine($"Количество чётных чисел в массиве: {chet(randomArray)}");


