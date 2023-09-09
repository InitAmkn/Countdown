namespace CountdownDLL
{
    public class Controller
    {
        public void Execute()
        {
            int i = 100;
            while (i > 0)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
                i--;
            }
        }
    }
}