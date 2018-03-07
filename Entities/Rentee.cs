using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rentee : IPersistable
    {
        #region Fields
        private string name;
        private string address;
        private string phoneNumber;
        private DateTime registerDate;
        private int id;
        #endregion

        #region Contructor
        public Rentee(string name, string address, string phoneNumber, DateTime registerDate, int id)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            RegisterDate = registerDate;
            Id = id;
        }
        public Rentee() { }
        #endregion

        #region Functions
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
