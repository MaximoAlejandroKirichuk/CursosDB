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
    public partial class UserControl1 : UserControl, IObservador
    {
        public UserControl1()
        {
            InitializeComponent();
            cursoBLL?.AgregarSuscriptor(this);
        }
       
        private CursoBLL cursoBLL = new CursoBLL();
      
        public void Actualizar()
        {
            dataGridViewC.DataSource = null;
            dataGridViewC.DataSource = cursoBLL.ListarTodos();
            MessageBox.Show("Factura importada y actualizado por Observer");
        }


        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    cursoBLL.ImportarCurso(ofd.FileName);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al importar: " + ex.Message);
            }
        }
    }
}
