using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateBankDetailsShowModel
    {
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public bool IsAccountNoVerified { get; set; }
        public string IFSCCode { get; set; }
        public bool IsIFSCCoeVerified { get; set; }
        public string PanNo { get; set; }
        public bool IsPanNoVerified { get; set; }
        public string AdharNo { get; set; }
        public bool IsAdharNoVerified { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
    }
}
