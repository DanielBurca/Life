using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life_Engine;

namespace ProvaLifeConsole
{
    class Program
    {
        public static void ScorriEScriviCella(Tabella grid)
        {
            char cella = ' ';
            for (int i = 0; i < grid.Celle.GetLength(0); i++)
            {
                for (int j = 0; j < grid.Celle.GetLength(1); j++)
                {
                    VerificaEScriviCella(grid.Celle[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void VerificaEScriviCella(bool cella)
        {
            char caratterecella = ' ';
            if (cella)
                caratterecella = 'x';
            else
                caratterecella = '.';
            Console.Write(caratterecella);
        }
        static void Main(string[] args)
        {
            int n = 3;
            char[,] tabellalife = new char[n, n];
            Tabella grid = new Tabella(n, n);
            Cellula cellula = new Cellula();

            Tabella gridris = grid;

            for (int i = 0; i < 10; i++)
            {
                ScorriEScriviCella(gridris);
                grid = gridris;
                gridris = cellula.VerificaCelle(grid);
            }

            #region Roba Vecchia
            //for (int i = 0; i < tabellalife.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabellalife.GetLength(1); j++)
            //    {
            //        if (gridris.Celle[i, j])
            //            tabellalife[i, j] = 'x';
            //        else
            //            tabellalife[i, j] = '.';
            //        Console.Write(tabellalife[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            //grid = gridris;

            //gridris = cellula.VerificaCelle(grid);
            //for (int i = 0; i < tabellalife.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabellalife.GetLength(1); j++)
            //    {
            //        if (gridris.Celle[i, j])
            //            tabellalife[i, j] = 'x';
            //        else
            //            tabellalife[i, j] = '.';
            //        Console.Write(tabellalife[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            //grid = gridris;

            //gridris = cellula.VerificaCelle(grid);
            //for (int i = 0; i < tabellalife.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabellalife.GetLength(1); j++)
            //    {
            //        if (gridris.Celle[i, j])
            //            tabellalife[i, j] = 'x';
            //        else
            //            tabellalife[i, j] = '.';
            //        Console.Write(tabellalife[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            //grid = gridris;

            //gridris = cellula.VerificaCelle(grid);
            //for (int i = 0; i < tabellalife.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabellalife.GetLength(1); j++)
            //    {
            //        if (gridris.Celle[i, j])
            //            tabellalife[i, j] = 'x';
            //        else
            //            tabellalife[i, j] = '.';
            //        Console.Write(tabellalife[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            //grid = gridris;

            //gridris = cellula.VerificaCelle(grid);
            //for (int i = 0; i < tabellalife.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabellalife.GetLength(1); j++)
            //    {
            //        if (gridris.Celle[i, j])
            //            tabellalife[i, j] = 'x';
            //        else
            //            tabellalife[i, j] = '.';
            //        Console.Write(tabellalife[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            #endregion

            Console.Read();
        }
    }
}
