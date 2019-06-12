using Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicIntegrationTests
{
    class AccountContainerLogicIntegrationTests
    {
        private AccountContainerLogic myAccountContainer;

        [SetUp]
        public void Setup()
        {
            myAccountContainer = new AccountContainerLogic();
        }

        [Test]
        public void Login_LoginWithCorrectCredentials_ReturnsCorrectUsername()
        {
            //Arange in Setup

            //Act
            var result = myAccountContainer.Login("vishengel", "w4chtw00rd");

            //Assert
            Assert.That(result.Username, Is.EqualTo("vishengel"));
        }

        [Test]
        public void Login_LoginWithWrongCredentials_ReturnsIncorrectUsername()
        {
            //Arange in Setup

            //Act
            var result = myAccountContainer.Login("Vishengel", "wachtwoord");

            //Assert
            Assert.That(result.Username, Is.Not.EqualTo("Vishengel"));
        }
    }
}
