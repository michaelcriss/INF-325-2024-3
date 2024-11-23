
using BusinessLogic;
using System.Data.SqlClient;
namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Codigo = txtCodigo.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.HorasVuelo = txtHorasVuelo.Text;

                if (cliente.Add())
                {
                    dataGridView1.DataSource = cliente.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            // if (string.IsNullOrEmpty(txtNombre.Text) ) 
            // {
            //     string sql = "Select * from cliente";
            //     cmd.CommandText=sql;
            // }
            // else
            // {
            //     string sql = "Select * from cliente where nombre like '%' + @nombre +'%'";
            //     cmd.CommandText = sql;
            //     cmd.Parameters.AddWithValue("@nombre",txtNombre.Text);
            // }


            //dataGridView1.DataSource = dbAcess.Consultar(cmd);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        cliente.Id = id;
                        dataGridView1.DataSource = cliente.GetById();
                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = cliente.Get();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        cliente.Id = id;
                        cliente.Codigo = txtCodigo.Text;
                        cliente.Nombre = txtNombre.Text;
                        cliente.HorasVuelo = txtHorasVuelo.Text;
                        if (cliente.Edit())
                        {
                            dataGridView1.DataSource = cliente.Get();
                            MessageBox.Show("Los datos fueron actualizados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        cliente.Id = id;
                        if (cliente.Delete())
                        {
                            dataGridView1.DataSource = cliente.Get();
                            MessageBox.Show("Los datos fueron eliminados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
