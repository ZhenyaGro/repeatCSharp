class BaseSeminar
{
  protected internal delegate void task();
  protected internal virtual Dictionary<int, task> tasks { get; } = new Dictionary<int, task>() { };

  protected internal virtual string genitiveSemNum { get; } = "";
}