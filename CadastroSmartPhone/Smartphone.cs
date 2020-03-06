using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSmartPhone
{
    class Smartphone
    {
        string processador, memMax, ram;
        string wifi, bluetooth, usb;
        string polegadas, resolucao, dpi;
        string tipo, autonomia, ampere;
        string radio, tv, vibracao;
        string acelerometro, proximidade, bussola;

        public Smartphone()
        {

        }

        public Smartphone(string processador, string memMax, string ram, string wifi, string bluetooth, string usb, string polegadas, string resolucao, string dpi, string tipo, string autonomia, string ampere, string radio, string tv, string vibracao, string acelerometro, string proximidade, string bussola)
        {
            this.processador = processador;
            this.memMax = memMax;
            this.ram = ram;
            this.wifi = wifi;
            this.bluetooth = bluetooth;
            this.usb = usb;
            this.polegadas = polegadas;
            this.resolucao = resolucao;
            this.dpi = dpi;
            this.tipo = tipo;
            this.autonomia = autonomia;
            this.ampere = ampere;
            this.radio = radio;
            this.tv = tv;
            this.vibracao = vibracao;
            this.acelerometro = acelerometro;
            this.Proximidade = proximidade;
            this.Bussola = bussola;
        }

        public string Processador { get => processador; set => processador = value; }
        public string MemMax { get => memMax; set => memMax = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Wifi { get => wifi; set => wifi = value; }
        public string Bluetooth { get => bluetooth; set => bluetooth = value; }
        public string Usb { get => usb; set => usb = value; }
        public string Polegadas { get => polegadas; set => polegadas = value; }
        public string Resolucao { get => resolucao; set => resolucao = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Autonomia { get => autonomia; set => autonomia = value; }
        public string Ampere { get => ampere; set => ampere = value; }
        public string Radio { get => radio; set => radio = value; }
        public string Tv { get => tv; set => tv = value; }
        public string Vibracao { get => vibracao; set => vibracao = value; }
        public string Acelerometro { get => acelerometro; set => acelerometro = value; }
        public string Proximidade { get => proximidade; set => proximidade = value; }
        public string Bussola { get => bussola; set => bussola = value; }
    }
}
