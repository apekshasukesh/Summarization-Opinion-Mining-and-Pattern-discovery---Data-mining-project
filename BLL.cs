using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using drugs_symptoms_diseases.DLTableAdapters;
using System.Data;

namespace drugs_symptoms_diseases
{
    //class which contains class members and member functions (functions based on the requirement)

    public class BLL
    {
        //class members
        tblLoginTableAdapter userObj = new tblLoginTableAdapter();
        tblKeywordsTableAdapter keywordObj = new tblKeywordsTableAdapter();
        tblOpinionsTableAdapter opinionObj = new tblOpinionsTableAdapter();

        //following the member functions

        #region -- User Login --

        //function to check the user login
        public DataTable CheckUserLogin(string loginId, string password)
        {
            return userObj.CheckUserLogin(loginId, password);
        }

        //function to the get the user details based on userid
        public DataTable GetUserByUserId(string loginId)
        {
            return userObj.GetUserById(loginId);
        }

        //function to check the login id
        public bool CheckLoginId(string loginId)
        {
            int cnt = int.Parse(userObj.CheckLoginId(loginId).ToString());

            if (cnt == 1)

                return false;

            return true;
        }

        //function to insert the new user (medical practioner)
        public void InsertUser(string loginId, string password, string emailId, string type)
        {
            userObj.InsertUser(loginId, password, emailId, type);
        }

        //function to update the user details
        public void UpdateUser(string loginId,string password,string emailId, string type, string loginId1)
        {
            userObj.UpdateUser(loginId, password, emailId, type, loginId1);
        }

        //function to delete the user
        public void DeleteUser(string loginId)
        {
            userObj.DeleteUser(loginId);
        }

        //function to get the users based on type
        public DataTable GetUsersByType(string type)
        {
            return userObj.GetUsersByType(type);
        }

        //function to update the user password
        public void UpdateUserPassword(string password, string loginId)
        {
            userObj.UpdatePassword(password, loginId);
        }


        #endregion

        #region -- Keywords --

        //function to check the keyword
        public bool CheckKeyword(string keyword, string type)
        {
            int cnt = int.Parse(keywordObj.CheckKeyword(keyword, type).ToString());

            if (cnt == 1)

                return false;

            return true;
        }

        //function to insert the keyword (symptoms,diseases,drugs,SA)
        public void InsertKeyword(string keyword, string type)
        {
            keywordObj.InsertKeyword(keyword, type);
        }

        //function to update the keyword
        public void UpdateKeyword(string keyword, string type, int keywordId)
        {
            keywordObj.UpdateKeyword(keyword, type, keywordId);
        }

        //function to delete the keyword
        public void DeleteKeyword(int keywordId)
        {
            keywordObj.DeleteKeyword(keywordId);
        }

        //function to get the keyword by id
        public DataTable GetKeywordById(int keywordId)
        {
            return keywordObj.GetKeywordById(keywordId);
        }

        //function to get the keywords by type
        public DataTable GetKeywordsByType(string type)
        {
            return keywordObj.GetKeywordsByType(type);
        }

        //function to get all keywords
        public DataTable GetAllKeywords()
        {
            return keywordObj.GetData();
        }

        #endregion

        #region -- Opinions --

        //function to insert the opinion
        public void InsertOpinion(string loginId, string patientName, int age, string address, bool gender, int drugId, string opinion, DateTime postedDate, int rating, string image)
        {
            opinionObj.InsertOpinion(loginId, patientName, age, address, gender, drugId, opinion, postedDate, rating, image);
        }

        //function to update the opinion
        public void UpdateOpinion(string loginId, string patientName, int age, string address, bool gender, int drugId, string opinion, DateTime postedDate, int rating, string image, int opinionId)
        {
            opinionObj.UpdateOpinion(loginId, patientName, age, address, gender, drugId, opinion, postedDate, rating,image, opinionId);
        }

        //function to delete the opinion
        public void DeleteOpinion(int opinionId)
        {
            opinionObj.DeleteOpinion(opinionId);
        }

        //function to get the opinion based on id
        public DataTable GetOpinionById(int opinionId)
        {
            return opinionObj.GetOpinionById(opinionId);
        }

        //function to get all opinions
        public DataTable GetAllOpinions()
        {
            return opinionObj.GetData();
        }

        //function to get the opinions based on login id
        public DataTable GetOpinionsByLoginId(string loginId)
        {
            return opinionObj.GetOpinionsByLoginId(loginId);
        }

        //function to get the opinions based on drug
        public DataTable GetOpinionsByLoginIdandDrug(string loginId, int drugId)
        {
            return opinionObj.GetOpinionsByDrug(loginId, drugId);
        }

        //function to get the opinions based on date
        public DataTable GetOpinionsBydate(DateTime startDate, DateTime endDate)
        {
            return opinionObj.GetOpinionsByDate(startDate, endDate);
        }

        //function to get the opinions based on drug
        public DataTable GetOpinionsByDrug(int drugId)
        {
            return opinionObj.GetOpinionsByDrugId(drugId);
        }

        //function to get the opinions based on date and drug
        public DataTable GetOpinionsBydateandDrug(DateTime startDate, DateTime endDate, int drugId)
        {
            return opinionObj.GetOpinionsByDateandDrug(startDate, endDate, drugId);
        }

        #endregion

    }
}