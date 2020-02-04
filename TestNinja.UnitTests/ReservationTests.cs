using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        Reservation reservation;
        [SetUp]
        public void Setup()
        {
             reservation = new Reservation();
        }

        [Test]
        public void CancelledBy_UserIsAdmin_ReturnsTrue()
        {

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert
            Assert.That(result == true);



        }

        [Test]
        public void CancelledBy_UserWhoMadeIt_ReturnsTrue()
        {
            reservation.MadeBy = new User();
            var user = reservation.MadeBy;
            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);


        }

        [Test]
        public void CancelledBy_AnyUser_ReturnsFalse()
        {


            var user = new User();

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsFalse(result);
        }
    }

}