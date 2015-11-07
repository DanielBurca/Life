using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Engine
{
    public class Cellula
    {
        public List<bool> Adiacenti { get; set; }
        
        public Cellula() { }

        public Tabella VerificaCelle(Tabella grid)
        {
            int contatore = 0;
            Tabella gridris = new Tabella(grid.Celle.GetLength(0), grid.Celle.GetLength(1));
            for (int i = 0; i < grid.Celle.GetLength(0); i++)
            {
                for (int j = 0; j < grid.Celle.GetLength(1); j++)
                {
                    VerificaCelleAdiacenti(i, j, grid, ref cont atore);
                    VerificaEAggiornaStatoCella(ref gridris.Celle[i, j], grid.Celle[i, j], contatore);
                    contatore = 0;
                }
            }
            return gridris;
        }
        private void VerificaSingolaCella(int i, int j, Tabella grid, ref int contatore)
        {
            try
            {
                if (grid.Celle[i, j])
                {
                    contatore++;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void VerificaEAggiornaStatoCella(ref bool cellaris, bool cella, int contatore)
        {
            if (contatore == 3)
                cellaris = true;
            if (contatore != 2 && contatore != 3)
                cellaris = false;
            if (contatore == 2)
                cellaris = cella;
        }

        private void VerificaCelleAdiacenti(int i, int j, Tabella grid, ref int contatore)
        {
            VerificaSingolaCella(i - 1, j - 1, grid, ref contatore);
            VerificaSingolaCella(i - 1, j, grid, ref contatore);
            VerificaSingolaCella(i - 1, j + 1, grid, ref contatore);
            VerificaSingolaCella(i, j + 1, grid, ref contatore);
            VerificaSingolaCella(i + 1, j + 1, grid, ref contatore);
            VerificaSingolaCella(i + 1, j, grid, ref contatore);
            VerificaSingolaCella(i + 1, j - 1, grid, ref contatore);
            VerificaSingolaCella(i, j - 1, grid, ref contatore);
        }
    }
}
