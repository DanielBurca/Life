using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Engine
{
    public class Tabella
    {
        public bool[,] Celle { get; set; }

        public Tabella(int x, int y) 
        {
            Random generatore = new Random();
            Celle = new bool[x,y];
            for (int i = 0; i < Celle.GetLength(0); i++)
            {
                for (int j = 0; j < Celle.GetLength(1); j++)
                {
                    if(generatore.Next()%2 == 0)
                        Celle[i, j] = true;
                    else
                        Celle[i, j] = false;
                }
            }
            //Celle[1, 0] = true;
            //Celle[1, 1] = true;
            //Celle[1, 2] = true;
            //Celle[1, 3] = true;
        }
    }

}
