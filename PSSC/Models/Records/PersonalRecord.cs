using System;

namespace Models.Records
{
    public enum Gender { Male, Female }

    public class PersonalRecord : Record
    {
        private string firstName;
        private string lastName;
        private string idCardSeries;
        private string pnc;
        private string fathersInitials;
        private string phoneNumber;
        private string email;

        private Address homeAddress;
        private Address currentAddress;

        #region PersonalRecord getters / setters / new properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        public string IdCardSeries
        {
            get { return idCardSeries; }
            set { idCardSeries = value; }
        }

        public string PNC
        {
            get { return pnc; }
            set { pnc = value; }
        }

        public Gender Gender
        {
            get { return (pnc[0].Equals('1') ? Gender.Male : Gender.Female); }
        }

        public int Age
        {
            get
            {
                int lastYearDigits = DateTime.Now.Year / 100;
                string pncBirthDate = (Int32.Parse(pnc.Substring(1, 2)) < lastYearDigits ?
                    lastYearDigits.ToString() : (lastYearDigits - 1).ToString()) + pnc.Substring(1, 6);
                string pncDateFormat = "yyyymmdd";

                DateTime birthDate = DateTime.ParseExact(pncBirthDate, pncDateFormat, System.Globalization.CultureInfo.InvariantCulture);
                DateTime currentDate = DateTime.UtcNow;

                int calculatedAge = currentDate.Year - birthDate.Year;

                if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                {
                    calculatedAge--;
                }

                return calculatedAge;
            }
        }

        public string FathersInitials
        {
            get { return fathersInitials; }
            set { fathersInitials = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string HomeAddress
        {
            get { return homeAddress.ToString(); }
        }

        public string CurrentAddress
        {
            get { return currentAddress.ToString(); }
        }
        #endregion

        public PersonalRecord(string studentUUID, string firstName, string lastName, string idCardSeries, string pnc,
            string fathersInitials, Address homeAddress, Address currentAddress, string phoneNumber, string email) : base(studentUUID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idCardSeries = idCardSeries;
            this.pnc = pnc;
            this.fathersInitials = fathersInitials;
            this.homeAddress = homeAddress;
            this.currentAddress = currentAddress;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
