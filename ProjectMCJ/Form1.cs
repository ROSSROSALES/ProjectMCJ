﻿using System;
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

            string userInput = loadIDTextBox.Text;

            if (LoadTargetMap.ContainsKey(userInput))
            {
                Console.WriteLine(userInput);
                Console.WriteLine(LoadTargetMap[userInput]);
                targetTextBox.Text = LoadTargetMap[userInput];
            }
            if (!LoadTargetMap.ContainsKey(userInput))
            {
                targetTextBox.Text = "Does Not Exist";
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
                    folderPathLabel.Text = "";
                }
                else
                {
                    Console.WriteLine("No .txt files found in the directory.");
                    folderPathLabel.Text = "No .txt files found in the directory.";
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
                        string Target = "Clearing Station";

                        if (values[1].Trim().Length == 3) // This is with the assumption that Target locations have length 3. ie C01 or B02
                        {
                            Target = values[1].Trim();
                        }

                        LoadTargetMap[LoadID] = Target;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// select folder with data
        /// updates which folder the application is searching for text files
        /// </summary>
        private void selectFolderPath(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the initial directory
                folderBrowserDialog.SelectedPath = @"C:";

                // Show the folder selection dialog
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Check if the user selected a folder
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    directoryPath = folderBrowserDialog.SelectedPath;
                    folderPathTextBox.Text = directoryPath;
                }
            }
        }

        /// <summary>
        /// text is red until 20 characters is reached
        /// updates the label to inform user
        /// </summary>
        private void loadIDTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = loadIDTextBox.Text;

            if (!IsValidInput(input))
            {
                loadIDTextBox.ForeColor = Color.Red;
                loadIDLabel.Text = "Input must be 20 characters long.";
            }
            else
            {
                loadIDTextBox.ForeColor = SystemColors.ControlText;
                loadIDLabel.Text = "";
            }
        }

        /// <summary>
        /// valid input must be x characters long
        /// </summary>
        private bool IsValidInput(string input)
        {
            return !string.IsNullOrEmpty(input) && input.Length == 20;
        }

    }
}
