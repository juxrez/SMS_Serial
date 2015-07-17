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
using System.IO;

namespace sms_serial
{

    public partial class frmSerialCom : Form
    {

        string rutaRaiz; //ruta donde tiene que estar la base de datos
        string rutaDB; //ruta de la base de datos 
        string rutaDBNew; //ruta de la base de datos nueva que se debe poner en la raíz 
        string preMsg; //menasaje predefido en caso de que se active la casilla 
        int lastRow; //numero de registros que hay en la DB
        bool enviar = false; //bandera que va a indicar cuando enviar un msj
        string txt;
        public frmSerialCom()
        {
            InitializeComponent();
            this.rutaDB = Application.StartupPath + @"\data\data.xlsx";
            
        }

 
        //Funcion para recibir datos
        public void serialPort1_DataReceived(object sender , System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string ok = "OK";
           // MessageBox.Show(serialPort1.ReadExisting());
            txt = serialPort1.ReadExisting().ToString();
           // this.txtRecibir.Text += serialPort1.ReadExisting().ToString() + "\n";
            txtRecibir.Text += txt + "\n";
            if (txt == ok || txt == "ok")
            {
                MessageBox.Show("OK");
            }
            
          //  txtRecibir.Text = "OK";
        }
        //form load
        private void frmSerialCom_Load(object sender, EventArgs e)
        {
            buscarPuertos(); //cargar puertos activos
            CheckForIllegalCrossThreadCalls = false; //evitar que se verifiquen llamadas ilegales entre hilos
            try
            {
               // fpsNumeros.ActiveSheet.OpenExcel(rutaDB, 0);
            }
            catch
            {
                MessageBox.Show("No se pudo abrir la base de datos");
            }
            fpsNumeros.ActiveSheet.Columns.Count = 6;
            //fpsTest.ActiveSheet.Columns.Count = 6;
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
                //preMsg = txtEnviar.Text;
                //string numero = txtNumero.Text;
                //char diag = (char)92;
                //char tab = (char)26;
                //char comillas = (char)34;
                //serialPort1.Write("AT + CMGS = " + comillas + "+52" + numero + comillas + char.ConvertFromUtf32(13)); //"AT + CMGS = \"+12128675309\""
                //Thread.Sleep(300);
                //serialPort1.Write(preMsg + char.ConvertFromUtf32(26));
                //Thread.Sleep(100);
                //Thread.Sleep(2000);
                preMsg = txtEnviar.Text;
                lastRow = fpsNumeros.ActiveSheet.NonEmptyRowCount;
                for (int i = 0; i <= lastRow; i++)
                {
                    
                }
              
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
                        //groupBox2.Enabled = true;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int numCeldas; // numero de celdas que va a tener el spread de la base de datos para que no haya un chingo   
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos .xls (*.xls;*.xlsx)|*.xls;*.xlsx";
            dialog.Title = "Seleccione DB";
            dialog.FileName = string.Empty;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rutaDBNew = dialog.FileName;
                try
                {

                    if (!Directory.Exists(Path.GetDirectoryName(this.rutaDB))) //comprobar el directorio
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(this.rutaDB));
                    }
                    if (File.Exists(rutaDB))
                    {
                        File.Delete(rutaDB);
                    }
                    File.Copy(rutaDBNew, rutaDB); // mover el archivo al destino
                    MessageBox.Show("Base de Datos actualizada");
                    fpsNumeros.ActiveSheet.OpenExcel(rutaDB, 0);
                    fpsNumeros.ActiveSheet.Columns.Count = 2;
                   // fpsTest.ActiveSheet.Columns.Count = 6;
                    
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Falló en la operación", ex.Message); 
                }
                numCeldas = fpsNumeros.ActiveSheet.NonEmptyRowCount;
                fpsNumeros.ActiveSheet.RowCount = numCeldas;
            }    
        }

        private void LeerDB() //funcion donde se leen todos numeros de telefono de la base de datos 
        {
            int i;
            lastRow = fpsNumeros.ActiveSheet.NonEmptyRowCount;
            for (i=0; i<=lastRow; i++)
            {
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                preMsg = txtEnviar.Text;
                txtEnviar.Enabled = false;
            }
            if (checkBox1.Checked == false)
                txtEnviar.Enabled = true;
        }
    }
}
