using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class Credit_Authorizer
    {
        string applicationNo;
        string ca_Id;
        string status;
        DateTime dateOfAppOrRej;
        double approvedLoanAmount;
        long loanAccountNo;
        int tenure;
        double rateOfInterest;
        double eMI;

        public string ApplicationNo { get => applicationNo; set => applicationNo = value; }
        public string Ca_Id { get => ca_Id; set => ca_Id = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DateOfAppOrRej { get => dateOfAppOrRej; set => dateOfAppOrRej = value; }
        public double ApprovedLoanAmount { get => approvedLoanAmount; set => approvedLoanAmount = value; }
        public long LoanAccountNo { get => loanAccountNo; set => loanAccountNo = value; }
        public int Tenure { get => tenure; set => tenure = value; }
        public double RateOfInterest { get => rateOfInterest; set => rateOfInterest = value; }
        public double EMI { get => eMI; set => eMI = value; }
    }
}