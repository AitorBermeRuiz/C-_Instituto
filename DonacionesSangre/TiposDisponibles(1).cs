using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonacionesSangre
{
    public partial class TiposDisponibles : Form
    {
        List<Usuarios> lUsuarios;
        public TiposDisponibles()
        {
            InitializeComponent();
        }
        public TiposDisponibles(List<Usuarios> lUsuarios)
        {
            InitializeComponent();
            this.lUsuarios = lUsuarios;
        }

        private void TiposDisponibles_Load(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<String, int> diccionario = crearDiccionario();
            foreach (Usuarios usr in lUsuarios)
            {
                if (usr.Activo == true)
                {
                    foreach (KeyValuePair<string, int> auxiliar in diccionario)
                    {
                        String grupoFactor = usr.Grupo + usr.Factor;
                        if (auxiliar.Key == grupoFactor)
                        {
                        }
                    }
                        
                }
            }
        }
        private Dictionary<String, int> crearDiccionario()
        {
            Dictionary<String, int> diccionario = new Dictionary<string, int>()
            {
                {"0+",0 },
                {"0-",0 },
                {"A+",0 },
                {"A-",0 },
                {"B+",0 },
                {"B-",0 },
                {"AB+",0 },
                {"AB-",0 }
            };
            return diccionario;
        }
    }
}
