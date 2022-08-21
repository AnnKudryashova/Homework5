// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

double[] createArray()
{
    var random = new Random();
    var result = new double[6];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
    }
    return result;
}

double MaxNumber(double[] array)
{
    double maxNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}
    
double MinNumber(double[] array)    
{   
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

var array = createArray();

Console.WriteLine("Сгенерировали массив: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}

double maxNumber = MaxNumber(array);
double minNumber = MinNumber(array);
double result = maxNumber - minNumber;

Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным числами составляет: ");

Console.WriteLine(result);