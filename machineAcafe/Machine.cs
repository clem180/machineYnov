using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machineAcafe
{
    public class Machine
    {
        public int money = 0;
        public bool gobeletInserer = false;
        public bool produitAcheter = false;
        public Produit produit;

        public Machine()
        {
            produit = new Produit();
        }

        public Produit boutonPressé()
        {
            if (gobeletInserer)
            {
                this.produit.gobelet = false;
                this.produit.produitSelectionner = 1;
            }
            else
            {
                this.produit.gobelet = true;
                this.produit.produitSelectionner = 1;
            }
            produitAcheter = true;
            return produit;
        }
        public void ajoutSucre()
        {
            if(this.produit.sucre < 10)
            {
                this.produit.sucre++;
            }
        }
        public void diminutionSucre()
        {
            if (this.produit.sucre > 0)
            {
                this.produit.sucre--;
            }
        }
    }
}
