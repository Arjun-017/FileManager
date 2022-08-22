using System;
using System.Collections.Generic;
using System.Text;

namespace FileManager
{
    class ValueObjectParser
    {
        public List<APVO> convertAllDataFromFile(string[][] items)
        {
            List<APVO> APList = new List<APVO>();
            List<FMVO> FMList = new List<FMVO>();
            List<VDVO> VDList = new List<VDVO>();
            List<RVVO> RVList = new List<RVVO>();
            foreach (var item in items)
            {
                FMList.Clear();
                RVList.Clear();
                VDList.Clear();
                APVO AP = new APVO();
                foreach (var line in item)
                {
                    string[] index = line.Split(",");
                    AP.FMList = FMList;
                    AP.RVList = RVList;
                    AP.VDList = VDList;
                    switch (index[0])
                    {
                        case "AD":
                            AP.AD = new ADVO(index[1], index[2], index[3]);
                            break;
                        case "FM":
                            AP.FMList.Add(new FMVO(index[1], index[2], index[3], index[4]));
                            break;
                        case "RV":
                            AP.RVList.Add(new RVVO(index[1], index[2], index[3]));
                            break;
                        case "VD":
                            AP.VDList.Add(new VDVO(index[1], index[2], index[3], index[4]));
                            break;
                    }

                }
                APList.Add(AP);

            }
            return APList;
        }
        public List<VDVO> convertVehicleDataFromFile(string[] lines)
        {
            string[] items;
            List<VDVO> VDList = new List<VDVO>();
            foreach (var line in lines)
            {
                items = line.Split(",");
                VDList.Add(new VDVO(items[1], items[2], items[3], items[4]));

            }
            return VDList;

        }
        public List<RVVO> convertVisitorDataFromFile(string[] lines)
        {
            string[] items;
            List<RVVO> RVList = new List<RVVO>();
            foreach (var line in lines)
            {
                items = line.Split(",");
                RVList.Add(new RVVO(items[1], items[2], items[3]));

            }
            return RVList;
        }
        public List<ADVO> convertApartmentDataFromFile(string[] lines)
        {
            string[] items;
            List<ADVO> ADList = new List<ADVO>();
            foreach (var line in lines)
            {
                items = line.Split(",");
                ADList.Add(new ADVO(items[1], items[2], items[3]));

            }
            return ADList;

        }
        public List<FMVO> convertFamilyMemberDataFromFile(string[] lines)
        {
            string[] items;
            List<FMVO> FMList = new List<FMVO>();
            foreach (var line in lines)
            {
                items = line.Split(",");
                FMList.Add(new FMVO(items[1], items[2], items[3], items[4]));

            }
            return FMList;

        }

    }

}
