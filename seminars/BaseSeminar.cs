class BaseSeminar
{
  protected internal delegate void method();
  protected internal virtual Dictionary<int, method> tasks { get; } = new Dictionary<int, method>() { };

  protected internal virtual string genitiveSemNum { get; } = "";
}