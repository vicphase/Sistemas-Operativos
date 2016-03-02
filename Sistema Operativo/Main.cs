using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Operativo
{
    public partial class Main : Form
    {
        ListaProcesos Ready, Bloqued, Finished;
        Proceso Running;
        public Main()
        {
            InitializeComponent();
        
        }

        //Metodo utilizado para que no se pueda escribir en la combo box de tipos de interrupciones
        private void ComboBoxInterrupciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        //Metodo para leer el archivo .txt
        private void ButtonCargarTxt_Click(object sender, EventArgs e)
        {
            int NumeroProcesos;
          
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Cursor File";
            string line;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                line = sr.ReadLine();
                NumeroProcesos = Int32.Parse(line);
                Proceso[] procesos = new Proceso[NumeroProcesos];
                for (int i = 0; i < NumeroProcesos; i++)
                {
                    procesos[i] = new Proceso();

                }
                sr.Close();
            }
        }
    }
}
