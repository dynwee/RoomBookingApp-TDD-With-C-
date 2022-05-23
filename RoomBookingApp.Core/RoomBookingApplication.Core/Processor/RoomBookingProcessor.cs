using RoomBookingApplication.Core.Models;
using System;

namespace RoomBookingApplication.Core.Processor
{
    public class RoomBookingProcessor
    {
        public RoomBookingProcessor()
        {
        }

        public RoomBookingResponse BookRoom(RoomBookingRequest request)
        {
            return new RoomBookingResponse
            {
                FullName = request.FullName,
                Email = request.Email,
                Date = request.Date
            };
        }
    }
}