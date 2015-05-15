using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeisStrangeTranslator
{
    class LISTransTools
    {
        string[] fileEntrys;
        public List<string[]> tempList;

        public void CSV2TransFile(string filename,DataGridView dgv)
        {
            string CSVFilename = filename.Replace(".csv", "");
            CSVFilename = CSVFilename.Replace("LifeisStrangeGerman - ", "");
            StreamWriter TransFile = new StreamWriter(CSVFilename + ".GER");
            //Datei verarbeiten
            fileEntrys = File.ReadAllLines(filename);
            
            foreach (string line in fileEntrys)
            {
                if (!line.StartsWith("["))
                {
                    string[] temp = line.Split(',');
                    string[] sTemp = new string[2];
                    int seperatorPos = line.IndexOf(",");
                    sTemp[0] = line.Substring(0, seperatorPos);
                    sTemp[1] = line.Remove(0, seperatorPos + 1);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0}=\"{1}\"", sTemp[0], sTemp[1]);
                    sb.Replace("\"\"", "\"");

                    TransFile.WriteLine(sb.ToString());
                }
                else
                {
                    string tempLine = line.Remove(line.Length - 1);
                    TransFile.WriteLine(tempLine);
                }
            }
            TransFile.Close();
        }


        public void ExporttoCSV(DataGridView dgv, string destination)
        {
            //Datei verarbeiten
            if (fileEntrys.Length != 0)
            {
                StreamWriter csvexport = new StreamWriter(destination);

                //Tabelle füllen
                foreach (string line in fileEntrys)
                {
                   
                    if (!line.StartsWith("["))
                    {
                        string[] temp = line.Split('=');

                    }
                    else
                    {

                    }
                }
                csvexport.Close();
            }
        }

        public void parseCSVFile(string filename)
        {
            tempList = new List<string[]>();
            fileEntrys = File.ReadAllLines(filename);
            //Tabelle füllen
            foreach (string line in fileEntrys)
            {
                string[] sTemp = new string[2];

                if (!line.StartsWith("["))
                {
                    int seperatorPos = line.IndexOf(",");
                    sTemp[0] = line.Substring(0, seperatorPos);
                    sTemp[1] = line.Remove(0, seperatorPos + 1);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("\"{0}\"", sTemp[1]);
                    sb.Replace("\"\"", "\"");
                    sTemp[1] = sb.ToString();
                    tempList.Add(sTemp);
                }
                else
                {
                    sTemp[0] = line.Replace(",", "");
                    sTemp[1] = "";
                    tempList.Add(sTemp);
                }
            }
        }
    }
}
