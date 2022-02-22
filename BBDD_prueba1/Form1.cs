using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDD_prueba1
{
    public partial class Form1 : Form
    {
        DataRow datos;
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.institutoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.institutoDataSet.alumnos);
                     

        }

        private void alumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filtro = "MAT = '" + textBox4.Text + "'";
            DataRow[] dr = institutoDataSet.Tables[0].Select(filtro);

            if (dr.Count() > 0)
            {
                tbMAT.Text = dr[0][0].ToString();
                tbAPEL_NOM.Text = dr[0][1].ToString();
                tbPOBLACION.Text = dr[0][2].ToString();
                tbTELEFONO.Text = dr[0][3].ToString();
            }
        }
    }
}
