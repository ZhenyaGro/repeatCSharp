namespace Seminar3
{
  class TaskSelector
  {
    public static void launchTask()
    {
      Console.Write("Выберите задание третьего семинара (доступно: 19, 21, 23): ");
      switch (Console.ReadLine())
      {
        case "19":
          Console.WriteLine();
          // Tasks.task19();
          break;

        case "21":
          Console.WriteLine();
          // Tasks.task21();
          break;

        case "23":
          Console.WriteLine();
          // Tasks.task23();
          break;

        default:
          Console.WriteLine("Задания с таким номером нет.");
          break;
      }
    }
    class Tasks
    {
      public static void task19()
      {
        /*
        Задача 19
        Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        12821 -> да
        23432 -> да
        */
      }
      public static void task21()
      {
        /*
        Задача 21
        Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53
        */
      }
      public static void task23()
      {
        /*
        Задача 23
        Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        3 -> 1, 8, 27
        5 -> 1, 8, 27, 64, 125
        */
      }
    }
  }
}