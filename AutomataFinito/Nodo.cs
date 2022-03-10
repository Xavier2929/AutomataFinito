using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataFinito
{
    internal class Nodo
    {
        private Nodo a;
        private Nodo b;
        private string lbl = "";

        private bool aceptar = false;

        public Nodo()
        { }

        public void setA(Nodo a)
        { this.a = a; }

        public void setB(Nodo b)
        { this.b = b; }

        public Nodo getA()
        {
            return a;
        }

        public Nodo getB()
        {
            return b;
        }

        public void siAceptar()
        {
            aceptar = true;
        }

        public bool aceptado()
        {
            return aceptar;
        }

        public void nombre(string lbl)
        {
            this.lbl = lbl;
        }

        public string retornarnombre()
        {
            return lbl;
        }
    }
}