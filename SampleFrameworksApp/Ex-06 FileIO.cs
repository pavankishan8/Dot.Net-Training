using System;
using System.Collections.Generic;
using System.IO;

namespace SampleFrameworksApp
{
    class Ex_06FileIO
    {
        static void Main(string[] args)
        {
            string desktopFile = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop) + "/" + "Assignments Dot Net.txt";

            //string filename = "../../Ex-01 Collections.cs";
            readFileExample(desktopFile);

            //writeFileExample(desktopFile);
        }

        private static void writeFileExample(string desktopFile)
        {
            var content = "Sample";
            File.WriteAllText(desktopFile, content);
        }
            
        private static void readFileExample(string filename)
        {

            if (!File.Exists(filename))
            {
                Console.WriteLine("File path is Wrong");
            }
            else
            {
                var contents = File.ReadAllText(filename);
                Console.WriteLine(contents);
            }
        }
    }
}
