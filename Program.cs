selectLesson();

// Start the app and propose to choose the task
static void selectLesson()
{
  Console.WriteLine("На данный момент доступны только задания первого семинара.");
  Console.WriteLine();

  Seminar1.TaskSelector.launchTask();
}