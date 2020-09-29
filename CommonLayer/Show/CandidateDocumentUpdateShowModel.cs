using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Show
{
    public class CandidateDocumentUpdateShowModel
    {
        public string DocType { get; set; }
        public IFormFile DocPath { get; set; }
        public string Status { get; set; }
    }
}
