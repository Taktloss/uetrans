﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace LifeisStrangeTranslator
{

        public partial class Form1 : Form
        {
        string[] fileEntrys;
        string tempFilename;
        List<string[]> tempList;

        public Form1()
        {
            InitializeComponent();
        }

      /*  public static class Extentions
        {
            public static DataGridView Clone(this DataGridView oldDGV)
            {
                DataGridView newDGV = new DataGridView();

                newDGV.Size = oldDGV.Size;
                newDGV.Anchor = oldDGV.Anchor;

                return newDGV;
            }
        }
            */

        private bool charcheck(string line)
        {
            string temp = line[0].ToString();
            switch(temp)
            {
                case "[": return true;
                    break;
                case "#": return true;
                    break;
                default: return false;
            }

        }

        private void parseTranslationFile(string filename)
        {
            tempList = new List<string[]>();
            StreamReader sr = new StreamReader(filename);
            Encoding enc = sr.CurrentEncoding;

            fileEntrys = File.ReadAllLines(filename);
            //Tabelle füllen
            foreach (string line in fileEntrys)
            {
                bool check = charcheck(line);
                if (!check && line.Length != 0)
                {
                    string[] temp = line.Split('=');
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = temp[0];
                    row.Cells[1].Value = temp[1];
                    dataGridView1.Rows.Add(row);
                    tempList.Add(temp);
                }
                else if (line.Length != 0)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    string[] templine = new string[2];
                    templine[0] = line;
                    templine[1] = "";

                    row.Cells[0].Value = line;
                    dataGridView1.Rows.Add(row);
                    tempList.Add(templine);
                }
            }
        }

        private void parseCSVFile(string filename)
        {
            fileEntrys = File.ReadAllLines(filename);
            //Tabelle füllen
            foreach (string line in fileEntrys)
            {
                if (!line.StartsWith("["))
                {
                    string[] sTemp = new string[2];
                    int seperatorPos = line.IndexOf(",");
                    sTemp[0] = line.Substring(0, seperatorPos);
                    sTemp[1] = line.Remove(0, seperatorPos + 1);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("\"{0}\"", sTemp[1]);
                    sb.Replace("\"\"", "\"");

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = sTemp[0];
                    row.Cells[1].Value = sb;
                    dataGridView1.Rows.Add(row);
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                    row.Cells[0].Value = line.Replace(",","");
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void CSV2TransFile(string filename)
        {
            string CSVFilename = filename.Replace(".csv", "");
            CSVFilename = CSVFilename.Replace("LifeisStrangeGerman - ", "");
            
            StreamWriter TransFile = new StreamWriter(CSVFilename + ".GER");
            //Datei verarbeiten
            tempFilename = filename;

            fileEntrys = File.ReadAllLines(filename);

            //Tabelle füllen
            foreach (string line in fileEntrys)
            {
                if (!line.StartsWith("["))
                {
                    string[] temp = line.Split(',');
                    string[] sTemp = new string[2];
                    int seperatorPos = line.IndexOf(",");
                    sTemp[0] = line.Substring(0, seperatorPos);
                    sTemp[1] = line.Remove(0,seperatorPos+1);

                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = temp[0];
                    row.Cells[1].Value = temp[1];
                    dataGridView1.Rows.Add(row);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}=\"{1}\"", sTemp[0], sTemp[1]);
                    sb.Replace("\"\"", "\"");

                    TransFile.WriteLine(sb.ToString());
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = line;
                    dataGridView1.Rows.Add(row);
                    string tempLine = line.Remove(line.Length-1);
                    TransFile.WriteLine(tempLine);
                }
            }
            TransFile.Close();
        }

        private void ExporttoCSV(DataGridView dgv,string destination)
        {
            //Datei verarbeiten
            if (fileEntrys.Length != 0)
            {
                StreamWriter csvexport = new StreamWriter(destination);

                //Tabelle füllen
                foreach (string line in fileEntrys)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    if (!line.StartsWith("["))
                    {
                        string[] temp = line.Split('=');
                        row.Cells[0].Value = temp[0];
                        row.Cells[1].Value = temp[1];
                        dataGridView1.Rows.Add(row);      
                    }
                    else
                    {
                        row.Cells[0].Value = line;
                        dataGridView1.Rows.Add(row);
                    }
                }
                csvexport.Close();
            }
        }

        private void translationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "English|*.INT| German|*.GER";

            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string CSVFilename = "test.GER";
                StreamWriter TransFile = new StreamWriter(CSVFilename + ".GER", false, Encoding.Unicode);

                //Datei verarbeiten
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string[] sValues = new string[2];
                    sValues[0] = (string)row.Cells[0].Value;
                    sValues[1] = (string)row.Cells[1].Value;

                    if (sValues[0] != null)
                    {
                        if (!row.Cells[0].Value.ToString().StartsWith("["))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat("{0}=\"{1}\"", sValues[0], sValues[1]);
                            sb.Replace("\"\"", "\"");

                            TransFile.WriteLine(sb.ToString());
                        }
                        else
                        {
                            tempList.Add(sValues);
                            TransFile.WriteLine(sValues[0]);
                        }
                    }
                }
                TransFile.Close();
            }
        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Inhalt nach CSV exportieren
            string csvfilename = tempFilename.Substring(0, tempFilename.IndexOf('.'));
            ExporttoCSV(dataGridView1, csvfilename + ".csv");
            MessageBox.Show("Converted successfully to *.csv format");
        }

        private void cSVToTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV File|*.CSV|All Files|*.*";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = fileDialog.FileName;
                CSV2TransFile(file);
            }
        }

        private void translationFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Translation File|*.INT;*.GER;*.FRE" ;
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Tabelle leeren und Datei verarbeiten
                dataGridView1.Rows.Clear();
                parseTranslationFile(fileDialog.FileName);
            }
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV File|*.CSV";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Tabelle leeren und Datei verarbeiten
                dataGridView1.Rows.Clear();
                parseCSVFile(fileDialog.FileName);
            }
        }
        
        private void directoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Tabelle leeren
                dataGridView1.Rows.Clear();
                //Datei verarbeiten
                string path = folderDialog.SelectedPath;
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    int index = file.LastIndexOf("\\");
                    string temp = file.Substring(index+1);
                    //tabControl1.TabPages.Add(temp);
                    //Clone DataGridView1
                    DataGridView cloneDGV = new DataGridView();

                    int i = 0;
                    foreach(DataGridViewColumn col in this.dataGridView1.Columns)
                    {
                        cloneDGV.Columns.Add(new DataGridViewColumn(col.CellTemplate));
                        cloneDGV.Columns[i].HeaderText = col.HeaderText;
                        cloneDGV.Columns[i].AutoSizeMode = col.AutoSizeMode;

                        i++;
                    }
                    TabPage tp = new TabPage();
                    tp.Text = temp;
                    tp.Controls.Add(cloneDGV);
                    tabControl1.TabPages.Add(tp);


                    //CSV2TransFile(file);
                    parseTranslationFile(file);

                }
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Translation File|*.INT;*.GER;*.FRE|CSV File|*.CSV";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (fileDialog.FilterIndex) 
                { 
                    case 1: //Tabelle leeren und Übersetzungsdatei verarbeiten
                            dataGridView1.Rows.Clear();
                            parseTranslationFile(fileDialog.FileName);
                            break;
                    case 2: //Tabelle leeren und CSV Datei verarbeiten
                            dataGridView1.Rows.Clear();
                            parseCSVFile(fileDialog.FileName);
                            break;
                    default: 
                            break;
                }
            }
        }
    }
}
