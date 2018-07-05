using System;
using App.Library;
using Xunit;

namespace App.UnitTest
{
    /* 
     * TODO:
     * 
     * Customer:
     * 
     * Test Customer firstName, lastName, preferedLocation setters & getter
     *      1. Look for test empty string
     *      2. Look for test of data types different to string
     * 
     * Note: This is the only fields we need the customer provide us with 
     * information other fields (if any) will be filled programaticaly 
     * like 'lastOrderTime'.
     * 
    */ 
    public class CustomerTest
    {
        // Customer test Customer.FirstName
        // When everything is beautiful...
        [Fact]
        public void CustomerFirstNameShouldPassAssigment()
        {
            // Arrange
            string firstName = "Jean";

            Customer customer = new Customer
            {
                FirstName = firstName
            };

            // Act
            var actual = customer.FirstName;

            // Assert
            Assert.Equal(firstName, actual);
        }


        // Customer test Customer.LastName
        // When everything is beautiful...
        [Fact]
        public void CustomerLastNameShouldPassAssigment()
        {
            // Arrange
            string lastName = "Semprit";

            Customer customer = new Customer
            {
                LastName = lastName
            };

            // Act
            var actual = customer.LastName;

            // Assert
            Assert.Equal(lastName, actual);
        }


        // Customer test PreferedLocation
        // When everything is beautiful...
        [Fact]
        public void CustomerPreferedLocatioShouldPassnAssigment()
        {
            // Arrange
            string preferedLocation = "Reston";

            Customer customer = new Customer
            {
                PreferedLocation = preferedLocation
            };

            // Act
            var actual = customer.PreferedLocation;

            // Assert
            Assert.Equal(preferedLocation, actual);
        }


        // Customer test Customer.LastTimeOrdered
        // When everything is beautiful...
        [Fact]
        public void CustomerLastTimeOrdereShouldPassdAssigment()
        {
            // Arrange
            DateTime lastTimeOrdered = new DateTime();

            Customer customer = new Customer
            {
                LastTimeOrdered = lastTimeOrdered.Date
            };

            // Act
            var actual = customer.LastTimeOrdered;

            // Assert
            Assert.Equal(lastTimeOrdered, actual);
        }


        /*
        // Customer test Customer.FirstName
        [Fact]
        public void CustomerFirstNameShouldNotAcceptEmptyString()
        {
            TODO
            Ask Nick about testing if code catch the error

            // Arrange
            string firstName = "";
            Customer customer = new Customer();

            // Act
            void action() => customer.FirstName = firstName;

            // Assert
            Assert.Throws<ArgumentException>( "FirstName", action);
        }
        */


        /*
        // Customer test Customer.LastName
        [Fact]
        public void CustomerLastNameShouldNotAcceptEmptyString()
        {
            TODO
            Ask Nick about testing if code catch the error

            // Arrange
            string LastName = "";
            Customer customer = new Customer();

            // Act
            void action() => customer.LastName = LastName;

            // Assert
            Assert.Throws<ArgumentException>( "LastName", action);
        }
        */
    }
}