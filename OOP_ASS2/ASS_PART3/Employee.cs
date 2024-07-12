using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASS2.ASS_PART3
{
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public enum Gender
    {
        M,
        F
    }

    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege Privilege { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, SecurityPrivilege privilege, decimal salary, HiringDate hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Privilege = privilege;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Privilege: {Privilege}, Salary: {Salary.ToString("C")}, Hire Date: {HireDate.Day}/{HireDate.Month}/{HireDate.Year}, Gender: {Gender}";
        }
    }

}
