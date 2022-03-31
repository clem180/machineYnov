using Microsoft.VisualStudio.TestTools.UnitTesting;
using machineAcafe;

namespace testMachineACafe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAchatProduit()
        {
            Machine machine = new Machine();

            machine.money = 40;
            Produit produit = machine.boutonPressé();
            
            if(produit.produitSelectionner == 0 || !machine.produitAcheter)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestAchatProduitAvecGobelet()
        {
            Machine machine = new Machine();

            machine.money = 40;
            machine.gobeletInserer = true;

            Produit produit = machine.boutonPressé();

            if (produit.gobelet)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestAjoutSucre()
        {
            Machine machine = new Machine();

            machine.money = 40;
            machine.gobeletInserer = true;

            int oldSucre = machine.produit.sucre;
            machine.ajoutSucre();
            int newSucre = machine.produit.sucre;
            if ((oldSucre >= newSucre && oldSucre < 10) || (oldSucre == 10 && oldSucre != newSucre))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestDiminutionSucre()
        {
            Machine machine = new Machine();

            machine.money = 40;
            machine.gobeletInserer = true;

            int oldSucre = machine.produit.sucre;
            machine.diminutionSucre();
            int newSucre = machine.produit.sucre;
            if ((oldSucre <= newSucre && oldSucre > 0) || (oldSucre == 0 && oldSucre != newSucre))
            {
                Assert.Fail();
            }
        }
    }
}