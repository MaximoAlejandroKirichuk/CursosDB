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

        private ProspectoBLL prospectoBLL = new ProspectoBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = 2003.32m;
            var cursoNuevo = new Curso("Coaching", "algo muy mono", DateTime.Now, true, a, "categoria1", 2);

            if (!cursoBLL.Agregar(cursoNuevo))
            {
                MessageBox.Show("Ocurrio un error");
                return;
            }
            ActualizarDGV();
        }

        private void ActualizarDGV()
        {
            dataGridViewCursos.DataSource = null;
            dataGridViewCursos.DataSource = cursoBLL.ListarTodos();
        }
        private void ActualizarDGVProspectos(int idCurso)
        {
            dataGridViewProspectos.DataSource = null;
            dataGridViewProspectos.DataSource = prospectoBLL.ListarProspectosPorCurso(idCurso);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCursos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un curso.");
                    return;
                }

                Curso curso = dataGridViewCursos.CurrentRow.DataBoundItem as Curso;

                if (!cursoBLL.Borrar(curso.IdCurso))
                    throw new Exception("Error al borrar");

                MessageBox.Show("Borrado correctamente");
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al borrar: " + ex.Message);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCursos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un curso.");
                    return;
                }

                // Recupero el objeto asociado a la fila seleccionada
                Curso curso = dataGridViewCursos.CurrentRow.DataBoundItem as Curso;

                if (curso == null)
                {
                    MessageBox.Show("No se pudo obtener el curso seleccionado.");
                    return;
                }
                var cursoModificado = new Curso(curso.IdCurso, "LOL", "gg", DateTime.Now, true, 123m, "categoria2", 24);
                var respuesta = cursoBLL.Modificar(cursoModificado);
                if (!respuesta) throw new Exception("Ocurrio un error");
                MessageBox.Show("Curso modificado correctamente.");
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar: " + ex.Message);
            }
        }

        private void btnAgregarPropectos_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridViewCursos.CurrentRow.Cells.Count < 0) throw new Exception("Seleccione un curso antes");
                Curso curso = dataGridViewCursos.CurrentRow.DataBoundItem as Curso;
                Prospecto nuevoProspecto = new Prospecto("Tomás Silva", 26, "tomas.sil@gmail.com", "11-9988-7766",
                          "React + APIs", DateTime.Now.AddDays(-15), false,
                          "Vio la publicidad en Instagram.", curso.IdCurso);
                var respuesta = prospectoBLL.Agregar(nuevoProspecto);

                if (!respuesta) throw new Exception("Error al agregar nuevo prospecto");
                ActualizarDGVProspectos(curso.IdCurso);
                MessageBox.Show("Agregado nuevo curso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void btnProspectosBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count == 0)
                MessageBox.Show("Seleccione un curso a exportar");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count < 0)
            {
                MessageBox.Show("Seleccione un curso a exportar");
                return;
            }
            try
            {
                Curso curso = dataGridViewCursos.CurrentRow.DataBoundItem as Curso;
                curso.Prospectos = prospectoBLL.ListarProspectosPorCurso(curso.IdCurso);
                SaveFileDialog ofd = new SaveFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    cursoBLL.ExportarCurso(curso, ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
