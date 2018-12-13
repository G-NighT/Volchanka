using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using static volchanka.Program;

namespace volchanka
{
    public partial class Form1 : Form
    {
        List<double[]> learn;
        List<double[]> check;
        Web web;
        CNetwork network;

        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            startttt();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            chart_errorDynamic.Series[0].Points.Clear();
            chart_sick.Series[0].Points.Clear();
            chart_sick.Series[1].Points.Clear();            
            chart_sick.Series[2].Points.Clear();

            if (rb2.Checked == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                parseLearnTxt();
                this.web = new Web();
                this.web = web.createWeb(7, Decimal.ToInt32(nudNeuro.Value), Decimal.ToInt32(nudLayer.Value), rnd);
                List<double> error_list = web.getErrorList();
                lbl_done.Text = this.web.learnWeb(learn, rnd, Decimal.ToDouble(nudAge.Value)) + "  " + error_list.Count.ToString();
                plot();
            }
            else
            {
                // Включить анимацию
                pictureBox1.Visible = true;

                // Создать сеть
                network = new CNetwork(Decimal.ToInt32(nudLayer.Value), Decimal.ToInt32(nudNeuro.Value));

                // Количество эпох
                int N = Decimal.ToInt32(nudAge.Value);

                // Текущая и старая ошибка
                double Enow = 0, Eold = 0;
                
                // Работа с выборкой
                string[] lines = File.ReadAllLines("learn.txt");
                double _a, _b, _c, _d, _e, _f, _g, _res;
                List<CParam> lst = new List<CParam>();
                foreach (string str in lines)
                {
                    string[] param = str.Split(new char[] { ';' });
                    Double.TryParse(param[0], out _a);
                    Double.TryParse(param[1], out _b);
                    Double.TryParse(param[2], out _c);
                    Double.TryParse(param[3], out _d);
                    Double.TryParse(param[4], out _e);
                    Double.TryParse(param[5], out _f);
                    Double.TryParse(param[6], out _g);
                    Double.TryParse(param[7], out _res);
                    CParam temp = new CParam(_a, _b, _c, _d, _e, _f, _g, _res);
                    lst.Add(temp);
                }

                // Цикл по всем эпохам
                for (int i = 0; i < N; i++)
                {
                    // Цикл по выборке
                    double sum = 0;
                    foreach (CParam param in lst)
                    {
                        List<double> resLst = network.GetCalculation(param);
                        sum += Math.Pow(param._res - resLst[0], 2);
                    }

                    // Текущая ошибка
                    Enow = sum / N;

                    // При привышении текущей ошибки над старой сделать откат
                    if (i > 0 && Eold < Enow)
                    {
                        network.Recoil();
                        Enow = Eold;
                    }
                    else
                    {
                        Eold = Enow;
                    }

                    // Обучить нейронную сеть
                    network.Education();

                    // Добавить ошибку в лист
                    network.ErrorLst.Add(Enow);

                    // Отрисовать прямо в цикле
                    if (checkBox8.Checked == true)
                    {
                        if (i > 0) DrawGraphics();
                        this.Refresh();

                        lbl_done.ForeColor = Color.Blue;
                        lbl_epoxi.ForeColor = Color.Blue;
                        lbl_err.ForeColor = Color.Blue;
                        lbl_done.Text = "Обучаюсь.";
                        lbl_epoxi.Text = "Эпоха: " + i.ToString();
                        richTextBox1.AppendText(network.ErrorLst[i].ToString().Substring(0, 13) + Environment.NewLine);
                        lbl_err.Text = "Ошибка = " + network.ErrorLst[i].ToString().Substring(0,13);
                    }
                }

                // Откатить сеть
                network.Recoil();

                // Отрисовать графики после обучения
                if (!checkBox8.Checked)
                {
                    DrawGraphics();
                }

                // Пост-обработка
                lbl_done.ForeColor = Color.Green;
                lbl_epoxi.ForeColor = Color.Green;
                lbl_err.ForeColor = Color.Green;
                lbl_done.Text = "Обучена.";
                lbl_epoxi.Text = "Кол-во эпох: " + network.ErrorLst.Count.ToString();
                lbl_err.Text = "Ошибка = " + network.ErrorLst[N-1].ToString().Substring(0, 13);
                button_diagnos.Enabled = true;
                button_check.Enabled = true;
                button_save.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void DrawGraphics()
        {
            // Отрисовка графика
            chart_errorDynamic.Series[0].Points.Clear();
            if (network.ErrorLst.Count != 0)
            {
                for (int i = 0; i < network.ErrorLst.Count; i++)
                {
                    chart_errorDynamic.Series[0].Points.AddXY(i, network.ErrorLst[i]);
                }
            }
        }

        private void button_diagnos_Click(object sender, EventArgs e)
        {
            if (rb2.Checked == true)
            {
                List<double> error_list = web.getErrorList();
                double[] param = new double[7];
                if (checkBox1.Checked) param[0] = 1; else param[0] = -1;
                if (checkBox2.Checked) param[1] = 1; else param[1] = -1;
                if (checkBox3.Checked) param[2] = 1; else param[2] = -1;
                if (checkBox4.Checked) param[3] = 1; else param[3] = -1;
                if (checkBox5.Checked) param[4] = 1; else param[4] = -1;
                if (checkBox6.Checked) param[5] = 1; else param[5] = -1;
                if (checkBox7.Checked) param[6] = 1; else param[6] = -1;

                double bbb = this.web.testWeb(param);

                if (bbb < 0)
                {
                    lbl_res.ForeColor = Color.Green;
                    lbl_diagnos.ForeColor = Color.Green;
                    lbl_diagnos.Text = "Вероятно, Вы здоровы";
                }
                else
                {
                    lbl_res.ForeColor = Color.Red;
                    lbl_diagnos.ForeColor = Color.Red;
                    lbl_diagnos.Text = "Вероятно, у Вас волчанка!";
                }
                lbl_res.Text = bbb.ToString();
                chart_sick.Series[2].Points.Clear();
                chart_sick.Series[2].Points.AddXY(bbb, 0);
                chart_sick.Series[2].Points.AddXY(bbb, error_list.Count - 1);
            }
            else
            {
                double Artrit, Disk, Antitela, Yazva, Skuli, Pochki, Serozit;
                if (checkBox1.Checked) Artrit = 1;   else Artrit = -1;
                if (checkBox2.Checked) Disk = 1;     else Disk = -1;
                if (checkBox3.Checked) Antitela = 1; else Antitela = -1;
                if (checkBox4.Checked) Yazva = 1;    else Yazva = -1;
                if (checkBox5.Checked) Skuli = 1;    else Skuli = -1;
                if (checkBox6.Checked) Pochki = 1;   else Pochki = -1;
                if (checkBox7.Checked) Serozit = 1;  else Serozit = -1;
                CParam param = new CParam(Artrit, Disk, Antitela, Yazva, Skuli, Pochki, Serozit, 0);
                double res = network.GetCalculation(param)[0];
                lbl_res.Text = res.ToString();
                if (res < 0)
                {
                    lbl_res.ForeColor = Color.Green;
                    lbl_diagnos.ForeColor = Color.Green;
                    lbl_diagnos.Text = "Вероятно, Вы здоровы";
                }
                else
                {
                    lbl_res.ForeColor = Color.Red;
                    lbl_diagnos.ForeColor = Color.Red;
                    lbl_diagnos.Text = "Вероятно, у Вас волчанка!";
                }
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            parseCheckTxt();
            double fff = this.web.testWeb(check[1]);
            MessageBox.Show("Диагноз: " +fff.ToString());
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            nudLayer.Value = 2;
            nudNeuro.Value = 3;
            nudAge.Value = 80;
            rb1.Checked = false;
            rb2.Checked = true;
        }

        public void parseLearnTxt()
        {
            learn = new List<double[]>();
            var l = File.ReadAllLines("learn.txt");
            foreach (string s in l)
            {
                string w;
                w = Regex.Replace(s,@"[;]","",RegexOptions.Compiled);
                double[] param = new double[8];
                for (int i = 0; i < 8; i++)
                {
                    if (w[i].ToString() != "0")
                        param[i] = Convert.ToDouble(w[i].ToString());
                    else
                        param[i] = -1;
                }
                learn.Add(param);
            }
        }

        public void parseCheckTxt()
        {
            check = new List<double[]>();
            var l = File.ReadAllLines("check.txt");
            foreach (string s in l)
            {
                string w;
                w = Regex.Replace(s, @"[;]", "", RegexOptions.Compiled);
                double[] param = new double[8];
                for (int i = 0; i < 8; i++)
                {
                    param[i] = Convert.ToDouble(w[i].ToString());
                }
                check.Add(param);
            }
        }

        static void SaveToXML(Web Network, string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, Network);
            }
        }
        static Web OpenXml(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Web Temp = (Web)bf.Deserialize(fs);
            return Temp;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                sfd_save.FileName = @"*.maxim";
                sfd_save.InitialDirectory = Application.ExecutablePath;
                sfd_save.ShowDialog();
                SaveToXML(this.web, sfd_save.FileName);
            }
            catch
            {

            }
        }

