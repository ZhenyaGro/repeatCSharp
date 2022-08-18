class Seminar7 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {47, new Task(Task47)},
    {50, new Task(Task50)},
    {52, new Task(Task52)}
  };
  protected internal override string genitiveSemNum { get; } = "седьмого";

  // Tasks
  public static void Task47()
  {
    /*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
    */
    Console.WriteLine("Запущено задание 47. Двумерный массив вещественных чисел");
    Console.WriteLine("Задайте размерность массива");
    Console.Write("Количество строк m: ");
    int countRow = Convert.ToInt16(Console.ReadLine());
    Console.Write("Количество столбцов n: ");
    int countCol = Convert.ToInt16(Console.ReadLine());

    double[,] numbers = new double[countRow, countCol];
    fillArray(numbers, countRow, countCol);

    for (int i = 0; i < countRow; i++)
    {
      Console.WriteLine();
      for (int j = 0; j < countCol; j++)
      {
        Console.Write($"{numbers[i, j]} ");
      }
    }

    void fillArray(double[,] array, int countRow, int countCol)
    {
      Random rnd = new Random();

      for (int i = 0; i < countRow; i++)
      {
        for (int j = 0; j < countCol; j++)
        {
          // random.NextDouble() * (maximum - minimum) + minimum;
          numbers[i, j] = Math.Round((rnd.NextDouble() * (10 + 10) - 10), 1);
        }
      }
    }
  }
  public static void Task50()
  {
    /*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    1, 7 -> такого числа в массиве нет
    */
    Console.WriteLine("Запущено задание 50. Значение элемента в двумерном массиве");

    int[,] numbers = createArray2Dimensional();
    ShowArray(numbers);

    Console.WriteLine();

    Console.Write("Введите позицию элемента 'n,m' (через пробел, запятую или точку): ");
    int[] arrayElement = new int[2];

    char[] delimiterChars = { ' ', ',', '.', '\t' };
    try
    {
      string[] userAnswer = Console.ReadLine().Split(delimiterChars);
      arrayElement = Array.ConvertAll(userAnswer, s => int.Parse(s));
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    if (arrayElement[0] > numbers.GetLength(0) || arrayElement[0] < 0)
    {
      Console.WriteLine("Такого числа в массиве нет");
      return;
    }
    if (arrayElement[1] > numbers.GetLength(1) || arrayElement[1] < 0)
    {
      Console.WriteLine("Такого числа в массиве нет");
      return;
    }

    Console.WriteLine($"({arrayElement[0]}, {arrayElement[1]}) -> {numbers[arrayElement[0], arrayElement[1]]}");

  }
  public static void Task52()
  {
    /*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    */
    Console.WriteLine("Запущено задание 52. Среднее арифметическое в столбцах");

    int[,] numbers = createArray2Dimensional();
    ShowArray(numbers);
    Console.WriteLine();
    double[] results = CalculateArithmeticMean(numbers);

    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < results.Length; i++)
    {
      if (i == results.Length - 1)
      {
        Console.Write(results[i] + ".");
        return;
      }
      Console.Write(results[i] + "; ");
    }

    double[] CalculateArithmeticMean(int[,] arrayNumbers)
    {
      double[] results = new double[numbers.GetLength(1)];

      for (int i = 0; i < numbers.GetLength(1); i++)
      {
        int currentSum = 0;
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
          currentSum += numbers[j, i];
        }
        results[i] = Math.Round(currentSum / Convert.ToDouble(numbers.GetLength(0)), 1);
      }

      return results;
    }
  }

  static int[,] createArray2Dimensional()
  {
    Random rnd = new Random();
    int countRow = rnd.Next(2, 10);
    int countCol = rnd.Next(2, 10);
    int[,] numbers = new int[countRow, countCol];

    for (int i = 0; i < countRow; i++)
    {
      for (int j = 0; j < countCol; j++)
      {
        numbers[i, j] = rnd.Next(0, 10);
      }
    }
    return numbers;
  }
  static void ShowArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j]} ");
      }
    }
  }
}