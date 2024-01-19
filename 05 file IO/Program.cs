using System;
using System.IO;

namespace _05_file_IO
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //create a text file in a folder(bin) of thr projrect
                //path =<proj folder>\bin\debug\<framewprk
                StreamWriter stream = File.CreateText("File.txt");
                stream.WriteLine("This is a text file.");
                stream.WriteLine("Hello,I AM SHAHIN ALAM");

                stream.WriteLine("MY NAME IS shahin ALAM");
                stream.Close();
            string directoryPath = @"C:\text";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // first make sure folder 
            stream = File.CreateText(@"C:\text\File.txt");
                stream.WriteLine("Text file in it a differerm");
                stream.Close();
                // create a destop files
                string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string desktopFilePath = Path.Combine(desktopfolder, "desktop.text");
                stream = File.CreateText(desktopFilePath);
                stream.WriteLine("Hello");

                stream.Close();

                if (File.Exists(desktopFilePath))
                {
                    stream = File.AppendText(desktopFilePath);
                    stream.WriteLine("");
                    stream.Close();

                }
               
            }
        }

    }                                                                       