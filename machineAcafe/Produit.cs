using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineAcafe
{
    public class Produit
    {
        public int produitSelectionner = 0;
        public bool gobelet = true;
        public int sucre = 0;

        public Produit()
        {

        }
        public Produit(int produitSelectionner, bool gobelet, int sucre)
        {
            this.produitSelectionner = produitSelectionner;
            this.gobelet = gobelet;
            this.sucre = sucre;
        }
    }
}
