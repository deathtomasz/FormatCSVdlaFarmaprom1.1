using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;


using System.Linq.Expressions;


namespace FormatCSVdlaFarmaprom1._1
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            setfiledir();
            InitializeComponent();
            loadcsv();          

        }



        //ustalenie aktualnej sciezki pliku z aplikacją
        static string filesstringinfo = Directory.GetCurrentDirectory().ToString() + @"\filespaths.txt";

        //ustalenie wartości ze sciezką w drugim wierszu zaczytanbego pliku
        public static string setfiledir()
        {
            List<string> path666 = File.ReadAllLines(filesstringinfo).ToList();
            string p1 = path666[1].ToString() + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
            return p1;         
        }

        static bool succes;


        public static void loadcsv()
        {

            try
            {
                var lines = File.ReadAllLines(setfiledir()).ToList();

                // lines.Insert(0, "sep=;");

                List<string> nowa = new List<string>();

                foreach (string line in lines)
                {
                    string output = line.Replace(",", ";");
                    //MessageBox.Show(setfiledir().ToString());
                    nowa.Add(output);
                }

                string[] abrakadabra = nowa.ToArray();
                File.WriteAllLines(setfiledir(), abrakadabra);
                succes = true;
            }
            catch
            {


                MessageBox.Show($"\n\n\n" + "##############################################" + "\n\n" +
                                           "Nie znaleziono pliku do przeformatowania!" +
                                           "\n" + "Prawidła nazwa pliku to:" + "\n" + "'aktualna data <yyyy-mm-dd> Apteki w Aflofarm Plus (tak-nie).csv '" +
                                           "\n" + "Ewentualnie powiadom Tomka!" +
                                           "\n\n" + "##############################################" + "\n\n\n"); // + "Enter, żeby zamknąć okno.");

                succes = false;
            }
        }



        private void Form2_Load_1(object sender, EventArgs e)

        {
            if (!succes)
            {
                this.Close();
                Application.Exit();

            }

            label1.Text = "Poprawnie wygenerowano plik dla Farmaprom";

        }




                private void button1_Click_1(object sender, EventArgs e)
                {
                    Application.Exit();
                }

                private void button2_Click_1(object sender, EventArgs e)
                {
                    System.Diagnostics.Process.Start(setfiledir());
                    Application.Exit();
                }
    }
}
