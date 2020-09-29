using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateQualificationShowModel
    {
        public string Degree { get; set; }
        public bool IsDegreeVerified { get; set; }
        public string EmployeeDecipline { get; set; }
        public bool IsEmpDeciplinVerified { get; set; }
        public int PassingYear { get; set; }
        public bool IsPassingYearVerified { get; set; }
        public int AggregatePercentage { get; set; }
        public bool IsAggPerVerified { get; set; }
        public int FinalYearPer { get; set; }
        public bool IsFinalYearPerVerified { get; set; }
        public string TrainingInstitute { get; set; }
        public bool IsTrainingInstituteVerified { get; set; }
        public int TrainingDurationMonth { get; set; }
        public bool IsTrainingDurationMonthVerified { get; set; }
        public string OtherTraining { get; set; }
        public bool IsOtherTrainingVerified { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
    }
}
