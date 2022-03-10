using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataFinito
{
    internal class Logica
    {
        private StringBuilder palabra = new StringBuilder();

        private Nodo q0;
        private Nodo q1;
        private Nodo q2;
        private Nodo q3;
        private Nodo q4;
        public int pos = 0;

        public Logica()
        {
        }

        public Logica(string palabra)
        {
            this.palabra = new StringBuilder(palabra);

            inicio();
        }

        private void inicio()
        {
            if (palabra.Equals("") || palabra.Equals(" "))
            {
                MessageBox.Show("la palabra que se envio fue nula o vacia");
            }
            else
            {
                crearNodos();
                procesoiterativo(palabra);
            }
        }

        public void procesoiterativo(StringBuilder palabra)
        {
            int i = 0;
            Nodo temp = q0;
            while (i != palabra.Length)
            {
                switch (palabra[i])
                {
                    case 'a':
                        temp = temp.getA();

                        break;

                    case 'b':
                        temp = temp.getB();
                        break;
                }
                i++;
            }
            if (temp.aceptado())
            {
                MessageBox.Show("palabra aceptada");
            }
            else MessageBox.Show("Palabra no aceptada :C");
            pos = Convert.ToInt32(temp.retornarnombre());
        }

        private void crearNodos()
        {
            //inicio los nodos
            q0 = new Nodo();
            q1 = new Nodo();
            q2 = new Nodo();
            q3 = new Nodo();
            q4 = new Nodo();

            //creo las conexiones entre los nodos

            q0.setA(q1);
            q0.setB(q2);
            q0.nombre("0");

            q1.setA(q3);
            q1.setB(q2);
            q1.nombre("1");

            q2.setA(q1);
            q2.setB(q2);
            q2.nombre("2");

            q3.setA(q3);
            q3.setB(q4);
            q3.nombre("3");

            q4.setA(q3);
            q4.setB(q4);
            q4.nombre("4");

            //asignamos si los nodos si terminan en ellos son palabras aceptadas
            q0.siAceptar();
            q1.siAceptar();
            q2.siAceptar();
            q3.siAceptar();
        }
    }
}