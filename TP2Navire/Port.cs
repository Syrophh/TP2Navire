using System;
using System.Collections.Generic;
using System.Text;

namespace Navire.Classesmetier
{
    class Port
    {

        private readonly string nom;
        private int nbNaviresMax = 5;
        private Dictionary<string, Navire> navires;
        
        //constructeur
        public Port(string nom)
        {
            this.nom = nom;
            navires = new Dictionary<string, Navire>();
        }

        // Methods
        public void EnregistrerArrivee(Navire navire)
        {
            if (this.navires.Count < this.nbNaviresMax)
            {
                this.navires.Add(navire.Imo,navire);
            }
            else
            {
                throw new Exception("Ajout impossible, le port est complet");
            }
        }

        private int RecupPosition(Navire navire)
        {
            //return this.RecupPosition(navire.Imo);
            if (this.navires.Contains(navire))
            {
                return this.navires.IndexOf(navire);
            }
            else
            {
                return -1;
            }
        }

        public void EnregistrerDepart(String imo)
        {
            int index = this.RecupPosition(imo);
            if (index >= 0)
            {
                // le navire est présent dans le port
                this.navires.RemoveAt(index);
            }
            else
            {
                // le navire n'est pas dans le port
                throw new Exception("impossible d'enregistrer le départ du navire " + imo + ", il n'est pas dans le port ");
            }
        }

        public bool EstPresent(String imo)
        {
            return this.RecupPosition(imo) >= 0;
        }

    }
}

