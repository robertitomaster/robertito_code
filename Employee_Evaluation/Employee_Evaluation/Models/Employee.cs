using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Evaluation
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public Employee Manager { get; set; }
        public virtual ICollection<Evalutation> Evaluations { get; set;}

        public bool AddEmployee(int employeeid, string fname, string mname, string lname, string positionname, string managername)
        {
            try
            {
                // TO Add 2 LINQ Queries that will search for Position and Manager
                var employee = new Employee()
                {
                    EmployeeId = employeeid,
                    FirstName = fname,
                    MiddleName = mname,
                    LastName = lname,
                };

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}