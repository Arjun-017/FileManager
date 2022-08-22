using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileManager
{
    
    interface IWriteManager
    {
        void writeApartmentData(string app_no, string line);
        void writeFamilyData(string ap_no, string line);
        void writeVehicleData(string Ap_no, string line);
        void writeVisitorData(string visitor_ID, string line);
    }
    class WriteManager
    {
        private List<IWriteManager> writers;
        private IWriteManager filewriter; 
        public WriteManager()
        {
            writers = new List<IWriteManager>();
            filewriter = new FileWriteManager();
            writers.Add(filewriter);
        }
        public void writeApartmentData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeApartmentData(ap_no, line);
            });
        }
        public void writeVisitorData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeVisitorData(ap_no, line);
            });
        }
        public void writeVehicleData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeVehicleData(ap_no, line);
            });
        }
        public void writeFamilyData(string ap_no, string line)
        {
            writers.ForEach(writer =>
            {
                writer.writeFamilyData(ap_no, line);
            });
        }
    }
    class FileWriteManager : IWriteManager
    {
        private string path { get; set; }
        private Utility utility { get; set; }
        public FileWriteManager()
        {
            utility = new Utility();
        }
        public void writeApartmentData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "AD");
            utility.writeToFilePath(path, line);
        }

        public void writeVisitorData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "RV");
            utility.writeToFilePath(path, line);
        }
        public void writeVehicleData(string ap_no, string line) {
            path = utility.getFilePath(ap_no, "VD");
            utility.writeToFilePath(path, line);
        }
        public void writeFamilyData(string ap_no, string line) {
            path = utility.getFilePath(ap_no, "FM");
            utility.writeToFilePath(path, line);
        }
    }

}
