class Seminar8 : BaseSeminar
{
  // Info about the tasks
  protected internal override Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>(){
    {54, new Task(Task54)},
    {56, new Task(Task56)},
    {58, new Task(Task58)},
    {60, new Task(Task60)}
  };
  protected internal override string genitiveSemNum { get; } = "восьмого";

  // Tasks
  public static void Task54()
  {
    /*
    */
    Console.WriteLine("Запущено задание 54. ");

  }
  public static void Task56()
  {
    /*
    */
    Console.WriteLine("Запущено задание 56. ");

  }
  public static void Task58()
  {
    /*
    */
    Console.WriteLine("Запущено задание 56. ");
  }
  public static void Task60()
  {
    /*
    */
    Console.WriteLine("Запущено задание 60. ");
  }
}