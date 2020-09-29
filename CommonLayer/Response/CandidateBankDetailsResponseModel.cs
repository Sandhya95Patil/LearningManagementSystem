using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Response
{
    public class CandidateBankDetailsResponseModel
    {
        public int BankId { get; set; }
        public int CandidateId { get; set; }
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public bool? IsAccountNoVerified { get; set; }
        public string IFSCCode { get; set; }
        public bool? IsIFSCCoeVerified { get; set; }
        public string PanNo { get; set; }
        public bool? IsPanNoVerified { get; set; }
        public string AdharNo { get; set; }
        public bool? IsAdharNoVerified { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
