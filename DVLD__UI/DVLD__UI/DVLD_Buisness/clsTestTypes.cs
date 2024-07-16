


using System.Data;


using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public int TestTypeFees { get; set; }

        public clsTestTypes() { }

        public static DataTable GetAllTestTypes()
        {
            return TestTypes.GetAllTestTypes();
        }

        private static clsTestTypes _ConvertToApplicationTypes(DataTable dataTable)
        {
            if (dataTable != null)
            {
                clsTestTypes _Application = new clsTestTypes();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    _Application.TestTypeID = (int)dataRow[0];
                    _Application.TestTypeTitle = (string)dataRow[1];
                    _Application.TestTypeDescription = (string)dataRow[2];
                    _Application.TestTypeFees = (int)dataRow[3];
                }
                return _Application;
            }
            return null;
        }


        public static clsTestTypes FindTestTypeByID(int TestTypeID)
        {
            return _ConvertToApplicationTypes(TestTypes.FindTestTypeByID(TestTypeID));
        }


        private static bool _UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, int TestTypeFees)
        {
            return TestTypes.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
        public bool Save()
        {
            bool value = _UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
            return value;
        }


    }




}