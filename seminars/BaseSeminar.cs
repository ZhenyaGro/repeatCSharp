class BaseSeminar
{
  protected internal delegate void Task();
  protected internal virtual Dictionary<int, Task> tasks { get; } = new Dictionary<int, Task>() { };

  protected internal virtual string genitiveSemNum { get; } = "";
}