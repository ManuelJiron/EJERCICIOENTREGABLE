using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_2_inventario
{
   
    
    public partial class Estudiante : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroEstudiante { get; set; }
        public string Carrera { get; set; }
        public double PromedioGeneral { get; set; }
        public int MateriasAprobadas { get; set; }

        private List<Estudiante> estudiantes = new List<Estudiante>();
        public Estudiante()
        {
            InitializeComponent();
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null; // Limpiar el DataGridView
            dataGridView1.DataSource = estudiantes; // Asignar la lista de estudiantes actualizada
        }

       
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indice = dataGridView1.SelectedRows[0].Index;

               
                estudiantes.RemoveAt(indice);

                
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                NumeroEstudiante = txtnumero.Text,
                Carrera = combobox.SelectedItem.ToString(),
                PromedioGeneral = double.Parse(txtpromedio.Text),
                MateriasAprobadas = int.Parse(txtmaterias.Text)
            };

           
            estudiantes.Add(estudiante);

            ActualizarDataGridView();

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indice = dataGridView1.SelectedRows[0].Index;

                // Modificar los datos del estudiante seleccionado con los valores de los controles
                estudiantes[indice].Nombre = txtnombre.Text;
                estudiantes[indice].Apellido = txtapellido.Text;
                estudiantes[indice].NumeroEstudiante = txtnumero.Text;
                estudiantes[indice].Carrera = combobox.SelectedItem.ToString();
                estudiantes[indice].PromedioGeneral = double.Parse(txtpromedio.Text);
                estudiantes[indice].MateriasAprobadas = int.Parse(txtmaterias.Text);

                // Actualizar el DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                NumeroEstudiante = txtnumero.Text,
                Carrera = combobox.SelectedItem.ToString(),
                PromedioGeneral = double.Parse(txtpromedio.Text),
                MateriasAprobadas = int.Parse(txtmaterias.Text)
            };


            estudiantes.Add(estudiante);

            ActualizarDataGridView();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtnumero.Clear();
            txtmaterias.Clear();
            txtpromedio.Clear();




        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("saliendo.....");
            Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indice = dataGridView1.SelectedRows[0].Index;

                // Modificar los datos del estudiante seleccionado con los valores de los controles
                estudiantes[indice].Nombre = txtnombre.Text;
                estudiantes[indice].Apellido = txtapellido.Text;
                estudiantes[indice].NumeroEstudiante = txtnumero.Text;
                estudiantes[indice].Carrera = combobox.SelectedItem.ToString();
                estudiantes[indice].PromedioGeneral = double.Parse(txtpromedio.Text);
                estudiantes[indice].MateriasAprobadas = int.Parse(txtmaterias.Text);

                // Actualizar el DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indice = dataGridView1.SelectedRows[0].Index;


                estudiantes.RemoveAt(indice);


                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                NumeroEstudiante = txtnumero.Text,
                Carrera = combobox.SelectedItem.ToString(),
                PromedioGeneral = double.Parse(txtpromedio.Text),
                MateriasAprobadas = int.Parse(txtmaterias.Text)
            };


            estudiantes.Add(estudiante);

            ActualizarDataGridView();
        
    }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indice = dataGridView1.SelectedRows[0].Index;


                estudiantes.RemoveAt(indice);


                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Obtén la celda seleccionada
                DataGridViewCell cell = dataGridView1.SelectedCells[0];

                // Puedes mostrar el valor de la celda en un cuadro de texto para editarlo
                string valorOriginal = cell.Value.ToString();

                // Aquí puedes poner un cuadro de texto o formulario para editar
                MessageBox.Show("Editando: " + valorOriginal);

                // Si estás editando directamente la celda:
                dataGridView1.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una celda para editar.");
            }
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("creado por isaac Mora y Manuel jiron");
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
