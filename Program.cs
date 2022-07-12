selectLesson();

// Start the app and propose to choose the task
static void selectLesson()
{
  Console.WriteLine("Доступны задания первого и второго семинаров.\nВведите номер семинара запускаемых заданий (цифрой 1 или 2)");
  switch (Console.ReadLine())
  {
    case "1":
      Seminar1.TaskSelector.launchTask();
      break;

    case "2":
      Seminar2.TaskSelector.launchTask();
      break;

    default:
      Console.WriteLine("Некорректный ввод");
      break;
  }
}