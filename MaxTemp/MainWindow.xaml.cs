using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace MaxTemp {
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Routine (EventHandler des Buttons Auswerten) liest die Werte
        /// zeilenweise aus der Datei temps.csv aus, merkt sich den höchsten Wert
        /// und gibt diesen auf der Oberfläche aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void BtnAuswerten_Click(object sender, RoutedEventArgs e) {
            //Git commit
            string realString = "S1";
            //Zugriff auf Datei erstellen.
            string fileName = "temps.csv";
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"MaxTemp\", fileName);
            // System.IO.Path.Combine(Environment.CurrentDirectory = Geht in deinen aktuellen VisualStudio Projekt Ordner und schaut nach Der Datei die im @ deklariert ist.



            string[] csvLines = File.ReadAllLines(path);

            Array.Sort(csvLines);

            for (int i = 0; i < csvLines.Length; i++)
            {
                Debug.WriteLine(csvLines[i]);
            }









            //List<string> csvList = new List<string>();
            //if (File.Exists(fileName))
            //{
            //    StreamReader reader = new StreamReader(File.OpenRead(fileName));
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');
            //        foreach (var elements in values)
            //        {
            //            csvList.Add(elements);
            //            Debug.WriteLine(elements);
            //        }
            //    }

            //}
            //else
            //{
            //    Debug.WriteLine("File not found");
            //}
            //csvList.Sort();

            //Anfangswert setzen, um sinnvoll vergleichen zu können.

            //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".

            //List<string> sortedList = csvAsList.GetRange(35, 33);
            //foreach (var element in sortedList) {
            //    Console.WriteLine(element);
            //}
            //String highestTemp = sortedList.Last();

            //Datei wieder freigeben

            //Höchstwert auf Oberfläche ausgeben.
            //lblAusgabe.Content = $"Höchste Temperatur ist: {highestTemp} °C";

            //MessageBox.Show("Gleich kachelt das Programm...");
            //kommentieren Sie die Exception aus.
            //throw new Exception("peng");
        }
    }
}
