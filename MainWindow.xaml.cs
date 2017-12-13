//******************************************************
// File: MainWindow.xaml.cs
//
// Purpose: The main use of this class will be to display
//          a Graphical User Interface. 
//
// Written By: Jonathan Cucuzza
//
// Compiler: Visual Studio 2015
//
//******************************************************
using System;
using System.Windows;
using Microsoft.Win32;
using TrainStation;
using System.IO;
using System.Runtime.Serialization.Json;

namespace jonathancucuzza.bcs450.lirr
{

    public partial class MainWindow : Window
    {
     
        StationCollection collection = new StationCollection();
 
        //****************************************************
        // Method: MainWindow
        //
        // Purpose: sets specific textBoxes to read only, 
        //          initializes component.
        //****************************************************
        public MainWindow()
        {
            InitializeComponent();
            textBox_Name.IsReadOnly = true;
            textBox_Location.IsReadOnly = true;
            textBox_FareZone.IsReadOnly = true;
            textBox_MileageToPenn.IsReadOnly = true;
            textBox_PicFilename.IsReadOnly = true;
        }
        //****************************************************
        // Method: button_Filename_Click
        //
        // Purpose: Opens a file dialog window. Deserializes 
        //          JSON code. Populates listView.
        //****************************************************
        private void button_Filename_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open StationCollection From JSON";
            openFileDialog.Filter = "JSON files (*.json) | *.json";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            textBox_Filename.Text = filePath;
            FileStream ReadJSON = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(StationCollection));
            collection = (StationCollection)inputSerializer.ReadObject(ReadJSON);
            ReadJSON.Close();
            listView.ItemsSource = collection.Stations;
        }
        //****************************************************
        // Method: button_StationId_Click
        //
        // Purpose: Searches for station entered by ID# from
        //          user. Displays data for that given station.
        //****************************************************
        private void button_StationID_Click(object sender, RoutedEventArgs e)
        {
            Station blah = collection.FindStation(int.Parse(textBox_StationID.Text));
            textBox_Name.Text = blah.Name;
            textBox_Location.Text = blah.Location;
            textBox_FareZone.Text = Convert.ToString(blah.FareZone);
            textBox_MileageToPenn.Text = Convert.ToString(blah.MileageToPenn);
            textBox_PicFilename.Text = blah.PicFilename;
        }
    }
}
