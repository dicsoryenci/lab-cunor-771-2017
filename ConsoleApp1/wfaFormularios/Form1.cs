using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFormularios
{
    public partial class Form1 : Form
    {
        static List<Persona> personas = new List<Persona>();
        static Persona tmp;
        static int tmpInx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que permite agregar personas a una lista
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        /// <param name="direccion">Dirección de la persona</param>
        static void agPersona(string nombre, string apellido, int edad, string direccion)
        {
            Persona p = new Persona();
            p.nombres = nombre;
            p.apellidos = apellido;
            p.edad = edad;
            p.direccion = direccion;
            personas.Add(p);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            agPersona(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), txtDireccion.Text);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "0";
            txtDireccion.Text = "";
            gvPersonas.DataSource = null;
            gvPersonas.DataSource = personas;
            foreach (var item in personas)
            {
                System.Diagnostics.Debug.Print(item.nombres);
            }
        }

        private void gvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void gvPersonas_Click(object sender, EventArgs e)
        {

        }

        private void gvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se utiliza el parametro "e" para extraer el índice de la fila. 
            int indx = e.RowIndex;
            //Almacenamos temporalmente el índice de la lista
            tmpInx = indx;
            if (indx >= 0) {
                //Sabiendo el indice actual de la fila, le asignamos al objeto temporal tmp
                //Un objeto que se encuentra en una posición X en la lista
                tmp = personas.ElementAt<Persona>(indx);
                txtNombre.Text = tmp.nombres;
                txtApellido.Text = tmp.apellidos;
                txtEdad.Text = "" + tmp.edad;
                txtDireccion.Text = tmp.direccion;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tmp != null) {
                //Para modificar, le asignamos directamente al objeto tmp 
                // los valores que queremos modificar.
                tmp.nombres = txtNombre.Text;
                tmp.apellidos = txtApellido.Text;
                tmp.edad = int.Parse(txtEdad.Text);
                tmp.direccion = txtDireccion.Text;

                gvPersonas.DataSource = null;
                gvPersonas.DataSource = personas;
                tmp = null;

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "0";
                txtDireccion.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                //Para eliminar, utilizamos el objeto temporal y el metodo remove.
                personas.Remove(tmp);
                gvPersonas.DataSource = null;
                gvPersonas.DataSource = personas;
                tmp = null;

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "0";
                txtDireccion.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para limpiar el listado, utilizamos el remove range, permite eliminar objetos de la 
            //lista por rangos.
            personas.RemoveRange(0, personas.Count);
            gvPersonas.DataSource = null;
            gvPersonas.DataSource = personas;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "0";
            txtDireccion.Text = "";
        }
    }
}
