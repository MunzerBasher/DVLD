




using System.Data;
using DVLD_DataAccess;

namespace DVLD_Buisness
{

    public class clsApplicationTypes
    {
        public clsApplicationTypes() { }
        public int ApplicationTypesID { get; set; }
        public string ApplicationTypesTitle { get; set; }
        public int ApplicationFees { get; set; }

        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypes.GetAllApplicationTypes();
        }

        private bool _UpdateApplicationTypes(int ApplicationTypesID, string ApplicationTypesTitle, int ApplicationFees)
        {
            return ApplicationTypes.UpdateApplicationTypes(ApplicationTypesID, ApplicationTypesTitle, ApplicationFees);
        }

        public bool Save()
        {
            bool value = _UpdateApplicationTypes(this.ApplicationTypesID, this.ApplicationTypesTitle, this.ApplicationFees);
            return value;
        }


        private static clsApplicationTypes _ConvertToApplicationTypes(DataTable dataTable)
        {
            if (dataTable != null)
            {
                clsApplicationTypes _Application = new clsApplicationTypes();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    _Application.ApplicationTypesID = (int)dataRow[0];
                    _Application.ApplicationTypesTitle = (string)dataRow[1];
                    _Application.ApplicationFees = (int)dataRow[2];
                }
                return _Application;
            }
            return null;
        }


        public static clsApplicationTypes FindApplicationTypesByID(int ApplicationTypesID)
        {
            return _ConvertToApplicationTypes(ApplicationTypes.FindApplicationTypeByID(ApplicationTypesID));
        }


        public static string GetApplicationTypeTitle(int ApplicationTypeID)
        {
            return ApplicationTypes.GetApplicationTypeTitle(ApplicationTypeID);
        }
    
    }   
}