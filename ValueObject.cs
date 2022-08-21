using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityClass
{
    class ValueObjectParser
    {
        public List<APVO> convertAllDataFromFile(string[][] items)
        {
            List<APVO> APList = new List<APVO>();
            List<FMVO> FMList = new List<FMVO>();
            List<VDVO> VDList = new List<VDVO>();
            List<RVVO> RVList = new List<RVVO>();
/*            string[] items;
*/            /*foreach(var line in lines)
            {
                items = line.Split(",");
                switch (items[0])
                {
                    case "AD":
                        if(APList.Count == 0)
                        {
                            ADVO AD = new ADVO(items[1], items[2], items[3]);
                        }
                        APList.Add(AD, FMList, VDList, RVList);

                        break;
                    case "FM":
                        FMVO FM = new FMVO(items[1], items[2], items[3],items[4],items[5]);
                        FMList.Add(FM);
                        break;
                    case "RV":
                        RVVO RV = new RVVO(items[1], items[2], items[3]);
                        RVList.Add(RV);
                        break;
                    case "VD":
                        VDVO VD = new VDVO(items[1], items[2], items[3]);
                        VDList.Add(VD);
                        break;
                    
                }
            }*/
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
            foreach(var line in lines)
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

    class APVO
    {
        public ADVO AD { get; set; } 
        public List<FMVO> FMList { get; set; }
        public List<VDVO> VDList { get; set; }
        public List<RVVO> RVList { get; set; }
/*        public APVO(ADVO AD, List<FMVO> FM, List<VDVO> VD, List<RVVO> RV)
        {
            this.AD = AD;
            this.FM = FM;
            this.VD = VD;
            this.RV = RV;
        }
*/
    }
    class ADVO
    {
        public string apartmentNumber;
        public string ownerName;
        public string apartmentType;
        public ADVO(string apartmentNumber, string ownerName, string apartmentType)
        {
            this.apartmentNumber = apartmentNumber;
            this.ownerName = ownerName;
            this.apartmentType = apartmentType;

        }
    }
    class FMVO
    {
        public string name;
        public string occupation;
        public string dob;
        public string relation;
        public FMVO(string name, string occupation, string dob, string relation)
        {
            this.name = name;
            this.occupation = occupation;
            this.dob = dob;
            this.relation = relation;
        }

    }
    class RVVO
    {
        public string name;
        public string visitorId;
        public string reason;
        public RVVO(string name, string visitorId, string reason)
        {
            this.name = name;
            this.visitorId = visitorId;
            this.reason = reason;
        }

    }
    class VDVO
    {
        public string licensePlateNumber;
        public string model;
        public string status;
        public string description;
        public VDVO(string licensePlateNumber, string description, string model, string status)
        {
            this.licensePlateNumber = licensePlateNumber;
            this.description = description;
            this.model = model;
            this.status = status;
        }

    }
}
