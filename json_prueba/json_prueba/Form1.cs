using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class User
{
    public string nombre, email;
    public int edad;
    public User(string nombreU, int edadU, string emailU)
    {
        edad = edadU;
        nombre = nombreU;
        email = emailU;
    }
}
namespace json_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creamos una variable de tipo User
            // instanciamos un objeto nuevo con los parametros tipo string, int
            User usuario = new User(txtnombre.Text, Convert.ToInt32(txtEdad.Text));
            Console.WriteLine(usuario.nombre);
        }
    }
}
