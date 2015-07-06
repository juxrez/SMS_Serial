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
using System.Threading;
namespace sms_serial
{
    
    public partial class frmSerialCom : Form
    {


        public frmSerialCom()
        {
            InitializeComponent();
            
        }

 
        //Funcion para recibir datos
        public void serialPort1_DataReceived(object sender , System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           // MessageBox.Show(serialPort1.ReadExisting());
            
            this.txtRecibir.Text += serialPort1.ReadExisting().ToString() + "\n";
          //  txtRecibir.Text = "OK";
        }
        //form load
        private void frmSerialCom_Load(object sender, EventArgs e)
        {
            buscarPuertos();
            CheckForIllegalCrossThreadCalls = false; //evitar que se verifiquen llamadas ilegales entre hilos
        }

        private void buscarPuertos ()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPuertos.Items.Clear();
            foreach(string port in ports)
            {
                cmbPuertos.Items.Add(port);
            }
            cmbPuertos.Text = "Seleccionar Puerto";
        } //cargar los puertos en el combobox
        
        //Boton enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //estructura de los comandos AT para enviar sms
            if ((serialPort1 != null) && (serialPort1.IsOpen == true))
            {
                string msg = txtEnviar.Text;
                string numero = txtNumero.Text;
                char diag = (char) 92;
                char tab = (char)26;
                char comillas = (char)34;
                serialPort1.Write("AT + CMGS = " + comillas + "+52" + numero + comillas + char.ConvertFromUtf32(13)); //"AT + CMGS = \"+12128675309\""
                Thread.Sleep(300);
                
                serialPort1.Write(msg + char.ConvertFromUtf32(26));
                Thread.Sleep(100);
                //serialPort1.Write();
                Thread.Sleep(2000);
              //  serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            }
            else
            {
                MessageBox.Show("Abra el puerto primero");
            }
        }

        //boton conectar
        private void conectar ()
        {
            if (cmbPuertos.Text != "Seleccionar Puerto")
            {
                if (serialPort1 != null)
                {
                    try
                    {
                        serialPort1 = new SerialPort(cmbPuertos.Text, 9600, Parity.None, 8, StopBits.One);
                        serialPort1.Open();
                        progressBar1.Value = 100;
                        
                        MessageBox.Show("Puerto abierto");
                        btnConectar.Text = "Desconectar";
                        rbRecibir.Enabled = true;
                        rbEnviar.Enabled = true;
                        btnSaldo.Enabled = true;
                        //  btnConectar.Enabled = false;
                        serialPort1.DataReceived += new SerialDataReceivedEventHandler(this.serialPort1_DataReceived);

                    }
                    catch
                    {
                        MessageBox.Show("No se pudo abrir el puerto");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione puerto");
            }
        } //conectar el puerto
        
        //boton desconectar
        private void desconectar()
        {
            if (serialPort1 != null)
            {
                if (serialPort1.IsOpen == true)
                {
                    try
                    {
                        serialPort1.Close();
                        MessageBox.Show("Puerto Cerrado");
                        rbEnviar.Enabled = false ;
                        rbRecibir.Enabled = false;
                        btnSaldo.Enabled = false;
                        //btnConectar.Enabled = true;
                        progressBar1.Value = 0;
                        btnConectar.Text = "Conectar";

                    }
                    catch
                    {
                        MessageBox.Show("No se pudo cerrar el puerto");
                    }
                }
            }
        } //desconectar el puerto
        //boton conexiones
        private void btnConectar_Click(object sender, EventArgs e)
        { //swichear el botón para varias actividades 
            if (btnConectar.Text == "Conectar")
            {
                conectar();
            }
            else if (btnConectar.Text == "Desconectar")
            {
                desconectar();
            }
        }

        private void rbEnviar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnviar.Checked == true)
            {
                serialPort1.Write("AT+CMGF=1\r");
                txtRecibir.Text += ("\r\n");
                Thread.Sleep(300);
                serialPort1.Write("AT+CNMI=2,2,0,0,0\r");
                txtRecibir.Text += ("\r\n");
            }
        }

        private void rbRecibir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecibir.Checked == true)
            {
                serialPort1.Write("AT+CMGF=1"); 
            }
        }

        private void btnLimparRecibido_Click(object sender, EventArgs e)
        {
            txtRecibir.Text = "";
        }
 
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            if ((serialPort1 != null) && (serialPort1.IsOpen == true))
            {
                serialPort1.Write("AT+CUSD=1"+ char.ConvertFromUtf32(13));
                Thread.Sleep(300);
                serialPort1.Write("ATD*133#" + char.ConvertFromUtf32(13));
            }
            else
            {
                MessageBox.Show("Abra el puerto primero");
            }
        }
    }
}
