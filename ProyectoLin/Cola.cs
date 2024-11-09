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
    public partial class Cola : Form
    {
        private Nodo primero;
        private Nodo ultimo;
        public Cola()
        {
            InitializeComponent();
            
        }
        private void enqueue(int Dato) {
            Nodo Nuevo = new Nodo();//instancia
            Nuevo.Dato = Dato;//asignar al nuevo nodo 
            Nuevo.Sig = null;// el siguinte es null
            if (ultimo == null)
            {
                ultimo = Nuevo;
                primero = Nuevo;
            }
            else {
                ultimo.Sig = Nuevo;
                ultimo=Nuevo ;
                    }
            
        }

        private void btEncolar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(cbDatos.Text, out valor))//asegura que el dato sea de tiop int 
            {
                enqueue(valor);
                Imprecion.Items.Add(valor);
            }
            else
            {
                MessageBox.Show("se requiere ingresar un numero");
            }

            cbDatos.Text = "";//blanquea el ingreso de los dATOS 
            cbDatos.Focus();//para no volver a hacer clic eb la barra 
        }
        private int Dequeue() {
            if (primero == null )
            {
                MessageBox.Show("Cola vasia");
                return -1;
            }
            else {
                Nodo Aux = primero;
                primero = Aux.Sig;
                int Dato= Aux.Dato;
                Aux = null;
                if (primero == null) {
                    ultimo = null;
                }
                return Dato;
            }
        }

        private void btDesencolar_Click(object sender, EventArgs e)
        {
            int valor = Dequeue();
            if (valor != -1)
            {
                MessageBox.Show("se a eliminado");
                if (Imprecion.Items.Count > 0)
                {
                    Imprecion.Items.RemoveAt(0);
                }
            }
            //por si cren que no funciona
            //Imprecion.Items.Add(valor);
        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            primero = null;
            ultimo= null;
            MessageBox.Show("se a vasiado ");
            Imprecion.Items.Clear();

        }
        public int conta()
        {
            int cont = 0;
            Nodo nodo = primero;
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
            act = primero ;
            bool enc = false;
            int valor;
            int.TryParse(cbDatos.Text, out valor);
            if (primero != null)
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
                MessageBox.Show("la cola se encuentra vacia");
            }
        }
        private void btContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + conta() + " datos");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            cbDatos.Text = "";//blanquea el ingreso de los dATOS 

            cbDatos.Focus();//para no volver a hacer clic eb la barra 
        }
    }


   
}
