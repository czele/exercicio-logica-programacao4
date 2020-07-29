using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iremos solucionar uma equação de segundo grau! (ax² + bx + c)");

            Console.WriteLine("Insira o valor de A:");
            double va = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de B:");
            double vb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor de C:");
            double vc = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Sqrt((vb * vb) - 4 * (va * vc));
            double equation1 = (-vb + delta) / (2 * va);
            double equation2 = (-vb - delta) / (2 * va);

            if (Double.IsNaN(delta) || delta < 0)
            {
                Console.WriteLine("O 'X' não possuí raiz.");
            }
            else
            {
                if (delta == 0)
                {
                    Console.WriteLine($"O 'X' possuí a raiz {equation1}.");
                }
                if (delta > 0)
                {
                    Console.WriteLine($"O 'X' possuí as raizez {equation1} e {equation2}.");
                }
            }

            
        }
    }
}
