using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_PatikafyMuzikPlatformu
{
    internal class Patikafy
    {
        public string TamAD { get; set; }
        public string Tur { get; set; }
        public int Yil { get; set; }
        public int Satis { get; set; }

        public Patikafy(string tamAD , string tur, int yil , int satis) 
        { 
            TamAD = tamAD;
            Tur = tur;
            Satis = satis;
            Yil = yil;

        }
    }
}
