namespace Seminar1
{
  // Start the app and propose to choose the task
  class TaskSelector
  {
    public static void launchTask()
    {
      Console.Write("Выберите задание первого семинара (доступно: 2, 4, 6, 8): ");
      switch (Console.ReadLine())
      {
        case "2":
          Console.WriteLine();
          Tasks.task2();
          break;

        case "4":
          Console.WriteLine();
          Tasks.task4();
          break;

        case "6":
          Console.WriteLine();
          Tasks.task6();
          break;

        case "8":
          Console.WriteLine();
          Tasks.task8();
          break;

        default:
          Console.WriteLine("Задания с таким номером нет.");
          break;
      }
    }
  }
  class Tasks
  {
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

      Console.WriteLine("max = " + numbers.Max());
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
        Console.WriteLine("Нет (число нечетное)");
        return;
      }
      Console.WriteLine("Да (число четное)");
    }
    public static void task8()
    {
      /*
      Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
      5 -> 2, 4
      8 -> 2, 4, 6, 8
      */
      Console.WriteLine("Запущено задание 8. Вывод четных чисел от 1 до N");
      Console.Write("Введите число N: ");
      int n = Convert.ToInt32(Console.ReadLine());

      // Т.к. в задании указано "ДО N", то N не выводится.
      if (n >= 2)
      {
        for (int i = 2; i < n; i += 2)
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
}