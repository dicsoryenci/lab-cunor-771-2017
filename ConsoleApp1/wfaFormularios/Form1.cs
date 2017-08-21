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
    }
}
