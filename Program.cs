selectLesson();

// Start the app and propose to choose the task
static void selectLesson()
{
  // Available seminars
  // int[] seminars = new int[3] { 1, 2, 3 };
  List<BaseSeminar> seminars = new List<BaseSeminar>() {
    new Seminar1(),
    new Seminar2(),
    new Seminar3()
    };

  // Choose the seminar
  Console.WriteLine($"Введите номер семинара запускаемых заданий (доступно: 1 - {seminars.Count})");
  int userAnswer = Convert.ToInt16(Console.ReadLine());

  // Show seminar's available tasks
  if (seminars.Count >= userAnswer && userAnswer > 0) launchTask(seminars[userAnswer - 1]);
  else Console.WriteLine("Некорректный ввод");
}

static void launchTask(BaseSeminar seminar)
{
  Console.Write($"Выберите задание {seminar.genitiveSemNum} семинара (доступно: {string.Join(", ", seminar.tasks.Keys)}): ");
  var method = seminar.tasks.GetValueOrDefault(Convert.ToInt16(Console.ReadLine()));
  if (method != null)
  {
    Console.WriteLine();
    method();
  }
  else Console.WriteLine("Задания с таким номером нет.");
}