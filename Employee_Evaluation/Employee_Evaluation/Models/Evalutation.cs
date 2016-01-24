using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Evaluation
{
    public class Evalutation
    {
        [Key]
        public int EvaluationId { get; set; }

        public string EvalutaionTitle { get; set; }

        public string Objectives { get; set; }

        public string Accomplishments { get; set; }

        public string EmployeeComments { get; set; }

        public string ManagerComments { get; set; }



    }
}