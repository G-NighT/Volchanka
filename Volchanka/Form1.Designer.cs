namespace volchanka
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnGo = new System.Windows.Forms.Button();
            this.nudLayer = new System.Windows.Forms.NumericUpDown();
            this.gbCheck = new System.Windows.Forms.GroupBox();
            this.lbl_diagnos = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.button_diagnos = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.lbl_err = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.lbl_epoxi = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lbl_done = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNeuro = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_errorDynamic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sick = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofd_select = new System.Windows.Forms.OpenFileDialog();
            this.sfd_save = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLayer)).BeginInit();
            this.gbCheck.SuspendLayout();
            this.gbConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_errorDynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(10, 255);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(157, 33);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Обучить сеть";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudLayer
            // 
            this.nudLayer.Location = new System.Drawing.Point(186, 28);
            this.nudLayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudLayer.Name = "nudLayer";
            this.nudLayer.Size = new System.Drawing.Size(201, 27);
            this.nudLayer.TabIndex = 1;
            this.nudLayer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gbCheck
            // 
            this.gbCheck.Controls.Add(this.lbl_diagnos);
            this.gbCheck.Controls.Add(this.lbl_res);
            this.gbCheck.Controls.Add(this.button_diagnos);
            this.gbCheck.Controls.Add(this.checkBox7);
            this.gbCheck.Controls.Add(this.checkBox6);
            this.gbCheck.Controls.Add(this.checkBox5);
            this.gbCheck.Controls.Add(this.checkBox4);
            this.gbCheck.Controls.Add(this.checkBox3);
            this.gbCheck.Controls.Add(this.checkBox2);
            this.gbCheck.Controls.Add(this.checkBox1);
            this.gbCheck.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCheck.Location = new System.Drawing.Point(5, 451);
            this.gbCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCheck.Name = "gbCheck";
            this.gbCheck.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCheck.Size = new System.Drawing.Size(395, 296);
            this.gbCheck.TabIndex = 2;
            this.gbCheck.TabStop = false;
            this.gbCheck.Text = "Ваши показатели";
            // 
            // lbl_diagnos
            // 
            this.lbl_diagnos.AutoSize = true;
            this.lbl_diagnos.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_diagnos.Location = new System.Drawing.Point(170, 245);
            this.lbl_diagnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diagnos.Name = "lbl_diagnos";
            this.lbl_diagnos.Size = new System.Drawing.Size(87, 19);
            this.lbl_diagnos.TabIndex = 18;
            this.lbl_diagnos.Text = "Состояние";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_res.Location = new System.Drawing.Point(170, 268);
            this.lbl_res.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(83, 19);
            this.lbl_res.TabIndex = 17;
            this.lbl_res.Text = "Результат";
            // 
            // button_diagnos
            // 
            this.button_diagnos.Enabled = false;
            this.button_diagnos.Location = new System.Drawing.Point(8, 245);
            this.button_diagnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_diagnos.Name = "button_diagnos";
            this.button_diagnos.Size = new System.Drawing.Size(157, 42);
            this.button_diagnos.TabIndex = 16;
            this.button_diagnos.Text = "Поставить диагноз";
            this.button_diagnos.UseVisualStyleBackColor = true;
            this.button_diagnos.Click += new System.EventHandler(this.button_diagnos_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(10, 212);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(88, 23);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Серозит";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(10, 181);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(157, 23);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Поражение почек";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(10, 150);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(261, 23);
            this.checkBox5.TabIndex = 13;
            this.checkBox5.Text = "Высыпания в скуловой области";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 119);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(367, 23);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Язвенные изменения слизистой в полости рта";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 88);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(220, 23);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Антинуклеарные антитела";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 57);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(206, 23);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Дискоидные высыпания";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 26);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(351, 23);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Артрит без эрозий суставных поверхностей";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.lbl_err);
            this.gbConfig.Controls.Add(this.checkBox8);
            this.gbConfig.Controls.Add(this.groupBox1);
            this.gbConfig.Controls.Add(this.lbl_epoxi);
            this.gbConfig.Controls.Add(this.button_load);
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.button_save);
            this.gbConfig.Controls.Add(this.nudAge);
            this.gbConfig.Controls.Add(this.lbl_done);
            this.gbConfig.Controls.Add(this.button_check);
            this.gbConfig.Controls.Add(this.btnDefault);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.nudNeuro);
            this.gbConfig.Controls.Add(this.label1);
            this.gbConfig.Controls.Add(this.nudLayer);
            this.gbConfig.Controls.Add(this.btnGo);
            this.gbConfig.Location = new System.Drawing.Point(5, 14);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Size = new System.Drawing.Size(395, 427);
            this.gbConfig.TabIndex = 3;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Нейронная сеть";
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(177, 355);
            this.lbl_err.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(169, 19);
            this.lbl_err.TabIndex = 17;
            this.lbl_err.Text = "Ошибка = неизвестно";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(181, 261);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(206, 23);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "Отрисовывать обучение";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Location = new System.Drawing.Point(10, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 63);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алгоритм";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(16, 26);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(95, 23);
            this.rb1.TabIndex = 1;
            this.rb1.Text = "Обычный";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Click += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Location = new System.Drawing.Point(130, 26);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(227, 23);
            this.rb2.TabIndex = 0;
            this.rb2.TabStop = true;
            this.rb2.Text = "Рекурсивный (до 700 эпох)";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.Click += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // lbl_epoxi
            // 
            this.lbl_epoxi.AutoSize = true;
            this.lbl_epoxi.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_epoxi.ForeColor = System.Drawing.Color.Red;
            this.lbl_epoxi.Location = new System.Drawing.Point(177, 327);
            this.lbl_epoxi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_epoxi.Name = "lbl_epoxi";
            this.lbl_epoxi.Size = new System.Drawing.Size(194, 19);
            this.lbl_epoxi.TabIndex = 13;
            this.lbl_epoxi.Text = "Кол-во эпох: неизвестно";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(10, 298);
            this.button_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(157, 33);
            this.button_load.TabIndex = 11;
            this.button_load.Text = "Загрузить сеть";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество эпох";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(10, 341);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(157, 33);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Сохранить сеть";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(186, 102);
            this.nudAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(201, 27);
            this.nudAge.TabIndex = 6;
            this.nudAge.Value = new decimal(new int[] {
            149,
            0,
            0,
            0});
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // lbl_done
            // 
            this.lbl_done.AutoSize = true;
            this.lbl_done.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_done.ForeColor = System.Drawing.Color.Red;
            this.lbl_done.Location = new System.Drawing.Point(177, 298);
            this.lbl_done.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_done.Name = "lbl_done";
            this.lbl_done.Size = new System.Drawing.Size(94, 19);
            this.lbl_done.TabIndex = 4;
            this.lbl_done.Text = "Не обучена";
            // 
            // button_check
            // 
            this.button_check.Enabled = false;
            this.button_check.Location = new System.Drawing.Point(10, 384);
            this.button_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(377, 33);
            this.button_check.TabIndex = 9;
            this.button_check.Text = "Проверить выборку";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(10, 212);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(377, 33);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Выставить настройки по умолчанию";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество нейронов";
            // 
            // nudNeuro
            // 
            this.nudNeuro.Location = new System.Drawing.Point(186, 65);
            this.nudNeuro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNeuro.Name = "nudNeuro";
            this.nudNeuro.Size = new System.Drawing.Size(201, 27);
            this.nudNeuro.TabIndex = 3;
            this.nudNeuro.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество слоев";
            // 
            // chart_errorDynamic
            // 
            chartArea1.AxisX.Title = "Эпохи";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Panton", 9.749999F);
            chartArea1.AxisY.Title = "Ошибка";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Panton", 9.749999F);
            chartArea1.Name = "Динамика обучения";
            this.chart_errorDynamic.ChartAreas.Add(chartArea1);
            this.chart_errorDynamic.Location = new System.Drawing.Point(379, 460);
            this.chart_errorDynamic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_errorDynamic.Name = "chart_errorDynamic";
            this.chart_errorDynamic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 4;
            series1.ChartArea = "Динамика обучения";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            this.chart_errorDynamic.Series.Add(series1);
            this.chart_errorDynamic.Size = new System.Drawing.Size(946, 287);
            this.chart_errorDynamic.TabIndex = 7;
            this.chart_errorDynamic.Text = "Динамика обучения";
            title1.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 7.464787F;
            title1.Position.Width = 94F;
            title1.Text = "Динамика обучения";
            this.chart_errorDynamic.Titles.Add(title1);
            // 
            // chart_sick
            // 
            chartArea2.AxisX.Title = "Выходное значение";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Panton", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Эпохи";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Panton", 9.749999F);
            chartArea2.Name = "Динамика обучения";
            this.chart_sick.ChartAreas.Add(chartArea2);
            this.chart_sick.Location = new System.Drawing.Point(379, 14);
            this.chart_sick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_sick.Name = "chart_sick";
            this.chart_sick.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "Динамика обучения";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Green;
            series2.LegendText = "Здоров";
            series2.MarkerBorderWidth = 0;
            series2.MarkerSize = 3;
            series2.Name = "Series3";
            series3.ChartArea = "Динамика обучения";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.LegendText = "Болен";
            series3.MarkerColor = System.Drawing.Color.Maroon;
            series3.MarkerSize = 4;
            series3.Name = "sick_positive";
            series4.BorderColor = System.Drawing.Color.Blue;
            series4.BorderWidth = 8;
            series4.ChartArea = "Динамика обучения";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.LegendText = "Вы";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.Name = "Series4";
            this.chart_sick.Series.Add(series2);
            this.chart_sick.Series.Add(series3);
            this.chart_sick.Series.Add(series4);
            this.chart_sick.Size = new System.Drawing.Size(946, 452);
            this.chart_sick.TabIndex = 8;
            title2.Font = new System.Drawing.Font("Panton Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Position.Auto = false;
            title2.Position.Height = 4.265593F;
            title2.Position.Width = 94F;
            title2.Text = "Визуализация обучения";
            this.chart_sick.Titles.Add(title2);
            // 
            // ofd_select
            // 
            this.ofd_select.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::volchanka.Properties.Resources.b76204f7f6a527d9c9a4107c5aa20612;
            this.pictureBox1.Location = new System.Drawing.Point(419, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::volchanka.Properties.Resources.all;
            this.pictureBox2.Location = new System.Drawing.Point(419, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(876, 398);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1121, 460);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(165, 149);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 752);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.gbCheck);
            this.Controls.Add(this.chart_errorDynamic);
            this.Controls.Add(this.chart_sick);
            this.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Диагностика КРАСНОЙ ВОЛЧАНКИ";
            ((System.ComponentModel.ISupportInitialize)(this.nudLayer)).EndInit();
            this.gbCheck.ResumeLayout(false);
            this.gbCheck.PerformLayout();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_errorDynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudLayer;
        private System.Windows.Forms.GroupBox gbCheck;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNeuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_done;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_errorDynamic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sick;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog ofd_select;
        private System.Windows.Forms.SaveFileDialog sfd_save;
        private System.Windows.Forms.Label lbl_epoxi;
        private System.Windows.Forms.Label lbl_diagnos;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button button_diagnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

