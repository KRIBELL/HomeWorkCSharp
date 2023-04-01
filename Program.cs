using HOMEWORK_4;

class Program
{
    static void Main(string[] args, ClassCounter counter)
    {
        ClassCounter Counter = new ClassCounter();
        Handler1 Handler1 = new Handler1();
        Handler2 Handler2 = new Handler2();

        Counter.Count += Handler1.Message;
        Counter.Count += Handler2.Message;
        Counter.Count();
    }
}
