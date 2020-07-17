using System.Drawing;
using System.Linq;
using Console = Colorful.Console;

namespace SuperApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var chars = "This is SuperApp sample to show your skills in DevOps".ToArray();
            Console.WriteWithGradient(chars, Color.Orange, Color.Green, 14);
            Console.ReadLine();
        }
    }
}