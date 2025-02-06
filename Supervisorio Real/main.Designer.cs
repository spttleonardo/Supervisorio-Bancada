namespace Supervisorio_Real
{
    partial class main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupoAutomatico = new System.Windows.Forms.GroupBox();
            this.DesligarAutomatico = new System.Windows.Forms.Button();
            this.LigarAutomatico = new System.Windows.Forms.Button();
            this.comboBoxAcionamentos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonInterromper = new System.Windows.Forms.Button();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.label_humidade = new System.Windows.Forms.Label();
            this.label_temperatura = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PortCom = new System.Windows.Forms.Label();
            this.comboBoxBuade = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLigarPistão = new System.Windows.Forms.Button();
            this.picturePligado = new System.Windows.Forms.PictureBox();
            this.picturePdesligado = new System.Windows.Forms.PictureBox();
            this.buttonDesligarPistao = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCLigado = new System.Windows.Forms.PictureBox();
            this.pictureBoxCDesligado = new System.Windows.Forms.PictureBox();
            this.buttonLigarCooler1 = new System.Windows.Forms.Button();
            this.buttonDesligarCooler1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxExterno = new System.Windows.Forms.PictureBox();
            this.pictureBoxExternol = new System.Windows.Forms.PictureBox();
            this.LigarCoolerExterno = new System.Windows.Forms.Button();
            this.DesligarCoolerExterno = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picturegreenOn = new System.Windows.Forms.PictureBox();
            this.picturegreenof = new System.Windows.Forms.PictureBox();
            this.LigarControlador = new System.Windows.Forms.Button();
            this.DesligarControlar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grupoAutomatico.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePligado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePdesligado)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCLigado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCDesligado)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExternol)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturegreenOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegreenof)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.grupoAutomatico);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 1055);
            this.panel1.TabIndex = 0;
            // 
            // grupoAutomatico
            // 
            this.grupoAutomatico.AutoSize = true;
            this.grupoAutomatico.Controls.Add(this.DesligarAutomatico);
            this.grupoAutomatico.Controls.Add(this.LigarAutomatico);
            this.grupoAutomatico.Controls.Add(this.comboBoxAcionamentos);
            this.grupoAutomatico.Controls.Add(this.label3);
            this.grupoAutomatico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grupoAutomatico.Location = new System.Drawing.Point(3, 597);
            this.grupoAutomatico.Name = "grupoAutomatico";
            this.grupoAutomatico.Size = new System.Drawing.Size(263, 267);
            this.grupoAutomatico.TabIndex = 9;
            this.grupoAutomatico.TabStop = false;
            this.grupoAutomatico.Text = "ACIONAMENTO AUTOMATICO";
            // 
            // DesligarAutomatico
            // 
            this.DesligarAutomatico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DesligarAutomatico.Location = new System.Drawing.Point(86, 215);
            this.DesligarAutomatico.Name = "DesligarAutomatico";
            this.DesligarAutomatico.Size = new System.Drawing.Size(94, 23);
            this.DesligarAutomatico.TabIndex = 10;
            this.DesligarAutomatico.Text = "Desativar";
            this.DesligarAutomatico.UseVisualStyleBackColor = true;
            this.DesligarAutomatico.Click += new System.EventHandler(this.DesligarAutomatico_Click);
            // 
            // LigarAutomatico
            // 
            this.LigarAutomatico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LigarAutomatico.Location = new System.Drawing.Point(86, 167);
            this.LigarAutomatico.Name = "LigarAutomatico";
            this.LigarAutomatico.Size = new System.Drawing.Size(94, 23);
            this.LigarAutomatico.TabIndex = 9;
            this.LigarAutomatico.Text = "Ativar";
            this.LigarAutomatico.UseVisualStyleBackColor = true;
            this.LigarAutomatico.Click += new System.EventHandler(this.LigarAutomatico_Click);
            // 
            // comboBoxAcionamentos
            // 
            this.comboBoxAcionamentos.FormattingEnabled = true;
            this.comboBoxAcionamentos.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.comboBoxAcionamentos.Location = new System.Drawing.Point(136, 99);
            this.comboBoxAcionamentos.Name = "comboBoxAcionamentos";
            this.comboBoxAcionamentos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAcionamentos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ACIONAMENTOS";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.buttonInterromper);
            this.groupBox4.Controls.Add(this.buttonVerificar);
            this.groupBox4.Controls.Add(this.label_humidade);
            this.groupBox4.Controls.Add(this.label_temperatura);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(86, 902);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 27);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Em breve";
            // 
            // buttonInterromper
            // 
            this.buttonInterromper.Location = new System.Drawing.Point(422, 91);
            this.buttonInterromper.Name = "buttonInterromper";
            this.buttonInterromper.Size = new System.Drawing.Size(142, 34);
            this.buttonInterromper.TabIndex = 4;
            this.buttonInterromper.Text = "Interromper";
            this.buttonInterromper.UseVisualStyleBackColor = true;
            this.buttonInterromper.Click += new System.EventHandler(this.buttonInterromper_Click);
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(422, 32);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(142, 36);
            this.buttonVerificar.TabIndex = 3;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // label_humidade
            // 
            this.label_humidade.AutoSize = true;
            this.label_humidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_humidade.Location = new System.Drawing.Point(427, 223);
            this.label_humidade.Name = "label_humidade";
            this.label_humidade.Size = new System.Drawing.Size(110, 24);
            this.label_humidade.TabIndex = 2;
            this.label_humidade.Text = "Humidade: %";
            // 
            // label_temperatura
            // 
            this.label_temperatura.AutoSize = true;
            this.label_temperatura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temperatura.Location = new System.Drawing.Point(427, 169);
            this.label_temperatura.Name = "label_temperatura";
            this.label_temperatura.Size = new System.Drawing.Size(146, 24);
            this.label_temperatura.TabIndex = 1;
            this.label_temperatura.Text = "Temperatura: ... C";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(19, 32);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperatura";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Humidade";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(380, 248);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Temperatura X Humidade";
            this.chart1.Titles.Add(title2);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(86, 547);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 30);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.buttonFechar);
            this.groupBox1.Controls.Add(this.buttonAbrir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortCom);
            this.groupBox1.Controls.Add(this.comboBoxBuade);
            this.groupBox1.Controls.Add(this.comboBoxCom);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONFIG COM";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 245);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscar.Location = new System.Drawing.Point(86, 161);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFechar.Location = new System.Drawing.Point(154, 199);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAbrir.Location = new System.Drawing.Point(20, 199);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrir.TabIndex = 4;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUDE";
            // 
            // PortCom
            // 
            this.PortCom.AutoSize = true;
            this.PortCom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PortCom.Location = new System.Drawing.Point(17, 51);
            this.PortCom.Name = "PortCom";
            this.PortCom.Size = new System.Drawing.Size(37, 16);
            this.PortCom.TabIndex = 2;
            this.PortCom.Text = "COM";
            // 
            // comboBoxBuade
            // 
            this.comboBoxBuade.FormattingEnabled = true;
            this.comboBoxBuade.Location = new System.Drawing.Point(95, 98);
            this.comboBoxBuade.Name = "comboBoxBuade";
            this.comboBoxBuade.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBuade.TabIndex = 1;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(95, 43);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCom.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supervisorio_Real.Properties.Resources._122030995_2825779091037720_1585508267409254733_n_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "Supervisório \r\n   Bancada";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.buttonLigarPistão);
            this.groupBox2.Controls.Add(this.picturePligado);
            this.groupBox2.Controls.Add(this.picturePdesligado);
            this.groupBox2.Controls.Add(this.buttonDesligarPistao);
            this.groupBox2.Location = new System.Drawing.Point(340, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pistão Pneumatico";
            // 
            // buttonLigarPistão
            // 
            this.buttonLigarPistão.Location = new System.Drawing.Point(90, 322);
            this.buttonLigarPistão.Name = "buttonLigarPistão";
            this.buttonLigarPistão.Size = new System.Drawing.Size(82, 36);
            this.buttonLigarPistão.TabIndex = 4;
            this.buttonLigarPistão.Text = "Ligar";
            this.buttonLigarPistão.UseVisualStyleBackColor = true;
            this.buttonLigarPistão.Click += new System.EventHandler(this.buttonLigarPistão_Click);
            // 
            // picturePligado
            // 
            this.picturePligado.Image = global::Supervisorio_Real.Properties.Resources.WhatsApp_Image_2022_08_11_at_21_34_03_removebg_preview__1_;
            this.picturePligado.Location = new System.Drawing.Point(161, 21);
            this.picturePligado.Name = "picturePligado";
            this.picturePligado.Size = new System.Drawing.Size(238, 278);
            this.picturePligado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePligado.TabIndex = 3;
            this.picturePligado.TabStop = false;
            // 
            // picturePdesligado
            // 
            this.picturePdesligado.Image = global::Supervisorio_Real.Properties.Resources.WhatsApp_Image_2022_08_11_at_21_34_04_removebg_preview;
            this.picturePdesligado.Location = new System.Drawing.Point(90, 21);
            this.picturePdesligado.Name = "picturePdesligado";
            this.picturePdesligado.Size = new System.Drawing.Size(309, 278);
            this.picturePdesligado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePdesligado.TabIndex = 3;
            this.picturePdesligado.TabStop = false;
            // 
            // buttonDesligarPistao
            // 
            this.buttonDesligarPistao.Location = new System.Drawing.Point(317, 322);
            this.buttonDesligarPistao.Name = "buttonDesligarPistao";
            this.buttonDesligarPistao.Size = new System.Drawing.Size(82, 36);
            this.buttonDesligarPistao.TabIndex = 2;
            this.buttonDesligarPistao.Text = "Desligar";
            this.buttonDesligarPistao.UseVisualStyleBackColor = true;
            this.buttonDesligarPistao.Click += new System.EventHandler(this.buttonDesligarPistao_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.pictureBoxCLigado);
            this.groupBox3.Controls.Add(this.pictureBoxCDesligado);
            this.groupBox3.Controls.Add(this.buttonLigarCooler1);
            this.groupBox3.Controls.Add(this.buttonDesligarCooler1);
            this.groupBox3.Location = new System.Drawing.Point(924, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 368);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cooler Interno";
            // 
            // pictureBoxCLigado
            // 
            this.pictureBoxCLigado.Image = global::Supervisorio_Real.Properties.Resources.vento_on__com_sem_marca_da_agua_removebg_preview;
            this.pictureBoxCLigado.Location = new System.Drawing.Point(108, 31);
            this.pictureBoxCLigado.Name = "pictureBoxCLigado";
            this.pictureBoxCLigado.Size = new System.Drawing.Size(340, 281);
            this.pictureBoxCLigado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCLigado.TabIndex = 3;
            this.pictureBoxCLigado.TabStop = false;
            this.pictureBoxCLigado.Visible = false;
            // 
            // pictureBoxCDesligado
            // 
            this.pictureBoxCDesligado.Image = global::Supervisorio_Real.Properties.Resources.ventilador_off_sem_marca_removebg_preview;
            this.pictureBoxCDesligado.Location = new System.Drawing.Point(90, 31);
            this.pictureBoxCDesligado.Name = "pictureBoxCDesligado";
            this.pictureBoxCDesligado.Size = new System.Drawing.Size(309, 278);
            this.pictureBoxCDesligado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCDesligado.TabIndex = 3;
            this.pictureBoxCDesligado.TabStop = false;
            // 
            // buttonLigarCooler1
            // 
            this.buttonLigarCooler1.Location = new System.Drawing.Point(90, 315);
            this.buttonLigarCooler1.Name = "buttonLigarCooler1";
            this.buttonLigarCooler1.Size = new System.Drawing.Size(83, 36);
            this.buttonLigarCooler1.TabIndex = 1;
            this.buttonLigarCooler1.Text = "Ligar";
            this.buttonLigarCooler1.UseVisualStyleBackColor = true;
            this.buttonLigarCooler1.Click += new System.EventHandler(this.buttonLigarCooler1_Click);
            // 
            // buttonDesligarCooler1
            // 
            this.buttonDesligarCooler1.Location = new System.Drawing.Point(317, 315);
            this.buttonDesligarCooler1.Name = "buttonDesligarCooler1";
            this.buttonDesligarCooler1.Size = new System.Drawing.Size(82, 36);
            this.buttonDesligarCooler1.TabIndex = 2;
            this.buttonDesligarCooler1.Text = "Desligar";
            this.buttonDesligarCooler1.UseVisualStyleBackColor = true;
            this.buttonDesligarCooler1.Click += new System.EventHandler(this.buttonDesligarCooler1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.pictureBoxExterno);
            this.groupBox5.Controls.Add(this.pictureBoxExternol);
            this.groupBox5.Controls.Add(this.LigarCoolerExterno);
            this.groupBox5.Controls.Add(this.DesligarCoolerExterno);
            this.groupBox5.Location = new System.Drawing.Point(924, 456);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 368);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Coolers Externos";
            // 
            // pictureBoxExterno
            // 
            this.pictureBoxExterno.Image = global::Supervisorio_Real.Properties.Resources.vento_on__com_sem_marca_da_agua_removebg_preview;
            this.pictureBoxExterno.Location = new System.Drawing.Point(108, 31);
            this.pictureBoxExterno.Name = "pictureBoxExterno";
            this.pictureBoxExterno.Size = new System.Drawing.Size(340, 281);
            this.pictureBoxExterno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExterno.TabIndex = 3;
            this.pictureBoxExterno.TabStop = false;
            this.pictureBoxExterno.Visible = false;
            // 
            // pictureBoxExternol
            // 
            this.pictureBoxExternol.Image = global::Supervisorio_Real.Properties.Resources.ventilador_off_sem_marca_removebg_preview;
            this.pictureBoxExternol.Location = new System.Drawing.Point(90, 31);
            this.pictureBoxExternol.Name = "pictureBoxExternol";
            this.pictureBoxExternol.Size = new System.Drawing.Size(309, 278);
            this.pictureBoxExternol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExternol.TabIndex = 3;
            this.pictureBoxExternol.TabStop = false;
            // 
            // LigarCoolerExterno
            // 
            this.LigarCoolerExterno.Location = new System.Drawing.Point(90, 315);
            this.LigarCoolerExterno.Name = "LigarCoolerExterno";
            this.LigarCoolerExterno.Size = new System.Drawing.Size(83, 36);
            this.LigarCoolerExterno.TabIndex = 1;
            this.LigarCoolerExterno.Text = "Ligar";
            this.LigarCoolerExterno.UseVisualStyleBackColor = true;
            this.LigarCoolerExterno.Click += new System.EventHandler(this.LigarCoolerExterno_Click);
            // 
            // DesligarCoolerExterno
            // 
            this.DesligarCoolerExterno.Location = new System.Drawing.Point(317, 315);
            this.DesligarCoolerExterno.Name = "DesligarCoolerExterno";
            this.DesligarCoolerExterno.Size = new System.Drawing.Size(82, 36);
            this.DesligarCoolerExterno.TabIndex = 2;
            this.DesligarCoolerExterno.Text = "Desligar";
            this.DesligarCoolerExterno.UseVisualStyleBackColor = true;
            this.DesligarCoolerExterno.Click += new System.EventHandler(this.DesligarCoolerExterno_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.picturegreenOn);
            this.groupBox6.Controls.Add(this.picturegreenof);
            this.groupBox6.Controls.Add(this.LigarControlador);
            this.groupBox6.Controls.Add(this.DesligarControlar);
            this.groupBox6.Location = new System.Drawing.Point(340, 456);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(508, 368);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controlador Peltier";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // picturegreenOn
            // 
            this.picturegreenOn.Image = global::Supervisorio_Real.Properties.Resources.green_led_on_md;
            this.picturegreenOn.Location = new System.Drawing.Point(215, 81);
            this.picturegreenOn.Name = "picturegreenOn";
            this.picturegreenOn.Size = new System.Drawing.Size(94, 114);
            this.picturegreenOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturegreenOn.TabIndex = 3;
            this.picturegreenOn.TabStop = false;
            // 
            // picturegreenof
            // 
            this.picturegreenof.Image = global::Supervisorio_Real.Properties.Resources.green_led_off_md;
            this.picturegreenof.Location = new System.Drawing.Point(215, 81);
            this.picturegreenof.Name = "picturegreenof";
            this.picturegreenof.Size = new System.Drawing.Size(95, 114);
            this.picturegreenof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturegreenof.TabIndex = 3;
            this.picturegreenof.TabStop = false;
            this.picturegreenof.Visible = false;
            // 
            // LigarControlador
            // 
            this.LigarControlador.Location = new System.Drawing.Point(90, 315);
            this.LigarControlador.Name = "LigarControlador";
            this.LigarControlador.Size = new System.Drawing.Size(83, 36);
            this.LigarControlador.TabIndex = 1;
            this.LigarControlador.Text = "Ligar";
            this.LigarControlador.UseVisualStyleBackColor = true;
            this.LigarControlador.Click += new System.EventHandler(this.LigarControlador_Click);
            // 
            // DesligarControlar
            // 
            this.DesligarControlar.Location = new System.Drawing.Point(317, 315);
            this.DesligarControlar.Name = "DesligarControlar";
            this.DesligarControlar.Size = new System.Drawing.Size(82, 36);
            this.DesligarControlar.TabIndex = 2;
            this.DesligarControlar.Text = "Desligar";
            this.DesligarControlar.UseVisualStyleBackColor = true;
            this.DesligarControlar.Click += new System.EventHandler(this.DesligarControlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1632, 1055);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Supervisório Bancada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoAutomatico.ResumeLayout(false);
            this.grupoAutomatico.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePligado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePdesligado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCLigado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCDesligado)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExternol)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturegreenOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegreenof)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PortCom;
        private System.Windows.Forms.ComboBox comboBoxBuade;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Label label1;
      
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDesligarPistao;
        private System.Windows.Forms.PictureBox picturePligado;
        private System.Windows.Forms.PictureBox picturePdesligado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxCLigado;
        private System.Windows.Forms.PictureBox pictureBoxCDesligado;
        private System.Windows.Forms.Button buttonLigarCooler1;
        private System.Windows.Forms.Button buttonDesligarCooler1;
        private System.Windows.Forms.Button buttonLigarPistão;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_humidade;
        private System.Windows.Forms.Label label_temperatura;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonInterromper;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAcionamentos;
        private System.Windows.Forms.GroupBox grupoAutomatico;
        private System.Windows.Forms.Button LigarAutomatico;
        private System.Windows.Forms.Button DesligarAutomatico;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxExterno;
        private System.Windows.Forms.PictureBox pictureBoxExternol;
        private System.Windows.Forms.Button LigarCoolerExterno;
        private System.Windows.Forms.Button DesligarCoolerExterno;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox picturegreenof;
        private System.Windows.Forms.PictureBox picturegreenOn;
        private System.Windows.Forms.Button LigarControlador;
        private System.Windows.Forms.Button DesligarControlar;
    }
}

