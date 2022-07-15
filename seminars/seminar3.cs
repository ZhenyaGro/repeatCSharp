class Seminar3 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, method> tasks { get; } = new Dictionary<int, method>(){
    {19, new method(task19)},
    {21, new method(task21)},
    {23, new method(task23)}
  };
  protected internal override string genitiveSemNum { get; } = "третьего";

  // Tasks
  public static void task19()
  {
    Console.WriteLine("Seminar 3, task 19 - well done!");
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
