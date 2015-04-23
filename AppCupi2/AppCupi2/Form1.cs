using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCupi2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            emp emple;
            string fechanac = dateTimeNac.Value.ToString("dd/mm/yyyy");
            string fechaing = dateTimeIng.Value.ToString("dd/mm/yyyy");
            char sexo;

            if (cmbSexo.SelectedIndex==0)
            {sexo='M';}
            else{sexo='F';}

            emple=new emp(txtNombre.Text,txtApellido.Text,sexo,fechanac,fechaing,float.Parse(txtSalario.Text));

            MessageBox.Show("EL señor: " + txtNombre.Text + " " + txtApellido.Text
                +" de sexo : "+cmbSexo.SelectedItem.ToString()+" edad de nacimiento "+fechanac
                +" de fecha de ingreso "+fechaing+" con un salario de :"+float.Parse(txtSalario.Text));
        

        }
    }
}
