namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao = 'S';
            do
            {
                Console.Clear();

                Console.WriteLine("-- Verificação de triângulos --,");

                Console.WriteLine("digite o primeiro segmento: ");
                Triangulos.x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite o segundo segmento: ");
                Triangulos.y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite o terceiro segmento: ");
                Triangulos.z = Convert.ToInt32(Console.ReadLine());



                if (Triangulos.TrianguloPodeSerCriado(Triangulos.x, Triangulos.y, Triangulos.z) == false)
                {
                    Console.WriteLine("Por favor digite uma opção válida");
                }

                Triangulos.TipoTriangulo(Triangulos.x, Triangulos.y, Triangulos.z);

                Console.WriteLine("Deseja continuar (S/N)");
                opcao = char.Parse(Console.ReadLine());

            } while (opcao != 'N' || opcao != 'n');
        }
    }

    public static class Triangulos
    {
        public static double x;
        public static double y;
        public static double z;

        public static bool TrianguloPodeSerCriado(double x, double y, double z)
        {
            if (x < y + z && y < x + z && z < x + y)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static void TipoTriangulo(double x, double y, double z)
        {
            Console.Write("Triângulo ");

            if (x != y && y != z && z != x)
            {
                Console.WriteLine("Escaleno");
            }
            else if (x == y && y == z && z == x)
            {
                Console.WriteLine("Equilátero");
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine("Isósceles");
            }
            
        }
    }
}
