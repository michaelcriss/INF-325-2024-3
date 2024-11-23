namespace Presentation
{
    partial class Paciente
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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtCodigoPostal = new TextBox();
            label6 = new Label();
            txtNIF = new TextBox();
            label7 = new Label();
            txtSeguridadSocial = new TextBox();
            label8 = new Label();
            cmbMedico = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 35);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(49, 85);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 32;
            label3.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Location = new Point(49, 108);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(280, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 34;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(280, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 33;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(462, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 36;
            label2.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Bottom;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtDireccion.Location = new Point(462, 108);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(49, 160);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 38;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Bottom;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.Location = new Point(49, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 37;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(280, 160);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 40;
            label5.Text = "Codigo Postal";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Anchor = AnchorStyles.Bottom;
            txtCodigoPostal.BackColor = Color.WhiteSmoke;
            txtCodigoPostal.Location = new Point(280, 183);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(125, 27);
            txtCodigoPostal.TabIndex = 39;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(462, 160);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 42;
            label6.Text = "NIF";
            // 
            // txtNIF
            // 
            txtNIF.Anchor = AnchorStyles.Bottom;
            txtNIF.BackColor = Color.WhiteSmoke;
            txtNIF.Location = new Point(462, 183);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(125, 27);
            txtNIF.TabIndex = 41;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(49, 234);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 44;
            label7.Text = "No. Seguridad Social";
            // 
            // txtSeguridadSocial
            // 
            txtSeguridadSocial.Anchor = AnchorStyles.Bottom;
            txtSeguridadSocial.BackColor = Color.WhiteSmoke;
            txtSeguridadSocial.Location = new Point(49, 257);
            txtSeguridadSocial.Name = "txtSeguridadSocial";
            txtSeguridadSocial.Size = new Size(148, 27);
            txtSeguridadSocial.TabIndex = 43;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(280, 234);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 45;
            label8.Text = "Medico";
            // 
            // cmbMedico
            // 
            cmbMedico.Anchor = AnchorStyles.Bottom;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(280, 256);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(151, 28);
            cmbMedico.TabIndex = 46;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Location = new Point(209, 349);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(139, 59);
            btnConsultar.TabIndex = 50;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(192, 0, 192);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Gainsboro;
            btnEditar.Location = new Point(354, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 59);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrar.BackColor = Color.FromArgb(192, 0, 192);
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.ForeColor = Color.Gainsboro;
            btnBorrar.Location = new Point(499, 349);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(139, 59);
            btnBorrar.TabIndex = 48;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(56, 349);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(147, 59);
            btnAceptar.TabIndex = 47;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 435);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbMedico);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtSeguridadSocial);
            Controls.Add(label6);
            Controls.Add(txtNIF);
            Controls.Add(label5);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Paciente";
            Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtId;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtCodigoPostal;
        private Label label6;
        private TextBox txtNIF;
        private Label label7;
        private TextBox txtSeguridadSocial;
        private Label label8;
        private ComboBox cmbMedico;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button btnAceptar;
    }
}