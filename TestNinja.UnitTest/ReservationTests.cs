
using TestNinja.Fundamentals;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);


            
        }
        [TestMethod]
        public void CancelledBy_UserWhoMadeIt_ReturnsTrue()
        {
            var reservation = new Reservation();
            reservation.MadeBy = new User();
            var user = reservation.MadeBy;
            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
            

        }

        [TestMethod]
        public void CancelledBy_AnyUser_ReturnsFalse()
        {
            
            var reservation = new Reservation();

            var user = new User();

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsFalse(result);
        }
    }
}
