using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bike : IPersistable
    {
        #region Fields
        private decimal pricePerDay;
        private string bikeDescription;
        private BikeKind kind;
        private int id;
        #endregion

        #region Contructor
        public Bike(decimal pricePerDay, string bikeDescription, BikeKind kind, int id)
        {
            PricePerDay = pricePerDay;
            BikeDescription = bikeDescription;
            Kind = kind;
            Id = id;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public BikeKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public string BikeDescription
        {
            get { return bikeDescription; }
            set { bikeDescription = value; }
        }

        public decimal PricePerDay
        {
            get { return pricePerDay; }
            set { pricePerDay = value; }
        }
        #endregion
    }
}
