namespace HomeWork4
{
    public class Counter
    {
        public delegate void Notifier(int value);
        public event Notifier? Notify;
        public int value = 77;
        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == value)
                {
                    Notify?.Invoke(value);
                }
            }
        }
    }
}
