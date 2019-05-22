using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class CreditManager
    {
        string applicationNo;
        string cm_Id;
        string status;
        string remarks;
        DateTime dateOfAppOrRej;

        public string ApplicationNo { get => applicationNo; set => applicationNo = value; }
        public string Cm_Id { get => cm_Id; set => cm_Id = value; }
        public string Status { get => status; set => status = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public DateTime DateOfAppOrRej { get => dateOfAppOrRej; set => dateOfAppOrRej = value; }
    }
}