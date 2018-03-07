using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class DbHandler
    {
        protected readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = CybellesCyklerDB; Integrated Security = True;";
        CommonDB cdb;
        public DbHandler()
        {
            cdb = new CommonDB(connectionString);
        }

        #region GetMetoder
        public ObservableCollection<Rentee> GetAllRentees()
        {
            string query = $"SELECT * FROM Renters";
            DataTable dt = cdb.execute(query);
            ObservableCollection<Rentee> OCRentee = new ObservableCollection<Rentee>();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["ID"]);
                string tempName = (string)reader["Name"];
                string tempPhoneNumber = (string)reader["PhoneNumber"];
                string tempPhysAddress = (string)reader["PhysAddress"];
                DateTime tempRegisterDate = (DateTime)reader["RegisterDate"];
                Rentee tempRentee = new Rentee(tempName, tempPhysAddress, tempPhoneNumber, tempRegisterDate, tempId);
                OCRentee.Add(tempRentee);
            }
            return OCRentee;
        }
        public Rentee GetRentee(int id)
        {
            string query = $"SELECT * FROM Renters WHERE ID={id}";
            DataTable dt = cdb.execute(query);
            Rentee tempRentee = new Rentee(); 
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["ID"]);
                string tempName = (string)reader["Name"];
                string tempPhoneNumber = (string)reader["PhoneNumber"];
                string tempPhysAddress = (string)reader["PhysAddress"];
                DateTime tempRegisterDate = (DateTime)reader["RegisterDate"];
                tempRentee = new Rentee(tempName,tempPhysAddress,tempPhoneNumber,tempRegisterDate,tempId);
            }
            return tempRentee;
        }
        public ObservableCollection<Order> GetAllOrders()
        {
            string query = $"SELECT Orders.OrderID, Orders.OrderDate, Orders.DeliverDate, Bikes.ID, Bikes.Kind, Bikes.PricePerDay, Bikes.BikeDescription, Renters.ID, Renters.Name, Renters.PhoneNumber, Renters.PhysAddress, Renters.RegisterDate FROM Bikes INNER JOIN Orders ON Bikes.ID = Orders.BikeID INNER JOIN Renters ON Orders.RenteeID = Renters.ID";
            DataTable dt = cdb.execute(query);
            ObservableCollection<Order> OCOrder = new ObservableCollection<Order>();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["OrderID"]);
                DateTime tempOrderDate = (DateTime)reader["OrderDate"];
                DateTime tempDeliverDate = (DateTime)reader["DeliverDate"];
                int tempBikeId = Convert.ToInt32(reader["ID"]);
                string tempDescription = (string)reader["BikeDescription"];
                BikeKind tempKind = (BikeKind)reader["Kind"];
                decimal tempPricePerDay = (decimal)reader["PricePerDay"];
                int tempRenteeId = Convert.ToInt32(reader["ID"]);
                string tempName = (string)reader["Name"];
                string tempPhoneNumber = (string)reader["PhoneNumber"];
                string tempPhysAddress = (string)reader["PhysAddress"];
                DateTime tempRegisterDate = (DateTime)reader["RegisterDate"];
                Rentee tempRentee = new Rentee(tempName, tempPhysAddress, tempPhoneNumber, tempRegisterDate, tempId);
                Bike tempBike = new Bike(tempPricePerDay, tempDescription, tempKind, tempId);
                Order tempOrder = new Order(tempBike,tempRentee,tempOrderDate,tempDeliverDate,tempId);
                OCOrder.Add(tempOrder);
            }
            return OCOrder;
        }
        public Order GetOrder(int id)
        {
            string query = $"SELECT * FROM Orders WHERE ID={id}";
            DataTable dt = cdb.execute(query);
            Order tempOrder = new Order();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["OrderID"]);
                DateTime tempOrderDate = (DateTime)reader["OrderDate"];
                DateTime tempDeliverDate = (DateTime)reader["DeliverDate"];
                int tempBikeId = Convert.ToInt32(reader["ID"]);
                string tempDescription = (string)reader["BikeDescription"];
                BikeKind tempKind = (BikeKind)reader["Kind"];
                decimal tempPricePerDay = (decimal)reader["PricePerDay"];
                int tempRenteeId = Convert.ToInt32(reader["ID"]);
                string tempName = (string)reader["Name"];
                string tempPhoneNumber = (string)reader["PhoneNumber"];
                string tempPhysAddress = (string)reader["PhysAddress"];
                DateTime tempRegisterDate = (DateTime)reader["RegisterDate"];
                Rentee tempRentee = new Rentee(tempName, tempPhysAddress, tempPhoneNumber, tempRegisterDate, tempId);
                Bike tempBike = new Bike(tempPricePerDay, tempDescription, tempKind, tempId);
                tempOrder = new Order(tempBike, tempRentee, tempOrderDate, tempDeliverDate, tempId);
            }
            return tempOrder;
        }
        public ObservableCollection<Bike> GetAllBikes()
        {
            string query = $"SELECT * FROM Bikes";
            DataTable dt = cdb.execute(query);
            ObservableCollection<Bike> OCBike = new ObservableCollection<Bike>();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["ID"]);
                string tempDescription = (string)reader["BikeDescription"];
                BikeKind tempKind = (BikeKind)reader["Kind"];
                decimal tempPricePerDay = (decimal)reader["PricePerDay"];
                Bike tempBike = new Bike(tempPricePerDay, tempDescription, tempKind, tempId);
                OCBike.Add(tempBike);
            }
            return OCBike;
        }
        public Bike GetBike(int id)
        {
            string query = $"SELECT * FROM Bikes WHERE ID={id}";
            DataTable dt = cdb.execute(query);
            Bike tempBike = new Bike();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int tempId = Convert.ToInt32(reader["ID"]);
                string tempDescription = (string)reader["BikeDescription"];
                BikeKind tempKind = (BikeKind)reader["Kind"];
                decimal tempPricePerDay = (decimal)reader["PricePerDay"];
                tempBike = new Bike(tempPricePerDay,tempDescription,tempKind, tempId);
            }
            return tempBike;
        }
        #endregion 

        #region InsertMetoder
        public void NewRentee(Rentee rentee)
        {
            string query = $"INSERT INTO Renters(Name,PhoneNumber,PhysAddress,RegisterDate) VALUES({rentee.Name},{rentee.PhoneNumber},{rentee.Address},{rentee.RegisterDate})";
            cdb.execute(query);
        }
        public void NewOrder(Order order)
        {
            string query = $"INSERT INTO Orders(BikeID,DeliverDate,OrderDate,RenteeID) VALUES({order.Bike.Id},{order.DeliveryDate},{order.RentDate},{order.Rentee.Id})";
            cdb.execute(query);
        }
        public void NewBike(Bike bike)
        {
            string query = $"INSERT INTO Bikes(BikeDescription,PricePerDay,Kind) VALUES({bike.BikeDescription},{bike.PricePerDay},{(int)bike.Kind})";
            cdb.execute(query);
        }
        #endregion 

        #region UpdateMetoder
        public void UpdateRentee(Rentee rentee)
        {
            string query = $"UPDATE Renters SET Name={rentee.Name},PhoneNumber={rentee.PhoneNumber},PhysAddress={rentee.Address},RegisterDate={rentee.RegisterDate} WHERE ID={rentee.Id}";
            cdb.execute(query);
        }
        public void UpdateOrder(Order order)
        {
            string query = $"UPDATE Orders SET BikeID={order.Bike.Id},DeliverDate={order.DeliveryDate},OrderDate={order.RentDate},RenteeID={order.Rentee.Id} WHERE OrderID={order.Id}";
            cdb.execute(query);
        }
        public void UpdateBike(Bike bike)
        {
            string query = $"UPDATE Bikes SET BikeDescription={bike.BikeDescription},PricePerDay={bike.PricePerDay},Kind={(int)bike.Kind} WHERE ID={bike.Id}";
            cdb.execute(query);
        }
        #endregion 
    }
}
