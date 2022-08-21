using System;
using System.Collections.Generic;
using System.IO;

namespace UtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Utility U = new Utility();
             U.initializeFileStructure();
             foreach(var line in U.readFromFilePath(@"C:\Users\arjunharidas\source\repos\UtilityClass\UtilityClass\1A\FM.txt"))
             {
                 Console.WriteLine($"{line}");
             }*/
            ValueObjectParser VO = new ValueObjectParser();
            string[][] dummy = new string[][]
            {
                new string[]{
                    "AD,1A,Mr Rahul Khanna,3BHK",
                    "FM,Mr Rahul Khanna,Smuggler,12/12/1978,Self",
                    "FM,Mrs Reena Khanna,Software Engineer,11/07/1976,Wife",
                    "FM,Tommy Khanna,Gamer,31/03/1996,Son",
                    "FM,Twinkle Khanna,Modelling,25/02/1999,Daughter",
                    "VD,KL01BT4567,4 Wheeler,XUV 500,IN",
                    "VD,KL01BT1234,2 Wheeler,Royal Enfield Hunter 350,OUT",
                    "RV,1234,Mrs Leela Tripati,Domestic Help",
                    "RV,1235,Mr Thomas Kurien,Driver"
                }
            };
            List<APVO> APList = VO.convertAllDataFromFile(dummy);
        }
    }
    class Utility
    {
        private string currentPath = @"D:\building\";
        public string getFilePath(string app_no, string type)
        {
            string path;
            path = @"D:\building\${app_no}\${type}";
            return path;
        }
        public void initializeFileStructure()
        {
            string[] lines = File.ReadAllLines(@"D:\data.txt");
            string tempPath = "";
            string[] items;
            foreach (var line in lines)
            {
                items = line.Split(",");
                switch (items[0])
                {
                    case "AD":
                        tempPath = @$"{currentPath}{items[1]}";
                        Directory.CreateDirectory(@$"{tempPath}");
                        break;
                    case "FM":
                        File.AppendAllText(@$"{tempPath}\FM.txt", $"{items[1]},{items[2]},{items[3]},{items[4]}\n");
                        break;
                    case "VD":
                        File.AppendAllText(@$"{tempPath}\VD.txt", $"{items[1]},{items[2]},{items[3]}\n");
                        break;
                    case "RV":
                        File.AppendAllText(@$"{tempPath}\RV.txt", $"{items[1]},{items[2]},{items[3]}\n");
                        break;
                    default: break;
                }
            }
        }
        public void writeToFilePath(string path, string msg)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, $"{msg}\n");
            }
        }
        public string[] readFromFilePath(string path)
        {
            if (File.Exists(path))
            {
                string[] lines= File.ReadAllLines(path);
                return lines;
            }
            return new string[] { };
        }
    }
    
}
