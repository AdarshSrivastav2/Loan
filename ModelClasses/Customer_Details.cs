using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelClasses
{
    public class Customer_Details
    {
        string applicationNo;
        string customerId;
        string firstName;
        string lastName;
        string fatherName;
        string motherName;
        string gender;
        DateTime dOB;
        string nationality;
        long phoneNo;
        long residentialNo;
        string email;
        string permanentAddress;
        string pincodePermanent;
        string presentAddress;
        string pincodePresent;
        string occupation;
        string companyName;
        double annualIncome;
        string appliedBefore;
        string regApplicationNo;
        string regApplicationStatus;
        DateTime regAppDate;
        double regLoanAmount;
        string regPaymentStatus;
        double regEMI;
        double loanAmount;
        int tenure;
        long aadharNo;
        string panNo;
        DateTime dateApplied;
        string presentStatus;
        string aadharImage;
        string panImage;
        string paySlipImage;

        public string ApplicationNo { get => applicationNo; set => applicationNo = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string MotherName { get => motherName; set => motherName = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DOB { get => dOB; set => dOB = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }
        public long ResidentialNo { get => residentialNo; set => residentialNo = value; }
        public string Email { get => email; set => email = value; }
        public string PermanentAddress { get => permanentAddress; set => permanentAddress = value; }
        public string PincodePermanent { get => pincodePermanent; set => pincodePermanent = value; }
        public string PresentAddress { get => presentAddress; set => presentAddress = value; }
        public string PincodePresent { get => pincodePresent; set => pincodePresent = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public double AnnualIncome { get => annualIncome; set => annualIncome = value; }
        public string AppliedBefore { get => appliedBefore; set => appliedBefore = value; }
        public string RegApplicationNo { get => regApplicationNo; set => regApplicationNo = value; }
        public string RegApplicationStatus { get => regApplicationStatus; set => regApplicationStatus = value; }
        public DateTime RegAppDate { get => regAppDate; set => regAppDate = value; }
        public double RegLoanAmount { get => regLoanAmount; set => regLoanAmount = value; }
        public string RegPaymentStatus { get => regPaymentStatus; set => regPaymentStatus = value; }
        public double RegEMI { get => regEMI; set => regEMI = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public int Tenure { get => tenure; set => tenure = value; }
        public long AadharNo { get => aadharNo; set => aadharNo = value; }
        public string PanNo { get => panNo; set => panNo = value; }
        public DateTime DateApplied { get => dateApplied; set => dateApplied = value; }
        public string PresentStatus { get => presentStatus; set => presentStatus = value; }
        public string AadharImage { get => aadharImage; set => aadharImage = value; }
        public string PanImage { get => panImage; set => panImage = value; }
        public string PaySlipImage { get => paySlipImage; set => paySlipImage = value; }
    }
}