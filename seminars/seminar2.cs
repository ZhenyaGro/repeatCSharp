class Seminar2 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, task> tasks { get; } = new Dictionary<int, task>(){
    {10, new task(task10)},
    {13, new task(task13)},
    {15, new task(task15)}
  };
  protected internal override string genitiveSemNum { get; } = "второго";
  public static void task10()
  {
    /*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
    */
    Console.WriteLine("Запущено задание 10. Вывод второй цифры трехзначного числа");
    Console.Write("Введите трехзначное число: ");
    int userAnswer = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (userAnswer <= 99 || userAnswer >= 1000)
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    Console.WriteLine(userAnswer / 10 % 10);
  }
  public static void task13()
  {
    /*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
    */
    Console.WriteLine("Запущено задание 13. Вывод третьей цифры числа");
    Console.Write("Введите число: ");
    int userAnswer = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (userAnswer < 100)
    {
      Console.WriteLine("Третьей цифры нет");
      return;
    }

    while (userAnswer / 10 >= 100) userAnswer /= 10;
    Console.WriteLine(userAnswer % 10);
  }
  public static void task15()
  {
    /*
    Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
    */
    Console.WriteLine("Запущено задание 15. Проверка выходного дня");
    Console.Write("Введите день недели: ");
    int userAnswer = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (userAnswer > 7 || userAnswer < 1)
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    if (userAnswer == 6 || userAnswer == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
  }
}