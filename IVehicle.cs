using System;
namespace FactoryPattern
{
    public interface IVehicle
    {
        String VehicleType();
        int NumberOfWheels();
        String VehicleNumber();
        String DriverNamer();
        int Capacity();
        bool Availability();
        String Route();
        //List BookingHistory();


        void UpdateAvailability(bool available);  // Method to update the availability status
        void UpdateDriverInformation(string newDriverName);  // Method to update driver information
        void UpdateRoute(string newRoute);  // Method to update the route information
        void Book(int bookingId, DateTime time, int numberOfPassengers);  // Method to book the vehicle
        void CompleteBooking(int bookingId);  // Method to complete a booking

    }
}

