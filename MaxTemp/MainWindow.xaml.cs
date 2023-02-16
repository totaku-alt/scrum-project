using System;
using System.Collections;
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
            //Hier wird der Sensor eingefügt
            string sensorName = txtEingabe.Text;
            //Zugriff auf Datei erstellen.
            string fileName = "temps.csv";
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"MaxTemp\", fileName);
            // System.IO.Path.Combine(Environment.CurrentDirectory = Geht in deinen aktuellen VisualStudio Projekt Ordner und schaut nach Der Datei die im @ deklariert ist.

            //csv wird in einem Array zugewiesen
            string[] csvLines = File.ReadAllLines(path);

            Array.Sort(csvLines);

            //List Objekt wird verwendet um die Add() Methode zu verwenden
            ArrayList arlist = new ArrayList();

            //Der sensorName bestimmt die Elemente die in Liste hinzugefügt werden
            for (int i = 0; i < csvLines.Length; i++)
            {
                string changedSensor = csvLines[i].Remove(3, 20);
                if (changedSensor.Contains(sensorName))
                {
                    arlist.Add(changedSensor);
                }  
            }

            //Hier wird die Liste noch einmal sortiert damit am Ende die Höchsttemperatur ist
            arlist.Sort();

            //Letzter Wert in der Liste
            string lastElement = (string)arlist[arlist.Count - 1];
            
            //Ausgabe des Wertes in der xaml
            lblAusgabe.Content = $"Höchste Temperatur ist: {lastElement} °C";
        }
    }
}
