class Seminar8 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {54, new Task(Task54)},
    {56, new Task(Task56)},
    {58, new Task(Task58)},
    {60, new Task(Task60)},
    {62, new Task(Task62)}
  };
  protected internal override string genitiveSemNum { get; } = "восьмого";

  // Tasks
  public static void Task54()
  {
    /*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по ?убыванию? (возрастанию?) элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    1 2 4 7
    2 3 5 9
    2 4 4 8
    */
    Console.WriteLine("Запущено задание 54. Элементы по возрастанию в каждой строке двумерного массива");

    // CreateArray();
    /*
    int[,] numbers = new int[3, 4]{
      {1, 4, 7, 2},
      {5, 9, 2, 3},
      {8, 4, 2, 4}};
    */

    int[,] numbers = createArray2Dimensional();
    ShowArray2Dimensional(numbers);
    Console.WriteLine("");
    Console.Write("----------------");
    BubbleSort(numbers);
    ShowArray2Dimensional(numbers);

    static int[,] createArray2Dimensional()
    {
      Random rnd = new Random();
      int countRow = rnd.Next(3, 10);
      int countCol = rnd.Next(4, 10);
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

    static void BubbleSort(int[,] array)
    {
      int countRows = array.GetLength(0);
      int countColumns = array.GetLength(1);

      for (int n = 0; n < countRows; n++)
      {
        for (int i = 0; i < countColumns; i++)
        {
          for (int j = 0; j < countColumns - 1 - i; j++)
          {
            if (array[n, j] > array[n, j + 1])
            {
              int temp = array[n, j];
              array[n, j] = array[n, j + 1];
              array[n, j + 1] = temp;
            }
          }
        }
      }
    }
  }
  public static void Task56()
  {
    /*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    */
    Console.WriteLine("Запущено задание 56. Строка с наименьшей суммой элементов");

    int[,] numbers = createArray2Dimensional();
    ShowArray2Dimensional(numbers);
    Console.WriteLine();
    Console.WriteLine($"{SearchMinSum(numbers)} строка");


    static int[,] createArray2Dimensional()
    {
      Random rnd = new Random();
      int countEl = rnd.Next(3, 4);
      int[,] numbers = new int[countEl, countEl];

      for (int i = 0; i < countEl; i++)
      {
        for (int j = 0; j < countEl; j++)
        {
          numbers[i, j] = rnd.Next(0, 10);
        }
      }
      return numbers;
    }

    int SearchMinSum(int[,] array)
    {
      int[] sums = new int[array.GetLength(0)];

      for (int i = 0; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum += array[i, j];
        }
        sums[i] = sum;
      }

      int result = sums[0];
      int min = -1;
      for (int i = 0; i < sums.Length; i++)
      {
        if (result > sums[i])
        {
          min = i + 1;
          result = sums[i];
        }
      }

      return min;
    }
  }
  public static void Task58()
  {
    /*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, заданы 2 массива:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    и
    1 5 8 5
    4 9 4 2
    7 2 2 6
    2 3 4 7
    Их произведение будет равно следующему массиву:
    1 20 56 10
    20 81 8 6
    56 8 4 24
    10 6 24 49
    */
    Console.WriteLine("Запущено задание 56. Произведение матриц");
  }
  public static void Task60()
  {
    /*
    Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    массив размером 2 x 2 x 2
    12(0,0,0) 22(0,0,1)
    45(1,0,0) 53(1,0,1)
    */
    Console.WriteLine("Запущено задание 60. Трехмерный массив");
  }
  public static void Task62()
  {
    /*
    Задача 62. Заполните спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7
    */
    Console.WriteLine("Запущено задание 62. Спиральное заполнение");
  }
  static void ShowArray2Dimensional(int[,] array)
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