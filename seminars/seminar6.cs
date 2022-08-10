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

    Console.Write("Введите количество чисел: ");
    int count = Convert.ToInt16(Console.ReadLine());

    EnterCountNumbers(count);
    // ShowResult();

    int EnterCountNumbers(int count)
    {
      int[] numbers = new int[count];
      int result = 0;

      for (int i = 0; i < count; i++)
      {
        Console.Write($"Число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] > 0) result++;
      }

      return result;
    }

    static void ShowResult()
    {

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