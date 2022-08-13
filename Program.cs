selectLesson();

// Start the app and propose to choose the task
static void selectLesson()
{
  // Available seminars
  List<BaseSeminar> seminars = new List<BaseSeminar>() {
    new Seminar1(),
    new Seminar2(),
    new Seminar3(),
    new Seminar4(),
    new Seminar5(),
    new Seminar6(),
    new Seminar7()
    };

  // Choose the seminar
  Console.WriteLine($"Введите номер семинара запускаемых заданий (доступно: 1 - {seminars.Count})");
  int userAnswer;
  try
  {
    userAnswer = Convert.ToInt16(Console.ReadLine());
  }
  catch (Exception)
  {
    Console.WriteLine("Некорректный ввод");
    return;
  }

  // Show seminar's available tasks
  if (seminars.Count >= userAnswer && userAnswer > 0) launchTask(seminars[userAnswer - 1]);
  else Console.WriteLine("Некорректный ввод");
}

static void launchTask(BaseSeminar seminar)
{
  Console.Write($"Выберите задание {seminar.genitiveSemNum} семинара (доступно: {string.Join(", ", seminar.tasks.Keys)}): ");
  var task = seminar.tasks.GetValueOrDefault(Convert.ToInt16(Console.ReadLine()));
  if (task != null)
  {
    Console.WriteLine();
    task();
  }
  else Console.WriteLine("Задания с таким номером нет.");
}