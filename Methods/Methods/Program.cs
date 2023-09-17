namespace Methdods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name? ");
            string name = Console.ReadLine();
            SayHi(name);
        }
        static void SayHi(string name){
            Console.WriteLine("Hello " + name);
        }
    }
}