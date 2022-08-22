using System;
using System.Collections.Generic;
using System.Text;

namespace FileManager
{
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
