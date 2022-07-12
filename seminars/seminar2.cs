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
      string userAnswer = Console.ReadLine();

      if (userAnswer.Length != 3)
      {
        Console.WriteLine("Некорректный ввод");
        return;
      }

      int[] numbers = new int[3];
      for (int i = 0; i < 3; i++)
      {
        numbers[i] = Convert.ToInt32(userAnswer.Split(""));
      }

      Console.WriteLine(numbers[2]);
    }
    public static void task13()
    {
      /*
      Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
      645 -> 5
      78 -> третьей цифры нет
      32679 -> 6
      */
    }
    public static void task15()
    {
      /*
      Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
      6 -> да
      7 -> да
      1 -> нет
      */
    }
  }
}