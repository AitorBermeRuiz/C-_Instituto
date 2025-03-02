﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInstituto
{
    public partial class fGestionAlumnos : Form
    {
        public fGestionAlumnos()
        {
            InitializeComponent();
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAltaAlumno fAlta = new fAltaAlumno();
            fAlta.Show();
        }
        private void bajaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBajaAlumno fBaja = new fBajaAlumno();
            fBaja.Show();
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String texto = "";
            try { 

                FileStream fs = new FileStream("Alumnos.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                //While hasta fin del fichero, que va guardando objeto a objeto en un string y los imprime al final
                while(fs.Position != fs.Length){

                    cAlumno alumno = (cAlumno)formatter.Deserialize(fs);
                    if (alumno.Activo)
                    {
                        texto += alumno.toStringSinNotas() + ", Modulos: ";
                        List<String> modulos = alumno.Modulos1;
                        foreach (String modulo in modulos)
                        {
                            texto += modulo + ", ";
                        }
                        texto += Environment.NewLine+ Environment.NewLine;
                    }
                }
                lMostrarAlumnos.Visible = true;
                lMostrarAlumnos.Text = texto;
                fs.Close();
            }catch(FileNotFoundException fnfe) { MessageBox.Show("Fichero no existente"); }   
    }

        private void ºDAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtrarBusqueda("1º DAM A");
        }
       

        private void ºDAMBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filtrarBusqueda("1º DAM B");
        }

        private void ºDAMAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filtrarBusqueda("2º DAM A");
        }

        private void ºDAMBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filtrarBusqueda("2º DAM B");
        }
        private void filtrarBusqueda(String curso)
        {
            //metodo igual que el de mostrar todos con una doble condicion de si activo esta en true y si
            //curso es igual al string que le enviamos

            String texto = "";
            try
            {

                FileStream fs = new FileStream("Alumnos.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                while (fs.Position != fs.Length)
                {

                    cAlumno alumno = (cAlumno)formatter.Deserialize(fs);
                    if (alumno.Curso == curso && alumno.Activo)
                    {
                        texto += alumno.toStringSinNotas() + ", Modulos: ";
                        List<String> modulos = alumno.Modulos1;
                        foreach (String modulo in modulos)
                        {
                            texto += modulo + ", ";
                        }
                        texto += Environment.NewLine+ Environment.NewLine;
                    }
                }
                lMostrarAlumnos.Visible = true;
                lMostrarAlumnos.Text = texto;
                fs.Close();
            }
            catch (FileNotFoundException fnfe) { MessageBox.Show("Fichero no existente"); }
        }
        public  static void altaBaja(bool alta,String DNI)
        {
            //Metodo que recibe dni y bolleano de true a false, encuentra el dni introducido correspondido,
            //al objeto alumno con el mismo dni, si el bolean es true da de alta al objeto(activo=true), si es false
            //lo contrario
            try
            {

                FileStream fs = new FileStream("Alumnos.txt", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs1 = new FileStream("Auxiliar.txt", FileMode.Create);

                while (fs.Position != fs.Length)
                {

                    cAlumno alumno = (cAlumno)formatter.Deserialize(fs);
                    if (DNI == alumno.DNI1)
                    {
                        if (alta)
                            alumno.Activo = true;
                        else
                            alumno.Activo = false;
                    }
                    formatter.Serialize(fs1, alumno);

                }
                fs.Close();

                fs1.Close();
                File.Delete("Alumnos.txt");
                File.Copy(fs1.Name, "Alumnos.txt");
                File.Delete("Auxiliar.txt");
            }
            catch (FileNotFoundException fnfe) { MessageBox.Show("Fichero no existente"); }
        }

        
    }
}