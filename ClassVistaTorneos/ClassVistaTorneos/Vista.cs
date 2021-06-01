using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassVistaTorneos
{
    public class Vista
    {
        public void MiLetrero(string frase)
        {
            MessageBox.Show(frase, "Informacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        public void MonstrarCadenas(string[]cadenas, ListBox lista)
        {
            //int y = 0;
            lista.Items.Clear();
            // for ( y = 0; y <= cadenas.Length-1; y++)
            // {
            //     lista.Items.Add(cadenas[y]);
            // }

             
            foreach (string j in cadenas)
            {
                lista.Items.Add(j);
            }
        }

        public void MostrarTorneos(string[] losEquipos, ListBox listaT)
        {
            listaT.Items.Clear();
            foreach (string item in losEquipos)
            {
                listaT.Items.Add(item);
            }
        }
    }
}
