namespace CentroMedico
{
    partial class frmRegistroPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtSintomas = new TextBox();
            lvRegistrados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(170, 38);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(170, 67);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(170, 96);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Síntomas:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(276, 183);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(394, 40);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(276, 9);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(394, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(276, 67);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(117, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(276, 96);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(394, 81);
            txtSintomas.TabIndex = 8;
            // 
            // lvRegistrados
            // 
            lvRegistrados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvRegistrados.Location = new Point(170, 305);
            lvRegistrados.Name = "lvRegistrados";
            lvRegistrados.Size = new Size(581, 200);
            lvRegistrados.TabIndex = 9;
            lvRegistrados.UseCompatibleStateImageBehavior = false;
            lvRegistrados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DNI";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Edad";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Síntomas";
            columnHeader4.Width = 250;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(170, 279);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(377, 23);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Lista de Pacientes Registrados";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 629);
            Controls.Add(lblEstado);
            Controls.Add(lvRegistrados);
            Controls.Add(txtSintomas);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmRegistroPaciente";
            Padding = new Padding(3, 0, 3, 3);
            ShowInTaskbar = false;
            Text = "Registro de Paciente (Lista Simple y Encola)";
            Load += frmRegistroPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtSintomas;
        private ListView lvRegistrados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblEstado;
    }
}