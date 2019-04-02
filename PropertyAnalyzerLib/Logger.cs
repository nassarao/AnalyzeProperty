using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace PropertyAnalyzerLib
{
    public class Logger
    {
        public string DirectoryLocation { get; set; }
        public Property property { get; set; }
        public DirectoryInfo Directory { get; set; }
        public FileInfo File { get; set; }
        private string lineBreak = "----------------------------------------------------------------------------";

        public Logger(Property property)
        {

            DirectoryLocation = @"C:\Real_Estate\" + property.Address.State + "\\" +
                property.Address.City + "\\" + property.Address.StreetNumber + "_" + property.Address.StreetName;


            if (System.IO.Directory.Exists(DirectoryLocation))
                Directory = new DirectoryInfo(DirectoryLocation);
            else
                Directory = System.IO.Directory.CreateDirectory(DirectoryLocation);

            File = new FileInfo(Directory.FullName + "\\Analysis.txt");

            if (!File.Exists)
                write(property.ToString());

           

        }


        public void write(string message)
        {

            using (StreamWriter writer = new StreamWriter(File.FullName, true))
            {
                if (message.Contains("|"))
                {
                    writer.WriteLine(lineBreak);
                    string[] messages = message.Split('|');
                    for (int i = 0; i < messages.Length; i++)
                    {
                        writer.WriteLine(messages[i].Trim());
                    }
                }
                else
                    writer.WriteLine(message);
            }
        }

        public void openAnalysisFile()
        {
            Process.Start("notepad.exe", File.FullName);
        }

    }
}
