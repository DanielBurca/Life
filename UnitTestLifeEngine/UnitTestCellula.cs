using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Life_Engine;

namespace UnitTestLifeEngine
{
    [TestClass]
    public class UnitTestCellula
    {
        [TestMethod]
        public void TestMethodVerificaCella()
        {
            Cellula cellula = new Cellula();
            Tabella grid = new Tabella(3, 3);
            grid = cellula.VerificaCelle(grid);
            bool[,] ris = new bool[3, 3];
            ris[0, 0] = true;
            ris[0, 1] = true;
            ris[0, 2] = false;
            ris[1, 0] = true;
            ris[1, 1] = true;
            ris[1, 2] = false;
            ris[2, 0] = false;
            ris[2, 1] = false;
            ris[2, 2] = false;
            CollectionAssert.AreEqual(ris, grid.Celle, "Metodo 'VerificaCelle' non riuscito");
        }
    }
}
