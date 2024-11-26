using System.ComponentModel.Design;
using DLL_CustomerService_For_MOQ_test;
using Moq;

namespace CustomerService_Moq_Test_Demo
{
    public class CustomerServiceTest
    {
        private Mock<ICustomerRepository> _repository;
        public CustomerServiceTest()
        {
            _repository = new Mock<ICustomerRepository>();
        }
        [Fact]
        public void SaveCustomer_ShouldThrowException_WhenNull()
        {
            //Arrange
            var service = new CustomerService(_repository.Object);

            //Act
            var act = () => { service.SaveCustomer(null); };

            //Assert
            Assert.Throws<ArgumentNullException>(act);

        }
        [Fact]
        public void SaveCustomer_ShouldThrowException_WhenNameEmpty()
        {
            //Arrange
            var customer = new Customer { Name = string.Empty }; // test value
            var service = new CustomerService(_repository.Object);

            //Act
            var act = () => { service.SaveCustomer(customer); };

            //Assert
            var exception = Assert.Throws<InvalidDataException>(act);
            Assert.Equal("Name cannot be empty", exception?.Message);

        }
        [Fact]
        public void SaveCustomer_ShouldThrowException_WhenEmailEmpty()
        {
            //Arrange
            var customer = new Customer { Name = "Abhishek", Email = string.Empty }; // test value
            var service = new CustomerService(_repository.Object);

            //Act
            var act = () => { service.SaveCustomer(customer); };

            //Assert
            var exception = Assert.Throws<InvalidDataException>(act);
            Assert.Equal("Email cannot be empty", exception?.Message);

        }
        [Fact]
        public void SaveCustomer_ShouldThrowException_WhenCustomerExists()
        {
            //Arrange
            var customer = new Customer { Id = 0, Name = "Abhishek", Email = "Abhishek.agnihotri@yash.com" };
            _repository.Setup(x => x.Search(It.IsAny<string>())).Returns(customer);
            var service = new CustomerService(_repository.Object);

            //Act
            var act = () => { service.SaveCustomer(customer); };

            //Assert
            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Customer already exists", exception?.Message);
        }
        [Fact]
        public void SaveCustomer_ShouldCreateCustomer_WhenValidCustomerAddRequest()
        {
            //Arrange
            var customer = new Customer { Id = 0, Name = "Abhishek", Email = "Abhishek.agnihotri@yash.com" };
            int cust_id = 20;
            _repository.Setup(x => x.Search(It.IsAny<string>())).Returns((Customer)null);
            _repository.Setup(x => x.Add(It.IsAny<Customer>())).Returns(cust_id);
            var service = new CustomerService(_repository.Object);

            //Act
            // var act = () =>  { service.SaveCustomer(customer);};
            var id = service.SaveCustomer(customer);

            //Assert
            _repository.Verify(x => x.Add(customer), Times.Once());
            Assert.Equal(id, cust_id);
            // var exception = Assert.Throws<InvalidOperationException>(act);
            // Assert.Equal("Customer already exists",exception?.Message);
        }
        [Fact]
        public void SaveCustomer_ShouldUpdateCustomer_WhenValidUpdateRequest()
        {
            // Arrange
            var customer = new Customer { Id = 20, Name = "Sarita", Email = "sarita.Lad@yash.com" };
            _repository.Setup(x => x.Search(It.IsAny<string>())).Returns(customer);
            _repository.Setup(x => x.Update(It.IsAny<Customer>())).Returns(customer.Id);
            var service = new CustomerService(_repository.Object);

            // Act
            var custId = service.SaveCustomer(customer);

            // Assert
            _repository.Verify(x => x.Update(customer), Times.Once());
            Assert.Equal(custId, customer.Id);
        }
        [Fact]
        public void SaveCustomer_ShouldSendSMS_WhenValidInput()
        {
            // Arrange
            var customer = new Customer { Id = 20, Name = "Sarita", Email = "sarita.lad@yash.com" };
            _repository.Setup(x => x.Search(It.IsAny<string>())).Returns(customer);
            _repository.Setup(x => x.Update(It.IsAny<Customer>())).Returns(customer.Id);
            var service = new CustomerService(_repository.Object);

            // Act
            var custId = service.SaveCustomer(customer);

            // Assert
            _repository.Verify(x => x.SendSms(), Times.Once());
        }
        [Fact]
        public void SaveCustomer_ShouldNotSend_WhenValidInput()
        {
            // Arrange
            var customer = new Customer { Id = 10, Name = "Sarita", Email = "sarita.lad@yash.com" };
            _repository.Setup(x => x.Search(It.IsAny<string>())).Returns(customer);
            _repository.Setup(x => x.Update(It.IsAny<Customer>())).Returns(customer.Id);
            var service = new CustomerService(_repository.Object);

            // Act
            var custId = service.SaveCustomer(customer);

            // Assert
            _repository.Verify(x => x.SendSms(), Times.Never());
        }
    }
}