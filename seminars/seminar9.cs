class Seminar9 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {64, new Task(Task64)},
    {66, new Task(Task66)},
    {68, new Task(Task68)}
  };
  protected internal override string genitiveSemNum { get; } = "девятого";

  // Tasks
  public static void Task64()
  {
    /*
    Задача 64: Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    */
    Console.WriteLine("Запущено задание 64. Числа от N до 1");

    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 2;
    PrintNumber(n, count);
    Console.Write(1);

    void PrintNumber(int n, int count)
    {
      if (count > n) return;
      PrintNumber(n, count + 1);
      Console.Write(count + ", ");
    }
  }
  public static void Task66()
  {
    /*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    */
    Console.WriteLine("Запущено задание 66. Сумма натуральных элементов");

    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp = m;

    if (m > n)
    {
      m = n;
      n = temp;
    }

    PrintSumm(m, n, temp = 0);

    void PrintSumm(int m, int n, int sum)
    {
      sum += n;
      if (n <= m)
      {
        Console.Write($"Сумма элементов = {sum}");
        return;
      }
      PrintSumm(m, n - 1, sum);
    }
  }
  public static void Task68()
  {
    /*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 3, n = 2 -> A(m,n) = 29
    */
    Console.WriteLine("Запущено задание 68. Функция Аккремана");


    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int functionAkkerman = Akkerman(m, n);

    Console.Write(functionAkkerman);

    int Akkerman(int m, int n)
    {
      if (m == 0) return n + 1;
      else if (n == 0) return Akkerman(m - 1, 1);
      else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
  }
}