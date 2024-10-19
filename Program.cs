namespace ExtraCredit1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 6; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
