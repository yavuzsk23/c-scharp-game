namespace games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
            Console.Write("1. what is capital of germany?");
            string s1 = Console.ReadLine();
            if (s1.ToLower() == "berlin") correct++;
            Console.Write("2. 5*6");
            string s2 = Console.ReadLine();
            if (s2  == "30 ")  correct++;
            Console.Write("3. data type in c#");
            string s3 = Console.ReadLine();
            if (s3.ToLower() == "string") correct++;

        }
    }

}
