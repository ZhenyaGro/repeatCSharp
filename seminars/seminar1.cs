class Seminar1 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, method> tasks { get; } = new Dictionary<int, method>(){
    {2, new method(task2)},
    {4, new method(task4)},
    {6, new method(task6)},
    {8, new method(task8)}
  };
  protected internal override string genitiveSemNum { get; } = "первого";

  public static void task2()
  {
    /*
  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
  a = 5; b = 7 -> max = 7
  a = 2 b = 10 -> max = 10
  a = -9 b = -3 -> max = -3
  */
    Console.WriteLine("Запущено задание 2. Поиск максимального и минимального чисел");
    Console.Write("Введите первое число: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    if (firstNum > secondNum)
      Console.WriteLine($"max = {firstNum}\nmin = {secondNum}");
    if (secondNum > firstNum)
      Console.WriteLine($"max = {secondNum}\nmin = {firstNum}");
    if (secondNum == firstNum)
      Console.WriteLine("Числа равны.");
  }

  public static void task4()
  {
    /*
  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
  2, 3, 7 -> 7
  44 5 78 -> 78
  22 3 9 -> 22
  */
    Console.WriteLine("Запущено задание 4. Поиск максимального числа");
    Console.Write("Введите три числа через пробел: ");
    int[] numbers = new int[3];
    try
    {
      string[] userAnswer = Console.ReadLine().Split(" ");

      // Is it really has no method to push element into arrays in C#?
      for (int i = 0; i < 3; i++)
        numbers[i] = Convert.ToInt32(userAnswer[i]);
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
      if (numbers[i] > max)
        max = numbers[i];
    }

    Console.WriteLine("max = " + max);
  }

  public static void task6()
  {
    /*
    Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
    */
    Console.WriteLine("Запущено задание 6. Проверка четности числа");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToBoolean(number % 2))
    {
      Console.WriteLine("Нет, не является четным");
      return;
    }
    Console.WriteLine("Да, является четным");
  }
  public static void task8()
  {
    /*
    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
    */
    Console.WriteLine("Запущено задание 8. Вывод четных чисел от 1 до N");
    Console.Write("Введите число N (больше чем 1): ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n >= 2)
    {
      for (int i = 2; i <= n; i += 2)
      {
        Console.Write(i + " ");
      }
    }
    else
    {
      Console.WriteLine("Некорректный ввод");
    }
  }
}