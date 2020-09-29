using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Response
{
    public class FellowshipCandidateResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HiredCity { get; set; }
        public DateTime? HiredDate { get; set; }
        public string HiredLab { get; set; }
        public string Degree { get; set; }
        public string MobileNo { get; set; }
        public int? PermanentPincode { get; set; }
        public string Attitude { get; set; }
        public string CommunicationRemark { get; set; }
        public string KnowledgeRemark { get; set; }
        public string AggregateRemark { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool? IsBirthVerified { get; set; }
        public string ParentName { get; set; }
        public string ParentOccupation { get; set; }
        public string ParentMobNo { get; set; }
        public long? ParentAnnualSalary { get; set; }
        public string LocalAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string PhotoPath { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string CandidateStatus { get; set; }
        public string PersonalInfo { get; set; }
        public string BankInfo { get; set; }
        public string EducationalInfo { get; set; }
        public string DocumentStatus { get; set; }
        public string Remark { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
