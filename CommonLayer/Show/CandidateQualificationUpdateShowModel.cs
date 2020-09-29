using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateQualificationUpdateShowModel
    {
        public string Degree { get; set; }
        public bool? IsDegreeVerified { get; set; }
        public string EmployeeDecipline { get; set; }
        public bool? IsEmpDeciplinVerified { get; set; }
        public int PassingYear { get; set; }
        public bool? IsPassingYearVerified { get; set; }
    }
}
