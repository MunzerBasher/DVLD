using DVLD_DataAccess;

namespace DVLD_Buisness
{

    public class clsTests
    {

        public static bool CheckExistsAppointment(int TestAppointmentID)
        {
            return Tests.CheckExistsAppointment(TestAppointmentID);
        }

        public static int GetTestID(int TestAppointmentID)
        {
            return Tests.GetTestID(TestAppointmentID);
        }

        public static int GetTestResultID(int TestAppointmentID)
        {
            return Tests.GetTestResultID(TestAppointmentID);
        }
        public static bool AddTest(int TestAppointmentID, int TestResult, string Notes, int CreatedByUserID)
        {
            return Tests.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public static bool UpdateLockedAppointment(int TestAppointmentID)
        {
            return Tests.UpdateLockedAppointment(TestAppointmentID);
        }


    }
}