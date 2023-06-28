using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtId;
        private string ogrtAd;
        private int ogrtBrans;

        public int OgrtId { get => ogrtId; set => ogrtId = value; }
        public string OgrtAd { get => ogrtAd; set => ogrtAd = value; }
        public int OgrtBrans { get => ogrtBrans; set => ogrtBrans = value; }
    }
}