        private void startttt()
        {
            if (Global.name != null)
            {
                this.web = OpenXml(Global.name);
                parseLearnTxt();
                plot();
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                chart_errorDynamic.Series[0].Points.Clear();
                chart_sick.Series[0].Points.Clear();
                chart_sick.Series[1].Points.Clear();
                chart_sick.Series[2].Points.Clear();
                ofd_select.FileName = @"*.maxim";
                ofd_select.InitialDirectory = Application.ExecutablePath;
                ofd_select.ShowDialog();
                this.web = OpenXml(ofd_select.FileName);
                parseLearnTxt();
                plot();
            }
            catch
            {

            }
        }

        private void plot()
        {
            List<double> error_list = web.getErrorList();
            lbl_done.ForeColor = Color.Green;
            lbl_epoxi.ForeColor = Color.Green;
            lbl_err.ForeColor = Color.Green;
            lbl_done.Text = "Обучена.";
            lbl_epoxi.Text = "Кол-во эпох: " + error_list.Count.ToString();
            lbl_err.Text = "Ошибка = " + error_list[error_list.Count - 1].ToString().Substring(0, 13);
            button_diagnos.Enabled = true;
            button_check.Enabled = true;
            button_save.Enabled = true;

            if (checkBox8.Checked == true)
            {
                chart_errorDynamic.ChartAreas[0].AxisY.Minimum = 0;
                chart_errorDynamic.ChartAreas[0].AxisX.Minimum = 0;
                for (int i = 0; i < error_list.Count; i++)
                {
                    chart_errorDynamic.Series[0].Points.AddXY(i, error_list[i]);
                    this.Refresh();
                }

                List<double[]> val = web.getFinalValues();
                chart_sick.ChartAreas[0].AxisY.Minimum = 0;
                for (int i = 0; i < error_list.Count; i++)
                {
                    for (int j = 0; j < val[i].Count(); j++)
                    {
                        if (learn[j][7] == -1)
                        {
                            chart_sick.Series[0].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                        }
                        else
                        {
                            chart_sick.Series[1].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                        }
                    }
                    this.Refresh();
                }
            }
            else
            {
                chart_errorDynamic.ChartAreas[0].AxisY.Minimum = 0;
                chart_errorDynamic.ChartAreas[0].AxisX.Minimum = 0;
                for (int i = 0; i < error_list.Count; i++)
                {
                    chart_errorDynamic.Series[0].Points.AddXY(i, error_list[i]);
                }

                List<double[]> val = web.getFinalValues();
                chart_sick.ChartAreas[0].AxisY.Minimum = 0;
                for (int i = 0; i < error_list.Count; i++)
                {
                    for (int j = 0; j < val[i].Count(); j++)
                    {
                        if (learn[j][7] == -1)
                        {
                            chart_sick.Series[0].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                        }
                        else
                        {
                            chart_sick.Series[1].Points.AddXY(val[i][j], i + rnd.NextDouble() / 5.0 - 0.1);
                        }
                    }
                }
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb2.Checked = false;
            checkBox8.Checked = true;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = true;
            checkBox8.Checked = false;
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            if (nudAge.Value > 699)
            {
                rb1.Checked = true;
                rb2.Checked = false;
                checkBox8.Checked = true;
            }
        }
    }
}
