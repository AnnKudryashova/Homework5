// Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] createArray()
{
    var random = new Random();
    var result = new int[5];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    
    return result;
}

int EvenNumbers(int[] array)
{
    var result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

var array = createArray();

Console.WriteLine("Сгенерировали массив по условиям задачи");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

Console.WriteLine();
Console.WriteLine("Количество четных чисел: ");

Console.WriteLine(EvenNumbers(array));