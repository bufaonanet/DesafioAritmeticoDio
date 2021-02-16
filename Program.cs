using System;
using System.Globalization;

namespace DesafioAritmetico
{

    class Program
    {
        static void Main(string[] args)
        {
            Ex01Media();
            //Ex02CrescimentoPopulacional();
            //Ex03Bazinga();
            //Ex04TempoDeUmEvento()
            //Ex05ComunicacaoEmPiralandia();

            System.Console.ReadKey();
        }

        private static void Ex05ComunicacaoEmPiralandia()
        {
            string n = Console.ReadLine();

            char[] arr = n.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                System.Console.Write(arr[i]);
            }
        }
        public static void  Ex04TempoDeUmEvento()
        {
            int diaInicio, diaTermino, horaMomentoInicio, horaMomentoTermino;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);


            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);

            int transformaSegundosInicio = RetornaTotalSegundos(dadosMomentoInicio, diaInicio);
            int transformaSegundosTermino = RetornaTotalSegundos(dadosMomentoTermino, diaTermino);

            var arrayDiferencaData = RetornaDiferencaHoraFormatada(
                transformaSegundosInicio, transformaSegundosTermino
            );

            Console.WriteLine("{0} dia(s)", arrayDiferencaData[0]);
            Console.WriteLine("{0} hora(s)", arrayDiferencaData[1]);
            Console.WriteLine("{0} minuto(s)", arrayDiferencaData[2]);
            Console.WriteLine("{0} segundo(s)", arrayDiferencaData[3]);
        }
        public static int RetornaTotalSegundos(string[] tempo, int dia)
        {
            int hora = Convert.ToInt32(tempo[0]);
            int minuto = Convert.ToInt32(tempo[2]);
            int segundos = Convert.ToInt32(tempo[4]);

            int totalSegundosPorHora = hora * 3600;
            int totalSegundosPorMinuto = minuto * 60;

            int totalSegundosPorDia = dia * 86400;

            var totalSegundos = totalSegundosPorDia +
                totalSegundosPorHora + totalSegundosPorMinuto + segundos;

            return totalSegundos;
        }
        public static string[] RetornaDiferencaHoraFormatada(int inicio, int fim)
        {
            var diferencaMomentos = fim - inicio;

            var dia = diferencaMomentos / 86400;
            if (dia > 0) diferencaMomentos = diferencaMomentos % (dia * 86400);

            var hora = diferencaMomentos / 3600;
            if (hora > 0) diferencaMomentos = diferencaMomentos % (hora * 3600);

            var minutos = diferencaMomentos / 60;
            if (minutos > 0) diferencaMomentos = diferencaMomentos % (minutos * 60);

            var segundos = diferencaMomentos;

            string[] arrayDiferencaData = {
                dia.ToString(),
                hora.ToString(),
                minutos.ToString(),
                segundos.ToString()
            };

            return arrayDiferencaData;
        }
        public static void Ex01Media()
        {
            double A;
            double B;
            double media = 0;
            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pesoNotaA = (3.5 / 11) * A;
            double pesoNotaB = (7.5 / 11) * B;
            media += pesoNotaA + pesoNotaB;

            Console.WriteLine($"MEDIA = {(string.Format("{0:0.00000}", media))}");
        }
        public static void  Ex02CrescimentoPopulacional()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();

                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                //declare as variaveis corretamente
                cpa = double.Parse(valores[2], CultureInfo.InvariantCulture);
                cpa /= 100;

                cpb = double.Parse(valores[3], CultureInfo.InvariantCulture);
                cpb /= 100;

                while (pa <= pb)
                {
                    pa += (int)(pa * cpa);
                    pb += (int)(pb * cpb);

                    anos++;

                    if (anos > 100)
                    {
                        break;
                    }
                }

                if (anos <= 100)
                {
                    System.Console.WriteLine($"{anos} anos");
                }
                else
                {
                    System.Console.WriteLine("Mais de 1 século");
                }

            }
        }
        public static void Ex03Bazinga()
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];

                if ((v1.Equals("tesoura") && v2.Equals("papel")) ||
                    (v1.Equals("papel") && v2.Equals("pedra")) ||
                    (v1.Equals("pedra") && v2.Equals("lagarto")) ||
                    (v1.Equals("lagarto") && v2.Equals("Spock")) ||
                    (v1.Equals("Spock") && v2.Equals("tesoura")) ||
                    (v1.Equals("tesoura") && v2.Equals("lagarto")) ||
                    (v1.Equals("lagarto") && v2.Equals("papel")) ||
                    (v1.Equals("papel") && v2.Equals("Spock")) ||
                    (v1.Equals("Spock") && v2.Equals("pedra")) ||
                    (v1.Equals("pedra") && v2.Equals("tesoura"))
                )
                    Console.WriteLine("Caso #{0}: Bazinga!", i);

                else if ((v1.Equals("tesoura") && v2.Equals("tesoura")) ||
                        (v1.Equals("papel") && v2.Equals("papel")) ||
                        (v1.Equals("pedra") && v2.Equals("pedra")) ||
                        (v1.Equals("lagarto") && v2.Equals("lagarto")) ||
                        (v1.Equals("Spock") && v2.Equals("Spock")) ||
                        (v1.Equals("tesoura") && v2.Equals("lagarto"))
                )
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

        }

    }
}
