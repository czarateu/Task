namespace WinFormsApp2
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

        private void agregar_Click(object sender, EventArgs e)

        //Mostrar un cuadro de entrada para añadir una nueva tarea.


        {
            string nuevaTarea = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la tarea:",
                "Agregar tarea", "");
            if (!string.IsNullOrEmpty(nuevaTarea))
            {
                //Añade una nueva tarea a la lista
                lsTareas.Items.Add(nuevaTarea);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (lsTareas.SelectedItem != null)
            {
                //Muestra cuadro de entrada para modificar la tarea seleccionada.
                string tareaEditada = Microsoft.VisualBasic.Interaction.InputBox("Edite la tarea:",
                    "Editar tarea:",
                    lsTareas.SelectedItem.ToString());
                if (!string.IsNullOrEmpty(tareaEditada))
                { //Reemplaza la tarea editada
                    int indice = lsTareas.SelectedIndex;
                    lsTareas.Items[indice] = tareaEditada;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar.",
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {

            if (lsTareas.SelectedItem != null)
            {
                //Confirmación de eliminación
                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta tarea?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    //Elimina la tarea seleccionada
                    lsTareas.Items.Remove(lsTareas.SelectedItem);
                }


            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void completada_Click(object sender, EventArgs e)
        {
            if (lsTareas.SelectedItem != null)
            {
                int indice = lsTareas.SelectedIndex;
                string tarea = lsTareas.SelectedItem.ToString();
                //Verifica si la tarea ya está marcada como completada
                if (!tarea.Contains("[Completada]"))
                {
                    //Marca la tarea como completada
                    lsTareas.Items[indice] = tarea + "[Completada]";
                }
                else
                {
                    MessageBox.Show("La tarea ya está marcada como completada", "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
        }

        private void lsTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
