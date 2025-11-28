using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CursoBLL cursoBLL = new CursoBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = 2003.32m;
            var cursoNuevo = new Curso("Coaching","algo muy mono",DateTime.Now,true,a,"categoria1",2);

            if (! cursoBLL.Agregar(cursoNuevo))
                MessageBox.Show("Ocurrio un error");
        }

        private void ActualizarDGV()
        {
            dataGridViewCursos.DataSource = null;
            dataGridViewCursos.DataSource = cursoBLL.ListarTodos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }
    }
}
