using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomatedSurvey.Models
{
    public class surveylist : survey
    {
        public List<State_list> State { get; set; }

        public List<City_list> City { get; set; }

        public List<Department_list> Department { get; set; }

    }


    public class State_list
    {
        public int State_ID { get; set; }

        public string State_Name { get; set; }
    }

    public class City_list
    {
        public int City_Id { get; set; }

        public string City_Name { get; set; }
    }

    public class Department_list
    {
        public int Dept_Code { get; set; }

        public string Dept_Name { get; set; }
    }



}