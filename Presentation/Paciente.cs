using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            ListarMedico();

        }

        private void ListarMedico()
        {
            Pacientes paciente = new Pacientes();
            cmbMedico.DataSource = paciente.ListarMed();
            cmbMedico.DisplayMember = "NOMBRE";
            cmbMedico.ValueMember = "IDMEDICO";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes pacientes = new Pacientes();
                pacientes.Nombre = txtNombre.Text;
                pacientes.Direccion = txtDireccion.Text;
                pacientes.Telefono = txtTelefono.Text;
                pacientes.CodigoPostal = txtCodigoPostal.Text;
                pacientes.NIF = txtNIF.Text;
                pacientes.NOSS = txtSeguridadSocial.Text;
                pacientes.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);


                if (pacientes.Add())
                {
                    dataGridView1.DataSource = pacientes.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes pacientes = new Pacientes();
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        pacientes.Id = id;
                        dataGridView1.DataSource = pacientes.GetById();
                        return;
                    }
                }
                else
                {
                    dataGridView1.DataSource = pacientes.Get();
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
                Pacientes pacientes = new Pacientes();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        pacientes.Id = id;
                        pacientes.Nombre = txtNombre.Text;
                        pacientes.Direccion = txtDireccion.Text;
                        pacientes.Telefono = txtTelefono.Text;
                        pacientes.CodigoPostal = txtCodigoPostal.Text;
                        pacientes.NIF = txtNIF.Text;
                        pacientes.NOSS = txtSeguridadSocial.Text;
                        pacientes.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);

                        if (pacientes.Edit())
                        {
                            dataGridView1.DataSource = pacientes.Get();
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

                Pacientes pacientes = new Pacientes();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        pacientes.Id = id;
                        if (pacientes.Delete())
                        {
                            dataGridView1.DataSource = pacientes.Get();
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

    }
    
}
