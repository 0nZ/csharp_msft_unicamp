using System;
namespace Jewel_Collector 
{
    public class Map
    {

        public void PrintMap()
        {

            // add object
            //mapa[2, 3] = " ## ";
            int colunas = 10;
            int linhas = 10;
            string[,] mapa = new string[colunas, linhas];

            // espaços vazios
            for (int x = 0; x < colunas; x++)
            {
                for (int y = 0; y < linhas; y++)
                {
                    mapa[x, y] = " -- ";
                }
            }

            // desenha o mapa
            for (int y = 0; y < linhas; y++)
            {
                for (int x = 0; x < colunas; x++)
                {
                    Console.Write(mapa[x, y]);
                }
                Console.WriteLine();
            }

        }

        public void add_obstacle() 
        {
            Console.Write("Adiciona Obstaculo.");
        }
    }
}
