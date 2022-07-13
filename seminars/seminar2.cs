namespace Seminar2
{
  // Start the app and propose to choose the task
  class TaskSelector
  {
    public static void launchTask()
    {
      Console.Write("Выберите задание второго семинара (доступно: 10, 13, 15): ");
      switch (Console.ReadLine())
      {
        case "10":
          Console.WriteLine();
          Tasks.task10();
          break;

        case "13":
          Console.WriteLine();
          Tasks.task13();
          break;

        case "15":
          Console.WriteLine();
          Tasks.task15();
          break;

        default:
          Console.WriteLine("Задания с таким номером нет.");
          break;
      }
    }
  }
  class Tasks
  {
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
      Console.WriteLine("Запущено задание 15. Проверка выходного");
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
}