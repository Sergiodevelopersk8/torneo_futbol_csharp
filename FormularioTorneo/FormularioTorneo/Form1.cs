﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassModeloTorneo;
using ClassVistaTorneos;

namespace FormularioTorneo
{
    public partial class Form1 : Form
    {
        //Torneo modelo;//
        Vista mivista;
        Confederacion miConfe;
        string mensj = "";
        string[] atrapa;

        public Form1()
        {
            InitializeComponent();
            mivista = new Vista();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txteliminar_TextChanged(object sender, EventArgs e)
        {

        }

        // crea la confederacion
        private void creaConfederacion_Click(object sender, EventArgs e)
        {
            try
            {
                miConfe = new Confederacion(Convert.ToInt16(textBox1.Text), textBox2.Text);
                mivista.MiLetrero("Confederacion creada.");
                textBox2.Text = "";
                textBox1.Text = "";
                textBox2.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        // muestra los torneos creados //
        private void button2_Click(object sender, EventArgs e)
        {
            atrapa = miConfe.devuelveDatosTorneos();
            mivista.MonstrarCadenas(atrapa, listBox2);
        }

        //crea el torneo
        private void btnCrearTor_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarTorneo(txtNombreTor.Text, Convert.ToInt16(txtTotalEquipos.Text));
                mivista.MiLetrero(mensj);
                atrapa = miConfe.devuelveDatosTorneos();
                txtNombreTor.Text = "";
                txtTotalEquipos.Text = "";
                txtNombreTor.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        // muestra los equipos // 
        private void btnMonstrarEq_Click_1(object sender, EventArgs e)
        {
            atrapa = miConfe.devuelveDatosEquiposPorTorneo(listBox2.SelectedIndex);
            mivista.MonstrarCadenas(atrapa, listBox1);
        }

        // elimina el equipo que busques //
        private void eliminarXbusqueda_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.EliminaPorBusqueda_EnTorneo(listBox2.SelectedIndex, txteliminar.Text);
                mivista.MiLetrero(mensj);
                txteliminar.Text = "";
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        // elimina todos los equipos repetidos //
        private void eliminaTodasCopias_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.EliminarTodasCopias_EnTorneo(listBox2.SelectedIndex, txteliminar.Text);
                mivista.MiLetrero(mensj);
                txteliminar.Text = "";
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        // agrega equipos al torneo seleccionado // 
        private void btnAgregarEq_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarEquiposATorneo(listBox2.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // elimina el equipo que selecciones // 
        private void eliminarPorSelec_Click(object sender, EventArgs e)
        {
            mensj = miConfe.EliminarPorPosi_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex);
            mivista.MiLetrero(mensj);
        }

        // agrega un nuevo equipo despues del que selecciones //
        private void DespuesDe_Click(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.AgregarDespuesDe_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }


        private void Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                mensj = miConfe.ModificarEquipo_EnTorneo(listBox2.SelectedIndex, listBox1.SelectedIndex, txtClub.Text, txtCiudad.Text, Convert.ToInt16(txtJugadores.Text), Convert.ToInt16(txtFundacion.Text));
                mivista.MiLetrero(mensj);
                txtClub.Text = "";
                txtCiudad.Text = "";
                txtJugadores.Text = "";
                txtFundacion.Text = "";
                txtClub.Focus();
            }
            catch
            {
                mivista.MiLetrero("Asegurese de haber insertado los datos correctamente.");
            }
        }
    }
}
