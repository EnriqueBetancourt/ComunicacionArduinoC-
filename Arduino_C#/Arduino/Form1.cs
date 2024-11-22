using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;
        bool isClosed = false;
        string completo = "@-";
        public Form1()
        {
            InitializeComponent();

            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM6";  
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EsucharSerial);
            Hilo.Start();
        }
        private void BtnCon_Click(object sender, EventArgs e)
        {
            BtnCon.Enabled = false;
            BtnCon.SendToBack();

            BtnDiscon.Enabled = true;
            BtnDiscon.BringToFront();

            try
            {
                Port.Open(); 

                MessageBox.Show("Conexión establecida correctamente con el puerto.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar al puerto: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDiscon_Click(object sender, EventArgs e)
        {
            BtnDiscon.Enabled = false;
            BtnDiscon.SendToBack();

            BtnCon.Enabled = true;
            BtnCon.BringToFront();

            try
            {
                Port.Close(); 

                MessageBox.Show("Conexión Cerrada.", "Conexión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cerrar el puerto: {ex.Message}", "Error al cerrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EsucharSerial()

        {
            while (!isClosed)
            {
                try
                {
                    string cadena = Port.ReadLine();
                    completo = completo.Insert(completo.Length - 1, cadena);


                    txtAlgo.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtAlgo.Text = completo;
                        }

                        ));

                }
                catch { }
            }

        }



        private void FormConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }
    }
}

