using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateBankDetailsUpdateModel
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
    }
}
