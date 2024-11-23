namespace Presentation
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
            btnAceptar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtHorasVuelo = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAceptar.BackColor = Color.FromArgb(192, 0, 192);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.Gainsboro;
            btnAceptar.Location = new Point(52, 363);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(138, 59);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 50);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(582, 164);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(52, 225);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Bottom;
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigo.Location = new Point(52, 249);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(116, 27);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(271, 249);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 27);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(271, 225);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Piloto";
            // 
            // txtHorasVuelo
            // 
            txtHorasVuelo.Anchor = AnchorStyles.Bottom;
            txtHorasVuelo.BackColor = Color.WhiteSmoke;
            txtHorasVuelo.Location = new Point(52, 321);
            txtHorasVuelo.Margin = new Padding(3, 4, 3, 4);
            txtHorasVuelo.Name = "txtHorasVuelo";
            txtHorasVuelo.Size = new Size(116, 27);
            txtHorasVuelo.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(52, 297);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "HorasVuelo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(520, 225);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 10;
            label5.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Bottom;
            txtId.BackColor = Color.WhiteSmoke;
            txtId.Location = new Point(520, 249);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 11;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(192, 0, 192);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = Color.Gainsboro;
            btnConsultar.Location = new Point(197, 363);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(138, 59);
            btnConsultar.TabIndex = 12;
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
            btnEditar.Location = new Point(341, 363);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(147, 59);
            btnEditar.TabIndex = 13;
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
            btnBorrar.Location = new Point(496, 363);
            btnBorrar.Margin = new Padding(3, 4, 3, 4);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(138, 59);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(192, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(594, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 29);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 435);
            Controls.Add(button1);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnConsultar);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(txtHorasVuelo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtHorasVuelo;
        private Label label3;
        private Label label5;
        private TextBox txtId;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnBorrar;
        private Button button1;
    }
}
