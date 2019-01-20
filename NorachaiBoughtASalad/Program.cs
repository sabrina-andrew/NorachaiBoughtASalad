using System;

namespace NorachaiBoughtASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            //After paying \$5.12 for a salad, Norachai has 27.10. How much money did he have before buying the salad?

            decimal salad = 5.12M;
            decimal has = 27.10M;
            decimal had = has - salad;
            Console.WriteLine("Before buying the salad, Norachai had $" + had + " in his wallet.");
        }
    }
}
