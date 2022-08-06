class Seminar5 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {34, new Task(Task34)},
    {36, new Task(Task36)},
    {38, new Task(Task38)}
  };
  protected internal override string genitiveSemNum { get; } = "пятого";

  // Tasks
  public static void Task34()
  {
    /*
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
    */
    Console.WriteLine("Запущено задание 34. Четные числа в массиве случайных");

    int[] numbers = CreateArray2_0(34);
    int numberOfEven = CountEven(numbers);
    ShowResult2_0(numbers, numberOfEven);

    int CountEven(int[] array)
    {
      int counter = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 0)
          counter++;
      }

      return counter;
    }
  }
  public static void Task36()
  {
    /*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
    */

    Console.WriteLine("Запущено задание 36. Сумма элементов на нечетных позициях (по индексу)");

    int[] numbers = CreateArray2_0(36);
    int sum = CountSum(numbers);
    ShowResult2_0(numbers, sum);

    int CountSum(int[] array)
    {
      int sum = 0;
      for (int i = 1; i < array.Length; i += 2)
        sum += array[i];

      return sum;
    }
  }
  public static void Task38()
  {
    /*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
    */
    Console.WriteLine("Запущено задание 38. Разница вещественных чисел");

    // Executing
    double[] array = CreateArray();
    double difference = FindDifference(array);
    ShowResult(array, difference);

    // Methods
    double[] CreateArray()
    {
      double[] array = new double[4];
      for (int i = 0; i < array.Length; i++)
      {
        Random rnd = new Random();
        array[i] = rnd.NextDouble() * 101;
      }

      return array;
    }

    double FindDifference(double[] array)
    {
      double min = array[0];
      double max = array[0];

      for (int i = 0; i < array.Length; i++)
      {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
      }

      return max - min;
    }

    void ShowResult(double[] array, double difference)
    {
      Console.Write("[");
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{Math.Round(array[i], 2)}");
        if (i != array.Length - 1)
          Console.Write(", ");
      }
      Console.WriteLine($"] -> {Math.Round(difference, 2)}");
    }
  }

  static int[] CreateArray2_0(int startedTask)
  {
    Console.Write("Введите длину массива: ");
    int arrLength = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[arrLength];
    Random rnd = new Random();

    if (startedTask == 34)
    {
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = rnd.Next(100, 1000);
      }
    }

    if (startedTask == 36)
    {
      Console.WriteLine("Генерация случайных чисел");
      Console.Write("От: ");
      int rndMin = Convert.ToInt32(Console.ReadLine());
      Console.Write("До: ");
      int rndMax = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();

      for (int i = 0; i < array.Length; i++)
      {
        array[i] = rnd.Next(rndMin, rndMax);
      }
    }

    return array;
  }

  static void ShowResult2_0(int[] array, int result)
  {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"{array[i]}");
      if (i != array.Length - 1)
        Console.Write(", ");
    }
    Console.WriteLine($"] -> {result}");
  }
}