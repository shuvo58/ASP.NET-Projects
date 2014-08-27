using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMdApp_02.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Designation { get; set; }
        public List<Article> Articles { get; set; }
    }
}