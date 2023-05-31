using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjectMCJ
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> LoadTargetMap = new Dictionary<string, string>();
        List<string> fileContent = new List<string>();
        string directoryPath = @"C:\Users\";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Find Target with LoadID in textbox
        /// searches LoadTargetMap, and displays Target in TextBox
        /// </summary>
        private void findTarget(object sender, EventArgs e)
        {
            storeNewestTextFile();
            MapLoadTarget();

            string userInput = textBox1.Text;

            if (LoadTargetMap.ContainsKey(userInput))
            {
                Console.WriteLine(userInput);
                Console.WriteLine(LoadTargetMap[userInput]);
                textBox2.Text = LoadTargetMap[userInput];
            }
            else
            {
                textBox2.Text = "Does not Exist";
            }
        }

        /// <summary>
        /// checks specified folder path for .txt files 
        /// reads the newest file and stores to List
        /// </summary>
        private void storeNewestTextFile()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(directoryPath, "*.txt");

                if (filePaths.Length > 0)
                {
                    string newestFilePath = filePaths
                        .OrderByDescending(f => File.GetLastWriteTime(f))
                        .First();

                    string[] linesInFile = File.ReadAllLines(newestFilePath);

                    fileContent = new List<string>(linesInFile);

                    Console.WriteLine($"Newest file: {Path.GetFileName(newestFilePath)}");
                }
                else
                {
                    Console.WriteLine("No .txt files found in the directory.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// reads List fileContent
        /// stores LoadID and Target into hashMap 
        /// </summary>
        private void MapLoadTarget()
        {
            try
            {
                foreach (string line in fileContent)
                {
                    string[] values = line.Split(';');

                    if (values.Length == 9)
                        Console.WriteLine(values);
                    {
                        string LoadID = values[0].Trim();
                        string Target = values[1].Trim();

                        LoadTargetMap[LoadID] = Target;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void selectFolderPath(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the initial directory (optional)
                folderBrowserDialog.SelectedPath = @"C:\path\to\default\folder";

                // Show the folder selection dialog
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Check if the user selected a folder
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    
                    directoryPath = folderBrowserDialog.SelectedPath;
                    textBox3.Text = directoryPath;
                }
            }
        }


    }
}
