using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class Rcu_Manager
    {
        string applicationNo;
        string rcuId;
        string status;
        string remarks;
        DateTime dateOfAppOrRej;

        public string ApplicationNo { get => applicationNo; set => applicationNo = value; }
        public string RcuId { get => rcuId; set => rcuId = value; }
        public string Status { get => status; set => status = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public DateTime DateOfAppOrRej { get => dateOfAppOrRej; set => dateOfAppOrRej = value; }
    }
}