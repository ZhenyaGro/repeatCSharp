class Seminar3 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, task> tasks { get; } = new Dictionary<int, task>(){
    {19, new task(task19)},
    {21, new task(task21)},
    {23, new task(task23)}
  };
  protected internal override string genitiveSemNum { get; } = "третьего";

  // Tasks
  public static void task19()
  {
    /*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
    */
    Console.WriteLine("Запущено задание 19. Число-палиндром");

    Console.Write("Введите пятизначное число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    int oldValue = number;
    int newValue = 0;
    while (number > 0)
    {
      int dig = number % 10;
      newValue = newValue * 10 + dig;
      number = number / 10;
    }
    if (newValue == oldValue) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
  }
  public static void task21()
  {
    /*
    Задача 21
    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
    */
    Console.WriteLine("Запущено задание 21. Расстояние в пространстве");

    int aX, aY, aZ, bX, bY, bZ;
    try
    {
      Console.WriteLine("Введите координаты точки A");
      Console.Write("X: ");
      aX = Convert.ToInt32(Console.ReadLine());
      Console.Write("Y: ");
      aY = Convert.ToInt32(Console.ReadLine());
      Console.Write("Z: ");
      aZ = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Введите координаты точки B");
      Console.Write("X: ");
      bX = Convert.ToInt32(Console.ReadLine());
      Console.Write("Y: ");
      bY = Convert.ToInt32(Console.ReadLine());
      Console.Write("Z: ");
      bZ = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("Некорректный ввод");
      return;
    }

    double distance = Math.Sqrt(Math.Pow((bX - aX), 2) + Math.Pow((bY - aY), 2) + Math.Pow((bZ - aZ), 2));

    Console.WriteLine(Math.Round(distance, 2));
  }
  public static void task23()
  {
    /*
    Задача 23
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
    */
    Console.WriteLine("Запущено задание 23. Кубы до числа");

    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine($"| {i} | {i * i * i,3} |");
    }
  }
}
