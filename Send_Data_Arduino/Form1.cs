using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace Send_Data_Arduino
{
    public partial class Form1 : Form
    {
        //CRIA OBJETO DE CONEXÃO COM O ARDUINO
        SerialPort conexao = new SerialPort("COM3", 9600);

        public Form1()
        {
            InitializeComponent();
            
            //CONFIGURANDO COR DE FUNDO DOS BOTÕES
            btn_OFF.BackColor = Color.White;
            btn_ON.BackColor = Color.White;
        }

        //BOTAO LIGA LED
        private void btn_ON_Click(object sender, EventArgs e)
        {
            conexao.Open();         //ABRE CONEXAO
            Thread.Sleep(500);      //DELAY
            if (conexao.IsOpen)
            {
                //ENVIA COMANDO "DIGC1" PARA ARDUINO - LIGA LED
                conexao.Write("L1");
            }
            //string retorno = conexao.ReadLine();
            Thread.Sleep(500);      //DELAY
            conexao.Close();        //FECHA CONEXÃO

            btn_ON.BackColor= Color.Green;
            btn_OFF.BackColor= Color.White;
        }

        //BOTAO DESLIGA LED
        private void btn_OFF_Click(object sender, EventArgs e)
        {
            conexao.Open();         //ABRE CONEXAO
            Thread.Sleep(500);      //DELAY
            if (conexao.IsOpen)
            {
                //ENVIA COMANDO "DIGC0" PARA ARDUINO - DESLIGA LED
                conexao.Write("L0");
            }
            //string retorno = conexao.ReadLine();
            Thread.Sleep(500);      //DELAY
            conexao.Close();        //FECHA CONEXAO
            btn_ON.BackColor = Color.White;
            btn_OFF.BackColor = Color.Red;
        }
    }
}
