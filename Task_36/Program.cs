// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] createArray()
{
    var random = new Random();
    var result = new int[4];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]  = random.Next(0, 21);
    }
    return result;
}

int sumOddIndex(int[] array)
{
    var result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            result += array[i]; 
        }
    }
    return result;
}

var array = createArray();

Console.WriteLine("Задан массив: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

Console.WriteLine();

Console.WriteLine("Сумма элементов на нечетных позициях: ");

Console.WriteLine(sumOddIndex(array));