// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. 
// Размерность массива определить самостоятельно. Использование методов для заполнения массива обязательно. 
// Остальное можно реализовать в главной программе. 

void FillRandomElement(double[,] array, int min, int max)
{
    Random rnd = new Random();

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(((rnd.NextDouble() * (max - min)) + min), 2);
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            string numberToString = string.Format("{0:f2}", array[i, j]);
            if (array[i, j] < 0)
            {
                Console.Write($"{numberToString} ");
            }
            else
            {
                Console.Write($" {numberToString} ");
            }

        }
        Console.WriteLine();
    }
}

bool FieldExists(double[,] array, int linePosition, int columnPosition)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    if ((linePosition < 1 || columns < 1)
    || (linePosition > rows || columnPosition > columns))
    {
        return false;
    }

    return true;
}

Console.Write("Введите количество строк: ");
int countLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int countColumn = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[countLine, countColumn];

//заполняем random
FillRandomElement(array, -10, 10);

//выводим массив
PrintArray(array);

Console.Write("Введите позицию строки: ");
int linePosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

if (FieldExists(array, linePosition, columnPosition))
{
    string numberToString = string.Format("{0:f2}", array[linePosition - 1, columnPosition - 1]);
    Console.WriteLine($"Элемент: {numberToString}");
}
else
{
    Console.WriteLine($"Элемент отсутствует!");
}
