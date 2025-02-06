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

namespace Supervisorio_Real
{
    public partial class main : Form
    {
        double temperature = 0, humidity = 0;
        bool updateData = false, flag = false;
        string ligacontrolador = "'";
       
        public main()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //imagem relacionado ao pistão
            picturePligado.Visible = false;
            picturePdesligado.Visible = true;

            //imagem relacionada ao cooler interno
            pictureBoxCDesligado.Visible = true;
            pictureBoxCLigado.Visible = false;

            // imagem relaciona ao cooler externo
            pictureBoxExternol.Visible = true;
            pictureBoxExterno.Visible = false;

            //imagem relacionada ao estado do controlador
            picturegreenof.Visible = true;
            picturegreenOn.Visible = false;
            
            // botões referentes a posta serial
            buttonAbrir.Enabled = true;
            buttonFechar.Enabled = false;
            buttonBuscar.Enabled = true;
            buttonReset.Enabled = true;

            //botões referente a equipamentos 
            buttonLigarPistão.Enabled = false;
            buttonDesligarPistao.Enabled = false;
            buttonLigarCooler1.Enabled = false;
            buttonDesligarCooler1.Enabled = false;
            LigarCoolerExterno.Enabled = false;
            DesligarCoolerExterno.Enabled = false;
            LigarControlador.Enabled = false;
            DesligarControlar.Enabled = false;

            //botões para verificar a temperatura
            buttonVerificar.Enabled = false;
            buttonInterromper.Enabled = false;


            //botões referente ao automatico
            LigarAutomatico.Enabled = false;
            DesligarAutomatico.Enabled = false;
            comboBoxAcionamentos.Enabled = false;

            //config de porta e barra de progresso em zero
            comboBoxBuade.Text = "9600";
            progressBar1.Value = 0;
            string[] portList = SerialPort.GetPortNames();
            comboBoxCom.Items.AddRange(portList);

            chart1.Series["Temperatura"].Points.AddXY(1, 1);
            chart1.Series["Humidade"].Points.AddXY(1, 1);

        }
        private void buttonAbrir_Click(object sender, EventArgs e) //botão para abrir porta serial
        {
            try
            {

                serialPort1.PortName = comboBoxCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBuade.Text);
                serialPort1.Open(); // abrir porta serial 

                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Humidade"].Points.Clear();

                progressBar1.Value = 100;

                MessageBox.Show("Success Conected to Arduino");

                buttonAbrir.Enabled = false;
                buttonFechar.Enabled = true;

                //botãoes referente a equipamentos 
                buttonLigarPistão.Enabled = true;
                buttonDesligarPistao.Enabled = true;
                buttonDesligarCooler1.Enabled = true;
                buttonLigarCooler1.Enabled = true;
                LigarCoolerExterno.Enabled = true;
                DesligarCoolerExterno.Enabled = true;
                LigarControlador.Enabled = true;
                DesligarControlar.Enabled = true;

                //botões referente ao automatico
                LigarAutomatico.Enabled = true;
                comboBoxAcionamentos.Enabled = true;

                // botões referente a verificar a temperatura
                buttonVerificar.Enabled = true;
                buttonInterromper.Enabled = true;


                comboBoxBuade.Enabled = false;
                comboBoxCom.Enabled = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e) // Fechar porta serial
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    
                    // deixar visivel ou não imagens dos componentes 
                    picturePligado.Visible = false;
                    picturePdesligado.Visible = true;
                    pictureBoxCLigado.Visible = false;
                    pictureBoxCDesligado.Visible = true;

                    serialPort1.Close(); // fechar porta serial

                    //habilitar e desabiltiar botões 
                    buttonAbrir.Enabled = true;
                    buttonFechar.Enabled = false;
                    buttonLigarPistão.Enabled = false;
                    buttonDesligarPistao.Enabled = false;
                    buttonLigarCooler1.Enabled = false;
                    buttonDesligarCooler1.Enabled = false;
                    LigarCoolerExterno.Enabled = false;
                    DesligarCoolerExterno.Enabled = false;
                    LigarControlador.Enabled = false;
                    DesligarControlar.Enabled = false;

