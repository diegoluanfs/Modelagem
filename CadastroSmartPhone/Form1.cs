using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSmartPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Smartphone smart = new Smartphone();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            smart.Processador = tfProcessador.Text;
            smart.Ram = tfRAM.Text;
            smart.MemMax = tfMemoriaMax.Text;
            smart.Polegadas = tfPolegadas.Text;
            smart.Resolucao = tfResolucao.Text;
            smart.Dpi = tfDPI.Text;
            smart.Wifi = tfWifi.Text;
            smart.Bluetooth = tfBluetooth.Text;
            smart.Usb = tfUSB.Text;
            smart.Tipo = tfTipo.Text;
            smart.Autonomia = tfAutonomia.Text;
            smart.Ampere = tfAmpere.Text;
            smart.Radio = tfProcessador.Text;
            smart.Tv = tfProcessador.Text;
            smart.Vibracao = tfProcessador.Text;
            smart.Acelerometro = tfProcessador.Text;
            smart.Proximidade = tfProximidade.Text;
            smart.Bussola = tfBussola.Text;

            MostrarDados();

        }
        public void MostrarDados()
        {
            Console.WriteLine("Os dados obtidos para o cadastro do smartphone foram: ");
            Console.WriteLine("Processador: " + smart.Processador);
            Console.WriteLine("Ram: " + smart.Ram);
            Console.WriteLine("Memória Máxima: " + smart.MemMax);
            Console.WriteLine("Polegadas: " + smart.Polegadas);
            Console.WriteLine("Resolução: " + smart.Resolucao);
            Console.WriteLine("Dpi: " + smart.Dpi);
            Console.WriteLine("Wifi: " + smart.Wifi);
            Console.WriteLine("Bluetooth: " + smart.Bluetooth);
            Console.WriteLine("Usb: " + smart.Usb);
            Console.WriteLine("Tipo de bateria: " + smart.Tipo);
            Console.WriteLine("Autonomia da bateria: " + smart.Autonomia);
            Console.WriteLine("Ampere da bateria: " + smart.Ampere);
            Console.WriteLine("Radio: " + smart.Radio);
            Console.WriteLine("TV: " + smart.Tv);
            Console.WriteLine("Vibração: " + smart.Vibracao);
            Console.WriteLine("Acelerômetro: " + smart.Acelerometro);
            Console.WriteLine("Sensor de Proximidade: " + smart.Proximidade);
            Console.WriteLine("Bússola: " + smart.Bussola);

        }

    }
}
