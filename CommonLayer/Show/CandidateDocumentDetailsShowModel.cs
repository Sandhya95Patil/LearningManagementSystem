using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateDocumentDetailsShowModel
    {
        public string DocType { get; set; }
        public IFormFile DocPath { get; set; }
        public string Status { get; set; }
        public string CreatorStamp { get; set; }
        public string CreatorUser { get; set; }
    }
}
