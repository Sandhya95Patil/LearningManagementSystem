using CommonLayer.Response;
using CommonLayer.Show;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using RepositoryLayer.Upload;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class FellowshipCandidateRL : IFellowshipCandidateRL
    {
        IConfiguration configuration;
        public FellowshipCandidateRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public FellowshipCandidateResponseModel AddFellowshipCandidate(FellowshipCandidateShowModel fellowshipCandidate)
        {
            try
            {
                DatabaseConnection databaseConnectin = new DatabaseConnection(this.configuration);
                string actionType = "insert";
                List<SPParameter> paramList = new List<SPParameter>();
                paramList.Add(new SPParameter("@ActionType",actionType));
                paramList.Add(new SPParameter("@FirstName", fellowshipCandidate.FirstName));
                paramList.Add(new SPParameter("@MiddleName", fellowshipCandidate.MiddleName));
                paramList.Add(new SPParameter("@LastName", fellowshipCandidate.LastName));
                paramList.Add(new SPParameter("@Email", fellowshipCandidate.Email));
                paramList.Add(new SPParameter("@HiredCity", fellowshipCandidate.HiredCity));
                paramList.Add(new SPParameter("@HiredDate", fellowshipCandidate.HiredDate));
                paramList.Add(new SPParameter("@HiredLab", fellowshipCandidate.HiredLab));
                paramList.Add(new SPParameter("@Degree", fellowshipCandidate.Degree));
                paramList.Add(new SPParameter("@Mobile_No", fellowshipCandidate.MobileNo));
                paramList.Add(new SPParameter("@PermanentPincode", fellowshipCandidate.PermanentPincode));
                paramList.Add(new SPParameter("@Attitude", fellowshipCandidate.Attitude));
                paramList.Add(new SPParameter("@CommunicationRemark", fellowshipCandidate.CommunicationRemark));
                paramList.Add(new SPParameter("@KnowledgeRemark", fellowshipCandidate.KnowledgeRemark));
                paramList.Add(new SPParameter("@AggregateRemark", fellowshipCandidate.AggregateRemark));
                paramList.Add(new SPParameter("@CreatorStamp", fellowshipCandidate.CreatorStamp));
                paramList.Add(new SPParameter("@CreatorUser", fellowshipCandidate.CreatorUser));
                paramList.Add(new SPParameter("@BirthDate", fellowshipCandidate.BirthDate));
                paramList.Add(new SPParameter("@Is_Bitrth_Date_Verified", fellowshipCandidate.IsBirthVerified));
                paramList.Add(new SPParameter("@ParentName", fellowshipCandidate.ParentName));
                paramList.Add(new SPParameter("@ParentOccupation", fellowshipCandidate.ParentOccupation));
                paramList.Add(new SPParameter("@ParentMobileNo", fellowshipCandidate.ParentMobNo));
                paramList.Add(new SPParameter("@ParentAnnualSalary", fellowshipCandidate.ParentAnnualSalary));
                paramList.Add(new SPParameter("@LocalAddress", fellowshipCandidate.LocalAddress));
                paramList.Add(new SPParameter("@PermanentAddress", fellowshipCandidate.PermanentAddress));
                paramList.Add(new SPParameter("@PhotoPath", fellowshipCandidate.PhotoPath));
                paramList.Add(new SPParameter("@JoiningDate", fellowshipCandidate.JoiningDate));
                paramList.Add(new SPParameter("@CandidateStatus", fellowshipCandidate.CandidateStatus));
                paramList.Add(new SPParameter("@PersonalInfo", fellowshipCandidate.PersonalInfo));
                paramList.Add(new SPParameter("@BankInfo", fellowshipCandidate.BankInfo));
                paramList.Add(new SPParameter("@EducationalInfo", fellowshipCandidate.EducationalInfo));
                paramList.Add(new SPParameter("@DocumentStatus", fellowshipCandidate.DocumentStatus));
                paramList.Add(new SPParameter("@Remark", fellowshipCandidate.Remark));
                paramList.Add(new SPParameter("@CreatedDate", DateTime.Now));
                DataTable table = databaseConnectin.StoredProcedureExecuteReader("FellowshipCandidateCRUD", paramList);
                FellowshipCandidateResponseModel candidateData = new FellowshipCandidateResponseModel();
                
                foreach (DataRow dataRow in table.Rows)
                {
                        candidateData.Id = (int)dataRow["Id"];
                        candidateData.FirstName = dataRow["FirstName"].ToString();
                        candidateData.MiddleName = dataRow["MiddleName"].ToString();
                        candidateData.LastName = dataRow["LastName"].ToString();
                        candidateData.Email = dataRow["Email"].ToString();
                        candidateData.HiredCity = dataRow["Hired_City"].ToString();
                        candidateData.HiredDate = (DateTime)dataRow["Hired_Date"];
                        candidateData.HiredLab = dataRow["Hired_Lab"].ToString();
                        candidateData.Degree = dataRow["Degree"].ToString();
                        candidateData.MobileNo = dataRow["Mobile_No"].ToString();
                        candidateData.PermanentPincode = (int)dataRow["Permanent_Pincode"];
                        candidateData.Attitude = dataRow["Attitude"].ToString();
                        candidateData.CommunicationRemark = dataRow["Communication_Remark"].ToString();
                        candidateData.KnowledgeRemark = dataRow["Knowledge_Remark"].ToString();
                        candidateData.AggregateRemark = dataRow["Aggregate_Remark"].ToString();
                        candidateData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                        candidateData.CreatorUser = dataRow["Creator_User"].ToString();
                        candidateData.BirthDate = (DateTime)dataRow["Birth_Date"];
                        candidateData.IsBirthVerified = (Boolean)dataRow["Is_Birth_Date_Verified"];
                        candidateData.ParentName = dataRow["Parent_Name"].ToString();
                        candidateData.ParentOccupation = dataRow["Parent_Occupation"].ToString();
                        candidateData.ParentMobNo = dataRow["Parent_Mobile_No"].ToString();
                        candidateData.ParentAnnualSalary = (long)dataRow["Parent_Annual_Salary"];
                        candidateData.LocalAddress = dataRow["Local_Address"].ToString();
                        candidateData.PermanentAddress = dataRow["Permanent_Address"].ToString();
                        candidateData.PhotoPath = dataRow["Photo_Path"].ToString();
                        candidateData.JoiningDate = (DateTime)dataRow["Joining_Date"];
                        candidateData.CandidateStatus = dataRow["Candidate_Status"].ToString();
                        candidateData.PersonalInfo = dataRow["Personal_Info"].ToString();
                        candidateData.BankInfo = dataRow["Bank_Info"].ToString();
                        candidateData.EducationalInfo = dataRow["Educational_Info"].ToString();
                        candidateData.DocumentStatus = dataRow["Document_Status"].ToString();
                        candidateData.Remark = dataRow["Remark"].ToString();
                        candidateData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                        candidateData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return candidateData;
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
                IList<FellowshipCandidateResponseModel> candidateList = new List<FellowshipCandidateResponseModel>();
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                var actionType = "select all";
                List<SPParameter> paramList = new List<SPParameter>();
                paramList.Add(new SPParameter("@ActionType", actionType));
                DataTable table = connection.StoredProcedureExecuteReader("FellowshipCandidateCRUD", paramList);
                FellowshipCandidateResponseModel candidateData = new FellowshipCandidateResponseModel();

                foreach (DataRow dataRow in table.Rows)
                {
                    candidateData.Id = (int)dataRow["Id"];
                    candidateData.FirstName = dataRow["FirstName"].ToString();
                    candidateData.MiddleName = dataRow["MiddleName"].ToString();
                    candidateData.LastName = dataRow["LastName"].ToString();
                    candidateData.Email = dataRow["Email"].ToString();
                    candidateData.HiredCity = dataRow["Hired_City"].ToString();
                    candidateData.HiredDate = (dataRow["Hired_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Hired_Date"]);
                    candidateData.HiredLab = dataRow["Hired_Lab"].ToString();
                    candidateData.Degree = dataRow["Degree"].ToString();
                    candidateData.MobileNo = dataRow["Mobile_No"].ToString();
                    candidateData.PermanentPincode = (dataRow["Permanent_Pincode"] == DBNull.Value) ? (int?)null : ((int)dataRow["Permanent_Pincode"]);
                    candidateData.Attitude = dataRow["Attitude"].ToString();
                    candidateData.CommunicationRemark = dataRow["Communication_Remark"].ToString();
                    candidateData.KnowledgeRemark = dataRow["Knowledge_Remark"].ToString();
                    candidateData.AggregateRemark = dataRow["Aggregate_Remark"].ToString();
                    candidateData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    candidateData.CreatorUser = dataRow["Creator_User"].ToString();
                    candidateData.BirthDate = (dataRow["Birth_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Birth_Date"]);
                    candidateData.IsBirthVerified = (dataRow["Is_Birth_Date_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Birth_Date_Verified"]);
                    candidateData.ParentName = dataRow["Parent_Name"].ToString();
                    candidateData.ParentOccupation = dataRow["Parent_Occupation"].ToString();
                    candidateData.ParentMobNo = dataRow["Parent_Mobile_No"].ToString();
                    candidateData.ParentAnnualSalary = (dataRow["Parent_Annual_Salary"] == DBNull.Value) ? (long?)null : ((long)dataRow["Parent_Annual_Salary"]);
                    candidateData.LocalAddress = dataRow["Local_Address"].ToString();
                    candidateData.PermanentAddress = dataRow["Permanent_Address"].ToString();
                    candidateData.PhotoPath = dataRow["Photo_Path"].ToString();
                    candidateData.JoiningDate = (dataRow["Joining_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Joining_Date"]);
                    candidateData.CandidateStatus = dataRow["Candidate_Status"].ToString();
                    candidateData.PersonalInfo = dataRow["Personal_Info"].ToString();
                    candidateData.BankInfo = dataRow["Bank_Info"].ToString();
                    candidateData.EducationalInfo = dataRow["Educational_Info"].ToString();
                    candidateData.DocumentStatus = dataRow["Document_Status"].ToString();
                    candidateData.Remark = dataRow["Remark"].ToString();
                    candidateData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    candidateData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                    candidateList.Add(candidateData);
                }
                return candidateList;
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
                string actionType = "select";
                DatabaseConnection databaseConnection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                DataTable table = databaseConnection.StoredProcedureExecuteReader("FellowshipCandidateCRUD", paramList);
                FellowshipCandidateResponseModel candidateData = new FellowshipCandidateResponseModel();
                foreach(DataRow dataRow in table.Rows)
                {
                    candidateData.Id = (int)dataRow["Id"];
                    candidateData.FirstName = dataRow["FirstName"].ToString();
                    candidateData.MiddleName = dataRow["MiddleName"].ToString();
                    candidateData.LastName = dataRow["LastName"].ToString();
                    candidateData.Email = dataRow["Email"].ToString();
                    candidateData.HiredCity = dataRow["Hired_City"].ToString();
                    candidateData.HiredDate = (dataRow["Hired_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Hired_Date"]);
                    candidateData.HiredLab = dataRow["Hired_Lab"].ToString();
                    candidateData.Degree = dataRow["Degree"].ToString();
                    candidateData.MobileNo = dataRow["Mobile_No"].ToString();
                    candidateData.PermanentPincode = (dataRow["Permanent_Pincode"] == DBNull.Value) ? (int?)null : ((int)dataRow["Permanent_Pincode"]);
                    candidateData.Attitude = dataRow["Attitude"].ToString();
                    candidateData.CommunicationRemark = dataRow["Communication_Remark"].ToString();
                    candidateData.KnowledgeRemark = dataRow["Knowledge_Remark"].ToString();
                    candidateData.AggregateRemark = dataRow["Aggregate_Remark"].ToString();
                    candidateData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    candidateData.CreatorUser = dataRow["Creator_User"].ToString();
                    candidateData.BirthDate = (dataRow["Birth_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Birth_Date"]);
                    candidateData.IsBirthVerified = (dataRow["Is_Birth_Date_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Birth_Date_Verified"]);
                    candidateData.ParentName = dataRow["Parent_Name"].ToString();
                    candidateData.ParentOccupation = dataRow["Parent_Occupation"].ToString();
                    candidateData.ParentMobNo = dataRow["Parent_Mobile_No"].ToString();
                    candidateData.ParentAnnualSalary = (dataRow["Parent_Annual_Salary"] == DBNull.Value) ? (long?)null : ((long)dataRow["Parent_Annual_Salary"]);
                    candidateData.LocalAddress = dataRow["Local_Address"].ToString();
                    candidateData.PermanentAddress = dataRow["Permanent_Address"].ToString();
                    candidateData.PhotoPath = dataRow["Photo_Path"].ToString();
                    candidateData.JoiningDate = (dataRow["Joining_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Joining_Date"]);
                    candidateData.CandidateStatus = dataRow["Candidate_Status"].ToString();
                    candidateData.PersonalInfo = dataRow["Personal_Info"].ToString();
                    candidateData.BankInfo = dataRow["Bank_Info"].ToString();
                    candidateData.EducationalInfo = dataRow["Educational_Info"].ToString();
                    candidateData.DocumentStatus = dataRow["Document_Status"].ToString();
                    candidateData.Remark = dataRow["Remark"].ToString();
                    candidateData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    candidateData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return candidateData;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public FellowshipCandidateResponseModel UpdateFellowshipCandidate(int candidateId, FellowshipCandidateUpdateShowModel candidateUpdateShowModel)
        {
            try
            {
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                var actionType = "update";
                List<SPParameter> paramList = new List<SPParameter>();
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@FirstName", candidateUpdateShowModel.FirstName));
                paramList.Add(new SPParameter("@MiddleName", candidateUpdateShowModel.MiddleName));
                paramList.Add(new SPParameter("@LastName", candidateUpdateShowModel.LastName));
                paramList.Add(new SPParameter("@Email", candidateUpdateShowModel.Email));
                paramList.Add(new SPParameter("@HiredCity", candidateUpdateShowModel.HiredCity));
                paramList.Add(new SPParameter("@HiredDate", candidateUpdateShowModel.HiredDate));
                paramList.Add(new SPParameter("@HiredLab", candidateUpdateShowModel.HiredLab));
                paramList.Add(new SPParameter("@Degree", candidateUpdateShowModel.Degree));
                paramList.Add(new SPParameter("@Mobile_No", candidateUpdateShowModel.MobileNo));
                paramList.Add(new SPParameter("@ModifiedDate", DateTime.Now));
                DataTable table = connection.StoredProcedureExecuteReader("FellowshipCandidateCRUD", paramList);
                FellowshipCandidateResponseModel candidateData = new FellowshipCandidateResponseModel();
                foreach(DataRow dataRow in table.Rows)
                {
                    candidateData.Id = (int)dataRow["Id"];
                    candidateData.FirstName = dataRow["FirstName"].ToString();
                    candidateData.MiddleName = dataRow["MiddleName"].ToString();
                    candidateData.LastName = dataRow["LastName"].ToString();
                    candidateData.Email = dataRow["Email"].ToString();
                    candidateData.HiredCity = dataRow["Hired_City"].ToString();
                    candidateData.HiredDate = (dataRow["Hired_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Hired_Date"]);
                    candidateData.HiredLab = dataRow["Hired_Lab"].ToString();
                    candidateData.Degree = dataRow["Degree"].ToString();
                    candidateData.MobileNo = dataRow["Mobile_No"].ToString();
                    candidateData.PermanentPincode = (dataRow["Permanent_Pincode"] == DBNull.Value) ? (int?)null : ((int)dataRow["Permanent_Pincode"]);
                    candidateData.Attitude = dataRow["Attitude"].ToString();
                    candidateData.CommunicationRemark = dataRow["Communication_Remark"].ToString();
                    candidateData.KnowledgeRemark = dataRow["Knowledge_Remark"].ToString();
                    candidateData.AggregateRemark = dataRow["Aggregate_Remark"].ToString();
                    candidateData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    candidateData.CreatorUser = dataRow["Creator_User"].ToString();
                    candidateData.BirthDate = (dataRow["Birth_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Birth_Date"]);
                    candidateData.IsBirthVerified = (dataRow["Is_Birth_Date_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Birth_Date_Verified"]);
                    candidateData.ParentName = dataRow["Parent_Name"].ToString();
                    candidateData.ParentOccupation = dataRow["Parent_Occupation"].ToString();
                    candidateData.ParentMobNo = dataRow["Parent_Mobile_No"].ToString();
                    candidateData.ParentAnnualSalary = (dataRow["Parent_Annual_Salary"] == DBNull.Value) ? (long?)null : ((long)dataRow["Parent_Annual_Salary"]);
                    candidateData.LocalAddress = dataRow["Local_Address"].ToString();
                    candidateData.PermanentAddress = dataRow["Permanent_Address"].ToString();
                    candidateData.PhotoPath = dataRow["Photo_Path"].ToString();
                    candidateData.JoiningDate = (dataRow["Joining_Date"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["Joining_Date"]);
                    candidateData.CandidateStatus = dataRow["Candidate_Status"].ToString();
                    candidateData.PersonalInfo = dataRow["Personal_Info"].ToString();
                    candidateData.BankInfo = dataRow["Bank_Info"].ToString();
                    candidateData.EducationalInfo = dataRow["Educational_Info"].ToString();
                    candidateData.DocumentStatus = dataRow["Document_Status"].ToString();
                    candidateData.Remark = dataRow["Remark"].ToString();
                    candidateData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    candidateData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return candidateData;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public string DeleteFellowshipCandidate(int candidateId)
        {
            try
            {
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                var actionType = "delete";
                List<SPParameter> paramList = new List<SPParameter>();
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                DataTable table = connection.StoredProcedureExecuteReader("FellowshipCandidateCRUD", paramList);
                return "Fellowship Candidate Deleted Successfully";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateDocumentDetailsResponseModel AddCandidateDocuments(int candidateId, CandidateDocumentDetailsShowModel candidateDocument)
        {
            try
            {
                ImageUpload imageUpload = new ImageUpload(this.configuration, candidateDocument.DocPath);
                var docPath = imageUpload.Upload(candidateDocument.DocPath);
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "insert";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@DocType", candidateDocument.DocType));
                paramList.Add(new SPParameter("@DocPath", docPath));
                paramList.Add(new SPParameter("@Status", candidateDocument.Status));
                paramList.Add(new SPParameter("@CreatorStamp", candidateDocument.CreatorStamp));
                paramList.Add(new SPParameter("@CreatorUser", candidateDocument.CreatorUser));
                paramList.Add(new SPParameter("@CreatedDate", DateTime.Now));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateDocumentDetailsCRUD", paramList);
                CandidateDocumentDetailsResponseModel documentData = new CandidateDocumentDetailsResponseModel();
                foreach(DataRow dataRow in table.Rows)
                {
                    documentData.DocumentId = (int)dataRow["Id"];
                    documentData.CandidateId = (int)dataRow["Candidate_Id"];
                    documentData.DocType = dataRow["Doc_Type"].ToString();
                    documentData.DocPath = dataRow["Doc_Path"].ToString();
                    documentData.Status = dataRow["Status"].ToString();
                    documentData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    documentData.CreatorUser = dataRow["Creator_USer"].ToString();
                    documentData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    documentData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return documentData;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public IList<CandidateDocumentDetailsResponseModel> GetCandidateDocument(int candidateId)
        {
            try
            {
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "select";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateDocumentDetailsCRUD", paramList);
                CandidateDocumentDetailsResponseModel documentData = new CandidateDocumentDetailsResponseModel();
                IList<CandidateDocumentDetailsResponseModel> documentList = new List<CandidateDocumentDetailsResponseModel>();
                foreach (DataRow dataRow in table.Rows)
                {
                    documentData.DocumentId = (int)dataRow["Id"];
                    documentData.CandidateId = (int)dataRow["Candidate_Id"];
                    documentData.DocType = dataRow["Doc_Type"].ToString();
                    documentData.DocPath = dataRow["Doc_Path"].ToString();
                    documentData.Status = dataRow["Status"].ToString();
                    documentData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    documentData.CreatorUser = dataRow["Creator_USer"].ToString();
                    documentData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    documentData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                    documentList.Add(documentData);
                }
                return documentList;
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
                var docPath = "";
                if (candidateDocumentUpdate.DocPath != null)
                {
                    ImageUpload imageUpload = new ImageUpload(this.configuration, candidateDocumentUpdate.DocPath);
                    docPath = imageUpload.Upload(candidateDocumentUpdate.DocPath);
                }
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "update";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@DocumentDetailsId", documentId));
                paramList.Add(new SPParameter("@DocType", candidateDocumentUpdate.DocType));
                paramList.Add(new SPParameter("@DocPath", docPath));
                paramList.Add(new SPParameter("@Status", candidateDocumentUpdate.Status));
                paramList.Add(new SPParameter("@ModifiedDate", DateTime.Now));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateDocumentDetailsCRUD", paramList);
                CandidateDocumentDetailsResponseModel documentData = new CandidateDocumentDetailsResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    documentData.DocumentId = (int)dataRow["Id"];
                    documentData.CandidateId = (int)dataRow["Candidate_Id"];
                    documentData.DocType = dataRow["Doc_Type"].ToString();
                    documentData.DocPath = dataRow["Doc_Path"].ToString();
                    documentData.Status = dataRow["Status"].ToString();
                    documentData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    documentData.CreatorUser = dataRow["Creator_USer"].ToString();
                    documentData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    documentData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return documentData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "delete";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@DocumentDetailsId", documentId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateDocumentDetailsCRUD", paramList);
                return "Candidate Document Details Deleted Successfully";
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "insert";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@Name", candidateBankDetails.Name));
                paramList.Add(new SPParameter("@AccountNo", candidateBankDetails.AccountNo));
                paramList.Add(new SPParameter("@IsAccountNoVerified", candidateBankDetails.IsAccountNoVerified));
                paramList.Add(new SPParameter("@IFSCCode", candidateBankDetails.IFSCCode));
                paramList.Add(new SPParameter("@IsIFSCCodeVerified", candidateBankDetails.IsIFSCCoeVerified));
                paramList.Add(new SPParameter("@PanNo", candidateBankDetails.PanNo));
                paramList.Add(new SPParameter("@IsPanNoVerified", candidateBankDetails.IsPanNoVerified));
                paramList.Add(new SPParameter("@AdharNo", candidateBankDetails.AdharNo));
                paramList.Add(new SPParameter("@IsAdharNoVerified", candidateBankDetails.IsAdharNoVerified));
                paramList.Add(new SPParameter("@CreatorStamp", candidateBankDetails.CreatorStamp));
                paramList.Add(new SPParameter("@CreatorUser", candidateBankDetails.CreatorUser));
                paramList.Add(new SPParameter("@CreatedDate", DateTime.Now));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateBankDetailsCRUD", paramList);
                CandidateBankDetailsResponseModel bankData = new CandidateBankDetailsResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    bankData.BankId = (int)dataRow["Id"];
                    bankData.CandidateId = (int)dataRow["Candidate_Id"];
                    bankData.Name = dataRow["Name"].ToString();
                    bankData.AccountNo = dataRow["Account_No"].ToString();
                    bankData.IsAccountNoVerified = (dataRow["Is_Account_No_Verified"]==DBNull.Value)? (bool?)null:((bool)dataRow["Is_Account_No_Verified"]);
                    bankData.IFSCCode = dataRow["IFSC_Code"].ToString();
                    bankData.IsIFSCCoeVerified = (dataRow["Is_IFSC_COde_Verified"]==DBNull.Value)?(bool?)null:((bool)dataRow["Is_IFSC_COde_Verified"]);
                    bankData.PanNo = (dataRow["Pan_No"]).ToString();
                    bankData.IsPanNoVerified = (dataRow["Is_Pan_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Pan_No_Verified"]);
                    bankData.AdharNo = (dataRow["Adhar_No"]).ToString();
                    bankData.IsAdharNoVerified= (dataRow["Is_Adhar_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Adhar_No_Verified"]);
                    bankData.CreatorStamp = dataRow["Cretor_Stamp"].ToString();
                    bankData.CreatorUser = dataRow["Cretor_USer"].ToString();
                    bankData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    bankData.ModifiedDate=(dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return bankData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "select";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@BankDetailsId", bankDetailsId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateBankDetailsCRUD", paramList);
                CandidateBankDetailsResponseModel bankData = new CandidateBankDetailsResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    bankData.BankId = (int)dataRow["Id"];
                    bankData.CandidateId = (int)dataRow["Candidate_Id"];
                    bankData.Name = dataRow["Name"].ToString();
                    bankData.AccountNo = dataRow["Account_No"].ToString();
                    bankData.IsAccountNoVerified = (dataRow["Is_Account_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Account_No_Verified"]);
                    bankData.IFSCCode = dataRow["IFSC_Code"].ToString();
                    bankData.IsIFSCCoeVerified = (dataRow["Is_IFSC_COde_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_IFSC_COde_Verified"]);
                    bankData.PanNo = (dataRow["Pan_No"]).ToString();
                    bankData.IsPanNoVerified = (dataRow["Is_Pan_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Pan_No_Verified"]);
                    bankData.AdharNo = (dataRow["Adhar_No"]).ToString();
                    bankData.IsAdharNoVerified = (dataRow["Is_Adhar_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Adhar_No_Verified"]);
                    bankData.CreatorStamp = dataRow["Cretor_Stamp"].ToString();
                    bankData.CreatorUser = dataRow["Cretor_USer"].ToString();
                    bankData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    bankData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return bankData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "select all";
                paramList.Add(new SPParameter("@ActionType", actionType));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateBankDetailsCRUD", paramList);
                IList<CandidateBankDetailsResponseModel> bankDetailsList = new List<CandidateBankDetailsResponseModel>();
                CandidateBankDetailsResponseModel bankData = new CandidateBankDetailsResponseModel();

                foreach (DataRow dataRow in table.Rows)
                {
                    bankData.BankId = (int)dataRow["Id"];
                    bankData.CandidateId = (int)dataRow["Candidate_Id"];
                    bankData.Name = dataRow["Name"].ToString();
                    bankData.AccountNo = dataRow["Account_No"].ToString();
                    bankData.IsAccountNoVerified = (dataRow["Is_Account_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Account_No_Verified"]);
                    bankData.IFSCCode = dataRow["IFSC_Code"].ToString();
                    bankData.IsIFSCCoeVerified = (dataRow["Is_IFSC_COde_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_IFSC_COde_Verified"]);
                    bankData.PanNo = (dataRow["Pan_No"]).ToString();
                    bankData.IsPanNoVerified = (dataRow["Is_Pan_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Pan_No_Verified"]);
                    bankData.AdharNo = (dataRow["Adhar_No"]).ToString();
                    bankData.IsAdharNoVerified = (dataRow["Is_Adhar_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Adhar_No_Verified"]);
                    bankData.CreatorStamp = dataRow["Cretor_Stamp"].ToString();
                    bankData.CreatorUser = dataRow["Cretor_USer"].ToString();
                    bankData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    bankData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);

                    bankData = new CandidateBankDetailsResponseModel()
                    {
                        BankId = bankData.BankId,
                        CandidateId = bankData.CandidateId,
                        Name = bankData.Name,
                        AccountNo = bankData.AccountNo,
                        IsAccountNoVerified = bankData.IsAccountNoVerified,
                        IFSCCode = bankData.IFSCCode,
                        IsIFSCCoeVerified = bankData.IsIFSCCoeVerified,
                        PanNo = bankData.PanNo,
                        IsPanNoVerified = bankData.IsPanNoVerified,
                        AdharNo = bankData.AdharNo,
                        IsAdharNoVerified = bankData.IsAdharNoVerified,
                        CreatorStamp = bankData.CreatorStamp,
                        CreatorUser = bankData.CreatorUser,
                        CreatedDate = bankData.CreatedDate,
                        ModifiedDate = bankData.ModifiedDate
                    };
                    bankDetailsList.Add(bankData);
                }
                return bankDetailsList;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public CandidateBankDetailsResponseModel UpdateBankDetails(int candidateId, int BankId, CandidateBankDetailsUpdateModel detailsUpdateModel)
        {
            try
            {
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "update";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@BankDetailsId", BankId));
                paramList.Add(new SPParameter("@Name", detailsUpdateModel.Name));
                paramList.Add(new SPParameter("@AccountNo", detailsUpdateModel.AccountNo));
                paramList.Add(new SPParameter("@IsAccountNoVerified", detailsUpdateModel.IsAccountNoVerified));
                paramList.Add(new SPParameter("@IFSCCode", detailsUpdateModel.IFSCCode));
                paramList.Add(new SPParameter("@IsIFSCCodeVerified", detailsUpdateModel.IsIFSCCoeVerified));
                paramList.Add(new SPParameter("@PanNo", detailsUpdateModel.PanNo));
                paramList.Add(new SPParameter("@IsPanNoVerified", detailsUpdateModel.IsPanNoVerified));
                paramList.Add(new SPParameter("@AdharNo", detailsUpdateModel.AdharNo));
                paramList.Add(new SPParameter("@IsAdharNoVerified", detailsUpdateModel.IsAdharNoVerified));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateBankDetailsCRUD", paramList);
                CandidateBankDetailsResponseModel bankData = new CandidateBankDetailsResponseModel();

                foreach (DataRow dataRow in table.Rows)
                {
                    bankData.BankId = (int)dataRow["Id"];
                    bankData.CandidateId = (int)dataRow["Candidate_Id"];
                    bankData.Name = dataRow["Name"].ToString();
                    bankData.AccountNo = dataRow["Account_No"].ToString();
                    bankData.IsAccountNoVerified = (dataRow["Is_Account_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Account_No_Verified"]);
                    bankData.IFSCCode = dataRow["IFSC_Code"].ToString();
                    bankData.IsIFSCCoeVerified = (dataRow["Is_IFSC_COde_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_IFSC_COde_Verified"]);
                    bankData.PanNo = (dataRow["Pan_No"]).ToString();
                    bankData.IsPanNoVerified = (dataRow["Is_Pan_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Pan_No_Verified"]);
                    bankData.AdharNo = (dataRow["Adhar_No"]).ToString();
                    bankData.IsAdharNoVerified = (dataRow["Is_Adhar_No_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Adhar_No_Verified"]);
                    bankData.CreatorStamp = dataRow["Cretor_Stamp"].ToString();
                    bankData.CreatorUser = dataRow["Cretor_USer"].ToString();
                    bankData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    bankData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return bankData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "delete";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@BankDetailsId", bankId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateBankDetailsCRUD", paramList);
                return "Candidate Bank Details Deleted Successfullty";
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "insert";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@Degree", qualificationShowModel.Degree));
                paramList.Add(new SPParameter("@DegreeVerified", qualificationShowModel.IsDegreeVerified));
                paramList.Add(new SPParameter("@EmployeeDeciplin", qualificationShowModel.EmployeeDecipline));
                paramList.Add(new SPParameter("@IsEmpDeciplineVerified", qualificationShowModel.IsEmpDeciplinVerified));
                paramList.Add(new SPParameter("@PassingYear", qualificationShowModel.PassingYear));
                paramList.Add(new SPParameter("@IsPassingYearVerified", qualificationShowModel.IsPassingYearVerified));
                paramList.Add(new SPParameter("@AggregatePer", qualificationShowModel.AggregatePercentage));
                paramList.Add(new SPParameter("@IsAggreVerifiedPer", qualificationShowModel.IsAggPerVerified));
                paramList.Add(new SPParameter("@IsFinalYearPerVerified", qualificationShowModel.IsFinalYearPerVerified));
                paramList.Add(new SPParameter("@TrainingInstitute", qualificationShowModel.TrainingInstitute));
                paramList.Add(new SPParameter("@IsTrainingInstituteVerified", qualificationShowModel.IsTrainingInstituteVerified));
                paramList.Add(new SPParameter("@TrainingDurationMonth", qualificationShowModel.TrainingDurationMonth));
                paramList.Add(new SPParameter("@IsTrainingDurMonthVerified", qualificationShowModel.IsTrainingDurationMonthVerified));
                paramList.Add(new SPParameter("@OtherTraining", qualificationShowModel.OtherTraining));
                paramList.Add(new SPParameter("@IsOtherTrainingVerified", qualificationShowModel.IsOtherTrainingVerified));
                paramList.Add(new SPParameter("@creatorStamp", qualificationShowModel.CreatorStamp));
                paramList.Add(new SPParameter("@creatorUser", qualificationShowModel.CreatorUser));
                paramList.Add(new SPParameter("@CreatedDate", DateTime.Now));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateQualificationCRUD", paramList);
                CandidateQualificationResponseModel qualificationData = new CandidateQualificationResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    qualificationData.QualificationId = (int)dataRow["Id"];
                    qualificationData.CandidateId = (int)dataRow["Candidate_Id"];
                    qualificationData.Degree = dataRow["Degree"].ToString();
                    qualificationData.IsDegreeVerified = (dataRow["Degree_Name_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Degree_Name_Verified"]);
                    qualificationData.EmployeeDecipline = dataRow["Employee_Deciplin"].ToString();
                    qualificationData.IsEmpDeciplinVerified = (dataRow["Is_Emp_Deciplin_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Emp_Deciplin_Verified"]);
                    qualificationData.PassingYear= (dataRow["Passing_Year"]==DBNull.Value)? (int?)null : ((int)dataRow["Passing_Year"]);
                    qualificationData.IsPassingYearVerified= (dataRow["Is_Passing_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Passing_Year_Verified"]);
                    qualificationData.AggregatePercentage= (dataRow["Aggregate_Percentage"] == DBNull.Value) ? (int?)null : ((int)dataRow["Aggregate_Percentage"]);
                    qualificationData.IsAggPerVerified = (dataRow["Is_Aggr_Per_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Aggr_Per_Verified"]);
                    qualificationData.FinalYearPer = (dataRow["Final_Year_Per"] == DBNull.Value) ? (int?)null : ((int)dataRow["Final_Year_Per"]);
                    qualificationData.IsFinalYearPerVerified = (dataRow["Is_Final_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Final_Year_Verified"]);
                    qualificationData.TrainingInstitute = dataRow["Training_Institute"].ToString();
                    qualificationData.IsTrainingInstituteVerified = (dataRow["Is_Training_Institute_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Institute_Verified"]);
                    qualificationData.TrainingDurationMonth = (dataRow["Training_Duration_Month"] == DBNull.Value) ? (int?)null : ((int)dataRow["Training_Duration_Month"]);
                    qualificationData.IsTrainingDurationMonthVerified = (dataRow["Is_Training_Duration_Month_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Duration_Month_Verified"]);
                    qualificationData.OtherTraining = dataRow["Other_Training"].ToString();
                    qualificationData.IsOtherTrainingVerified = (dataRow["Is_Other_Training_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Other_Training_Verified"]);
                    qualificationData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    qualificationData.CreatorUser = dataRow["Creator_User"].ToString();
                    qualificationData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    qualificationData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return qualificationData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "select";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@CandidateQualificationId", qualificationId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateQualificationCRUD", paramList);
                CandidateQualificationResponseModel qualificationData = new CandidateQualificationResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    qualificationData.QualificationId = (int)dataRow["Id"];
                    qualificationData.CandidateId = (int)dataRow["Candidate_Id"];
                    qualificationData.Degree = dataRow["Degree"].ToString();
                    qualificationData.IsDegreeVerified = (dataRow["Degree_Name_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Degree_Name_Verified"]);
                    qualificationData.EmployeeDecipline = dataRow["Employee_Deciplin"].ToString();
                    qualificationData.IsEmpDeciplinVerified = (dataRow["Is_Emp_Deciplin_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Emp_Deciplin_Verified"]);
                    qualificationData.PassingYear = (dataRow["Passing_Year"] == DBNull.Value) ? (int?)null : ((int)dataRow["Passing_Year"]);
                    qualificationData.IsPassingYearVerified = (dataRow["Is_Passing_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Passing_Year_Verified"]);
                    qualificationData.AggregatePercentage = (dataRow["Aggregate_Percentage"] == DBNull.Value) ? (int?)null : ((int)dataRow["Aggregate_Percentage"]);
                    qualificationData.IsAggPerVerified = (dataRow["Is_Aggr_Per_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Aggr_Per_Verified"]);
                    qualificationData.FinalYearPer = (dataRow["Final_Year_Per"] == DBNull.Value) ? (int?)null : ((int)dataRow["Final_Year_Per"]);
                    qualificationData.IsFinalYearPerVerified = (dataRow["Is_Final_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Final_Year_Verified"]);
                    qualificationData.TrainingInstitute = dataRow["Training_Institute"].ToString();
                    qualificationData.IsTrainingInstituteVerified = (dataRow["Is_Training_Institute_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Institute_Verified"]);
                    qualificationData.TrainingDurationMonth = (dataRow["Training_Duration_Month"] == DBNull.Value) ? (int?)null : ((int)dataRow["Training_Duration_Month"]);
                    qualificationData.IsTrainingDurationMonthVerified = (dataRow["Is_Training_Duration_Month_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Duration_Month_Verified"]);
                    qualificationData.OtherTraining = dataRow["Other_Training"].ToString();
                    qualificationData.IsOtherTrainingVerified = (dataRow["Is_Other_Training_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Other_Training_Verified"]);
                    qualificationData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    qualificationData.CreatorUser = dataRow["Creator_User"].ToString();
                    qualificationData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    qualificationData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return qualificationData;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public async Task<IList<CandidateQualificationResponseModel>> AllCandidateQualification()
        {
            try
            {
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> patamList = new List<SPParameter>();
                var actionType = "select all";
                patamList.Add(new SPParameter("@ActionType", actionType));
                DataTable table = await connection.StoredProcedureExecuteReaderAsync("CandidateQualificationCRUD", patamList);
                IList<CandidateQualificationResponseModel> qualificationList = new List<CandidateQualificationResponseModel>();
                CandidateQualificationResponseModel qualificationData = new CandidateQualificationResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    qualificationData.QualificationId = (int)dataRow["Id"];
                    qualificationData.CandidateId = (int)dataRow["Candidate_Id"];
                    qualificationData.Degree = dataRow["Degree"].ToString();
                    qualificationData.IsDegreeVerified = (dataRow["Degree_Name_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Degree_Name_Verified"]);
                    qualificationData.EmployeeDecipline = dataRow["Employee_Deciplin"].ToString();
                    qualificationData.IsEmpDeciplinVerified = (dataRow["Is_Emp_Deciplin_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Emp_Deciplin_Verified"]);
                    qualificationData.PassingYear = (dataRow["Passing_Year"] == DBNull.Value) ? (int?)null : ((int)dataRow["Passing_Year"]);
                    qualificationData.IsPassingYearVerified = (dataRow["Is_Passing_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Passing_Year_Verified"]);
                    qualificationData.AggregatePercentage = (dataRow["Aggregate_Percentage"] == DBNull.Value) ? (int?)null : ((int)dataRow["Aggregate_Percentage"]);
                    qualificationData.IsAggPerVerified = (dataRow["Is_Aggr_Per_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Aggr_Per_Verified"]);
                    qualificationData.FinalYearPer = (dataRow["Final_Year_Per"] == DBNull.Value) ? (int?)null : ((int)dataRow["Final_Year_Per"]);
                    qualificationData.IsFinalYearPerVerified = (dataRow["Is_Final_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Final_Year_Verified"]);
                    qualificationData.TrainingInstitute = dataRow["Training_Institute"].ToString();
                    qualificationData.IsTrainingInstituteVerified = (dataRow["Is_Training_Institute_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Institute_Verified"]);
                    qualificationData.TrainingDurationMonth = (dataRow["Training_Duration_Month"] == DBNull.Value) ? (int?)null : ((int)dataRow["Training_Duration_Month"]);
                    qualificationData.IsTrainingDurationMonthVerified = (dataRow["Is_Training_Duration_Month_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Duration_Month_Verified"]);
                    qualificationData.OtherTraining = dataRow["Other_Training"].ToString();
                    qualificationData.IsOtherTrainingVerified = (dataRow["Is_Other_Training_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Other_Training_Verified"]);
                    qualificationData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    qualificationData.CreatorUser = dataRow["Creator_User"].ToString();
                    qualificationData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    qualificationData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);

                    qualificationData = new CandidateQualificationResponseModel()
                    {
                        QualificationId = qualificationData.QualificationId,
                        CandidateId = qualificationData.CandidateId,
                        Degree=qualificationData.Degree,
                        IsDegreeVerified=qualificationData.IsDegreeVerified,
                        EmployeeDecipline=qualificationData.EmployeeDecipline,
                        IsEmpDeciplinVerified=qualificationData.IsEmpDeciplinVerified,
                        PassingYear=qualificationData.PassingYear,
                        IsPassingYearVerified=qualificationData.IsPassingYearVerified,
                        AggregatePercentage=qualificationData.AggregatePercentage,
                        IsAggPerVerified=qualificationData.IsAggPerVerified,
                        FinalYearPer=qualificationData.FinalYearPer,
                        IsFinalYearPerVerified=qualificationData.IsFinalYearPerVerified,
                        TrainingInstitute=qualificationData.TrainingInstitute,
                        IsTrainingInstituteVerified=qualificationData.IsTrainingInstituteVerified,
                        TrainingDurationMonth=qualificationData.TrainingDurationMonth,
                        IsTrainingDurationMonthVerified=qualificationData.IsTrainingDurationMonthVerified,
                        OtherTraining=qualificationData.OtherTraining,
                        IsOtherTrainingVerified=qualificationData.IsOtherTrainingVerified,
                        CreatorStamp=qualificationData.CreatorStamp,
                        CreatorUser=qualificationData.CreatorUser,
                        CreatedDate=qualificationData.CreatedDate,
                        ModifiedDate=qualificationData.ModifiedDate
                    };
                    qualificationList.Add(qualificationData);
                }
                return qualificationList;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "update";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@CandidateQualificationId", qualificationId));
                paramList.Add(new SPParameter("@Degree", candidateQualificationUpdate.Degree));
                paramList.Add(new SPParameter("@DegreeVerified", candidateQualificationUpdate.IsDegreeVerified));
                paramList.Add(new SPParameter("@EmployeeDeciplin", candidateQualificationUpdate.EmployeeDecipline));
                paramList.Add(new SPParameter("@IsEmpDeciplineVerified", candidateQualificationUpdate.IsEmpDeciplinVerified));
                paramList.Add(new SPParameter("@PassingYear", candidateQualificationUpdate.PassingYear));
                paramList.Add(new SPParameter("@IsPassingYearVerified", candidateQualificationUpdate.IsPassingYearVerified));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateQualificationCRUD", paramList);
                CandidateQualificationResponseModel qualificationData = new CandidateQualificationResponseModel();
                foreach (DataRow dataRow in table.Rows)
                {
                    qualificationData.QualificationId = (int)dataRow["Id"];
                    qualificationData.CandidateId = (int)dataRow["Candidate_Id"];
                    qualificationData.Degree = dataRow["Degree"].ToString();
                    qualificationData.IsDegreeVerified = (dataRow["Degree_Name_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Degree_Name_Verified"]);
                    qualificationData.EmployeeDecipline = dataRow["Employee_Deciplin"].ToString();
                    qualificationData.IsEmpDeciplinVerified = (dataRow["Is_Emp_Deciplin_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Emp_Deciplin_Verified"]);
                    qualificationData.PassingYear = (dataRow["Passing_Year"] == DBNull.Value) ? (int?)null : ((int)dataRow["Passing_Year"]);
                    qualificationData.IsPassingYearVerified = (dataRow["Is_Passing_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Passing_Year_Verified"]);
                    qualificationData.AggregatePercentage = (dataRow["Aggregate_Percentage"] == DBNull.Value) ? (int?)null : ((int)dataRow["Aggregate_Percentage"]);
                    qualificationData.IsAggPerVerified = (dataRow["Is_Aggr_Per_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Aggr_Per_Verified"]);
                    qualificationData.FinalYearPer = (dataRow["Final_Year_Per"] == DBNull.Value) ? (int?)null : ((int)dataRow["Final_Year_Per"]);
                    qualificationData.IsFinalYearPerVerified = (dataRow["Is_Final_Year_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Final_Year_Verified"]);
                    qualificationData.TrainingInstitute = dataRow["Training_Institute"].ToString();
                    qualificationData.IsTrainingInstituteVerified = (dataRow["Is_Training_Institute_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Institute_Verified"]);
                    qualificationData.TrainingDurationMonth = (dataRow["Training_Duration_Month"] == DBNull.Value) ? (int?)null : ((int)dataRow["Training_Duration_Month"]);
                    qualificationData.IsTrainingDurationMonthVerified = (dataRow["Is_Training_Duration_Month_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Training_Duration_Month_Verified"]);
                    qualificationData.OtherTraining = dataRow["Other_Training"].ToString();
                    qualificationData.IsOtherTrainingVerified = (dataRow["Is_Other_Training_Verified"] == DBNull.Value) ? (bool?)null : ((bool)dataRow["Is_Other_Training_Verified"]);
                    qualificationData.CreatorStamp = dataRow["Creator_Stamp"].ToString();
                    qualificationData.CreatorUser = dataRow["Creator_User"].ToString();
                    qualificationData.CreatedDate = (dataRow["CreatedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["CreatedDate"]);
                    qualificationData.ModifiedDate = (dataRow["ModifiedDate"] == DBNull.Value) ? (DateTime?)null : ((DateTime)dataRow["ModifiedDate"]);
                }
                return qualificationData;
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
                DatabaseConnection connection = new DatabaseConnection(this.configuration);
                List<SPParameter> paramList = new List<SPParameter>();
                var actionType = "delete";
                paramList.Add(new SPParameter("@ActionType", actionType));
                paramList.Add(new SPParameter("@CandidateId", candidateId));
                paramList.Add(new SPParameter("@CandidateQualificationId", qualificationId));
                DataTable table = connection.StoredProcedureExecuteReader("CandidateQualificationCRUD", paramList);
                return "Candidate Qualification Details Deleted Successfully";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
