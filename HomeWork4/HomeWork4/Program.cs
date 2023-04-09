using HomeWork4;

public static class Program
{
    public static void Main()
    {
        Counter counter = new Counter();
        Handler1 handler1 = new Handler1();
        Handler2 handler2 = new Handler2();

        counter.Notify += handler1.Message;
        counter.Notify += handler2.Message;

        counter.Count();
    }
}
