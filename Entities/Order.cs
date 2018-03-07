using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order : IPersistable
    {
        #region Fields
        private Bike bike;
        private Rentee rentee;
        private DateTime rentDate;
        private DateTime deliveryDate;
        private int id;
        #endregion

        #region Contructor
        public Order(Bike bike, Rentee rentee, DateTime rentDate, DateTime deliveryDate, int id)
        {
            Bike = bike;
            Rentee = rentee;
            RentDate = rentDate;
            DeliveryDate = deliveryDate;
            Id = id;
        }
        public Order() { }
        #endregion

        #region Funtions
        public decimal GetPrice()
        {
            decimal d = 0;
            return d;
        }

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


        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }


        public DateTime RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }


        public Rentee Rentee
        {
            get { return rentee; }
            set { rentee = value; }
        }


        public Bike Bike
        {
            get { return bike; }
            set { bike = value; }
        }
        #endregion
    }
}
