using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.Interface;
using CommonLayer.Show;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FellowshipCandidate : ControllerBase
    {
        IFellowshipCandidateBL fellowshipCandidateBL;
        public FellowshipCandidate(IFellowshipCandidateBL fellowshipCandidateBL)
        {
            this.fellowshipCandidateBL = fellowshipCandidateBL;
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddFellowshipCandidate(FellowshipCandidateShowModel fellowshipCandidateShowModel)
        {
            try
            {
                var data = this.fellowshipCandidateBL.AddFellowshipCandidate(fellowshipCandidateShowModel);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Added Successfully", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("")]
        public IActionResult AllFellowshipCandidates()
        {
            try
            {
                var data = this.fellowshipCandidateBL.AllFellowshipCandidates();
                return this.Ok(new { status = "True", message = "All Fellowship Candidates", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("{candidateId}")]
        public IActionResult GetFellowshipCandidates(int candidateId)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.GetFellowshipCandidate(candidateId);
                    return this.Ok(new { status = "True", message = "Get Fellowship Candidate By Candidate Id", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPut]
        [Route("{candidateId}")]
        public IActionResult UpdateFellowshipCandidate(int candidateId, FellowshipCandidateUpdateShowModel fellowshipCandidateUpdate)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.UpdateFellowshipCandidate(candidateId, fellowshipCandidateUpdate);
                    return this.Ok(new { status = "True", message = "Fellowship Candidate Update Successfully", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpDelete]
        [Route("{candidateId}")]
        public IActionResult DeleteFellowshipCandidate(int candidateId)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.DeleteFellowshipCandidate(candidateId);
                    return this.Ok(new { status = "True", data});
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPost]
        [Route("{candidateId}/DocumentDetails")]
        public IActionResult AddCondidateDocumentDetails(int candidateId, [FromForm]CandidateDocumentDetailsShowModel candidateDocumentDetails)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.AddCandidateDocuments(candidateId, candidateDocumentDetails);
                    return this.Ok(new { status = "True", message="Fellowship Candidate Document Details Added Successfully", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("{candidateId}/DocumentDetails")]
        public IActionResult GetCondidateDocumentDetails(int candidateId)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.GetCandidateDocument(candidateId);
                    return this.Ok(new { status = "True", message = "Get Fellowship Candidate Document Details", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPut]
        [Route("{candidateId}/DocumentDetails/{documentId}")]
        public IActionResult UpdateCondidateDocumentDetails(int candidateId, int documentId, [FromForm]CandidateDocumentUpdateShowModel candidateDocumentUpdate)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.UpdateCandidateDocument(candidateId, documentId, candidateDocumentUpdate);
                    return this.Ok(new { status = "True", message = "Fellowship Candidate Document Updated Successfully", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpDelete]
        [Route("{candidateId}/DocumentDetails/{documentId}")]
        public IActionResult DeleteCondidateDocumentDetails(int candidateId, int documentId)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.DeleteCandidateDocument(candidateId, documentId);
                    return this.Ok(new { status = "True", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPost]
        [Route("{candidateId}/BankDetails")]
        public IActionResult AddBankDetails(int candidateId, CandidateBankDetailsShowModel candidateBankDetails)
        {
            try
            {
                if (candidateId > 0)
                {
                    var data = this.fellowshipCandidateBL.AddCandidateBankDetails(candidateId, candidateBankDetails);
                    return this.Ok(new { status = "True", message = "Fellowship Candidate Bank Details Added Successfully", data });
                }
                else
                    return BadRequest(new { status = "False", message = "Please Provide Candidate Id Greater Than 0" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("BankDetails")]
        public IActionResult AllCandidateBankDetails()
        {
            try
            {
                    var data = this.fellowshipCandidateBL.AllCandidateBankDetails();
                    return this.Ok(new { status = "True", message = "Fellowship Candidates Bank Details", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }


        [HttpGet]
        [Route("{candidateId}/BankDetails/{bankDetailsId}")]
        public IActionResult GetCandidateBankDetails(int candidateId, int bankDetailsId)
        {
            try
            {
                var data = this.fellowshipCandidateBL.GetCandidateBankDetails(candidateId, bankDetailsId);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Bank Details", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPut]
        [Route("{candidateId}/BankDetails/{bankDetailsId}")]
        public IActionResult UpdateCandidateBankDetails(int candidateId, int bankDetailsId, CandidateBankDetailsUpdateModel candidateBankDetails)
        {
            try
            {
                var data = this.fellowshipCandidateBL.UpdateBankDetails(candidateId, bankDetailsId, candidateBankDetails);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Bank Details Updated Successfully", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpDelete]
        [Route("{candidateId}/BankDetails/{bankDetailsId}")]
        public IActionResult DeleteCandidateBankDetails(int candidateId, int bankDetailsId)
        {
            try
            {
                var data = this.fellowshipCandidateBL.DeleteBankDetails(candidateId, bankDetailsId);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Bank Details Deleted Successfully" });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPost]
        [Route("{candidateId}/QualificationDetails")]
        public IActionResult AddCandidateQualificationDetails(int candidateId, CandidateQualificationShowModel candidateQualification)
        {
            try
            {
                var data = this.fellowshipCandidateBL.AddCandidateQualification(candidateId, candidateQualification);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Qualification Details Added Successfully", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("QualificationDetails")]
        public async Task<IActionResult> AllCandidateQualificationDetails()
        {
            try
            {
                var data = await this.fellowshipCandidateBL.AllCandidateQualification();
                return this.Ok(new { status = "True", message = "All Candidates Qualification Details", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpGet]
        [Route("{candidateId}/QualificationDetails/{qualificationId}")]
        public IActionResult AddCandidateQualificationDetails(int candidateId, int qualificationId)
        {
            try
            {
                var data = this.fellowshipCandidateBL.GetCandidateQualification(candidateId, qualificationId);
                return this.Ok(new { status = "True", message = "Get Fellowship Candidate Qualification Details", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpPut]
        [Route("{candidateId}/QualificationDetails/{qualificationId}")]
        public IActionResult UpdateCandidateQualificationDetails(int candidateId, int qualificationId, CandidateQualificationUpdateShowModel candidateQualificationUpdate)
        {
            try
            {
                var data = this.fellowshipCandidateBL.UpdateCandidateQualification(candidateId, qualificationId, candidateQualificationUpdate);
                return this.Ok(new { status = "True", message = "Fellowship Candidate Qualification Details Updated Successfully", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }

        [HttpDelete]
        [Route("{candidateId}/QualificationDetails/{qualificationId}")]
        public IActionResult DeleteCandidateQualificationDetails(int candidateId, int qualificationId)
        {
            try
            {
                var data = this.fellowshipCandidateBL.DeleteCandidateQualification(candidateId, qualificationId);
                return this.Ok(new { status = "True", data });
            }
            catch (Exception exception)
            {
                return this.BadRequest(new { status = "False", exception.Message });
            }
        }
    }
}
