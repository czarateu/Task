namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsTareas = new ListBox();
            agregar = new Button();
            editar = new Button();
            eliminar = new Button();
            completada = new Button();
            SuspendLayout();
            // 
            // lsTareas
            // 
            lsTareas.AccessibleName = "";
            lsTareas.BackColor = Color.Silver;
            lsTareas.FormattingEnabled = true;
            lsTareas.ItemHeight = 15;
            lsTareas.Location = new Point(149, 64);
            lsTareas.Name = "lsTareas";
            lsTareas.Size = new Size(213, 274);
            lsTareas.TabIndex = 0;
            lsTareas.SelectedIndexChanged += lsTareas_SelectedIndexChanged;
            // 
            // agregar
            // 
            agregar.Location = new Point(449, 64);
            agregar.Name = "agregar";
            agregar.Size = new Size(84, 39);
            agregar.TabIndex = 1;
            agregar.Text = "Agregar tarea";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // editar
            // 
            editar.Location = new Point(449, 145);
            editar.Name = "editar";
            editar.Size = new Size(84, 46);
            editar.TabIndex = 2;
            editar.Text = "Editar tarea";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(449, 220);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(84, 42);
            eliminar.TabIndex = 3;
            eliminar.Text = "Eliminar tarea";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // completada
            // 
            completada.Location = new Point(449, 299);
            completada.Name = "completada";
            completada.Size = new Size(84, 50);
            completada.TabIndex = 4;
            completada.Text = "Tarea completada";
            completada.UseVisualStyleBackColor = true;
            completada.Click += completada_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(completada);
            Controls.Add(eliminar);
            Controls.Add(editar);
            Controls.Add(agregar);
            Controls.Add(lsTareas);
            Name = "Form1";
            Text = "Gestor de tareas";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsTareas;
        private Button agregar;
        private Button editar;
        private Button eliminar;
        private Button completada;
    }
}
