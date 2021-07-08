using System;

namespace calculodesempenho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cálculo de Desempenho (Km/L)\nInforme a quantidade de semanas em que deseja saber o desempenho do seu veículo: ");
            int semanas = Int32.Parse(Console.ReadLine());

            double litros, km, litrostotal, kmtotal, medias, mediat;
            litros = 0; km = 0; litrostotal = 0; kmtotal = 0; medias = 0; mediat = 0;

            for (int contador = 1; contador <= semanas; contador++)
            {
                Console.Write("Informe a quantidade de quilômetros rodados na " + contador + "ª semana: ");
                km += Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a quantidade de litros abastecida na " + contador + "ª semana: ");
                litros += Convert.ToDouble(Console.ReadLine());
                litrostotal += litros;
                kmtotal += km;
                medias = km / litros;
                Console.Write("O desempenho do seu veículo na " +contador+ "ª semana foi de: "+Math.Round(medias, 2)+" Km/L.\n\n");
                litros = 0; km = 0;
            }

            mediat = kmtotal / litrostotal;
            Console.WriteLine("O desempenho médio do seu veículo foi de: "+Math.Round(mediat, 2)+" Km/L.");

        }
    }
}
