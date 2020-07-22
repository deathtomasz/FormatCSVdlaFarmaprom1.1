using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;



namespace FormatCSVdlaFarmaprom1._1
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            loadcsv();

        }

        
        
            static string sciecha = @"M:\Kuba-Arek-Aflofarm Plus - pliki\Farmaprom - zgłoszenia\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
            static string sciecha3 = @"M:\Kuba-Arek-Aflofarm Plus - pliki\Farmaprom - zgłoszenia\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
            // static string sciecha = @"C:\Users\Tomek\Documents\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";
            //static string sciecha3 = @"C:\Users\Tomek\Documents\" + DateTime.Now.ToString("yyyy-MM-dd") + " Apteki w Aflofarm Plus (tak-nie).csv";

           
            public static void loadcsv()
            {
                List<string> linie = new List<string>();
                try
                {
                    var lines = File.ReadAllLines(sciecha).ToList();


                    // lines.Insert(0, "sep=;");

                    List<string> nowa = new List<string>();
                    foreach (var line in lines)
                    {
                        string output = line.Replace(",", ";");
                      //  Console.WriteLine(output);
                        nowa.Add(output);
                    }
                       //File.WriteAllLines(sciecha3, nowa);
                }
                catch
                {
                    MessageBox.Show($"\n\n\n\n" + "##############################################" + "\n\n" +
                                       "Nie znaleziono pliku do przeformatowania!" +
                                       "\n" + "Prawidła nazwa pliku to"+"\n" +"'aktualna data <yyyy-mm-dd> Apteki w Aflofarm Plus (tak-nie).csv '" +
                                       "\n" + "Ewentualnie powiadom Tomka!" +
                                       "\n\n" + "##############################################" + "\n\n\n" // + "Enter, żeby zamknąć okno.");
                
                   // Console.ReadLine();
                }
            }
        



    }





}
