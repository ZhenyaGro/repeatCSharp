class Seminar4 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, task> tasks { get; } = new Dictionary<int, task>(){
    {25, new task(task25)},
    {27, new task(task27)},
    {29, new task(task29)}
  };
  protected internal override string genitiveSemNum { get; } = "четвертого";

  // Tasks
  public static void task25()
  {
    /*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
    */
    Console.WriteLine("Запущено задание 25. Число в степени");

    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a;

    for (int i = 0; i < b - 1; i++)
    {
      result *= a;
    }

    Console.WriteLine(result);
  }
  public static void task27()
  {
    /*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
    */
    Console.WriteLine("Запущено задание 27. Сумма цифр числа");

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int digit = 0;
    int sum = 0;
    while (number > 0)
    {
      digit = number % 10;
      number /= 10;
      sum += digit;
    }

    Console.WriteLine(sum);
  }
  public static void task29()
  {
    /*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
    псевдослучайными числами и выводит их на экран.
    1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
    */
    Console.WriteLine("Запущено задание 29. Массив случайных чисел");

    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
      array[i] = rnd.Next(0, 101);
      Console.Write($"{array[i]} ");
    }
  }
}
