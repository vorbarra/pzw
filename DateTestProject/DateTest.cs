using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DateProject;
namespace DateTestProject
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void IsConstructedTest()
        {
            var date = new Date();
            Assert.IsNotNull(date);

            var date2 = new Date(12, 3, 2011);
            Assert.IsNotNull(date2);
        }

        [TestMethod]
        public void IsRightMonthTest()
        {
            var date = new Date(11,-12,2011);
            Assert.AreEqual(0, date.Mjesec);
            var date2 = new Date(11, 14, 2011);
            Assert.AreEqual(0, date2.Mjesec);
            var date3 = new Date(11, 4, 2011);
            Assert.AreEqual(4, date3.Mjesec);
        }

        [TestMethod]
        public void IsRightDayTest()
        {
            var date = new Date(31,4,3014);
            Assert.AreEqual(0, date.Dan);
            
            date = new Date(31,3,2012);
            Assert.AreEqual(31, date.Dan);
            
            date = new Date(29,2,2000);
            Assert.AreEqual(29, date.Dan);

            date = new Date(29,2,2001);
            Assert.AreEqual(0, date.Dan);

            date = new Date(30,4,2011);
            Assert.AreEqual(30, date.Dan);

            date = new Date(31, 3, 2011);
            Assert.AreEqual(31, date.Dan);

            date = new Date(33, 3, 2011);
            Assert.AreEqual(0, date.Dan);
        }

        [TestMethod]
        public void GetMonthNameTest()
        {
            var date = new Date();
            Assert.AreEqual("Sijecanj", date.getMonthName());

            date = new Date(3,11,2012);
            Assert.AreEqual("Studeni", date.getMonthName());
        }


        [TestMethod]
        public void IsLeapYearTest()
        {
            var date = new Date();
            Assert.IsFalse(date.isLeapYear());

            date = new Date(2,4,2000);
            Assert.IsTrue(date.isLeapYear());

            date = new Date(3,3,2004);
            Assert.IsTrue(date.isLeapYear());

            date = new Date(3,3,2100);
            Assert.IsFalse(date.isLeapYear());
        }

        [TestMethod]
        public void GetNumberOfRemaingDaysTest()
        {
            var date = new Date();
            Assert.AreEqual(30,date.getNumberOfRemainingDaysInMonth());

            date = new Date(22,8,2012);
            Assert.AreEqual(9, date.getNumberOfRemainingDaysInMonth());

            date = new Date(27,2,2000);
            Assert.AreEqual(2, date.getNumberOfRemainingDaysInMonth());

            date = new Date(27,2,2001);
            Assert.AreEqual(1, date.getNumberOfRemainingDaysInMonth());
 
        }
    }
}
