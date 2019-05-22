using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class Repayments
    {
        string applicationNo;
        long loanAccountNo;
        double paidAmount;
        double dueAmount;
        double totalAmount;
        DateTime dateOfTransaction;

        public string ApplicationNo { get => applicationNo; set => applicationNo = value; }
        public long LoanAccountNo { get => loanAccountNo; set => loanAccountNo = value; }
        public double PaidAmount { get => paidAmount; set => paidAmount = value; }
        public double DueAmount { get => dueAmount; set => dueAmount = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public DateTime DateOfTransaction { get => dateOfTransaction; set => dateOfTransaction = value; }

    }
}