// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write($"Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[size];

void FillArray (int size)
{
Random rand = new Random();
for (int i = 0; i < size; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2}, ");
}

}

double dif (double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

FillArray (size);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {dif (randomArray):F2}");
