using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjagedogpartmcgsm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nome:Maria cecilia gomes da silva madalena
            // Nome dos participantes:Maria cecilia ,Taina,Melissa.
            {
                while (true)
                {

                    Console.Clear();
                  
                    Console.SetCursorPosition(22, 10);

                    Console.WriteLine("Selecione o porte do cachorro:");
                    Console.SetCursorPosition(22, 11);
                    Console.WriteLine("1 - Pequeno (até 14kg)");
                    Console.SetCursorPosition(22, 12);
                    Console.WriteLine("2 - Médio (15kg a 25kg)");
                    Console.SetCursorPosition(22, 13);
                    Console.WriteLine("3 - Grande (a partir de 25kg)");
                    Console.SetCursorPosition(22, 14);
                    Console.WriteLine("4 - Mostrar Raças pequenas");
                    Console.SetCursorPosition(22, 15);
                    Console.WriteLine("5 - Mostrar Raças grandes");
                    Console.SetCursorPosition(22, 16);
                    Console.WriteLine("6- Mostrar Raças medias");

                    Console.SetCursorPosition(22, 17);
                    Console.WriteLine("7- Sair");
                    Console.SetCursorPosition(22, 18);
                    Console.WriteLine("Selecione a opção");
                    Console.SetCursorPosition(22, 19);
                    Console.WriteLine("Digite a idade do cachorro em anos:");

                    int escolhaPorte = int.Parse(Console.ReadLine());
                    double multiplicador = 0;

                    switch (escolhaPorte)
                    {
                        case 1:
                            multiplicador = 12.5;
                            break;
                        case 2:
                            multiplicador = 10.5;
                            break;
                        case 3:
                            multiplicador = 9.0;
                            break;
                        case 4:
                            MostrarRacasP();
                            break;
                        case 5:
                            //  MostrarRacasG();
                            break;
                        case 6:
                            //   MostrarRacasM();
                            break;
                        case 7:
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção de porte inválida.");
                            break;
                    }


                    int idadeCachorro = int.Parse(Console.ReadLine());

                    double idadeHumana = CalcularIdadeCao(idadeCachorro, multiplicador);

                    Console.WriteLine($"A idade do seu cachorro em idade canina é aproximadamente: {idadeHumana:F2} anos.");
                    Console.ReadKey();
                }
            }
            //Nome:Maria cecilia gomes da silva madalena
            static double CalcularIdadeCao(int idade, double multiplicador)
            {
                if (idade == 1)
                {
                    return idade * multiplicador;
                }
                else if (idade >= 3)
                {
                    // Cálculo para anos após o terceiro ano de vida
                    double anosExtras = 0;
                    if (multiplicador == 12.5)
                    {
                        anosExtras = (idade - 2) * 4.5; // Para cães pequenos
                    }
                    else if (multiplicador == 10.5)
                    {
                        anosExtras = (idade - 2) * 6.0; // Para cães médios
                    }
                
                else
                {
                    return idade * multiplicador;
                }
            }
            //Nome:Maria cecilia gomes da silva madalena
            static void MostrarRacasP()
            {
                Console.Clear();

                Console.SetCursorPosition(22, 10);
                Console.WriteLine("Raças de cachorros de porte pequeno:");
                Console.WriteLine("- Pinscher (adorável :) )");
                Console.WriteLine("- Beagle");
                Console.WriteLine("- Chihuahua");
                Console.WriteLine("- Dachshund (Cofap, sal)");
                Console.WriteLine("- Bulldog");
                Console.WriteLine("- Jack Russell Terrier");
                Console.WriteLine("- Lhasa Apso");
                Console.WriteLine("- Lulu da Pomerânia");
                Console.WriteLine("- Pug");
                Console.WriteLine("- Shih Tzu");
                Console.WriteLine("- Toy Poodle");
                Console.WriteLine("- West Highland White Terrier");
            }
        }



















        }
    }
}
