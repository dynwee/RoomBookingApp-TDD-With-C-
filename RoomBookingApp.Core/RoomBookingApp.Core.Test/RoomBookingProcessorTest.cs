using RoomBookingApplication.Core.Models;
using RoomBookingApplication.Core.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoomBookingApp.Core
{
    
    public class RoomBookingProcessorTest
    {
        [Fact]
        public void Should_Return_RoomBooking_Response_With_Request_Values()
        {
            //Arrange
            RoomBookingRequest request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@gmail.com",
                Date = new DateTime(2022, 5, 23)
            };

            var processor = new RoomBookingProcessor();

            //Act

            RoomBookingResponse result = processor.BookRoom(request);

            //Assert

            Assert.NotNull(result);
            Assert.Equal(request.FullName, result.FullName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }
    }
}
