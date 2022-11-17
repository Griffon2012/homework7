// Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами. 
// Напишите метод для поиска ср. арифметического значения каждого столбца. 

// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. 
// Размерность массива определить самостоятельно. Использование методов для заполнения массива обязательно. 
// Остальное можно реализовать в главной программе. 

void FillRandomElement(int[,] array, int min, int max)
{
    Random rnd = new Random();

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetAverageByColumn(int[,] array)
{
    int columns = array.GetLength(1);
    int rows = array.GetLength(0);
    double[] arrayAverage = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        int sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }
        arrayAverage[i] = Math.Round((sum / (double)rows), 1);
    }

    return arrayAverage;
}

Console.Write("Введите количество строк: ");
int countLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int countColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[countLine, countColumn];

//заполняем random
FillRandomElement(array, 0, 9);

//выводим массив
PrintArray(array);

double[] arrayAverage = GetAverageByColumn(array);

Console.Write($"Среднее арифметическое каждого столбца: {String.Join("; ", arrayAverage)}");