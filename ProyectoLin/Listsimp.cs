using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLin
{
    public partial class Listsimp : Form
    {
        private Nodo inicio;
        private Nodo fin;
        public Listsimp()
        {
            InitializeComponent();
         
        }
        private void insertar(int Dato, int posicion) {
            Nodo Nuevo = new Nodo();//instancia
            Nuevo.Dato = Dato;//asignar al nuevo nodo 
            Nuevo.Sig = null;// el siguinte es null
            if (inicio == null && fin==null) {
                inicio = Nuevo;
                fin = Nuevo;
                return;
            }
            if (posicion == 0 || posicion == 1) {
                Nuevo.Sig = inicio;
                inicio = Nuevo;
                return ;
            }
            int pos = 1;
            Nodo Aux = inicio;
            Nodo previo = null;
            while (pos < posicion && Aux != null) {
                previo = Aux;
                Aux = Aux.Sig;
                pos++;
            }
            if (Aux != null)
            {
                Nuevo.Sig = Aux;
                previo.Sig = Nuevo;
            }
            else {
                fin.Sig = Nuevo;
                fin= Nuevo;
            }
            return;
        }
        private void ver()
        {
            Imprecion.Items.Clear(); // Limpia 
            Nodo actual = inicio;

            while (actual != null)
            {
                Imprecion.Items.Add(actual.Dato); // Añade el valor
                actual = actual.Sig; // Pasa al siguiente
            }
        }
        private void btIncertP_Click(object sender, EventArgs e)
        {
            int valor;
            int x;
            if (int.TryParse(cbDato.Text, out valor) && int.TryParse(cbPosicion.Text, out x))//asegura que el dato sea de tiop int 
            {
                insertar(valor,x);
                ver();
            }
            else
            {
                MessageBox.Show("se requiere ingresar un dato y una posision");
            }

            cbDato.Text = "";//blanquea el ingreso de los dATOS 
            cbPosicion.Text = "";
            cbDato.Focus();//para no volver a hacer clic eb la barra 
        }

        private void cbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int eliminar(int posicion)
        {
            if (inicio == null && fin == null)
            {
                MessageBox.Show("lista vasia");
                return -1;


            }


            int pos = 1;
            Nodo Aux = inicio;
            Nodo prev = null;
            int Dato;
            while (pos < posicion && Aux != null)
            {
                if (Aux.Sig != null)
                {
                    prev = Aux;
                    Aux = Aux.Sig;
                }
                else
                {
                    Aux = null;
                }
                pos++;
            }
            if (Aux != null)
            {
                if (Aux == fin)
                {
                    fin = prev;
                    if (prev != null)
                    {
                        prev.Sig = null;
                    }

                }
                else
                {
                    if (prev != null)
                    {
                        prev.Sig = Aux.Sig;
                    }
                    else
                    {
                        inicio = Aux.Sig;
                    }
                }
                Dato = Aux.Dato;
                Aux = null;
                return Dato;
            }
            else {
                MessageBox.Show("no lo encontramos");
                return 0;
            }
        }

        private void btElimP_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(cbPosicion.Text, out x))
            {
                int eliminado = eliminar(x);
                if (eliminado != 0)
                {
                    MessageBox.Show("dato eliminda");
                    ver();
                }
            }
            else {
                MessageBox.Show("ingresa una posision");
            }
            cbPosicion.Text = "";
            cbPosicion.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int conta()
        {
            if (inicio == null)
            {
                MessageBox.Show("la lista esta vacia");
                return 0;
            }
            int cont = 0;
            Nodo nodo = inicio;
            while (nodo != null)
            {
                cont++;
                nodo = nodo.Sig;
            }
            return cont;
        }

        private void btvaciar_Click(object sender, EventArgs e)
        {
            inicio=null;
            fin=null;  
            Imprecion.Items.Clear();
            MessageBox.Show("la lista fue vaciada");
        }
        public void buscar()
        {
            Nodo act = new Nodo();
            act = inicio;
            bool enc = false;
            int valor;
            int.TryParse(cbDato.Text, out valor);
            if (inicio != null)
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
                MessageBox.Show("la lista se encuentra vacia");
            }
            
        }
        private void btContar_Click(object sender, EventArgs e)
        {
            conta();
            MessageBox.Show("hay " + conta() + " datos");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            cbDato.Text = "";//blanquea el ingreso de los dATOS 
            cbPosicion.Text = "";
            cbDato.Focus();//para no volver a hacer clic eb la barra 
        }
    }
}