                    // botões verificar
                    buttonVerificar.Enabled = false;
                    buttonInterromper.Enabled=false;

                    //botoões automatico
                    LigarAutomatico.Enabled = false;
                    DesligarAutomatico.Enabled = false;
                    comboBoxAcionamentos.Enabled = false;

                    progressBar1.Value = 0; // barra de progresso 


                    MessageBox.Show("Success Disconect to Arduino");

                    comboBoxBuade.Enabled = true;
                    comboBoxCom.Enabled = true;

                    comboBoxCom.Items.Clear();



                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            string dataIn = serialPort1.ReadTo("\n");
            Data_Parsing(dataIn);
            this.BeginInvoke(new EventHandler(Show_Data));

        }

        private void Show_Data(object sender, EventArgs e)
        {
            if (updateData == true && flag == true)
            {
                label_temperatura.Text = String.Format("Temperatura ={0} C", temperature.ToString());
                label_humidade.Text = String.Format("Humidade ={0}", humidity.ToString());

                chart1.Series["Temperatura"].Points.Add(temperature);
                chart1.Series["Humidade"].Points.Add(humidity);

            }
        }


        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                flag = true;
                serialPort1.WriteLine("5");


                buttonVerificar.Enabled = false;
                buttonLigarPistão.Enabled = false;
                buttonDesligarPistao.Enabled = false;
                buttonLigarCooler1.Enabled = false;
                buttonDesligarCooler1.Enabled = false;

                //botões relacionador a porta
                buttonFechar.Enabled = false;
                buttonReset.Enabled =  false;
                buttonAbrir.Enabled = false;
                buttonBuscar.Enabled = false;

                //botões relacionados ao automatico
                LigarAutomatico.Enabled = false;    
                DesligarAutomatico.Enabled = false;
                comboBoxAcionamentos.Enabled = false;
               

                int mydelay = 3000;
                Thread.Sleep(mydelay);
            }


        }

        private void buttonInterromper_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                flag = false;
                serialPort1.WriteLine("6");

                buttonVerificar.Enabled = true;

                buttonLigarPistão.Enabled = true;
                buttonDesligarPistao.Enabled = true;
                buttonLigarCooler1.Enabled = true;
                buttonDesligarCooler1.Enabled = true;
                
                //botões relacionado a portas
                buttonFechar.Enabled = true;
                buttonReset.Enabled = true;
                buttonAbrir.Enabled = true;
                buttonBuscar.Enabled = true;

                //botões automaticos
                LigarAutomatico.Enabled = true;
                DesligarAutomatico.Enabled = true;
                comboBoxAcionamentos.Enabled = false;

                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Humidade"].Points.Clear();
            }
        }


        private void Data_Parsing(string data)
        {
            if (flag == true)
            {

                sbyte indexOf_startDataCharacter = (sbyte)data.IndexOf("@");
                sbyte indexOfA = (sbyte)data.IndexOf("A");
                sbyte indexOfB = (sbyte)data.IndexOf("B");

                // se o caracter A, B e @  existir  no pacote de dados

                if (indexOfA != -1 && indexOfB != -1 && indexOf_startDataCharacter != -1)
                {
                    try
                    {
                        string str_temperatura = data.Substring(indexOf_startDataCharacter + 1, (indexOfA - indexOf_startDataCharacter) - 1);
                        string str_humidade = data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

                        temperature = Convert.ToDouble(str_temperatura);
                        humidity = Convert.ToDouble(str_humidade);

                        updateData = true;
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    updateData = false;
                }
            }

        }


        private void buttonLigarPistão_Click(object sender, EventArgs e) //botão para acionar pistão
        {

            if (serialPort1.IsOpen )
            {
                try
                {
                    serialPort1.WriteLine("!"); // escrever na porta serial numero 4
                    picturePdesligado.Visible = false;
                    picturePligado.Visible = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonDesligarPistao_Click(object sender, EventArgs e) // botão para desligar pistão 
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("#"); // escrever na porta serial numero 1
                    picturePdesligado.Visible = true;
                    picturePligado.Visible = false;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonLigarCooler1_Click(object sender, EventArgs e) // botão de ligar cooler
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine("%");
                    pictureBoxCLigado.Visible = true;
                    pictureBoxCDesligado.Visible = false;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonDesligarCooler1_Click(object sender, EventArgs e) // botão para desligar cooler
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine("&");
                    pictureBoxCLigado.Visible = false;
                    pictureBoxCDesligado.Visible = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                comboBoxCom.Items.Clear();
                serialPort1.Close();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void LigarAutomatico_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                buttonLigarPistão.Enabled = false;
                buttonDesligarPistao.Enabled = false;
                LigarAutomatico.Enabled = false;
                DesligarAutomatico.Enabled = true;
                buttonVerificar.Enabled = false;
                buttonInterromper.Enabled = false;
                comboBoxAcionamentos.Enabled = true;
                string variavel = comboBoxAcionamentos.Text;
                int teste = Convert.ToInt32(variavel);

                switch (teste)
                {
                    case 2:
                        serialPort1.WriteLine("2");
                        break;
                    case 4:
                        serialPort1.WriteLine("4");
                        break;
                    case 6:
                        serialPort1.WriteLine("6");
                        break;
                    case 8:
                        serialPort1.WriteLine("8");
                        break;
                    case 10:
                        serialPort1.WriteLine(":");
                        break;


                }


            }
        }

        private void DesligarAutomatico_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                DesligarAutomatico.Enabled = false;
                LigarAutomatico.Enabled = true;
                comboBoxAcionamentos.Enabled = true;
                buttonLigarPistão.Enabled = true;
                buttonDesligarPistao.Enabled = true;
                serialPort1.WriteLine("#");

                buttonVerificar.Enabled = true;
                buttonInterromper.Enabled = true;
            }
        }

        private void LigarCoolerExterno_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine("$");
                    pictureBoxExternol.Visible= false;
                    pictureBoxExterno.Visible = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        private void DesligarCoolerExterno_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine(")");
                    pictureBoxExternol.Visible = true;
                    pictureBoxExterno.Visible= false;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        private void LigarControlador_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine("(");
                    picturegreenOn.Visible = true;
                    picturegreenof.Visible = false;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void DesligarControlar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.WriteLine(ligacontrolador);
                    picturegreenOn.Visible = false;
                    picturegreenof.Visible = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e) // botão para buscar porta serial
        {
            if (serialPort1.IsOpen) 
            {
                try
                {
                    comboBoxCom.Items.Clear();

                    string[] portList = SerialPort.GetPortNames();
                    comboBoxCom.Items.AddRange(portList);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else // caso a porta serial não estiver aberta 
            {
                try
                {
                    comboBoxCom.Items.Clear();

                    string[] portList = SerialPort.GetPortNames();
                    comboBoxCom.Items.AddRange(portList);
                }

                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        }

        private void buttonReset_Click(object sender, EventArgs e) // botão reset 
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    // deixar visivel ou não imagens dos componentes 
                    picturePligado.Visible = false;
                    picturePdesligado.Visible = true;
                    pictureBoxCLigado.Visible = false;
                    pictureBoxCDesligado.Visible = true;

                    serialPort1.Close(); // fechar porta serial

                    //habilitar e desabiltiar botões 
                    buttonAbrir.Enabled = true;
                    buttonFechar.Enabled = false;
                    buttonLigarPistão.Enabled = false;
                    buttonDesligarPistao.Enabled = false;
                    buttonLigarCooler1.Enabled = false;
                    buttonDesligarCooler1.Enabled = false;
                    LigarCoolerExterno.Enabled = false;
                    DesligarCoolerExterno.Enabled = false;
                    LigarControlador.Enabled = false;
                    DesligarControlar.Enabled = false;

                    progressBar1.Value = 0; // barra de progresso 

                    comboBoxBuade.Enabled = true;
                    comboBoxCom.Enabled = true;

                    comboBoxCom.Items.Clear();

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

           
        
    }
}
