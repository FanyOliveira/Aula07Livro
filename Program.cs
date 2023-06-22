using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Livro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Livro - Página 77

            int numero;


            Console.WriteLine("Escolha um número:");
            numero = int.Parse(Console.ReadLine());

            if ( numero > 100 )
            {
                numero = numero + 150;
            }

            Console.WriteLine($"O número é: {numero}");

            Console.ReadKey();

            // Livro - Página 81

            string nome;
            int media;

            Console.WriteLine("Confira aqui, se conseguiu ter uma boa média no final do bimestre: ");
            Console.WriteLine("Primeiro, digite o seu primeiro e segundo nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua média: ");
            media = int.Parse(Console.ReadLine());

            if ( media >= 6 )
            {
                Console.WriteLine($"O aluno {nome} está aprovado!");
            }
            else
            {
                Console.WriteLine("Você foi reprovado!");
            }
            Console.ReadKey();

            // Livro - Página 84

            int nota1;
            int nota2;
            int media_final;

            Console.WriteLine("Digita a sua primeira média: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora, digite a sua segunda nota: ");
            nota2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua média é: ");
            media_final = (nota1 + nota2) / 2;

            if ( media_final > 6 )
            {
                Console.WriteLine("Média superior á média mínima (6,0), Aprovado!");
            }
            else
            {
                Console.WriteLine("Média inferior á média mínima (6,0), Reprovado!");
            }

            // Livro - Página 87

            int nota_1;
            int nota_2;
            int nota_3;
            int nota_maior;

            Console.WriteLine("digite a sua primeira média: ");
            nota_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a segunda média: ");
            nota_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a terceira média: ");
            nota_3 = int.Parse(Console.ReadLine());
            

            if ( nota_1 > nota_2 && nota_1 > nota_3 )
            {
                Console.WriteLine($"A maior nota é {nota_maior}");                       

            }
                













        }
    }
}
