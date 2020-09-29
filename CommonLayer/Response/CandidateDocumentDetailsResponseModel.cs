using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Response
{
    public class CandidateDocumentDetailsResponseModel
    {
        public int DocumentId { get; set; }
        public int CandidateId { get; set; }
        public string DocType { get; set; }
        public string DocPath { get; set; }
        public string Status { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
