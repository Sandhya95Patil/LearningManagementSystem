using CommonLayer.Response;
using CommonLayer.Show;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IFellowshipCandidateRL
    {
        FellowshipCandidateResponseModel AddFellowshipCandidate(FellowshipCandidateShowModel fellowshipCandidateShowModel);
        IList<FellowshipCandidateResponseModel> AllFellowshipCandidates();
        FellowshipCandidateResponseModel GetFellowshipCandidate(int candidateId);
        FellowshipCandidateResponseModel UpdateFellowshipCandidate(int candidateId, FellowshipCandidateUpdateShowModel candidateUpdateShowModel);
        string DeleteFellowshipCandidate(int candidateId);
        CandidateDocumentDetailsResponseModel AddCandidateDocuments(int candidateId, CandidateDocumentDetailsShowModel candidateDocument);
        IList<CandidateDocumentDetailsResponseModel> GetCandidateDocument(int candidateId);
        CandidateDocumentDetailsResponseModel UpdateCandidateDocument(int candidateId, int documentId, CandidateDocumentUpdateShowModel candidateDocumentUpdate);
        string DeleteCandidateDocument(int candidateId, int documentId);
        CandidateBankDetailsResponseModel AddCandidateBankDetails(int candidateId, CandidateBankDetailsShowModel candidateBankDetails);
        CandidateBankDetailsResponseModel GetCandidateBankDetails(int candidateId, int bankDetailsId);
        IList<CandidateBankDetailsResponseModel> AllCandidateBankDetails();
        CandidateBankDetailsResponseModel UpdateBankDetails(int candidateId, int BankId, CandidateBankDetailsUpdateModel detailsUpdateModel);
        string DeleteBankDetails(int candidateId, int bankId);

        CandidateQualificationResponseModel AddCandidateQualification(int candidateId, CandidateQualificationShowModel qualificationShowModel);
        CandidateQualificationResponseModel GetCandidateQualification(int candidateId, int qualificationId);
        Task<IList<CandidateQualificationResponseModel>> AllCandidateQualification();
        CandidateQualificationResponseModel UpdateCandidateQualification(int candidateId, int qualificationId, CandidateQualificationUpdateShowModel candidateQualificationUpdate);
        string DeleteCandidateQualification(int candidateId, int qualificationId);
    }
}
