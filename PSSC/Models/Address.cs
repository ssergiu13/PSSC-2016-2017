using System.Text;

namespace Models
{
    public class Address
    {
        private string country;
        private string county;
        private string city;
        private string street;
        private int number;             //House or block number
        private int? apartement;
        private string zipCode;

        #region Address getters / setters
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string County
        {
            get { return county; }
            set { county = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int? Apartement
        {
            get { return apartement; }
            set { apartement = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        #endregion

        public Address(string country, string county, string city, string street, int number, int? apartement, string zipCode)
        {
            this.country = country;
            this.county = county;
            this.city = city;
            this.street = street;
            this.number = number;
            this.apartement = apartement;
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.country + ", ");
            sb.Append(this.county + ", ");
            sb.Append(this.city + ", ");
            sb.Append("Str. " + this.street + ", ");
            sb.Append("Nr. " + this.number + ", ");

            if (this.apartement != null)
            {
                sb.Append("Ap. " + this.country + ", ");
            }

            sb.Append(this.country);

            return sb.ToString();
        }
    }
}
