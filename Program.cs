executor();

// Start the app and propose to choose the task
static void executor()
{
  Console.Write("Выберите задание (доступно: 2, 4, 6, 8): ");
  switch (Console.ReadLine())
  {
    case "2":
      task2();
      break;

    case "4":
      task4();
      break;

    case "6":
      break;

    case "8":
      break;

    default:
      Console.WriteLine("Задания с таким номером нет.");
      break;
  }
}

static void task2()
{
  /*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
  Console.WriteLine();
  Console.WriteLine("Запущено задание 2");
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


static void task4()
{
  /*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

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