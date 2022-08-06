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

    int[] array = new int[4];
    Random rnd = new Random();
    int countEven = 0;

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.Next(100, 1000);
      Console.Write($"{array[i]}");
      if (i != array.Length - 1)
        Console.Write(", ");

      if (array[i] % 2 == 0)
        countEven++;
    }
    Console.WriteLine($"] -> {countEven}");
  }
  public static void Task36()
  {
    /*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
    */

    Console.WriteLine("Запущено задание 36. Сумма элементов на нечетных позициях (по индексу)");

    int[] array = new int[4];
    Random rnd = new Random();
    int sum = 0;

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.Next(-100, 101);
      Console.Write($"{array[i]}");
      if (i != array.Length - 1)
        Console.Write(", ");
    }

    for (int i = 1; i < array.Length; i += 2)
      sum += array[i];

    Console.Write($"] -> {sum}");
  }
  public static void Task38()
  {
    /*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
    */
    Console.WriteLine("Запущено задание 38. Разница вещественных чисел");

    double[] array = new double[4];
    Random rnd = new Random();
    double difference = 0;

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.NextDouble() * 101;
      Console.Write($"{Math.Round(array[i], 2)}");
      if (i != array.Length - 1)
        Console.Write(", ");
    }

    double min = array[0];
    double max = array[0];
    double temp;

    for (int i = 0; i < array.Length; i++)
    {
      if (max < array[i]) max = array[i];
      if (min > array[i]) min = array[i];
    }

    difference = max - min;

    Console.WriteLine($"] -> {Math.Round(difference, 2)}");
  }
}
