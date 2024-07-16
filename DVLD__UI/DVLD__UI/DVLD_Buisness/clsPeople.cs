using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Buisness
{

    public class clsPeople
    {

        public clsPeople()
        {
            this.PersonID = -1;
            this.First = "";
            this.Second = "";
            this.Third = "";
            this.Last = "";
            this.National = "";
            this.BirthDay = DateTime.Now;
            this.Gender = 0;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.Country = 1;
            this.ImagePath = "";
        }

        private clsPeople(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, string NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.First = FirstName;
            this.Second = SecondName;
            this.Third = ThirdName;
            this.Last = LastName;
            this.National = NationalNo;
            this.BirthDay = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.Country = Country;
            this.ImagePath = ImagePath;

        }
        public int PersonID
        { get; set; }

        public string First
        {
            get;
            set;
        }

        public string Second
        {
            get;
            set;
        }

        public string Third
        {
            get;
            set;
        }

        public string Last
        {
            get;
            set;
        }

        public string National
        {
            get;
            set;
        }

        public DateTime BirthDay
        {
            get;
            set;
        }

        public int Gender
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

        public int Country
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }
        public string ImagePath
        {
            get;
            set;
        }

        public static string[] arr = { "NationalNo", "PersonID", "Email", "Phone" };

        enum Op
        {
            NationalNo, PersonID, Email, Phone
        }

        private int _AddPerson()
        {
            return People.AddPerson(this.National, this.First, this.Second, this.Third, this.Last,
           this.BirthDay, this.Gender, this.Address, this.Phone, this.Email, this.Country, this.ImagePath);

        }

        private bool _UpdatePerson()
        {
            return People.UpdatePerson(this.PersonID, this.National, this.First, this.Second, this.Third, this.Last,
           this.BirthDay, this.Gender, this.Address, this.Phone, this.Email, this.Country, this.ImagePath);

        }

        public static bool DeletePerson(int PersonID)
        {
            return People.DeletePerson(PersonID);
        }

        public bool Save()
        {
            bool value = false;
            if (this.PersonID == -1)
            {
                this.PersonID = _AddPerson();
                value = this.PersonID > -1 ? true : false;

            }
            else
            {
                value = _UpdatePerson();
            }
            return value;
        }


        public static DataTable GetAllPeople()
        {
            return People.GetAllPeople();

        }

        public static int FindPersonNationalityCountryID(int personID)
        {
            return People.FindPersonNationalityCountryID(personID);
        }

        public static bool CheckExistsNationalNo(string NationalNo)
        {
            return People.CheckExistsNationalNo(NationalNo);
        }


        private static clsPeople _ConvertDataTableToPerson(DataTable dataTable)
        {
            if (dataTable.Rows.Count != 0)
            {
                clsPeople people = new clsPeople();
                foreach (DataRow row in dataTable.Rows)
                {
                    people.PersonID = (int)row[0];
                    people.National = row[1].ToString();
                    people.First = row[2].ToString();
                    people.Second = row[3].ToString();
                    people.Third = row[4].ToString();
                    people.Last = row[5].ToString();
                    people.BirthDay = (DateTime)row[6];
                    people.Gender = int.Parse(row[7].ToString());
                    people.Address = row[8].ToString();
                    people.Phone = row[9].ToString();
                    people.Email = row[10].ToString();
                    people.Country = int.Parse(row[11].ToString());
                    people.ImagePath = row[12].ToString();
                }
                return (people);
            }
            return (null);
        }


        public static clsPeople FindPerson(int PersonID)
        {
            return _ConvertDataTableToPerson(People.FindPerson(PersonID));
        }
        public static DataTable FindPeople(string Column, string value)
        {
            return People.FindPeople(Column, value);
        }

        public static DataTable GetPersonByID(int PersonID)
        {
            return (People.FindPerson(PersonID));
        }
        public static clsPeople FindPerson(string PersonID)
        {
            bool value = CheckExistsNationalNo(PersonID);
            if (value)
                return _ConvertDataTableToPerson(People.FindPerson(PersonID));
            return null;
        }

        public static bool CheckExistsPersonID(string NationalNo)
        {
            return People.CheckExistsPersonID(NationalNo);
        }





        public static clsPeople FindPersonBy(int ChooseIndex, dynamic Data)
        {
            Op Index = (Op)ChooseIndex;
            switch (Index)
            {
                case Op.NationalNo:
                    {
                        return _ConvertDataTableToPerson(People.FindPerson((string)Data));
                    }
                case Op.PersonID:
                    {
                        return _ConvertDataTableToPerson(People.FindPerson((int)Data));
                    }
                case Op.Phone:
                    {
                        //return _ConvertDataTableToPerson(People.FindPerson((string)Data));
                        break;
                    }
                case Op.Email:
                    {
                        //return _ConvertDataTableToPerson(People.FindPerson((string)Data));
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return null;
        }
        public static string GetPersonNationalNo(int PersonID)
        {
            return People.GetPersonNationalNo(PersonID);
        }

        public static string GetPersonImagePath(int PersonID)
        {
            return People.GetPersonImagePath(PersonID);
        }

        public static int GetPersonIDByNationalNo(string NationalNo)
        {
            return People.GetPersonIDByNationalNo(NationalNo);
        }

        public static DataTable GetPersonDetainLicense(int PersonID)
        {
            return People.GetPersonDetainLicense(PersonID);
        }

    }
}