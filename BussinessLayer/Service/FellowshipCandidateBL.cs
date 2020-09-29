using BussinessLayer.Interface;
using CommonLayer.Response;
using CommonLayer.Show;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Service
{
    public class FellowshipCandidateBL : IFellowshipCandidateBL
    {
        IFellowshipCandidateRL fellowshipCandidateRL;
        public FellowshipCandidateBL(IFellowshipCandidateRL fellowshipCandidateRL)
        {
            this.fellowshipCandidateRL = fellowshipCandidateRL;
        }
        public FellowshipCandidateResponseModel AddFellowshipCandidate(FellowshipCandidateShowModel fellowshipCandidateShowModel)
        {
            try
            {
                return fellowshipCandidateRL.AddFellowshipCandidate(fellowshipCandidateShowModel);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public IList<FellowshipCandidateResponseModel> AllFellowshipCandidates()
        {
            try
            {
                return this.fellowshipCandidateRL.AllFellowshipCandidates();
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public FellowshipCandidateResponseModel GetFellowshipCandidate(int candidateId)
        {
            try
            {
                return this.fellowshipCandidateRL.GetFellowshipCandidate(candidateId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public FellowshipCandidateResponseModel UpdateFellowshipCandidate(int candidateId, FellowshipCandidateUpdateShowModel candidateUpdateShowModel)
        {
            try
            {
                return this.fellowshipCandidateRL.UpdateFellowshipCandidate(candidateId, candidateUpdateShowModel);
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public string DeleteFellowshipCandidate(int candidateId)
        {
            try
            {
                return this.fellowshipCandidateRL.DeleteFellowshipCandidate(candidateId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateDocumentDetailsResponseModel AddCandidateDocuments(int candidateId, CandidateDocumentDetailsShowModel candidateDocument)
        {
            try
            {
                return this.fellowshipCandidateRL.AddCandidateDocuments(candidateId, candidateDocument);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public IList<CandidateDocumentDetailsResponseModel> GetCandidateDocument(int candidateId)
        {
            try
            {
                return this.fellowshipCandidateRL.GetCandidateDocument(candidateId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateDocumentDetailsResponseModel UpdateCandidateDocument(int candidateId, int documentId, CandidateDocumentUpdateShowModel candidateDocumentUpdate)
        {
            try
            {
                return this.fellowshipCandidateRL.UpdateCandidateDocument(candidateId, documentId, candidateDocumentUpdate);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public string DeleteCandidateDocument(int candidateId, int documentId)
        {
            try
            {
                return this.fellowshipCandidateRL.DeleteCandidateDocument(candidateId, documentId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateBankDetailsResponseModel AddCandidateBankDetails(int candidateId, CandidateBankDetailsShowModel candidateBankDetails)
        {
            try
            {
                return this.fellowshipCandidateRL.AddCandidateBankDetails(candidateId, candidateBankDetails);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateBankDetailsResponseModel GetCandidateBankDetails(int candidateId, int bankDetailsId)
        {
            try
            {
                return this.fellowshipCandidateRL.GetCandidateBankDetails(candidateId, bankDetailsId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public IList<CandidateBankDetailsResponseModel> AllCandidateBankDetails()
        {
            try
            {
                return this.fellowshipCandidateRL.AllCandidateBankDetails();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateBankDetailsResponseModel UpdateBankDetails(int candidateId, int BankId, CandidateBankDetailsUpdateModel detailsUpdateModel)
        {
            try
            {
                return this.fellowshipCandidateRL.UpdateBankDetails(candidateId, BankId, detailsUpdateModel);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public string DeleteBankDetails(int candidateId, int bankId)
        {
            try
            {
                return this.fellowshipCandidateRL.DeleteBankDetails(candidateId, bankId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateQualificationResponseModel AddCandidateQualification(int candidateId, CandidateQualificationShowModel qualificationShowModel)
        {
            try
            {
                return this.fellowshipCandidateRL.AddCandidateQualification(candidateId, qualificationShowModel);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateQualificationResponseModel GetCandidateQualification(int candidateId, int qualificationId)
        {
            try
            {
                return this.fellowshipCandidateRL.GetCandidateQualification(candidateId, qualificationId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public Task<IList<CandidateQualificationResponseModel>> AllCandidateQualification()
        {
            try
            {
                return this.fellowshipCandidateRL.AllCandidateQualification();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateQualificationResponseModel UpdateCandidateQualification(int candidateId, int qualificationId, CandidateQualificationUpdateShowModel candidateQualificationUpdate)
        {
            try
            {
                return this.fellowshipCandidateRL.UpdateCandidateQualification(candidateId, qualificationId, candidateQualificationUpdate);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public string DeleteCandidateQualification(int candidateId, int qualificationId)
        {
            try
            {
                return this.fellowshipCandidateRL.DeleteCandidateQualification(candidateId, qualificationId);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
