//Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами. 
//Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
//Округлите значения, генерируемые Random до двух знаков после запятой.

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

Console.Write("Введите количество строк: ");
int countLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int countColumn = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[countLine, countColumn];

//заполняем random
FillRandomElement(array, -10, 10);

//выводим массив
PrintArray(array);