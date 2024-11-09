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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Pila pila= new Pila();//instancia de Pila 
            pila.FormClosed += (s, args) => this.Show();//muestra form1 al cerrar Pila 
            pila.Show();//muestra Pila 
            this.Hide();//oculta Form1
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
           Cola cola= new Cola();//instancia de la cola
            cola.FormClosed+=(s,args)=> this.Show();//muestra form 1 al cerrar la cola 
            cola.Show();//muetra cola
            this.Hide();//oculta form 1
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btListsimp_Click(object sender, EventArgs e)
        {
            Listsimp lis = new Listsimp();
            lis.FormClosed+=(s,args)=> this.Show();
            lis.Show();
            this.Hide();
        }

        private void btListdou_Click(object sender, EventArgs e)
        {
            ListDobl li= new ListDobl();
            li.FormClosed+=(s,args)=> this.Show();
            li.Show();
            this.Hide();

        }

        private void btCirSimp_Click(object sender, EventArgs e)
        {
            circsimp ci= new circsimp();
            ci.FormClosed += (s, args) => this.Show();
            ci.Show();
            this.Hide();
        }

        private void btcitcdoubl_Click(object sender, EventArgs e)
        {
            listcircdoubl dou = new listcircdoubl();
            dou.FormClosed+=(s, args) => this.Show();
            dou.Show();
            this.Hide();
        }
    }
}
