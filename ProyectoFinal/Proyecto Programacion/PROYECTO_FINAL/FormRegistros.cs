using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConexionCSharpconMySQL
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        

        public Cliente clienteActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
        	    string.IsNullOrWhiteSpace(txtDireccion.Text) ||  string.IsNullOrWhiteSpace(textBox1.Text) ||
        	    string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {
                Cliente pCliente = new Cliente();
                pCliente.Nombre = txtNombre.Text.Trim();
                pCliente.Apellido = txtApellido.Text.Trim();
                pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
                pCliente.Direccion = txtDireccion.Text.Trim();
                pCliente.Telefono = textBox1.Text.Trim();
                pCliente.Email = textBox2.Text.Trim();
                 pCliente.CodigoPostal = textBox3.Text.Trim();


                int resultado = ClietesDAL.Agregar(pCliente);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
          }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Basedatos buscar = new Basedatos();
            buscar.ShowDialog();

            if (buscar.ClienteSelecionado != null)
            {
                clienteActual = buscar.ClienteSelecionado;
                txtNombre.Text = buscar.ClienteSelecionado.Nombre;
                txtApellido.Text = buscar.ClienteSelecionado.Apellido;
                txtDireccion.Text = buscar.ClienteSelecionado.Direccion;
                textBox1.Text = buscar.ClienteSelecionado.Telefono;
                textBox2.Text = buscar.ClienteSelecionado.Email;
                textBox3.Text = buscar.ClienteSelecionado.CodigoPostal;
                dtpFechaNacimiento.Text = buscar.ClienteSelecionado.Fecha_Nac;

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                Habilitar();
                btnGuardar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
        	    string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || 
        	    string.IsNullOrWhiteSpace(textBox2.Text)|| string.IsNullOrWhiteSpace(textBox3.Text))

                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else

          {

            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Apellido = txtApellido.Text.Trim();
            pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
            pCliente.Direccion = txtDireccion.Text.Trim();
            pCliente.Telefono = textBox1.Text.Trim();
            pCliente.Email = textBox2.Text.Trim();
            pCliente.CodigoPostal = textBox3.Text.Trim();
            pCliente.CodigoPostal = textBox3.Text.Trim();
           
            pCliente.Id = clienteActual.Id;

            if (ClietesDAL.Actualizar(pCliente) > 0)
            {
                MessageBox.Show("El Registro se actualizo", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Deshabilitar();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
          }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            Deshabilitar();

            
            
        }

       // private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       // {
           // ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            //Process.Start(sInfo);
      // }

       // private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       // {
        //    ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
        //    Process.Start(sInfo);
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Registro Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClietesDAL.Eliminar(clienteActual.Id) > 0)
                {
                    MessageBox.Show("Registro Eliminado Correctamente!", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                }
                else

                {
                    MessageBox.Show("No se pudo eliminar el Registtro", "Registro No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
        }


        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            textBox1.Clear();
             textBox2.Clear();
           textBox3.Clear();
             dtpFechaNacimiento.ResetText();
            

        }

        void Habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
           textBox1.Enabled = true;
           
            textBox2.Enabled = true;
           textBox3.Enabled = true;
           
           dtpFechaNacimiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }


        void Deshabilitar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            textBox1.Enabled = false;
             textBox2.Enabled = false;
             textBox3.Enabled = false;
            
            dtpFechaNacimiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;

            btnNuevo.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
        }


        
        
        void PictureBox1Click(object sender, EventArgs e)
        {
        	
        }
    }
}
