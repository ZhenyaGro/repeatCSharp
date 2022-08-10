class Seminar6 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {41, new Task(Task41)},
    {43, new Task(Task43)}
  };
  protected internal override string genitiveSemNum { get; } = "шестого";

  // Tasks
  public static void Task41()
  {
    /*
    Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
    */
    Console.WriteLine("Запущено задание 41. Числа больше нуля");

    int[] numbers = CreateArray();
    int count = CountNumbers(numbers);
    ShowResult(numbers, count);

    int[] CreateArray()
    {
      Console.WriteLine("Введите числа массива через пробел:");

      // string separator = ", ";

      string[] userAnswer = Console.ReadLine().Split(" ");
      int[] numbers = new int[userAnswer.Length];

      try
      {
        for (int i = 0; i < userAnswer.Length; i++)
          numbers[i] = Convert.ToInt32(userAnswer[i]);
      }
      catch
      {
        Console.WriteLine("Некорректный ввод");
        return null;
      }

      return numbers;
    }

    int CountNumbers(int[] array)
    {
      int count = 0;

      foreach (int number in array)
        if (number > 0) count++;

      return count;
    }

    static void ShowResult(int[] array, int result)
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
  public static void Task43()
  {
    /*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    */

    Console.WriteLine("Запущено задание 43. Точка пересечения прямых");

  }
}