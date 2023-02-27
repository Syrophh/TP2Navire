using System;
using System.Collections.Generic;
using System.Text;

namespace Navire.Classesmetier
{
    class Navire
    {
        private readonly string imo;
        private readonly string nom;
        private string libelleFret;
        private int qteFretMaxi;

        public Navire(string imo, string nom, string libelleFret, int qteFretMaxi)
        {
            this.imo = imo;
            this.nom = nom;
            this.libelleFret = libelleFret;
            this.qteFretMaxi = qteFretMaxi;
        }
        public Navire(string imo, string nom) : this(imo, nom, "Indéfini", 0) { }

        public string Imo => imo;

        public string Nom => nom;
        public string LibelleFret { get => libelleFret; set => libelleFret = value; }
        public int QteFretMaxi { get => qteFretMaxi; set => qteFretMaxi = value; }

        public override String ToString()
        {
            String Message = "Identification \t: " + this.imo;
            Message += "\nNom :\t" + this.nom;
            Message += "\nType de frêt :\t" + this.libelleFret;
            Message += "\nQuantité de Frêt : \t" + this.qteFretMaxi;
            Message += "\n-------------------------------\n";
            return Message;
        }
    }
}
