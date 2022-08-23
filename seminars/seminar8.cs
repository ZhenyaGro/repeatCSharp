class Seminar8 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {54, new Task(Task64)},
    {56, new Task(Task56)},
    {58, new Task(Task58)},
    {60, new Task(Task60)},
    {62, new Task(Task62)}
  };
  protected internal override string genitiveSemNum { get; } = "восьмого";

  // Tasks
  public static void Task64()
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
    ShowArray2D(numbers);
    Console.WriteLine("");
    Console.Write("----------------");
    BubbleSort(numbers);
    ShowArray2D(numbers);

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

    int[,] numbers = createRectangularMatrix();
    ShowArray2D(numbers);
    Console.WriteLine();
    Console.WriteLine($"{SearchMinSum(numbers)} строка");

    static int[,] createRectangularMatrix()
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
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          currentSum += array[i, j];
        }

        sums[i] = currentSum;
      }

      int result = sums[0];
      int min = 1;
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
    Console.WriteLine("Запущено задание 58. Произведение матриц");

    int[,] firstMatrix = createRectangularMatrix();
    int[,] secondMatrix = createRectangularMatrix();

    /*
    int[,] firstMatrix = {
      {1, 4, 7, 2},
      {5, 9, 2, 3},
      {8, 4, 2, 4},
      {5, 2, 6, 7}};
    int[,] secondMatrix = {
      {1, 5, 8, 5},
      {4, 9, 4, 2},
      {7, 2, 2, 6},
      {2, 3, 4, 7}};
    */

    Console.WriteLine("Первая матрица: ");
    ShowArray2D(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("\nВторая матрица: ");
    ShowArray2D(secondMatrix);

    int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);

    Console.WriteLine();
    Console.WriteLine("\nПроизведение матриц:");
    ShowArray2D(result);

    int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
      int countRowsFirst = firstMatrix.GetLength(0);
      int countColumnsFirst = firstMatrix.GetLength(1);
      int countRowsSecond = secondMatrix.GetLength(0);
      int countColumnsSecond = secondMatrix.GetLength(1);

      if (countColumnsFirst != countRowsSecond)
      {
        Console.WriteLine("Умножение невозможно");
        return null;
      }
      else
      {
        int[,] resultMatrix = new int[countRowsFirst, countColumnsSecond];
        for (int i = 0; i < countRowsFirst; i++)
        {
          for (int j = 0; j < countColumnsSecond; j++)
          {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < countColumnsFirst; k++)
            {
              resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
          }
        }

        return resultMatrix;
      }
    }
    static int[,] createRectangularMatrix()
    {
      Random rnd = new Random();
      int countEl = rnd.Next(3, 4);
      int[,] matrix = new int[countEl, countEl];

      for (int i = 0; i < countEl; i++)
      {
        for (int j = 0; j < countEl; j++)
        {
          matrix[i, j] = rnd.Next(0, 10);
        }
      }
      return matrix;
    }
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
    Console.WriteLine();

    int[,,] array3D = CreateArray3D();
    ShowArray3D(array3D);

    void ShowArray3D(int[,,] array3D)
    {
      for (int i = 0; i < array3D.GetLength(0); i++)
      {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
          // Console.Write($"X({i}) Y({j}) ");
          for (int k = 0; k < array3D.GetLength(2); k++)
          {
            Console.Write($"{array3D[i, j, k]}({i}, {j}, {k}) ");
          }
          Console.WriteLine();
        }
        Console.WriteLine();
      }
    }

    int[,,] CreateArray3D()
    {
      int[] temp = new int[8];
      int number;
      int[,,] resultArray = new int[2, 2, 2];

      for (int i = 0; i < temp.Length; i++)
      {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
          for (int j = 0; j < i; j++)
          {
            while (temp[i] == temp[j])
            {
              temp[i] = new Random().Next(10, 100);
              j = 0;
              number = temp[i];
            }
            number = temp[i];
          }
        }
      }
      int count = 0;
      for (int x = 0; x < 2; x++)
      {
        for (int y = 0; y < 2; y++)
        {
          for (int z = 0; z < 2; z++)
          {
            resultArray[x, y, z] = temp[count];
            count++;
          }
        }
      }

      return resultArray;
    }

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
    Console.WriteLine();

    int[,] sqareMatrix = new int[4, 4];

    int currentNumber = 1;
    int i = 0;
    int j = 0;

    while (currentNumber <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
      sqareMatrix[i, j] = currentNumber;
      currentNumber++;
      if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
      else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
      else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
      else
        i--;
    }

    ShowArray2D(sqareMatrix);
  }
  static void ShowArray2D(int[,] array)
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