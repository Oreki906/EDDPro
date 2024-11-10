using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class Pilas

    {
        public Nodo Top;
        public void Push(int Dato)
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = Dato;//asignar al nuevo nodo 
            Nuevo.Sig = null;// el siguinte es null

            //metodo if 
            if (Top == null)//si la pila esta vacia 
            {
                Top = Nuevo;//el nuevo nodo es el tope de la pila
            }
            else
            {
                Nodo Aux = Top;
                Top = Nuevo;
                Top.Sig = Aux;
            }
        }
        public int Pop()
        {
            if (Top == null)
            {
                MessageBox.Show("pila vasia");
                return -1;
            }
            else
            {
                Nodo Aux = Top;
                int Dato = Aux.Dato;
                Top = Top.Sig;
                Dato = Aux.Dato;
                Aux = null;
                return Dato;
            }
        }
        public int conta()
        {
            int cont = 0;
            Nodo nodo = Top;
            while (nodo != null)
            {
                cont++;
                nodo = nodo.Sig;
            }
            return cont;
        }
        public void buscar()
        {
            Nodo act = new Nodo();
            act = Top;
            bool enc = false;
            int valor;
            int.TryParse(txtDatos.Text, out valor);
            if (Top != null)
            {
                while (act != null && enc != true)
                {
                    if (act.Dato == valor)
                    {
                        MessageBox.Show("el nodo con el dato " + valor + " fue encontrado");
                        enc = true;
                    }
                    act = act.Sig;
                }
                if (!enc)
                {
                    MessageBox.Show("no encontrado");
                }
            }
            else
            {
                MessageBox.Show("la pila se encuentra vacia");
            }
        }
    }
}
